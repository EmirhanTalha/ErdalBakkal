namespace proje_ErdalBakkal
{
	partial class frmKullaniciListe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciListe));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
			this.gcListe = new DevExpress.XtraGrid.GridControl();
			this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colKullaniciID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKullaniciAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKullaniciKodu = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKullaniciSifre = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtgvKullaniciSifre = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
			this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
			this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtgvKullaniciSifre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.btnGuncelle);
			this.panelControl1.Controls.Add(this.btnExcel);
			this.panelControl1.Controls.Add(this.btnKapat);
			this.panelControl1.Controls.Add(this.btnDegistir);
			this.panelControl1.Controls.Add(this.btnSil);
			this.panelControl1.Controls.Add(this.btnEkle);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelControl1.Location = new System.Drawing.Point(0, 392);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(605, 42);
			this.panelControl1.TabIndex = 0;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
			this.btnGuncelle.Location = new System.Drawing.Point(120, 4);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(40, 35);
			this.btnGuncelle.TabIndex = 3;
			this.btnGuncelle.Text = "simpleButton6";
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnExcel
			// 
			this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
			this.btnExcel.Location = new System.Drawing.Point(200, 4);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(40, 35);
			this.btnExcel.TabIndex = 5;
			this.btnExcel.Text = "simpleButton5";
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// btnKapat
			// 
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(160, 4);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(40, 35);
			this.btnKapat.TabIndex = 4;
			this.btnKapat.Text = "simpleButton4";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnDegistir
			// 
			this.btnDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.ImageOptions.Image")));
			this.btnDegistir.Location = new System.Drawing.Point(80, 4);
			this.btnDegistir.Name = "btnDegistir";
			this.btnDegistir.Size = new System.Drawing.Size(40, 35);
			this.btnDegistir.TabIndex = 2;
			this.btnDegistir.Text = "simpleButton3";
			this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
			// 
			// btnSil
			// 
			this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
			this.btnSil.Location = new System.Drawing.Point(40, 4);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(40, 35);
			this.btnSil.TabIndex = 1;
			this.btnSil.Text = "simpleButton2";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
			this.btnEkle.Location = new System.Drawing.Point(0, 4);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(40, 35);
			this.btnEkle.TabIndex = 0;
			this.btnEkle.Text = "simpleButton1";
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// gcListe
			// 
			this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcListe.Location = new System.Drawing.Point(0, 0);
			this.gcListe.MainView = this.gvListe;
			this.gcListe.Name = "gcListe";
			this.gcListe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtgvKullaniciSifre});
			this.gcListe.Size = new System.Drawing.Size(605, 392);
			this.gcListe.TabIndex = 1;
			this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe,
            this.gridView1,
            this.cardView1,
            this.bandedGridView1,
            this.winExplorerView1});
			this.gcListe.Click += new System.EventHandler(this.gridControl1_Click);
			// 
			// gvListe
			// 
			this.gvListe.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.gvListe.Appearance.FocusedRow.Options.UseBackColor = true;
			this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKullaniciID,
            this.colKullaniciAdSoyad,
            this.colKullaniciKodu,
            this.colKullaniciSifre,
            this.colAktif});
			this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gvListe.GridControl = this.gcListe;
			this.gvListe.Name = "gvListe";
			this.gvListe.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvListe.OptionsPrint.PrintHeader = false;
			this.gvListe.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvListe.OptionsView.ColumnAutoWidth = false;
			this.gvListe.OptionsView.EnableAppearanceEvenRow = true;
			this.gvListe.OptionsView.EnableAppearanceOddRow = true;
			this.gvListe.OptionsView.ShowAutoFilterRow = true;
			// 
			// colKullaniciID
			// 
			this.colKullaniciID.Caption = "Kullanıcı ID";
			this.colKullaniciID.FieldName = "KullaniciID";
			this.colKullaniciID.Name = "colKullaniciID";
			this.colKullaniciID.Visible = true;
			this.colKullaniciID.VisibleIndex = 0;
			// 
			// colKullaniciAdSoyad
			// 
			this.colKullaniciAdSoyad.Caption = "Ad Soyad";
			this.colKullaniciAdSoyad.FieldName = "KullaniciAdSoyad";
			this.colKullaniciAdSoyad.Name = "colKullaniciAdSoyad";
			this.colKullaniciAdSoyad.Visible = true;
			this.colKullaniciAdSoyad.VisibleIndex = 1;
			// 
			// colKullaniciKodu
			// 
			this.colKullaniciKodu.Caption = "Kullanıcı Kodu";
			this.colKullaniciKodu.FieldName = "KullaniciKodu";
			this.colKullaniciKodu.Name = "colKullaniciKodu";
			this.colKullaniciKodu.Visible = true;
			this.colKullaniciKodu.VisibleIndex = 2;
			// 
			// colKullaniciSifre
			// 
			this.colKullaniciSifre.Caption = "Kullanıcı Şifre";
			this.colKullaniciSifre.ColumnEdit = this.txtgvKullaniciSifre;
			this.colKullaniciSifre.FieldName = "KullaniciSifre";
			this.colKullaniciSifre.Name = "colKullaniciSifre";
			this.colKullaniciSifre.Visible = true;
			this.colKullaniciSifre.VisibleIndex = 3;
			// 
			// txtgvKullaniciSifre
			// 
			this.txtgvKullaniciSifre.AutoHeight = false;
			this.txtgvKullaniciSifre.Name = "txtgvKullaniciSifre";
			this.txtgvKullaniciSifre.PasswordChar = '*';
			// 
			// colAktif
			// 
			this.colAktif.Caption = "Aktif";
			this.colAktif.FieldName = "Aktif";
			this.colAktif.Name = "colAktif";
			this.colAktif.Visible = true;
			this.colAktif.VisibleIndex = 4;
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gcListe;
			this.gridView1.Name = "gridView1";
			// 
			// cardView1
			// 
			this.cardView1.FocusedCardTopFieldIndex = 0;
			this.cardView1.GridControl = this.gcListe;
			this.cardView1.Name = "cardView1";
			// 
			// bandedGridView1
			// 
			this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
			this.bandedGridView1.GridControl = this.gcListe;
			this.bandedGridView1.Name = "bandedGridView1";
			// 
			// gridBand1
			// 
			this.gridBand1.Caption = "gridBand1";
			this.gridBand1.Name = "gridBand1";
			this.gridBand1.VisibleIndex = 0;
			// 
			// winExplorerView1
			// 
			this.winExplorerView1.GridControl = this.gcListe;
			this.winExplorerView1.Name = "winExplorerView1";
			// 
			// frmKullaniciListe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 434);
			this.Controls.Add(this.gcListe);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmKullaniciListe";
			this.Text = "frmKullaniciListe";
			this.Load += new System.EventHandler(this.frmKullaniciListe_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtgvKullaniciSifre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraGrid.GridControl gcListe;
		private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
		private DevExpress.XtraEditors.SimpleButton btnGuncelle;
		private DevExpress.XtraEditors.SimpleButton btnExcel;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnDegistir;
		private DevExpress.XtraEditors.SimpleButton btnSil;
		private DevExpress.XtraEditors.SimpleButton btnEkle;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Views.Card.CardView cardView1;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
		private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
		private DevExpress.XtraGrid.Columns.GridColumn colKullaniciID;
		private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdSoyad;
		private DevExpress.XtraGrid.Columns.GridColumn colKullaniciKodu;
		private DevExpress.XtraGrid.Columns.GridColumn colKullaniciSifre;
		private DevExpress.XtraGrid.Columns.GridColumn colAktif;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtgvKullaniciSifre;
	}
}