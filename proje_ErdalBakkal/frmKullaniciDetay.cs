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
	public partial class frmKullaniciDetay : DevExpress.XtraEditors.XtraForm
	{
		public frmKullaniciDetay(string KullaniciID)
		{
			InitializeComponent();
			_KullaniciID = KullaniciID;
		}
		string _KullaniciID = "-1";

		private void frmKullaniciDetay_Load(object sender, EventArgs e)
		{
			try
			{
				if (_KullaniciID != "-1")
				{
					using (SqlCommand cmd = new SqlCommand(@"Select KullaniciAdSoyad, KullaniciKodu, 
					KullaniciSifre, Aktif From Kullanici Where KullaniciID=@KullaniciID",
					cs.csBaglanti.BaglantiGetir()))
					{
						cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = _KullaniciID;
						using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
						{
							if (dr.Read())
							{
								txtKullaniciAdSoyad.Text = dr["KullaniciAdSoyad"].ToString();
								txtKullaniciKodu.Text = dr["KullaniciKodu"].ToString();
								txtKullaniciSifre.Text = dr["KullaniciSifre"].ToString();
								ceAktif.Checked = (bool)dr["Aktif"];
							}
						}
					}
				}
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				if (String.IsNullOrWhiteSpace(txtKullaniciAdSoyad.Text))
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtKullaniciAdSoyad.Focus();
					return;
				}
				if (String.IsNullOrWhiteSpace(txtKullaniciKodu.Text))
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtKullaniciKodu.Focus();
					return;
				}
				if (String.IsNullOrWhiteSpace(txtKullaniciSifre.Text))
				{
					XtraMessageBox.Show("Zorunlu alan boş geçilemez.");
					txtKullaniciSifre.Focus();
					return;
				}

				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.Connection = cs.csBaglanti.BaglantiGetir();
				if (_KullaniciID == "-1")
				{
					cmd.CommandText = @"Insert Into Kullanici values(@KullaniciAdSoyad, @KullaniciKodu, @KullaniciSifre, @Aktif)";
				}
				else
				{
					cmd.CommandText = @"Update Kullanici SET 
					KullaniciAdSoyad=@KullaniciAdSoyad, KullaniciKodu=@KullaniciKodu, KullaniciSifre=@KullaniciSifre, Aktif=@Aktif 
					Where KullaniciID=@KullaniciID";
					cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = _KullaniciID;
				}
				cmd.Parameters.Add("@KullaniciAdSoyad", SqlDbType.NVarChar).Value = txtKullaniciAdSoyad.Text;
				cmd.Parameters.Add("@KullaniciKodu", SqlDbType.NVarChar).Value = txtKullaniciKodu.Text;
				cmd.Parameters.Add("@KullaniciSifre", SqlDbType.NVarChar).Value = txtKullaniciSifre.Text;
				cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = ceAktif.Checked;

				cmd.ExecuteNonQuery();
				XtraMessageBox.Show("Kaydetme işlemi başarılı");
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnIptal_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void ceAktif_CheckedChanged(object sender, EventArgs e)
		{
			ceAktif.Text = (ceAktif.Checked) ? "Aktif" : "Pasif";
		}
	}
}