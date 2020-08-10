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

namespace proje_ErdalBakkal
{
	public partial class frmKullaniciGiris : DevExpress.XtraEditors.XtraForm
	{
		public frmKullaniciGiris()
		{
			InitializeComponent();
		}
	
		private void btnGiris_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtKullaniciKodu.Text))
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtKullaniciKodu.Focus();
					return;
				}
				if (string.IsNullOrWhiteSpace(txtKullaniciSifre.Text))
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtKullaniciSifre.Focus();
					return;
				}

				bool giris = false;
				using (SqlCommand cmd = new SqlCommand(@"Select KullaniciID, KullaniciAdSoyad From Kullanici Where KullaniciKodu=@KullaniciKodu AND KullaniciSifre=@KullaniciSifre AND Aktif=1", cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@KullaniciKodu", SqlDbType.NVarChar).Value = txtKullaniciKodu.Text;
					cmd.Parameters.Add("@KullaniciSifre", SqlDbType.NVarChar).Value = txtKullaniciSifre.Text;

					using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
					{
						if (dr.Read())
						{
							giris = true;
							cs.csKullanici.KullaniciAdSoyad = dr["KullaniciAdSoyad"].ToString();
							cs.csKullanici.KullaniciID= dr["KullaniciID"].ToString();
						}
					}
				}


				if (giris)
				{
					frmAnaForm frmAnaForm = new frmAnaForm();
					frmAnaForm.FormClosed += AnaFormKapandi;
					this.Hide();
					frmAnaForm.Show();
				}
				else
					XtraMessageBox.Show("Kullanıcı Kodu/Şifreniz hatalı veya Kullanıcı Aktif değil...");
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void AnaFormKapandi(object sender, FormClosedEventArgs e)
		{
			this.Close();
		}
	}
}