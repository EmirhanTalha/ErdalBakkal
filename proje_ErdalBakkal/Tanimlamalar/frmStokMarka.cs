using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Tanimlamalar
{
  public partial class frmStokMarka : DevExpress.XtraEditors.XtraUserControl
  {
    public frmStokMarka()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    BindingSource bs = new BindingSource();
    DataTable dt = new DataTable();
    bool islem = false;
    int SatirNo = 0;

    private void frmStokMarka_Load(object sender, EventArgs e)
    {
      try
      {
        
        using (da.SelectCommand = new SqlCommand(@"SELECT     StokMarkaID, StokMarkaTanim FROM dbo.StokMarka", cs.csBaglanti.BaglantiGetir()))
        {
          GridGuncelle();
          bs.DataSource = dt;
          gcStokMarka.DataSource = bs;

          txtStokMarkaTanim.DataBindings.Clear();
          txtStokMarkaTanim.DataBindings.Add("Text", bs, "StokMarkaTanim");

          gvStokMarka.Columns["StokMarkaID"].Visible = false;
          gvStokMarka.Columns["StokMarkaTanim"].Caption = @"Stok Birim Tanım";
        }

        gvStokMarka.OptionsView.ShowGroupPanel = false;
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

      txtStokMarkaTanim.Enabled = !islem;
      gcStokMarka.Enabled = islem;
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
      txtStokMarkaTanim.Text = "";
      txtStokMarkaTanim.Focus();
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvStokMarka.FocusedRowHandle < 0) return;
        int seciliSatirNo = gvStokMarka.FocusedRowHandle;

        #region Kullanılıp Kullanılmadığının kontrolü yapılıyor.
        int satirSayisi = 0;
        using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) as SatirSayisi FROM Cari WHERE (StokMarkaID = @StokMarkaID )", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@StokMarkaID", SqlDbType.Int).Value = gvStokMarka.GetFocusedRowCellValue("StokMarkaID").ToString();
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

        using (SqlCommand cmd = new SqlCommand("Delete From StokMarka Where StokMarkaID=@StokMarkaID", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@StokMarkaID", SqlDbType.Int).Value = gvStokMarka.GetFocusedRowCellValue("StokMarkaID").ToString();
           cmd.ExecuteNonQuery();
        }
        dt.Clear();
        da.Fill(dt);
        gvStokMarka.FocusedRowHandle = seciliSatirNo - 1;

      }
      catch (Exception hata)
			{
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
    private void btnDegistir_Click(object sender, EventArgs e)
    {
      if (gvStokMarka.FocusedRowHandle < 0) return;
      SatirNo = gvStokMarka.FocusedRowHandle;
      islem = false;
      NesneEnabled(false);
      txtStokMarkaTanim.Focus();
    }
    private void btnVazgec_Click(object sender, EventArgs e)
    {
      islem = false;
      NesneEnabled(true);
      GridGuncelle();
      gvStokMarka.FocusedRowHandle = SatirNo;
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtStokMarkaTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alan, boş geçilemez.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtStokMarkaTanim.Focus();
          return;
        }

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cs.csBaglanti.BaglantiGetir();
        cmd.CommandType = CommandType.Text;

        //if (cs.csAyniKayitVarmiKontrolu.kontolET(cs.csBaglanti.BaglantiGetir(), cmd, "StokMarka", islem, gvStokMarka.GetFocusedRowCellDisplayText("StokMarkaID"), txtStokMarkaTanim.Text))
        //{
        //  XtraMessageBox.Show(txtStokMarkaTanim.Text + " isimde bir kayıt var zaten.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //  return;
        //}
        cmd.Parameters.Clear();
        if (islem)
        {
          cmd.CommandText = "Insert Into StokMarka(StokMarkaTanim) Values(@StokMarkaTanim)";
        }
        else
        {
          cmd.CommandText = "Update StokMarka Set StokMarkaTanim=@StokMarkaTanim Where StokMarkaID=@StokMarkaID";
          cmd.Parameters.Add("@StokMarkaID", SqlDbType.Int).Value = gvStokMarka.GetFocusedRowCellValue("StokMarkaID").ToString();
        }

        cmd.Parameters.Add("@StokMarkaTanim", SqlDbType.NVarChar).Value = txtStokMarkaTanim.Text;
        cmd.ExecuteNonQuery();

        NesneEnabled(true);
        GridGuncelle();
        if (!islem) gvStokMarka.FocusedRowHandle = SatirNo;
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
