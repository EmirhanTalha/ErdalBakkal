using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Tanimlamalar
{
  public partial class frmOzelKod : DevExpress.XtraEditors.XtraUserControl
  {
    public frmOzelKod()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    BindingSource bs = new BindingSource();
    DataTable dt = new DataTable();
    bool islem = false;
    int SatirNo = 0;

    private void frmOzelKod_Load(object sender, EventArgs e)
    {
      try
      {
        
        using (da.SelectCommand = new SqlCommand(@"SELECT     OzelKodID, OzelKodTanim FROM dbo.OzelKod", cs.csBaglanti.BaglantiGetir()))
        {
          GridGuncelle();
          bs.DataSource = dt;
          gcOzelKod.DataSource = bs;

          txtOzelKodTanim.DataBindings.Clear();
          txtOzelKodTanim.DataBindings.Add("Text", bs, "OzelKodTanim");

          gvOzelKod.Columns["OzelKodID"].Visible = false;
          gvOzelKod.Columns["OzelKodTanim"].Caption = @"Stok Birim Tanım";
        }

        gvOzelKod.OptionsView.ShowGroupPanel = false;
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    void NesneEnabled(bool islem)
    {
      btnEkle.Enabled = islem;
      btnSil.Enabled = islem;
      btnDegistir.Enabled = islem;

      btnVazgec.Enabled = !islem;
      btnKaydet.Enabled = !islem;

      btnGuncelle.Enabled = islem;

      txtOzelKodTanim.Enabled = !islem;
      gcOzelKod.Enabled = islem;
    }
    private void AktifTextBackColorChange(object sender, EventArgs e)
    {
      DevExpress.XtraEditors.TextEdit AktifText = (TextEdit)sender;
      AktifText.BackColor = Color.AntiqueWhite;
    }
    private void PasifTextBackColorChange(object sender, EventArgs e)
    {
      DevExpress.XtraEditors.TextEdit AktifText = (TextEdit)sender;
      AktifText.BackColor = Color.White;
    }
    private void btnEkle_Click(object sender, EventArgs e)
    {
      islem = true;
      NesneEnabled(false);
      txtOzelKodTanim.Text = "";
      txtOzelKodTanim.Focus();
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvOzelKod.FocusedRowHandle < 0) return;
        int seciliSatirNo = gvOzelKod.FocusedRowHandle;

        #region Kullanılıp Kullanılmadığının kontrolü yapılıyor.
        int satirSayisi = 0;
        using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) as SatirSayisi FROM Cari WHERE (OzelKodID = @OzelKodID )", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@OzelKodID", SqlDbType.Int).Value = gvOzelKod.GetFocusedRowCellValue("OzelKodID").ToString();
          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
            if (dr.Read())
              satirSayisi = (int)dr["SatirSayisi"];
        }

        if (satirSayisi > 0)
        {
          XtraMessageBox.Show("Kayıt, Cari Bilgilerinde daha önceden kullanılmış.\n\nSeçili Kayıt Silinemez.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }
        #endregion

        if (XtraMessageBox.Show("Seçili Kaydı Silmek İstediğinize Emin misiniz ?", "Perakende Satış", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
          return;

        using (SqlCommand cmd = new SqlCommand("Delete From OzelKod Where OzelKodID=@OzelKodID", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@OzelKodID", SqlDbType.Int).Value = gvOzelKod.GetFocusedRowCellValue("OzelKodID").ToString();
           cmd.ExecuteNonQuery();
        }
        dt.Clear();
        da.Fill(dt);
        gvOzelKod.FocusedRowHandle = seciliSatirNo - 1;

      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    private void btnDegistir_Click(object sender, EventArgs e)
    {
      if (gvOzelKod.FocusedRowHandle < 0) return;
      SatirNo = gvOzelKod.FocusedRowHandle;
      islem = false;
      NesneEnabled(false);
      txtOzelKodTanim.Focus();
    }
    private void btnVazgec_Click(object sender, EventArgs e)
    {
      islem = false;
      NesneEnabled(true);
      GridGuncelle();
      gvOzelKod.FocusedRowHandle = SatirNo;
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtOzelKodTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alan, boş geçilemez.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtOzelKodTanim.Focus();
          return;
        }

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cs.csBaglanti.BaglantiGetir();
        cmd.CommandType = CommandType.Text;

        //if (cs.csAyniKayitVarmiKontrolu.kontolET(cs.csBaglanti.BaglantiGetir(), cmd, "OzelKod", islem, gvOzelKod.GetFocusedRowCellDisplayText("OzelKodID"), txtOzelKodTanim.Text))
        //{
        //  XtraMessageBox.Show(txtOzelKodTanim.Text + " isimde bir kayıt var zaten.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //  return;
        //}
        cmd.Parameters.Clear();
        if (islem)
        {
          cmd.CommandText = "Insert Into OzelKod(OzelKodTanim) Values(@OzelKodTanim)";
        }
        else
        {
          cmd.CommandText = "Update OzelKod Set OzelKodTanim=@OzelKodTanim Where OzelKodID=@OzelKodID";
          cmd.Parameters.Add("@OzelKodID", SqlDbType.Int).Value = gvOzelKod.GetFocusedRowCellValue("OzelKodID").ToString();
        }

        cmd.Parameters.Add("@OzelKodTanim", SqlDbType.NVarChar).Value = txtOzelKodTanim.Text;
        cmd.ExecuteNonQuery();

        NesneEnabled(true);
        GridGuncelle();
        if (!islem) gvOzelKod.FocusedRowHandle = SatirNo;
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    private void btnGuncelle_Click(object sender, EventArgs e)
    {
     GridGuncelle();
    }
    void GridGuncelle()
    {
      dt.Clear();
      da.Fill(dt);
    }
  }
}
