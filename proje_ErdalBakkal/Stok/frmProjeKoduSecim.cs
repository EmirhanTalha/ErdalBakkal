using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.stok
{
  public partial class frmProjeKoduSecim : DevExpress.XtraEditors.XtraForm
  {
    public frmProjeKoduSecim()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();

    private void btnSec_Click(object sender, EventArgs e)
    {
      if (gvListe.FocusedRowHandle < 0) return;

      ((frmStokDetay)Application.OpenForms["frmStokDetay"]).txtProjeKod.Text = gvListe.GetFocusedRowCellDisplayText("ProjeTanim");
      ((frmStokDetay)Application.OpenForms["frmStokDetay"]).ProjeKodID = gvListe.GetFocusedRowCellDisplayText("ProjeID");

      this.Close();
    }

    private void frmStokBarkodSecim_Load(object sender, EventArgs e)
    {
      try
      {
        using (da.SelectCommand = new SqlCommand(@"SELECT ProjeID, ProjeKodu, ProjeTanim FROM dbo.Proje", cs.csBaglanti.BaglantiGetir()))
        {
          da.Fill(dt);
          gcListe.DataSource = dt;
        }

        gvListe.OptionsView.ShowGroupPanel = false;
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "input teknoloji a.ş.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
  }
}