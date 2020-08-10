using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Stok
{
  public partial class frmStokSecim : DevExpress.XtraEditors.XtraForm
  {
    public frmStokSecim()
    {
      InitializeComponent();
    }
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();
    public string StokID = "", StokBarkod = "", StokTanim = "", SatisFiyati = "", KdvOranTanim = "";
    private void btnSec_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvListe.FocusedRowHandle < 0) return;
        StokID = gvListe.GetFocusedRowCellDisplayText("StokID");
        StokBarkod = gvListe.GetFocusedRowCellDisplayText("StokBarkod");
        StokTanim = gvListe.GetFocusedRowCellDisplayText("StokTanim");
        SatisFiyati = gvListe.GetFocusedRowCellDisplayText("SatisFiyati");
        KdvOranTanim = gvListe.GetFocusedRowCellDisplayText("KdvOranTanim");

        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }

    private void frmStokSecim_Load(object sender, EventArgs e)
    {
      try
      {
        using (da.SelectCommand = new SqlCommand(@"SELECT     dbo.Stok.StokID, dbo.Stok.StokBarkod, dbo.Stok.StokTanim, dbo.Stok.SatisFiyati, dbo.KdvOran.KdvOranTanim
FROM         dbo.Stok INNER JOIN
                      dbo.KdvOran ON dbo.Stok.KdvOranID = dbo.KdvOran.KdvOranID", cs.csBaglanti.BaglantiGetir()))
        {
          da.Fill(dt);
          gcListe.DataSource = dt;
        }

        gvListe.OptionsView.ShowGroupPanel = false;
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    }
  }
}