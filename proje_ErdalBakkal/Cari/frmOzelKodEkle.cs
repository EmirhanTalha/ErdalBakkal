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
  public partial class frmOzelKodEkle : DevExpress.XtraEditors.XtraForm
  {
    public frmOzelKodEkle()
    {
      InitializeComponent();
    }
    public static int sonKayitID = -1;
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand(@"Insert Into OzelKod values(@OzelKodTanim) set @sonID=SCOPE_IDENTITY()", cs.csBaglanti.BaglantiGetir()))
        {
          cmd.Parameters.Add("@sonID", SqlDbType.Int).Direction = ParameterDirection.Output;
          cmd.Parameters.Add("@OzelKodTanim", SqlDbType.VarChar).Value = txtOzelKod.Text;

          cmd.ExecuteNonQuery();
          sonKayitID = (int)cmd.Parameters["@sonID"].Value;
        }
        //MessageBox.Show("Kaydetme işlemi başarılı");
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}