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
	public partial class frmKullaniciListe : DevExpress.XtraEditors.XtraForm
	{
		public frmKullaniciListe()
		{
			InitializeComponent();
		}
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();

		private void gridControl1_Click(object sender, EventArgs e)
		{

		}

		private void frmKullaniciListe_Load(object sender, EventArgs e)
		{
			try
			{
				using (da.SelectCommand = new SqlCommand(@"Select KullaniciID, KullaniciAdSoyad, KullaniciKodu, KullaniciSifre, CASE WHEN Aktif=1 THEN 'Aktif' ELSE 'Pasif'  END  as Aktif From Kullanici", cs.csBaglanti.BaglantiGetir()))
				{

					da.Fill(dt);
					gcListe.DataSource = dt;
				}
				gvListe.Columns["KullaniciID"].Visible = false;
				//kolonun uzunluğunu, hücrenin içindeki veri kadar uzatır.
				gvListe.BestFitColumns();
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			frmKullaniciDetay frmKullaniciDetay = new frmKullaniciDetay("-1");
			if (frmKullaniciDetay.ShowDialog() == DialogResult.OK)
			{
				btnGuncelle_Click(null, null);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			try
			{
				if (gvListe.FocusedRowHandle < 0) return;
				int seciliSatirNo = gvListe.FocusedRowHandle;

				if (XtraMessageBox.Show("Seçili Kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

				using (var cmd = new SqlCommand(@"Delete From Kullanici Where KullaniciID=@KullaniciID", cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("KullaniciID").ToString();
					cmd.ExecuteNonQuery();
				}

				btnGuncelle_Click(null, null);

				gvListe.FocusedRowHandle = seciliSatirNo - 1;
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{

		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnDegistir_Click(object sender, EventArgs e)
		{
			//gvListe.GetFocusedRowCellDisplayText("KullaniciID") -> seçilen satırdaki KullaniciId kolonunun içindeki bilgiyi getir.
			//gvListe.FocusedRowHandle -> seçilen satırın indisini verir.

			int satir = gvListe.FocusedRowHandle;
			frmKullaniciDetay frmKullaniciDetay = new frmKullaniciDetay(gvListe.GetFocusedRowCellDisplayText("KullaniciID"));
			if (frmKullaniciDetay.ShowDialog() == DialogResult.OK)
			{
				btnGuncelle_Click(null, null);
				gvListe.FocusedRowHandle = satir;
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			//grid içerisine, veritabanındaki son bilgiler gelsin.
			dt.Clear();
			da.Fill(dt);
		}
	}
}