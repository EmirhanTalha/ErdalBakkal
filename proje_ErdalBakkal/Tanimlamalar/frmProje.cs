using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace proje_ErdalBakkal.Tanimlamalar
{
	public partial class frmProje : DevExpress.XtraEditors.XtraUserControl
	{
		public frmProje()
		{
			InitializeComponent();
		}
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable(); // dt veriyi sadece bir nesneye aktarabilir.
		BindingSource bs = new BindingSource(); // bs bir veriyi n tane nesneye aktarabilir.

		enum islemTipi { insert, update }
		islemTipi islem;
		int SatirNo = 0;
		private void frmProje_Load(object sender, EventArgs e)
		{
			try
			{
				using (da.SelectCommand = new SqlCommand(@"Select ProjeID, ProjeKodu, ProjeTanim From Proje Order by ProjeTanim ASC", cs.csBaglanti.BaglantiGetir()))
				{
					da.Fill(dt);
					bs.DataSource = dt;
					gcListe.DataSource = bs;
				}
				txtProjeTanim.DataBindings.Clear();
				txtProjeTanim.DataBindings.Add("Text", bs, "ProjeTanim");

				txtProjeKodu.DataBindings.Clear();
				txtProjeKodu.DataBindings.Add("Text", bs, "ProjeKodu");

				gvListe.Columns["ProjeID"].Visible = false;
				gvListe.BestFitColumns();
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}

		void NesneEnableAyarla(bool islem)
		{
			btnEkle.Enabled = !islem;
			btnSil.Enabled = !islem;
			btnDegistir.Enabled = !islem;

			btnVazgec.Enabled = islem;
			btnKaydet.Enabled = islem;

			//btnExcel.Enabled = islem;
			btnGuncelle.Enabled = !islem;

			txtProjeTanim.Enabled = islem;
			gcListe.Enabled = !islem;
		}
		private void btnEkle_Click(object sender, EventArgs e)
		{
			NesneEnableAyarla(true);
			txtProjeTanim.Focus();
			txtProjeTanim.Text = "";
			islem = islemTipi.insert;
		}
		private void btnSil_Click(object sender, EventArgs e)
		{
			try
			{
				if (gvListe.FocusedRowHandle < 0) return;
				int seciliSatirNo = gvListe.FocusedRowHandle;

				if (XtraMessageBox.Show("Seçili Kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

				using (var cmd = new SqlCommand(@"Delete From Proje Where ProjeID=@ProjeID", cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@ProjeID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("ProjeID").ToString();
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
		private void btnDegistir_Click(object sender, EventArgs e)
		{
			if (gvListe.FocusedRowHandle < 0) return;
			NesneEnableAyarla(true);
			txtProjeTanim.Focus();
			islem = islemTipi.update;
			SatirNo = gvListe.FocusedRowHandle;
		}
		private void btnVazgec_Click(object sender, EventArgs e)
		{
			NesneEnableAyarla(false);
			btnGuncelle_Click(null, null);
			gvListe.FocusedRowHandle = 0;
		}
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtProjeKodu.Text))
				{
					XtraMessageBox.Show("Zorunlu alan, boş geçilemez.", "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtProjeKodu.Focus();
					return;
				}
				if (string.IsNullOrWhiteSpace(txtProjeTanim.Text))
				{
					XtraMessageBox.Show("Zorunlu alan, boş geçilemez.", "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtProjeTanim.Focus();
					return;
				}
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cs.csBaglanti.BaglantiGetir();
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.Clear();
				switch (islem)
				{
					case islemTipi.insert:
						cmd.CommandText = "Insert Into Proje(ProjeKodu, ProjeTanim) Values(@ProjeKodu, @ProjeTanim)";
						break;
					case islemTipi.update:
						cmd.CommandText = "Update Proje Set ProjeKodu=@ProjeKodu, ProjeTanim=@ProjeTanim Where ProjeID=@ProjeID";
						cmd.Parameters.Add("@ProjeID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("ProjeID").ToString();
						break;
					default:
						break;
				}

				cmd.Parameters.Add("@ProjeKodu", SqlDbType.NVarChar).Value = txtProjeKodu.Text;
				cmd.Parameters.Add("@ProjeTanim", SqlDbType.NVarChar).Value = txtProjeTanim.Text;
				cmd.ExecuteNonQuery();

				NesneEnableAyarla(true);
				btnGuncelle_Click(null, null);
				if (islem == islemTipi.update) gvListe.FocusedRowHandle = SatirNo;
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show(hata.Message);
			}
		}
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			dt.Clear();
			da.Fill(dt);
		}
		private void btnExcel_Click(object sender, EventArgs e)
		{
			cs.csExceleAktar excel = new cs.csExceleAktar();
			excel.ExceleAktar(gcListe);
		}
	}
}
