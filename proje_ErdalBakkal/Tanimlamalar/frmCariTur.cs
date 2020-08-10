using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Tanimlamalar
{
  public partial class frmCariTur : DevExpress.XtraEditors.XtraUserControl
  {
    public frmCariTur()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    BindingSource bs = new BindingSource();
    DataTable dt = new DataTable();
    bool islem = false;
    int SatirNo = 0;

    private void frmCariTur_Load(object sender, EventArgs e)
    {
      try
      {
        using (da.SelectCommand = new SqlCommand(@"SELECT CariTurID, CariTurTanim FROM dbo.CariTur", cs.csBaglanti.BaglantiGetir()))
        {
          GridGuncelle();
          bs.DataSource = dt;
          gcCariTur.DataSource = bs;

          txtCariTurTanim.DataBindings.Clear();
          txtCariTurTanim.DataBindings.Add("Text", bs, "CariTurTanim");

          gvCariTur.Columns["CariTurID"].Visible = false;
          gvCariTur.Columns["CariTurTanim"].Caption = @"Cari Tur Tanım";
        }

        gvCariTur.OptionsView.ShowGroupPanel = false;
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

      txtCariTurTanim.Enabled = !islem;
      gcCariTur.Enabled = islem;
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
      txtCariTurTanim.Text = "";
      txtCariTurTanim.Focus();
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvCariTur.FocusedRowHandle < 0) return;
        int seciliSatirNo = gvCariTur.FocusedRowHandle;

        #region Kullanılıp Kullanılmadığının kontrolü yapılıyor.
        int satirSayisi = 0;
        using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) as SatirSayisi FROM Cari WHERE (CariTurID = @CariTurID )", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@CariTurID", SqlDbType.Int).Value = gvCariTur.GetFocusedRowCellValue("CariTurID").ToString();
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

        using (SqlCommand cmd = new SqlCommand("Delete From CariTur Where CariTurID=@CariTurID", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@CariTurID", SqlDbType.Int).Value = gvCariTur.GetFocusedRowCellValue("CariTurID").ToString();
           cmd.ExecuteNonQuery();
        }
        dt.Clear();
        da.Fill(dt);
        gvCariTur.FocusedRowHandle = seciliSatirNo - 1;

      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    private void btnDegistir_Click(object sender, EventArgs e)
    {
      if (gvCariTur.FocusedRowHandle < 0) return;
      SatirNo = gvCariTur.FocusedRowHandle;
      islem = false;
      NesneEnabled(false);
      txtCariTurTanim.Focus();
    }
    private void btnVazgec_Click(object sender, EventArgs e)
    {
      islem = false;
      NesneEnabled(true);
      GridGuncelle();
      gvCariTur.FocusedRowHandle = SatirNo;
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtCariTurTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alan, boş geçilemez.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtCariTurTanim.Focus();
          return;
        }

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cs.csBaglanti.BaglantiGetir();
        cmd.CommandType = CommandType.Text;

        //if (cs.csAyniKayitVarmiKontrolu.kontolET(cs.csBaglanti.BaglantiGetir(), cmd, "CariTur", islem, gvCariTur.GetFocusedRowCellDisplayText("CariTurID"), txtCariTurTanim.Text))
        //{
        //  XtraMessageBox.Show(txtCariTurTanim.Text + " isimde bir kayıt var zaten.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //  return;
        //}
        cmd.Parameters.Clear();
        if (islem)
        {
          cmd.CommandText = "Insert Into CariTur(CariTurTanim) Values(@CariTurTanim)";
        }
        else
        {
          cmd.CommandText = "Update CariTur Set CariTurTanim=@CariTurTanim Where CariTurID=@CariTurID";
          cmd.Parameters.Add("@CariTurID", SqlDbType.Int).Value = gvCariTur.GetFocusedRowCellValue("CariTurID").ToString();
        }

        cmd.Parameters.Add("@CariTurTanim", SqlDbType.NVarChar).Value = txtCariTurTanim.Text;
        cmd.ExecuteNonQuery();

        NesneEnabled(true);
        GridGuncelle();
        if (!islem) gvCariTur.FocusedRowHandle = SatirNo;
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
