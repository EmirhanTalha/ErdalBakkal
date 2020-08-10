using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using proje_ErdalBakkal.cs;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proje_ErdalBakkal.Kasa
{
	public partial class frmKasaNakitOdemeTahsilatListe : DevExpress.XtraEditors.XtraForm
	{
		public frmKasaNakitOdemeTahsilatListe()
		{
			InitializeComponent();
		}
		enum enGridArayuzIslemleri { Set, Get };
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();

		//KasaIslem.KasaIslemTipi -> 1: Kasadan Alınan Hizmet Faturası, 2: Kasadan Satış Faturası, 3: Kasadan Nakit Tahsilat, 4: Kasadan Nakit Ödeme

		private void frmKasaNakitTahsilatListe_Load(object sender, EventArgs e)
		{
			try
			{
				ListeDoldur();

				new csGridLayout(csGridLayout.enGridArayuzIslemleri.Get, this, Convert.ToInt32(cs.csKullanici.KullaniciID), cs.csBaglanti.BaglantiGetir());
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void ListeDoldur()
		{
			try
			{
				string sqlWhere = "";
				if (cmbDurum.SelectedIndex != 2)
					sqlWhere = " WHERE (dbo.KasaIslem.Tahsilat = " + cmbDurum.SelectedIndex.ToString() + ")";

				using (da.SelectCommand = new SqlCommand(@"
SELECT     dbo.KasaIslem.KasaIslemID, CASE WHEN dbo.KasaIslem.Tahsilat = 0 THEN 'Ödeme' ELSE 'Tahsilat' END AS KasaIslem, dbo.Kasa.KasaTanim, dbo.Cari.CariTanim, 
                      dbo.KasaIslem.IslemTarihi, dbo.KasaIslem.GenelToplam, 
                      CASE WHEN dbo.KasaIslem.KasaIslemTipi = 0 THEN 'Kasadan Alınan Hizmet Faturası' WHEN dbo.KasaIslem.KasaIslemTipi = 1 THEN 'Kasadan Satış Faturası' WHEN
                       dbo.KasaIslem.KasaIslemTipi = 2 THEN 'Kasadan Nakit Tahsilat' WHEN dbo.KasaIslem.KasaIslemTipi = 3 THEN 'Kasadan Nakit Ödeme' END AS KasaIslemTipi
FROM         dbo.KasaIslem LEFT OUTER JOIN
                      dbo.Kasa ON dbo.KasaIslem.KasaID = dbo.Kasa.KasaID LEFT OUTER JOIN
                      dbo.Cari ON dbo.KasaIslem.CariID = dbo.Cari.CariID
                      " + sqlWhere, cs.csBaglanti.BaglantiGetir()))
				{
					dt.Clear();
					da.Fill(dt);
					gcListe.DataSource = dt;
				}
				gvListe.Columns["KasaIslemID"].Visible = false;
				gvListe.FormatConditions.Clear();

				if (cmbDurum.SelectedIndex == 2)
				{
					StyleFormatCondition CariGiris = new StyleFormatCondition(FormatConditionEnum.Equal, gvListe.Columns["KasaIslem"], "Ödeme", "Ödeme");
					CariGiris.Appearance.BackColor = Color.Wheat;
					CariGiris.Appearance.Options.UseBackColor = true;
					CariGiris.ApplyToRow = true;
					gvListe.FormatConditions.Add(CariGiris);
				}
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnEkle_Click(object sender, EventArgs e)
		{
			Kasa.frmKasaIslemDetay frmKasaIslemDetay = new frmKasaIslemDetay("-1");
			if (frmKasaIslemDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				btnGuncelle_Click(null, null);
		}
		private void btnSil_Click(object sender, EventArgs e)
		{
			try
			{
				if (gvListe.FocusedRowHandle < 0) return;
				int seciliSatirNo = gvListe.FocusedRowHandle;
				if (XtraMessageBox.Show("Seçili Kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

				using (var cmd = new SqlCommand(@"Delete From KasaIslem Where KasaIslemID=@KasaIslemID", cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@KasaIslemID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("KasaIslemID").ToString();
					cmd.ExecuteNonQuery();
				}
				dt.Clear();
				da.Fill(dt);
				gvListe.FocusedRowHandle = seciliSatirNo - 1;
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void btnDegistir_Click(object sender, EventArgs e)
		{
			Kasa.frmKasaIslemDetay frmKasaIslemDetay = new frmKasaIslemDetay(gvListe.GetFocusedRowCellDisplayText("KasaIslemID"));
			if (frmKasaIslemDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				btnGuncelle_Click(null, null);
		}
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			dt.Clear();
			da.Fill(dt);
		}
		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnExcel_Click(object sender, EventArgs e)
		{
			try
			{
				//var frmExcel = new frmExceleAktar(gcListe);
				//frmExcel.Show();
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cbtnGorunumKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				new csGridLayout(csGridLayout.enGridArayuzIslemleri.Set, this, Convert.ToInt32(csKullanici.KullaniciID), cs.csBaglanti.BaglantiGetir());

			}
			catch (Exception hata)
			{
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "Erdal Bakkal", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cbtnEkranGorunumuSifirla_Click(object sender, EventArgs e)
		{
			if (XtraMessageBox.Show("Liste Sıralaması için Öndeğerlere dönülecek. Onaylıyor musunuz?\n(Form işlem sonrasında kapatılacaktır.)", "Perakende Satış", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
				 == DialogResult.No) return;
			cs.csGridLayout.LayoutClear(Convert.ToInt32(cs.csKullanici.KullaniciID), this.Name, gvListe.Name, cs.csBaglanti.BaglantiGetir());
			this.Close();
		}

		private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListeDoldur();
		}


	}
}