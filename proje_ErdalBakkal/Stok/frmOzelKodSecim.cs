using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.stok
{
  public partial class frmOzelKodSecim : DevExpress.XtraEditors.XtraForm
  {
    public frmOzelKodSecim()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();

    private void btnSec_Click(object sender, EventArgs e)
    {
      if (gvListe.FocusedRowHandle < 0) return;

      ((frmStokDetay)Application.OpenForms["frmStokDetay"]).txtOzelKod.Text = gvListe.GetFocusedRowCellDisplayText("OzelKodTanim");
      ((frmStokDetay)Application.OpenForms["frmStokDetay"]).OzelKodID = 
			gvListe.GetFocusedRowCellDisplayText("OzelKodID");

      this.Close();
    }
		private void frmOzelKodSecim_Load(object sender, EventArgs e)
		{
			try
			{
				using (da.SelectCommand = new SqlCommand(@"SELECT OzelKodID, OzelKodTanim FROM dbo.OzelKod", cs.csBaglanti.BaglantiGetir()))
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