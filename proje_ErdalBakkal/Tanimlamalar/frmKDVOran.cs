using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Tanimlamalar
{
  public partial class frmKDVOran : DevExpress.XtraEditors.XtraUserControl
  {
    public frmKDVOran()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    BindingSource bs = new BindingSource();
    DataTable dt = new DataTable();
    bool islem = false;
    int SatirNo = 0;

    private void frmKDVOran_Load(object sender, EventArgs e)
    {
      try
      {
        using (da.SelectCommand = new SqlCommand(@"SELECT KDVOranID, KDVOranTanim FROM dbo.KDVOran", cs.csBaglanti.BaglantiGetir()))
        {
          GridGuncelle();
          bs.DataSource = dt;
          gcKDVOran.DataSource = bs;

          txtKDVOranTanim.DataBindings.Clear();
          txtKDVOranTanim.DataBindings.Add("Text", bs, "KDVOranTanim");

          gvKDVOran.Columns["KDVOranID"].Visible = false;
          gvKDVOran.Columns["KDVOranTanim"].Caption = @"Kdv Oran Tanım";
        }

        gvKDVOran.OptionsView.ShowGroupPanel = false;
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

      txtKDVOranTanim.Enabled = !islem;
      gcKDVOran.Enabled = islem;
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
      txtKDVOranTanim.Text = "";
      txtKDVOranTanim.Focus();
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvKDVOran.FocusedRowHandle < 0) return;
        int seciliSatirNo = gvKDVOran.FocusedRowHandle;

        #region Kullanılıp Kullanılmadığının kontrolü yapılıyor.
        int satirSayisi = 0;
        using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) as SatirSayisi FROM Cari WHERE (KDVOranID = @KDVOranID )", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@KDVOranID", SqlDbType.Int).Value = gvKDVOran.GetFocusedRowCellValue("KDVOranID").ToString();
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

        using (SqlCommand cmd = new SqlCommand("Delete From KDVOran Where KDVOranID=@KDVOranID", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@KDVOranID", SqlDbType.Int).Value = gvKDVOran.GetFocusedRowCellValue("KDVOranID").ToString();
           cmd.ExecuteNonQuery();
        }
        dt.Clear();
        da.Fill(dt);
        gvKDVOran.FocusedRowHandle = seciliSatirNo - 1;

      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    private void btnDegistir_Click(object sender, EventArgs e)
    {
      if (gvKDVOran.FocusedRowHandle < 0) return;
      SatirNo = gvKDVOran.FocusedRowHandle;
      islem = false;
      NesneEnabled(false);
      txtKDVOranTanim.Focus();
    }
    private void btnVazgec_Click(object sender, EventArgs e)
    {
      islem = false;
      NesneEnabled(true);
      GridGuncelle();
      gvKDVOran.FocusedRowHandle = SatirNo;
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtKDVOranTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alan, boş geçilemez.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtKDVOranTanim.Focus();
          return;
        }

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cs.csBaglanti.BaglantiGetir();
        cmd.CommandType = CommandType.Text;

        //if (cs.csAyniKayitVarmiKontrolu.kontolET(cs.csBaglanti.BaglantiGetir(), cmd, "KDVOran", islem, gvKDVOran.GetFocusedRowCellDisplayText("KDVOranID"), txtKDVOranTanim.Text))
        //{
        //  XtraMessageBox.Show(txtKDVOranTanim.Text + " isimde bir kayıt var zaten.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //  return;
        //}
        cmd.Parameters.Clear();
        if (islem)
        {
          cmd.CommandText = "Insert Into KDVOran(KDVOranTanim) Values(@KDVOranTanim)";
        }
        else
        {
          cmd.CommandText = "Update KDVOran Set KDVOranTanim=@KDVOranTanim Where KDVOranID=@KDVOranID";
          cmd.Parameters.Add("@KDVOranID", SqlDbType.Int).Value = gvKDVOran.GetFocusedRowCellValue("KDVOranID").ToString();
        }

        cmd.Parameters.Add("@KDVOranTanim", SqlDbType.NVarChar).Value = txtKDVOranTanim.Text;
        cmd.ExecuteNonQuery();

        NesneEnabled(true);
        GridGuncelle();
        if (!islem) gvKDVOran.FocusedRowHandle = SatirNo;
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
