using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace proje_ErdalBakkal.Cari
{
  public partial class frmCariTurEkle : DevExpress.XtraEditors.XtraForm
  {
    public frmCariTurEkle()
    {
      InitializeComponent();
    }
    public static int sonCariTurID = -1;
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand(
        @"Insert Into CariTur values(@CariTurTanim) SET @sonID=SCOPE_IDENTITY()", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@sonID", SqlDbType.Int).Direction = ParameterDirection.Output;
          cmd.Parameters.Add("@CariTurTanim", SqlDbType.NVarChar).Value = txtCariTurTanim.Text;
          cmd.ExecuteNonQuery();
          sonCariTurID = (int)cmd.Parameters["@sonID"].Value;
        }
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
      catch (Exception hata)
      {
				XtraMessageBox.Show(hata.Message);
			}
    }
  }
}