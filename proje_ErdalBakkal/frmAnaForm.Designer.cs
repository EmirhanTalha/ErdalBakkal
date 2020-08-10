namespace proje_ErdalBakkal
{
	partial class frmAnaForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
			this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnKullaniciListe = new DevExpress.XtraBars.BarButtonItem();
			this.lblGirisYapanKullanici = new DevExpress.XtraBars.BarStaticItem();
			this.mbtnStokListe = new DevExpress.XtraBars.BarButtonItem();
			this.mbtnCariListe = new DevExpress.XtraBars.BarButtonItem();
			this.btnKasadanNakitOdemeTahsilat = new DevExpress.XtraBars.BarButtonItem();
			this.btnKasaIslemRapor = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.btnHizliSatis = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbon
			// 
			this.ribbon.ExpandCollapseItem.Id = 0;
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnKullaniciListe,
            this.lblGirisYapanKullanici,
            this.mbtnStokListe,
            this.mbtnCariListe,
            this.btnKasadanNakitOdemeTahsilat,
            this.btnKasaIslemRapor,
            this.btnHizliSatis});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.MaxItemId = 9;
			this.ribbon.Name = "ribbon";
			this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
			this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
			this.ribbon.Size = new System.Drawing.Size(948, 143);
			this.ribbon.StatusBar = this.ribbonStatusBar;
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "barButtonItem1";
			this.barButtonItem1.Id = 1;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// btnKullaniciListe
			// 
			this.btnKullaniciListe.Caption = "Kullanıcı Liste";
			this.btnKullaniciListe.Id = 2;
			this.btnKullaniciListe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciListe.ImageOptions.Image")));
			this.btnKullaniciListe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullaniciListe.ImageOptions.LargeImage")));
			this.btnKullaniciListe.LargeWidth = 100;
			this.btnKullaniciListe.Name = "btnKullaniciListe";
			this.btnKullaniciListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.btnKullaniciListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciListe_ItemClick);
			// 
			// lblGirisYapanKullanici
			// 
			this.lblGirisYapanKullanici.Caption = "...";
			this.lblGirisYapanKullanici.Id = 3;
			this.lblGirisYapanKullanici.Name = "lblGirisYapanKullanici";
			// 
			// mbtnStokListe
			// 
			this.mbtnStokListe.Caption = "Stok Liste";
			this.mbtnStokListe.Id = 4;
			this.mbtnStokListe.Name = "mbtnStokListe";
			this.mbtnStokListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbtnStokListe_ItemClick);
			// 
			// mbtnCariListe
			// 
			this.mbtnCariListe.Caption = "Cari Liste";
			this.mbtnCariListe.Id = 5;
			this.mbtnCariListe.LargeWidth = 100;
			this.mbtnCariListe.Name = "mbtnCariListe";
			this.mbtnCariListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.mbtnCariListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mbtnCariListe_ItemClick);
			// 
			// btnKasadanNakitOdemeTahsilat
			// 
			this.btnKasadanNakitOdemeTahsilat.Caption = "Kasadan Nakit Ödeme/Tahsilat";
			this.btnKasadanNakitOdemeTahsilat.Id = 6;
			this.btnKasadanNakitOdemeTahsilat.LargeWidth = 100;
			this.btnKasadanNakitOdemeTahsilat.Name = "btnKasadanNakitOdemeTahsilat";
			this.btnKasadanNakitOdemeTahsilat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.btnKasadanNakitOdemeTahsilat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKasadaNakitOdemeTahsilat_ItemClick);
			// 
			// btnKasaIslemRapor
			// 
			this.btnKasaIslemRapor.Caption = "Kasa İşlem Rapor";
			this.btnKasaIslemRapor.Id = 7;
			this.btnKasaIslemRapor.LargeWidth = 100;
			this.btnKasaIslemRapor.Name = "btnKasaIslemRapor";
			this.btnKasaIslemRapor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.btnKasaIslemRapor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKasaIslemRapor_ItemClick);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Tanımlamalar";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.btnKullaniciListe);
			this.ribbonPageGroup1.ItemLinks.Add(this.mbtnStokListe);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.ShowCaptionButton = false;
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			this.ribbonPageGroup4.Text = "ribbonPageGroup4";
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "Cari";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.mbtnCariListe);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "ribbonPageGroup2";
			// 
			// ribbonPage3
			// 
			this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
			this.ribbonPage3.Name = "ribbonPage3";
			this.ribbonPage3.Text = "Kasa İşlemleri";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.btnKasadanNakitOdemeTahsilat);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "ribbonPageGroup3";
			// 
			// ribbonPageGroup5
			// 
			this.ribbonPageGroup5.ItemLinks.Add(this.btnKasaIslemRapor);
			this.ribbonPageGroup5.Name = "ribbonPageGroup5";
			this.ribbonPageGroup5.Text = "ribbonPageGroup5";
			// 
			// ribbonStatusBar
			// 
			this.ribbonStatusBar.ItemLinks.Add(this.lblGirisYapanKullanici);
			this.ribbonStatusBar.Location = new System.Drawing.Point(0, 397);
			this.ribbonStatusBar.Name = "ribbonStatusBar";
			this.ribbonStatusBar.Ribbon = this.ribbon;
			this.ribbonStatusBar.Size = new System.Drawing.Size(948, 31);
			// 
			// xtraTabbedMdiManager1
			// 
			this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
			this.xtraTabbedMdiManager1.MdiParent = this;
			this.xtraTabbedMdiManager1.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
			// 
			// ribbonPage4
			// 
			this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
			this.ribbonPage4.Name = "ribbonPage4";
			this.ribbonPage4.Text = "ribbonPage4";
			// 
			// ribbonPageGroup6
			// 
			this.ribbonPageGroup6.ItemLinks.Add(this.btnHizliSatis);
			this.ribbonPageGroup6.Name = "ribbonPageGroup6";
			this.ribbonPageGroup6.Text = "ribbonPageGroup6";
			// 
			// btnHizliSatis
			// 
			this.btnHizliSatis.Caption = "Hızlı satış";
			this.btnHizliSatis.Id = 8;
			this.btnHizliSatis.LargeWidth = 100;
			this.btnHizliSatis.Name = "btnHizliSatis";
			this.btnHizliSatis.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			this.btnHizliSatis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHizliSatis_ItemClick);
			// 
			// frmAnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 428);
			this.Controls.Add(this.ribbonStatusBar);
			this.Controls.Add(this.ribbon);
			this.IsMdiContainer = true;
			this.Name = "frmAnaForm";
			this.Ribbon = this.ribbon;
			this.StatusBar = this.ribbonStatusBar;
			this.Text = "frmAnaForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmAnaForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem btnKullaniciListe;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.BarStaticItem lblGirisYapanKullanici;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
		private DevExpress.XtraBars.BarButtonItem mbtnStokListe;
		private DevExpress.XtraBars.BarButtonItem mbtnCariListe;
		private DevExpress.XtraBars.BarButtonItem btnKasadanNakitOdemeTahsilat;
		private DevExpress.XtraBars.BarButtonItem btnKasaIslemRapor;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private DevExpress.XtraBars.BarButtonItem btnHizliSatis;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
	}
}