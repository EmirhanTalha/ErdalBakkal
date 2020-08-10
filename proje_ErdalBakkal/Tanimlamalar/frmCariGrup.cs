using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Tanimlamalar
{
  public partial class frmCariGrup : DevExpress.XtraEditors.XtraUserControl
  {
    public frmCariGrup()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    BindingSource bs = new BindingSource();
    DataTable dt = new DataTable();
    bool islem = false;
    int SatirNo = 0;

    private void frmCariGrup_Load(object sender, EventArgs e)
    {
      try
      {
        
        using (da.SelectCommand = new SqlCommand(@"SELECT     CariGrupID, CariGrupTanim FROM         dbo.CariGrup", cs.csBaglanti.BaglantiGetir()))
        {
          GridGuncelle();
          bs.DataSource = dt;
          gcCariGrup.DataSource = bs;

          txtCariGrupTanim.DataBindings.Clear();
          txtCariGrupTanim.DataBindings.Add("Text", bs, "CariGrupTanim");

          gvCariGrup.Columns["CariGrupID"].Visible = false;
          gvCariGrup.Columns["CariGrupTanim"].Caption = @"Cari Grup Tanım";
        }

        gvCariGrup.OptionsView.ShowGroupPanel = false;
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

      txtCariGrupTanim.Enabled = !islem;
      gcCariGrup.Enabled = islem;
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
      txtCariGrupTanim.Text = "";
      txtCariGrupTanim.Focus();
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvCariGrup.FocusedRowHandle < 0) return;
        int seciliSatirNo = gvCariGrup.FocusedRowHandle;

        #region Kullanılıp Kullanılmadığının kontrolü yapılıyor.
        int satirSayisi = 0;
        using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) as SatirSayisi FROM Cari WHERE (CariGrupID = @CariGrupID )", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@CariGrupID", SqlDbType.Int).Value = gvCariGrup.GetFocusedRowCellValue("CariGrupID").ToString();
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

        using (SqlCommand cmd = new SqlCommand("Delete From CariGrup Where CariGrupID=@CariGrupID", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@CariGrupID", SqlDbType.Int).Value = gvCariGrup.GetFocusedRowCellValue("CariGrupID").ToString();
           cmd.ExecuteNonQuery();
        }
        dt.Clear();
        da.Fill(dt);
        gvCariGrup.FocusedRowHandle = seciliSatirNo - 1;
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    private void btnDegistir_Click(object sender, EventArgs e)
    {
      if (gvCariGrup.FocusedRowHandle < 0) return;
      SatirNo = gvCariGrup.FocusedRowHandle;
      islem = false;
      NesneEnabled(false);
      txtCariGrupTanim.Focus();
    }
    private void btnVazgec_Click(object sender, EventArgs e)
    {
      islem = false;
      NesneEnabled(true);
      GridGuncelle();
      gvCariGrup.FocusedRowHandle = SatirNo;
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtCariGrupTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alan, boş geçilemez.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtCariGrupTanim.Focus();
          return;
        }

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cs.csBaglanti.BaglantiGetir();
        cmd.CommandType = CommandType.Text;

        //if (cs.csAyniKayitVarmiKontrolu.kontolET(cs.csBaglanti.BaglantiGetir(), cmd, "CariGrup", islem, gvCariGrup.GetFocusedRowCellDisplayText("CariGrupID"), txtCariGrupTanim.Text))
        //{
        //  XtraMessageBox.Show(txtCariGrupTanim.Text + " isimde bir kayıt var zaten.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //  return;
        //}
        cmd.Parameters.Clear();
        if (islem)
        {
          cmd.CommandText = "Insert Into CariGrup(CariGrupTanim) Values(@CariGrupTanim)";
        }
        else
        {
          cmd.CommandText = "Update CariGrup Set CariGrupTanim=@CariGrupTanim Where CariGrupID=@CariGrupID";
          cmd.Parameters.Add("@CariGrupID", SqlDbType.Int).Value = gvCariGrup.GetFocusedRowCellValue("CariGrupID").ToString();
        }

        cmd.Parameters.Add("@CariGrupTanim", SqlDbType.NVarChar).Value = txtCariGrupTanim.Text;
        cmd.ExecuteNonQuery();

        NesneEnabled(true);
        GridGuncelle();
        if (!islem) gvCariGrup.FocusedRowHandle = SatirNo;
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
