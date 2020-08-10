using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using proje_ErdalBakkal.cs;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Kasa
{
  public partial class frmKasaIslemListesi : DevExpress.XtraEditors.XtraForm
  {
    public frmKasaIslemListesi()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();
    string _IslemID = "-1", YazdirilacakIslemID = "-1";
    //KasaIslem.KasaIslemTipi -> 1: Kasadan Alınan Hizmet Faturası, 2: Kasadan Satış Faturası, 3: Kasadan Nakit Tahsilat, 4: Kasadan Nakit Ödeme
    private void frmKasaIslemListesi_Load(object sender, EventArgs e)
    {
      try
      {
        deBaslangicTarihi.DateTime = DateTime.Now.AddYears(-1);
        deBitisTarihi.DateTime = DateTime.Now;

        #region lkpKasa
        using (SqlDataAdapter da = new SqlDataAdapter(@"Select KasaID, KasaTanim From Kasa  order by KasaTanim", cs.csBaglanti.BaglantiGetir()))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);
          lkpKasa.Properties.DataSource = dt;
          lkpKasa.Properties.PopulateColumns();
          lkpKasa.Properties.ValueMember = "KasaID";
          lkpKasa.Properties.DisplayMember = "KasaTanim";

          lkpKasa.Properties.Columns["KasaID"].Visible = false;
          lkpKasa.Properties.Columns["KasaTanim"].Caption = @"Kasa Tanım";
          lkpKasa.EditValue = -1;
        }
        #endregion
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }

    private void btnSorgula_Click(object sender, EventArgs e)
    {
      try
      {
        string whereCari = " AND FisBaslik.CariID=@CariID ";
        if ((int)lkpKasa.EditValue == -1)
          whereCari = "";

        using (da.SelectCommand = new SqlCommand(@"
SELECT     dbo.Kasa.KasaTanim, dbo.CariTur.CariTurTanim, dbo.CariGrup.CariGrupTanim, dbo.Cari.CariKod, dbo.Cari.CariTanim, 
                      CASE WHEN dbo.KasaIslem.Tahsilat = 0 THEN 'Ödeme' ELSE 'Tahsilat' END AS KasaIslem, CASE Tahsilat WHEN 1 THEN GenelToplam ELSE (- 1 * GenelToplam) 
                      END AS GenelToplam, dbo.KasaIslem.KasaIslemTipi, dbo.KasaIslem.IslemTarihi
FROM         dbo.CariGrup RIGHT OUTER JOIN
                      dbo.Cari ON dbo.CariGrup.CariGrupID = dbo.Cari.CariGrupID LEFT OUTER JOIN
                      dbo.CariTur ON dbo.Cari.CariTurID = dbo.CariTur.CariTurID RIGHT OUTER JOIN
                      dbo.Kasa INNER JOIN
                      dbo.KasaIslem ON dbo.Kasa.KasaID = dbo.KasaIslem.KasaID ON dbo.Cari.CariID = dbo.KasaIslem.CariID
WHERE     (CONVERT(DATETIME, dbo.KasaIslem.IslemTarihi, 104) BETWEEN CONVERT(DATETIME, @BaslangicTarihi, 104) AND CONVERT(DATETIME, @BitisTarihi, 104)) " + whereCari, cs.csBaglanti.BaglantiGetir()))
        {
          da.SelectCommand.Parameters.Add("@BaslangicTarihi", SqlDbType.DateTime).Value = deBaslangicTarihi.DateTime;
          da.SelectCommand.Parameters.Add("@BitisTarihi", SqlDbType.DateTime).Value = deBitisTarihi.DateTime;
          if (whereCari != "")
            da.SelectCommand.Parameters.Add("@CariID", SqlDbType.Int).Value = lkpKasa.EditValue.ToString();

          dt.Clear();
          da.Fill(dt);
          gcListe.DataSource = dt;
        }
        new csGridLayout(csGridLayout.enGridArayuzIslemleri.Get, this, Convert.ToInt32(cs.csKullanici.KullaniciID), cs.csBaglanti.BaglantiGetir());

				foreach (DataRow satir in dt.AsEnumerable())
				{
					//satir["GelenToplam"]
				}
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }

    private void btnExceleAktar_Click(object sender, EventArgs e)
    {
      try
      {
				var frmExcel = new cs.csExceleAktar();
				frmExcel.ExceleAktar(gcListe);
			}
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    private void btnRaporla_Click(object sender, EventArgs e)
    {
      try
      {
        if (XtraMessageBox.Show("Fiş Bilgileri Yazdırılsın mı? ", "Perakende Satış", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        {
          //   InitReport(InitData(_IslemID)).Print(); // tek bir satır bilgisini yazdırmak için kullanılacak fonksiyon
          // InitReport(dt).ShowPreview();
        }
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show("Hata Kodu : " + hata.Message, "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private void btnRaporDizayn_Click(object sender, EventArgs e)
    {
      try
      {
        if (XtraMessageBox.Show("Fiş Yazdırılsın mı? ", "Perakende Satış", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        {
        //  InitReport(InitData("")).ShowDesigner();
        }
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show("Hata Kodu : " + hata.Message, "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    #region Yazdırma İşlemleri
    //private XtraReport InitReport(DataSet dtMazot)
    //{
    //  //this.TopMost = false;
    //  XtraReport xr_MazotBilgi = new XtraReport();
    //  xr_MazotBilgi.LoadLayout(Application.StartupPath + @"\ReportLayouts\xrKasaIslemListesi.repx");
    //  BindingSource bsMazot = new BindingSource();
    //  bsMazot.DataSource = dtMazot;
    //  xr_MazotBilgi.DataSource = bsMazot;
    //  return xr_MazotBilgi;
    //}
    private DataSet InitData(string YazdirilacakislemID)
    {
      //      SqlDataAdapter daTemp = new SqlDataAdapter(
      //@"
      //SELECT     dbo.Islem.Yaziyla, dbo.Islem.IslemID, dbo.Islem.IslemNo, dbo.Islem.FirmaID, dbo.Islem.PlakaID, dbo.Islem.GirisTarihi, dbo.Islem.GirisSaati, dbo.Islem.Cikis, 
      //                      dbo.Islem.CikisTarihi, dbo.Islem.CikisSaati, dbo.Islem.GirisCikisUcreti, dbo.Islem.KaldigiGun, dbo.Islem.IsgaliyeUcreti, dbo.Islem.ToplamIsgaliyeUcreti, 
      //                      dbo.Islem.TartimMiktari, dbo.Islem.TartimUcreti, dbo.Islem.ToplamTartimUcreti, dbo.Islem.ToplamUcret, dbo.Islem.KayitTarihi, dbo.Islem.KaydedenID, 
      //                      dbo.Islem.GuncellemeTarihi, dbo.Islem.GuncelleyenID, dbo.Islem.Aktif, dbo.Plaka.Plaka, dbo.Firma.FirmaTanim, Kullanici_1.KullaniciAdSoyad
      //FROM         dbo.Islem INNER JOIN
      //                      dbo.Kullanici ON dbo.Islem.KaydedenID = dbo.Kullanici.KullaniciID INNER JOIN
      //                      dbo.Kullanici AS Kullanici_1 ON dbo.Islem.GirisKullaniciID = Kullanici_1.KullaniciID LEFT OUTER JOIN
      //                      dbo.Firma ON dbo.Islem.FirmaID = dbo.Firma.FirmaID LEFT OUTER JOIN
      //                      dbo.Plaka ON dbo.Islem.PlakaID = dbo.Plaka.PlakaID
      //WHERE     (dbo.Islem.IslemID = @IslemID)", cs.csBaglanti.BaglantiGetir());
      //      daTemp.SelectCommand.Transaction = trGenel;
      //      daTemp.SelectCommand.Parameters.Add("@IslemID", SqlDbType.Int).Value = YazdirilacakislemID;
      //      DataTable dtTemp = new DataTable();
      //      daTemp.Fill(dtTemp);

      DataSet ds = new DataSet();

      using (SqlDataAdapter daCari = new SqlDataAdapter(@"SELECT CariID, CariTurID, CariGrupID, CariKod, CariTanim FROM dbo.Cari", cs.csBaglanti.BaglantiGetir()))
      {
        daCari.Fill(ds, "Cari");
      }
      //-------------------------
      using (SqlDataAdapter daCariTur = new SqlDataAdapter(@"SELECT CariTurID, CariTurTanim FROM dbo.CariTur", cs.csBaglanti.BaglantiGetir()))
      {
        daCariTur.Fill(ds, "CariTur");
      }
      //-------------------------
      using (SqlDataAdapter daCariGrup = new SqlDataAdapter(@"SELECT CariGrupID, CariGrupTanim FROM dbo.CariGrup", cs.csBaglanti.BaglantiGetir()))
      {
        daCariGrup.Fill(ds, "CariGrup");
      }

      DataColumn keyColumnCariCariTur = ds.Tables["Cari"].Columns["CariTurID"];
      DataColumn foreignKeyColumnCariCariTur = ds.Tables["CariTur"].Columns["CariTurID"];
      ds.Relations.Add("Cari_CariTur", keyColumnCariCariTur, foreignKeyColumnCariCariTur, false);

      DataColumn keyColumnCariCariGrup = ds.Tables["Cari"].Columns["CariGrupID"];
      DataColumn foreignKeyColumnCariCariGrup = ds.Tables["CariGrup"].Columns["CariGrupID"];
      ds.Relations.Add("Cari_CariGrup", keyColumnCariCariGrup, foreignKeyColumnCariCariGrup, false);

      return ds;
    }

    private void btnFisYazdir_Click(object sender, EventArgs e)
    {
      try
      {
        if (XtraMessageBox.Show("Fiş Yazdırılsın mı? ", "Perakende Satış", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        {
          //   InitReport(InitData(_IslemID)).Print(); // tek bir satır bilgisini yazdırmak için kullanılacak fonksiyon
          //InitReport(dt);
        }
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show("Hata Kodu : " + hata.Message, "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    #endregion
  }
}