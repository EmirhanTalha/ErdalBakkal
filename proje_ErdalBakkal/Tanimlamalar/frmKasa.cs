using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Tanimlamalar
{
  public partial class frmKasa : DevExpress.XtraEditors.XtraUserControl
  {
    public frmKasa()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    BindingSource bs = new BindingSource();
    DataTable dt = new DataTable();
    bool islem = false;
    int SatirNo = 0;

    private void frmKasa_Load(object sender, EventArgs e)
    {
      try
      {
        
        using (da.SelectCommand = new SqlCommand(@"SELECT KasaID, KasaTanim FROM dbo.Kasa", cs.csBaglanti.BaglantiGetir()))
        {
          GridGuncelle();
          bs.DataSource = dt;
          gcListe.DataSource = bs;

          txtKasaTanim.DataBindings.Clear();
          txtKasaTanim.DataBindings.Add("Text", bs, "KasaTanim");

          gvListe.Columns["KasaID"].Visible = false;
          gvListe.Columns["KasaTanim"].Caption = @"Kasa Tanım";
        }

        gvListe.OptionsView.ShowGroupPanel = false;
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

      txtKasaTanim.Enabled = !islem;
      gcListe.Enabled = islem;
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
      txtKasaTanim.Text = "";
      txtKasaTanim.Focus();
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvListe.FocusedRowHandle < 0) return;
        int seciliSatirNo = gvListe.FocusedRowHandle;
       
        #region Kullanılıp Kullanılmadığının kontrolü yapılıyor.
        //int satirSayisi = 0;
        //using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) as SatirSayisi FROM Cari WHERE (KasaID = @KasaID )", cs.csBaglanti.BaglantiGetir()))
        //{
        //  cmd.Parameters.Add("@KasaID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("KasaID").ToString();
        //  using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
        //    if (dr.Read())
        //      satirSayisi = (int)dr["SatirSayisi"];
        //}

        //if (satirSayisi > 0)
        //{
        //  XtraMessageBox.Show("Kayıt, Cari Bilgilerinde daha önceden kullanılmış.\n\nSeçili Kayıt Silinemez.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //  return;
        //}
        #endregion

        if (XtraMessageBox.Show("Seçili Kaydı Silmek İstediğinize Emin misiniz ?", "Perakende Satış", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
          return;

        using (SqlCommand cmd = new SqlCommand("Delete From Kasa Where KasaID=@KasaID", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@KasaID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("KasaID").ToString();
           cmd.ExecuteNonQuery();
        }
        dt.Clear();
        da.Fill(dt);
        gvListe.FocusedRowHandle = seciliSatirNo - 1;
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    private void btnDegistir_Click(object sender, EventArgs e)
    {
      if (gvListe.FocusedRowHandle < 0) return;
      SatirNo = gvListe.FocusedRowHandle;
      islem = false;
      NesneEnabled(false);
      txtKasaTanim.Focus();
    }
    private void btnVazgec_Click(object sender, EventArgs e)
    {
      islem = false;
      NesneEnabled(true);
      GridGuncelle();
      gvListe.FocusedRowHandle = SatirNo;
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtKasaTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alan, boş geçilemez.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtKasaTanim.Focus();
          return;
        }

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cs.csBaglanti.BaglantiGetir();
        cmd.CommandType = CommandType.Text;

        //if (cs.csAyniKayitVarmiKontrolu.kontolET(cs.csBaglanti.BaglantiGetir(), cmd, "Kasa", islem, gvListe.GetFocusedRowCellDisplayText("KasaID"), txtKasaTanim.Text))
        //{
        //  XtraMessageBox.Show(txtKasaTanim.Text + " isimde bir kayıt var zaten.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //  return;
        //}
        cmd.Parameters.Clear();
        if (islem)
        {
          cmd.CommandText = "Insert Into Kasa(KasaTanim) Values(@KasaTanim)";
        }
        else
        {
          cmd.CommandText = "Update Kasa Set KasaTanim=@KasaTanim Where KasaID=@KasaID";
          cmd.Parameters.Add("@KasaID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("KasaID").ToString();
        }

        cmd.Parameters.Add("@KasaTanim", SqlDbType.NVarChar).Value = txtKasaTanim.Text;
        cmd.ExecuteNonQuery();

        NesneEnabled(true);
        GridGuncelle();
        if (!islem) gvListe.FocusedRowHandle = SatirNo;
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
