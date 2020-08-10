using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using proje_ErdalBakkal.cs;
using DevExpress.XtraGrid;
using System.Data.SqlClient;

namespace proje_ErdalBakkal.Cari
{
	public partial class frmCariListe : DevExpress.XtraEditors.XtraForm
	{
		public frmCariListe()
		{
			InitializeComponent();
		}
		SqlTransaction trGenel;
		enum enGridArayuzIslemleri { Set, Get };
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();

		void ListeDoldur()
		{
			try
			{
				string sqlWhere = "";

				if (cmbDurum.SelectedIndex != 2)
					sqlWhere = " WHERE (dbo.Cari.Aktif = " + cmbDurum.SelectedIndex.ToString() + ")";

				using (da.SelectCommand = new SqlCommand(@"
SELECT     dbo.Cari.CariID, dbo.CariTur.CariTurTanim, dbo.CariGrup.CariGrupTanim, dbo.Cari.CariKod, dbo.Cari.CariTanim, dbo.OzelKod.OzelKodTanim, dbo.Cari.Yetkili, 
                      dbo.Cari.EMailAdres, dbo.Cari.Adres, dbo.Cari.VergiDairesi, dbo.Cari.VergiNumarasi, dbo.Cari.TelefonNo, dbo.Cari.FaksNo, dbo.Cari.Aktif
FROM         dbo.Cari LEFT OUTER JOIN
                      dbo.Proje ON dbo.Cari.ProjeID = dbo.Proje.ProjeID LEFT OUTER JOIN
                      dbo.OzelKod ON dbo.Cari.OzelKodID = dbo.OzelKod.OzelKodID LEFT OUTER JOIN
                      dbo.CariGrup ON dbo.Cari.CariGrupID = dbo.CariGrup.CariGrupID LEFT OUTER JOIN
                      dbo.CariTur ON dbo.Cari.CariTurID = dbo.CariTur.CariTurID
                      " + sqlWhere, cs.csBaglanti.BaglantiGetir()))
				{
					dt.Clear();
					da.Fill(dt);
					gcListe.DataSource = dt;
				}

				if (cmbDurum.SelectedIndex == 1)
				{
					gvListe.FormatConditions.Clear();
				}
				else
				{
					gvListe.FormatConditions.Clear();
					StyleFormatCondition CariGiris = new StyleFormatCondition(FormatConditionEnum.Equal, gvListe.Columns["Aktif"], "Aktif", "Aktif");
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
		private void frmCariListe_Load(object sender, EventArgs e)
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

		private void btnEkle_Click(object sender, EventArgs e)
		{
			Cari.frmCariDetay frmCariDetay = new frmCariDetay("-1");
			if (frmCariDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				btnGuncelle_Click(null, null);
		}
		private void btnSil_Click(object sender, EventArgs e)
		{
			try
			{
				if (gvListe.FocusedRowHandle < 0) return;

				int seciliSatirNo = gvListe.FocusedRowHandle;

				#region Kullanılıp Kullanılmadığının kontrolü yapılıyor.
				int satirSayisi = 0;
				using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) as SatirSayisi FROM FisBaslik WHERE (CariID = @CariID  )", cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("CariID").ToString();
					using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
						if (dr.Read())
							satirSayisi = (int)dr["SatirSayisi"];
				}

				if (satirSayisi > 0)
				{
					XtraMessageBox.Show("Kayıt, daha önceden kullanılmış.\n\nSeçili Kayıt Silinemez.", "Perakende Satış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				#endregion

				if (XtraMessageBox.Show("Seçili Kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

				using (var cmd = new SqlCommand(@"Delete From Cari Where CariID=@CariID", cs.csBaglanti.BaglantiGetir()))
				{
					cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellValue("CariID").ToString();
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
			Cari.frmCariDetay frmCariDetay = new frmCariDetay(gvListe.GetFocusedRowCellDisplayText("CariID"));
			if (frmCariDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
		private void cmbEgitim_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListeDoldur();
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
		private void gvListe_DoubleClick(object sender, EventArgs e)
		{
			if (gvListe.FocusedRowHandle > 0)
				if (btnDegistir.Enabled) btnDegistir_Click(null, null);
		}
	}
}