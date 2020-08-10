using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using proje_ErdalBakkal.cs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.stok
{
  public partial class frmStokListe : DevExpress.XtraEditors.XtraForm
  {
    public frmStokListe()
    {
      InitializeComponent();
    }
    SqlTransaction trGenel;
    enum enGridArayuzIslemleri { Set, Get };
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();

    void ListeDoldur()
    {
      try
      {
        string sqlWhere = "";

        if (cmbEgitim.SelectedIndex != 2)
          sqlWhere = " WHERE (dbo.Stok.Aktif = " + cmbEgitim.SelectedIndex.ToString() + ")";

        using (da.SelectCommand = new SqlCommand(@"
SELECT     dbo.Stok.StokID, dbo.Stok.StokBarkod, dbo.Stok.StokTanim, dbo.Stok.KdvOranID, dbo.Stok.MinimumStokSeviyesi, dbo.Stok.AlisFiyati, dbo.Stok.SatisFiyati, 
                      dbo.Stok.StokMiktari, dbo.Stok.StokBirimID, dbo.StokBirim.StokBirimTanim, dbo.Stok.StokMarkaID, dbo.StokMarka.StokMarkaTanim, dbo.Stok.HizliSatis, dbo.Stok.Aktif, 
                      CASE WHEN dbo.Stok.Aktif = 1 THEN 'Aktif' ELSE 'Pasif' END AS StokDurum, dbo.Stok.OzelKodID, dbo.Stok.ProjeID
FROM         dbo.Stok LEFT OUTER JOIN
                      dbo.OzelKod ON dbo.Stok.OzelKodID = dbo.OzelKod.OzelKodID LEFT OUTER JOIN
                      dbo.Proje ON dbo.Stok.ProjeID = dbo.Proje.ProjeID LEFT OUTER JOIN
                      dbo.StokBirim ON dbo.Stok.StokBirimID = dbo.StokBirim.StokBirimID LEFT OUTER JOIN
                      dbo.StokMarka ON dbo.Stok.StokMarkaID = dbo.StokMarka.StokMarkaID
                      " + sqlWhere, cs.csBaglanti.BaglantiGetir()))
        {
          dt.Clear();
          da.Fill(dt);
          gcListe.DataSource = dt;
        }

        if (cmbEgitim.SelectedIndex == 1)
        {
          gvListe.FormatConditions.Clear();
        }
        else
        {
          gvListe.FormatConditions.Clear();
          StyleFormatCondition StokGiris = new StyleFormatCondition(FormatConditionEnum.Equal, gvListe.Columns["Aktif"], "Aktif", "Aktif");
          StokGiris.Appearance.BackColor = Color.Wheat;
          StokGiris.Appearance.Options.UseBackColor = true;
          StokGiris.ApplyToRow = true;
          gvListe.FormatConditions.Add(StokGiris);
        }
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show(hata.Message);
			}
    }
    private void frmStokListe_Load(object sender, EventArgs e)
    {
      try
      {
        ListeDoldur();

        new csGridLayout(csGridLayout.enGridArayuzIslemleri.Get, this, Convert.ToInt32(cs.csKullanici.KullaniciID), cs.csBaglanti.BaglantiGetir());
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show(hata.Message);
			}
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      stok.frmStokDetay frmStokDetay = new frmStokDetay("-1");
      if (frmStokDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        btnGuncelle_Click(null, null);
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvListe.FocusedRowHandle < 0) return;
        int seciliSatirNo = gvListe.FocusedRowHandle;

        #region Kullanılıp Kullanılmadığının kontrolü yapılıyor.
        int satirSayisi = 0;
        using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) as SatirSayisi FROM FisDetay WHERE (StokID = @StokID  )", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@StokID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("StokID").ToString();
          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
            if (dr.Read())
              satirSayisi = (int)dr["SatirSayisi"];
        }

        if (satirSayisi > 0)
        {
          XtraMessageBox.Show("Kayıt, daha önceden kullanılmış.\n\nSeçili Kayıt Silinemez.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }
        #endregion

        if (XtraMessageBox.Show("Seçili Kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

        using (var cmd = new SqlCommand(@"Delete From Stok Where StokID=@StokID", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@StokID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("StokID").ToString();
          cmd.ExecuteNonQuery();
        }

        dt.Clear();
        da.Fill(dt);

        gvListe.FocusedRowHandle = seciliSatirNo - 1;
      }
      catch (Exception hata)
      {
        MessageBox.Show(hata.Message);
      }
    }

    private void btnDegistir_Click(object sender, EventArgs e)
    {
      stok.frmStokDetay frmStokDetay = new frmStokDetay(gvListe.GetFocusedRowCellDisplayText("StokID"));
      if (frmStokDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        btnGuncelle_Click(null, null);
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
      dt.Clear();
      da.Fill(dt);
    }

    private void btnKapat_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnExcel_Click(object sender, EventArgs e)
    {
      try
      {
			cs.csExceleAktar a=new csExceleAktar();
				a.ExceleAktar(gcListe);
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show(hata.Message);
			}
    }

    private void cmbEgitim_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListeDoldur();
    }

    private void cbtnGorunumKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        new csGridLayout(csGridLayout.enGridArayuzIslemleri.Set, this, Convert.ToInt32(csKullanici.KullaniciID), cs.csBaglanti.BaglantiGetir());

      }
      catch (Exception hata)
      {
				XtraMessageBox.Show(hata.Message);
			}
    }

    private void cbtnEkranGorunumuSifirla_Click(object sender, EventArgs e)
    {
      if (XtraMessageBox.Show("Liste Sıralaması için Öndeğerlere dönülecek. Onaylıyor musunuz?\n(Form işlem sonrasında kapatılacaktır.)", "Perakende Satış", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
         == DialogResult.No) return;
      cs.csGridLayout.LayoutClear(Convert.ToInt32(cs.csKullanici.KullaniciID), this.Name, gvListe.Name, cs.csBaglanti.BaglantiGetir());
      this.Close();
    }

    private void gvListe_DoubleClick(object sender, EventArgs e)
    {
      if (gvListe.FocusedRowHandle > 0)
        if (btnDegistir.Enabled) btnDegistir_Click(null, null);
    }
  }
}