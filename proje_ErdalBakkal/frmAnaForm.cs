using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace proje_ErdalBakkal
{
	public partial class frmAnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public frmAnaForm()
		{
			InitializeComponent();
		}
		public void FormuAc(Form GelenForm)
		{
			try
			{
				bool Durum = false;
				foreach (var item in this.MdiChildren)
				{
					if (item.Name == GelenForm.Name)
					{
						Durum = true;
						item.Activate();
					}
				}
				if (Durum == false)
				{
					GelenForm.MdiParent = this;
					GelenForm.Show();
				}
			}
			catch (Exception hata)
			{
				XtraMessageBox.Show("Hata Kodu : " + hata.Message + "\nHata Açıklama: " + hata.StackTrace, "input teknoloji a.ş.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void frmAnaForm_Load(object sender, EventArgs e)
		{
			lblGirisYapanKullanici.Caption = "Kullanıcı: " + cs.csKullanici.KullaniciAdSoyad + " | Veritabanı: " + cs.csBaglanti.BaglantiGetir().DataSource + "\\" + cs.csBaglanti.BaglantiGetir().Database;
		}

		private void btnKullaniciListe_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmKullaniciListe frmKullaniciListe = new frmKullaniciListe();
			FormuAc(frmKullaniciListe);
		}

		private void mbtnStokListe_ItemClick(object sender, ItemClickEventArgs e)
		{
			stok.frmStokListe frmStokListe = new stok.frmStokListe();
			FormuAc(frmStokListe);
		}

		private void mbtnCariListe_ItemClick(object sender, ItemClickEventArgs e)
		{
			Cari.frmCariListe frmCariListe = new Cari.frmCariListe();
			FormuAc(frmCariListe);
		}

		private void btnKasadaNakitOdemeTahsilat_ItemClick(object sender, ItemClickEventArgs e)
		{
			Kasa.frmKasaNakitOdemeTahsilatListe frmKasaNakitOdemeTahsilatListe = new Kasa.frmKasaNakitOdemeTahsilatListe();
			FormuAc(frmKasaNakitOdemeTahsilatListe);
		}

		private void btnKasaIslemRapor_ItemClick(object sender, ItemClickEventArgs e)
		{
			Kasa.frmKasaIslemListesi frmKasaIslemListesi = new Kasa.frmKasaIslemListesi();
			FormuAc(frmKasaIslemListesi);
		}

		private void btnHizliSatis_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmHizliSatis frmHizliSatis = new frmHizliSatis();
			frmHizliSatis.ShowDialog();
		}
	}
}