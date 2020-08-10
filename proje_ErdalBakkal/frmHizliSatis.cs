using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal
{
  public partial class frmHizliSatis : DevExpress.XtraEditors.XtraForm
  {
    public frmHizliSatis()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();
    SqlTransaction tr;
    string StokBarkod = "", StokTanim = "", SatisFiyati = "", SatirMiktar = "", BirimFiyat = "", KDVOranTanim = "";
    bool enSonIndirimYapilan = true;
    private void frmHizliSatis_Load(object sender, EventArgs e)
    {
      try
      {
        HizliSatisUrunleriniGetir();

        dt.Columns.Add("FisDetayID", typeof(System.Int32));
        dt.Columns.Add("FisBaslikID", typeof(System.Int32));
        dt.Columns.Add("StokID", typeof(System.Int32));
        dt.Columns.Add("StokBarkod", typeof(System.String));
        dt.Columns.Add("StokTanim", typeof(System.String));
        dt.Columns.Add("SatirMiktar", typeof(System.Decimal));
        dt.Columns.Add("BirimFiyat", typeof(System.Decimal));
        dt.Columns.Add("SatirToplam", typeof(System.Decimal));
        dt.Columns.Add("KDVOranTanim", typeof(System.Decimal));
        dt.Columns.Add("KDVTutar", typeof(System.Decimal));

        gcListe.DataSource = dt;
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    private void HizliSatisUrunleriniGetir()
    {
      try
      {
        xtraScrollableControl1.Controls.Clear();
        int ust = 0, sol = 0;
        int sayac = 1; int degerX = 0, degerY = 0, butonlarinUzunlugu = 0;

        using (var cmd = new SqlCommand(@"SELECT StokID, StokTanim, HizliSatis, Aktif FROM dbo.Stok WHERE (HizliSatis = 1) AND (Aktif = 1)", cs.csBaglanti.BaglantiGetir()))
        {
          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
          {
            while (dr.Read())
            {
              SimpleButton btn = new SimpleButton();
              btn.Name = "btn" + dr["StokID"].ToString();
              btn.Text = dr["StokTanim"].ToString().Trim();
              btn.Click += btn_Click;
              btn.Width = 120;
              btn.Height = 60;
              butonlarinUzunlugu += (btn.Width);

              if (sayac > 1)
                if (xtraScrollableControl1.Width <= butonlarinUzunlugu)
                {
                  degerX = 0; degerY += 65;
                  butonlarinUzunlugu = 0;
                }
                else
                {
                  degerX += 122;
                }
              btn.Location = new Point(degerX, degerY);
              xtraScrollableControl1.Controls.Add(btn);
              sayac++;
            }
          }
        }
      }
      catch (Exception hata)
      {
        throw new Exception(hata.Message);
      }
    }
    void btn_Click(object sender, EventArgs e)
    {
      decimal miktar = 0;
      if (decimal.TryParse(txtMiktar.Text, out miktar) == false)
        txtMiktar.Text = "1";

      SimpleButton btn = (SimpleButton)sender;
      string stokID = btn.Name.Substring(3, btn.Name.Length - 3);
      using (SqlCommand cmd = new SqlCommand(@"SELECT dbo.Stok.StokBarkod, dbo.Stok.StokTanim, dbo.Stok.OzelKodID, dbo.Stok.ProjeID, dbo.Stok.KdvOranID, dbo.Stok.MinimumStokSeviyesi, dbo.Stok.AlisFiyati,   dbo.Stok.SatisFiyati, dbo.Stok.StokMiktari, dbo.Stok.StokBirimID, dbo.Stok.StokMarkaID, dbo.Stok.HizliSatis, dbo.Stok.Aktif, dbo.KdvOran.KdvOranTanim, 0 as KdvTutar
FROM dbo.Stok INNER JOIN dbo.KdvOran ON dbo.Stok.KdvOranID = dbo.KdvOran.KdvOranID
WHERE (StokID = @StokID)", cs.csBaglanti.BaglantiGetir()))
      {
        cmd.Parameters.Add("@StokID", SqlDbType.Int).Value = stokID;
        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
        {
          if (dr.Read())
          {
            StokBarkod = dr["StokBarkod"].ToString();
            StokTanim = dr["StokTanim"].ToString();
            SatisFiyati = dr["SatisFiyati"].ToString();
            KDVOranTanim = dr["KdvOranTanim"].ToString();

            SatirIslemi(stokID, StokBarkod, StokTanim, SatisFiyati, KDVOranTanim, txtMiktar.Text);
          }
        }
      }

      if (txtIskontoOrani.Text != "0" || txtIskontoTutari.Text != "0")
        if (enSonIndirimYapilan)
          iskontoOranindanHesapla();
        else
          iskontoTutarindanHesapla();

      txtMiktar.Focus();
      txtMiktar.Text = "1";
    }
    public void SatirIslemi(string StokID, string StokBarkod, string StokTanim, string SatisFiyati, string KdvOranTanim, string satisMiktar)
    {
      int stokSatiri = StokVarmi(StokID);
      decimal _satirToplam = 0, _kdvOranTanim = 0, kdv = 0;
      _satirToplam = Convert.ToDecimal(SatisFiyati);
      _kdvOranTanim = Convert.ToDecimal(KdvOranTanim);


      if (stokSatiri == -1)
      {
        kdv = _satirToplam - (_satirToplam / (1 + (_kdvOranTanim / 100)));
        dt.Rows.Add(new object[] { -1, -1, StokID, StokBarkod, StokTanim, Convert.ToDecimal(satisMiktar), SatisFiyati, SatisFiyati, KdvOranTanim, Math.Round(kdv, 2) });
      }
      else
      {
        dt.Rows[stokSatiri]["SatirMiktar"] = Convert.ToDecimal(dt.Rows[stokSatiri]["SatirMiktar"].ToString()) + Convert.ToDecimal(satisMiktar);
        dt.Rows[stokSatiri]["SatirToplam"] = Convert.ToDecimal(dt.Rows[stokSatiri]["SatirMiktar"].ToString()) * Convert.ToDecimal(dt.Rows[stokSatiri]["BirimFiyat"].ToString());

        kdv = Convert.ToDecimal(dt.Rows[stokSatiri]["SatirToplam"]) - (Convert.ToDecimal(dt.Rows[stokSatiri]["SatirToplam"]) / (1 + (_kdvOranTanim / 100)));
        dt.Rows[stokSatiri]["KDVTutar"] = Math.Round(kdv, 2);

      }

      txtSonEklenenStokBarkod.Text = StokBarkod;
      txtSonEklenenStokTanim.Text = StokTanim;

      GenelToplamHesapla();
    }
    private void GenelToplamHesapla()
    {
      decimal genelToplam = 0;
      foreach (DataRow row in dt.AsEnumerable())
      {
        genelToplam += Convert.ToDecimal(row["SatirToplam"].ToString());
      }

      txtFisToplam.Text = genelToplam.ToString();
    }
    private int StokVarmi(string _stokID)
    {
      int satirNo = -1, sayac = 0;

      foreach (DataRow row in dt.AsEnumerable())
      {
        if (row["StokID"].ToString() == _stokID)
        {
          satirNo = sayac;
          break;
        }
        sayac++;
      }

      return satirNo;
    }
    private void txtIskontoOrani_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        iskontoOranindanHesapla();

        enSonIndirimYapilan = true;
      }
    }
    private void iskontoOranindanHesapla()
    {
      GenelToplamHesapla();
      decimal iskontoOrani = 0, fisToplam = 0, genelToplam = 0;
      if (decimal.TryParse(txtFisToplam.Text, out fisToplam) == false)
        return;

      if (decimal.TryParse(txtIskontoOrani.Text, out iskontoOrani))
      {
        genelToplam = fisToplam - (fisToplam * iskontoOrani / 100);

        txtIskontoTutari.Text = (fisToplam - genelToplam).ToString();
        txtFisToplam.Text = genelToplam.ToString();
      }
      else
      {
        GenelToplamHesapla();
        txtIskontoOrani.Text = "0";
        txtIskontoTutari.Text = "0";
      }
    }
    private void txtIskontoTutari_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        iskontoTutarindanHesapla();

        enSonIndirimYapilan = false;
      }
    }
    private void iskontoTutarindanHesapla()
    {
      GenelToplamHesapla();
      decimal iskontoTutari = 0, fisToplam = 0, genelToplam = 0;
      if (decimal.TryParse(txtFisToplam.Text, out fisToplam) == false)
        return;

      if (decimal.TryParse(txtIskontoTutari.Text, out iskontoTutari))
      {
        genelToplam = fisToplam - (iskontoTutari);

        txtIskontoOrani.Text = ((iskontoTutari * 100) / fisToplam).ToString();
        txtFisToplam.Text = genelToplam.ToString();
      }
      else
      {
        GenelToplamHesapla();
        txtIskontoOrani.Text = "0";
        txtIskontoTutari.Text = "0";
      }
    }
    private void btnSatisKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvListe.FocusedRowHandle < 0) return;

        if (cs.csKullanici.SatisSonundaOnayiIste)
          if (XtraMessageBox.Show("işlem Kaydedilecek. Onaylıyor musunuz?", "Perakende Satış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No) return;

        tr = cs.csBaglanti.BaglantiGetir().BeginTransaction();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cs.csBaglanti.BaglantiGetir();
        cmd.CommandType = CommandType.Text;
        cmd.Transaction = tr;

        decimal toplamKDV = 0;
        foreach (DataRow row in dt.AsEnumerable())
        {
          toplamKDV += Convert.ToDecimal(row["KDVTutar"].ToString());
        }

        string sonFisNo = "";
        cmd.CommandText = "Select TOP 1 ISNULL(FisNo,1)+1 as FisNo From FisBaslik Order by FisBaslikID DESC";
        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
        {
          if (dr.Read())
            sonFisNo = dr["FisNo"].ToString();
        }

        if (sonFisNo == "") sonFisNo = "1";

        string fisBaslikID = "-1";
        cmd.CommandText = "Insert Into FisBaslik(FisTur, FisNo, CariID, KasaID, FisTarih, ToplamKdv, FisToplam, IskontoOrani, GenelToplam) values(@FisTur, @FisNo ,@CariID, @KasaID, @FisTarih, @ToplamKdv, @FisToplam, @IskontoOrani, @GenelToplam) SET @fisBaslikID=SCOPE_IDENTITY()";

        cmd.Parameters.Add("@FisTur", SqlDbType.Int).Value = 1; // Perakende Satış
        cmd.Parameters.Add("@FisNo", SqlDbType.VarChar).Value = sonFisNo;
        cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = cs.csKullanici.PerakendeCariID;
        cmd.Parameters.Add("@KasaID", SqlDbType.Int).Value = cs.csKullanici.HizliSatisKasaID;
        cmd.Parameters.Add("@FisTarih", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString();
        cmd.Parameters.Add("@ToplamKdv", SqlDbType.Decimal).Value = toplamKDV;
        cmd.Parameters.Add("@FisToplam", SqlDbType.Decimal).Value = Convert.ToDecimal(txtFisToplam.Text) + Convert.ToDecimal(txtIskontoTutari.Text);
        cmd.Parameters.Add("@IskontoOrani", SqlDbType.Decimal).Value = txtIskontoOrani.Text;
        cmd.Parameters.Add("@GenelToplam", SqlDbType.Decimal).Value = Convert.ToDecimal(txtFisToplam.Text);

        cmd.Parameters.Add("@fisBaslikID", SqlDbType.Int).Direction = ParameterDirection.Output;

        cmd.ExecuteNonQuery();
        fisBaslikID = cmd.Parameters["@fisBaslikID"].Value.ToString();

        foreach (DataRow row in dt.AsEnumerable())
        {
          cmd.Parameters.Clear();
          cmd.CommandText = @"
          Insert Into FisDetay(FisBaslikID, StokID, SatirMiktar, BirimFiyat, SatirToplamTutar) values(@FisBaslikID, @StokID, @SatirMiktar, @BirimFiyat, @SatirToplamTutar);
          Update Stok SET StokMiktari=StokMiktari-@SatirMiktar Where Stok.StokID=@StokID";
          cmd.Parameters.Add("@FisBaslikID", SqlDbType.Int).Value = fisBaslikID;
          cmd.Parameters.Add("@StokID", SqlDbType.Int).Value = row["StokID"].ToString();
          cmd.Parameters.Add("@SatirMiktar", SqlDbType.Decimal).Value = row["SatirMiktar"].ToString();
          cmd.Parameters.Add("@BirimFiyat", SqlDbType.Decimal).Value = row["BirimFiyat"].ToString();
          cmd.Parameters.Add("@SatirToplamTutar", SqlDbType.Decimal).Value = row["SatirToplam"].ToString();

          cmd.ExecuteNonQuery();
        }

        #region KasaIslem Tablosuna kayıt ekleniyor.

        cmd.Parameters.Clear();
        cmd.CommandText = @"Insert Into KasaIslem values(@KasaID, @CariID, @Tahsilat, @IslemTarihi, @GenelToplam, @KasaIslemTipi,@FisBaslikID)";
        cmd.Parameters.Add("@KasaID", SqlDbType.Int).Value = cs.csKullanici.HizliSatisKasaID;
        cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = cs.csKullanici.PerakendeCariID;
        cmd.Parameters.Add("@Tahsilat", SqlDbType.Bit).Value = 1;

        cmd.Parameters.Add("@IslemTarihi", SqlDbType.DateTime).Value = DateTime.Now;
        cmd.Parameters.Add("@GenelToplam", SqlDbType.Decimal).Value = Convert.ToDecimal(txtFisToplam.Text);
        cmd.Parameters.Add("@KasaIslemTipi", SqlDbType.Int).Value = 5;
        cmd.Parameters.Add("@FisBaslikID", SqlDbType.Int).Value = fisBaslikID;

        cmd.ExecuteNonQuery();

        #endregion
        XtraMessageBox.Show("Kaydetme işlemi başarılı", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
        tr.Commit();

        dt.Rows.Clear();
        txtAlinanPara.Text = "0";
        txtFisToplam.Text = "0";
        txtIskontoOrani.Text = "0";
        txtIskontoTutari.Text = "0";
        txtMiktar.Text = "1";
        txtParaUstu.Text = "0";
        txtStokBarkod.Text = "";
        txtSonEklenenStokBarkod.Text = "";
        txtSonEklenenStokTanim.Text = "";
      }
      catch (Exception hata)
      {
        tr.Rollback();
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    private void txtStokBarkod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      decimal miktar = 0;
      if (decimal.TryParse(txtMiktar.Text, out miktar) == false)
        txtMiktar.Text = "1";

      Stok.frmStokSecim frmStokSecim = new Stok.frmStokSecim();
      if (frmStokSecim.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        SatirIslemi(frmStokSecim.StokID, frmStokSecim.StokBarkod, frmStokSecim.StokTanim, frmStokSecim.SatisFiyati, frmStokSecim.KdvOranTanim, txtMiktar.Text);
      }
      txtStokBarkod.Text = "";
      txtMiktar.Text = "1";
    }
    private void txtStokBarkod_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        decimal miktar = 0;
        if (decimal.TryParse(txtMiktar.Text, out miktar) == false)
          txtMiktar.Text = "1";

        using (SqlCommand cmd = new SqlCommand(@"SELECT dbo.Stok.StokID, dbo.Stok.StokBarkod, dbo.Stok.StokTanim, dbo.Stok.SatisFiyati, dbo.KdvOran.KdvOranTanim
FROM         dbo.Stok INNER JOIN
                      dbo.KdvOran ON dbo.Stok.KdvOranID = dbo.KdvOran.KdvOranID
WHERE     (dbo.Stok.StokBarkod = @StokBarkod)", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("StokBarkod", SqlDbType.VarChar).Value = txtStokBarkod.Text;

          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
          {
            if (dr.Read())
            {
              SatirIslemi(dr["StokID"].ToString(), dr["StokBarkod"].ToString(), dr["StokTanim"].ToString(), dr["SatisFiyati"].ToString(), dr["KdvOranTanim"].ToString(), txtMiktar.Text);
            }
          }
        }
        txtStokBarkod.Text = "";
        txtMiktar.Text = "1";
      }
    }
    private void txtAlinanPara_EditValueChanged(object sender, EventArgs e)
    {
      decimal alinanPara = 0, paraUstu = 0, fisToplam = 0;

      if (decimal.TryParse(txtFisToplam.Text, out fisToplam) == false)
        return;

      if (decimal.TryParse(txtAlinanPara.Text, out alinanPara) == false)
        return;

      txtParaUstu.Text = (alinanPara - fisToplam).ToString();
    }
    private void frmHizliSatis_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F10)
        btnSatisKaydet_Click(null, null);
    }
    private void gvListe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      //decimal satirToplam = 0, kdvOran = 0;
      //decimal.TryParse(gvListe.GetRowCellValue(e.RowHandle, "SatirToplam").ToString(), out satirToplam);
      //decimal.TryParse(gvListe.GetRowCellValue(e.RowHandle, "KDVOranTanim").ToString(), out kdvOran);

      //dt.Rows[e.RowHandle]["KDVTutar"] = satirToplam / (1 + (kdvOran / 100));


    }

    private void gvListe_DoubleClick(object sender, EventArgs e)
    {
      try
      {
        if (gvListe.FocusedRowHandle < 0) return;
        if (XtraMessageBox.Show(gvListe.GetFocusedRowCellDisplayText(colStokTanim) + ", satırı silinecek onaylıyo musunuz?", "Perakende Satış", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;

        gvListe.DeleteRow(gvListe.FocusedRowHandle);
        GenelToplamHesapla();
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
  }
}