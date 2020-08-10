namespace proje_ErdalBakkal.Cari
{
	partial class frmCariListe
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
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			this.cbtnGorunumKaydet = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.cbtnGuncelle = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.cbtnIncele = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cbtnDegistir = new System.Windows.Forms.ToolStripMenuItem();
			this.cbtnSil = new System.Windows.Forms.ToolStripMenuItem();
			this.cbtnEkranGorunumuSifirla = new System.Windows.Forms.ToolStripMenuItem();
			this.cbtnEkle = new System.Windows.Forms.ToolStripMenuItem();
			this.gcListe = new DevExpress.XtraGrid.GridControl();
			this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.cmbDurum = new DevExpress.XtraEditors.ComboBoxEdit();
			this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
			this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
			this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
			this.cmsMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbDurum.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSil
			// 
			this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSil.Location = new System.Drawing.Point(85, 2);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(80, 27);
			this.btnSil.TabIndex = 1;
			this.btnSil.Text = "Sil";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// cbtnGorunumKaydet
			// 
			this.cbtnGorunumKaydet.Name = "cbtnGorunumKaydet";
			this.cbtnGorunumKaydet.Size = new System.Drawing.Size(203, 22);
			this.cbtnGorunumKaydet.Text = "Ekran Görünümü Kaydet";
			this.cbtnGorunumKaydet.Click += new System.EventHandler(this.cbtnGorunumKaydet_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
			// 
			// cbtnGuncelle
			// 
			this.cbtnGuncelle.Name = "cbtnGuncelle";
			this.cbtnGuncelle.Size = new System.Drawing.Size(203, 22);
			this.cbtnGuncelle.Text = "Güncelle";
			this.cbtnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
			// 
			// cbtnIncele
			// 
			this.cbtnIncele.Name = "cbtnIncele";
			this.cbtnIncele.Size = new System.Drawing.Size(203, 22);
			this.cbtnIncele.Text = "İncele";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
			// 
			// cbtnDegistir
			// 
			this.cbtnDegistir.Name = "cbtnDegistir";
			this.cbtnDegistir.Size = new System.Drawing.Size(203, 22);
			this.cbtnDegistir.Text = "Değiştir";
			this.cbtnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
			// 
			// cbtnSil
			// 
			this.cbtnSil.Name = "cbtnSil";
			this.cbtnSil.Size = new System.Drawing.Size(203, 22);
			this.cbtnSil.Text = "Sil";
			this.cbtnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// cbtnEkranGorunumuSifirla
			// 
			this.cbtnEkranGorunumuSifirla.Name = "cbtnEkranGorunumuSifirla";
			this.cbtnEkranGorunumuSifirla.Size = new System.Drawing.Size(203, 22);
			this.cbtnEkranGorunumuSifirla.Text = "Ekran Görünümü Sıfırla";
			this.cbtnEkranGorunumuSifirla.Click += new System.EventHandler(this.cbtnEkranGorunumuSifirla_Click);
			// 
			// cbtnEkle
			// 
			this.cbtnEkle.Name = "cbtnEkle";
			this.cbtnEkle.Size = new System.Drawing.Size(203, 22);
			this.cbtnEkle.Text = "Ekle";
			this.cbtnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// gcListe
			// 
			this.gcListe.ContextMenuStrip = this.cmsMenu;
			this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcListe.Location = new System.Drawing.Point(0, 31);
			this.gcListe.MainView = this.gvListe;
			this.gcListe.Name = "gcListe";
			this.gcListe.Size = new System.Drawing.Size(804, 447);
			this.gcListe.TabIndex = 7;
			this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
			// 
			// cmsMenu
			// 
			this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnEkle,
            this.cbtnSil,
            this.cbtnDegistir,
            this.toolStripSeparator1,
            this.cbtnIncele,
            this.toolStripMenuItem1,
            this.cbtnGuncelle,
            this.toolStripMenuItem2,
            this.cbtnGorunumKaydet,
            this.cbtnEkranGorunumuSifirla});
			this.cmsMenu.Name = "contextMenuStrip1";
			this.cmsMenu.Size = new System.Drawing.Size(204, 176);
			// 
			// gvListe
			// 
			this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gvListe.GridControl = this.gcListe;
			this.gvListe.Name = "gvListe";
			this.gvListe.OptionsBehavior.Editable = false;
			this.gvListe.OptionsPrint.AutoWidth = false;
			this.gvListe.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvListe.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.gvListe.OptionsView.ColumnAutoWidth = false;
			this.gvListe.OptionsView.EnableAppearanceEvenRow = true;
			this.gvListe.OptionsView.EnableAppearanceOddRow = true;
			this.gvListe.OptionsView.ShowAutoFilterRow = true;
			this.gvListe.OptionsView.ShowFooter = true;
			this.gvListe.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
			this.gvListe.DoubleClick += new System.EventHandler(this.gvListe_DoubleClick);
			// 
			// cmbDurum
			// 
			this.cmbDurum.EditValue = "Aktif Cari Listesi";
			this.cmbDurum.Location = new System.Drawing.Point(532, 5);
			this.cmbDurum.Name = "cmbDurum";
			this.cmbDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbDurum.Properties.Items.AddRange(new object[] {
            "Pasif Cari Listesi",
            "Aktif Cari Listesi",
            "Tüm Carilerin Listele"});
			this.cmbDurum.Size = new System.Drawing.Size(160, 20);
			this.cmbDurum.TabIndex = 14;
			this.cmbDurum.SelectedIndexChanged += new System.EventHandler(this.cmbEgitim_SelectedIndexChanged);
			// 
			// btnEkle
			// 
			this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEkle.Location = new System.Drawing.Point(5, 2);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(80, 27);
			this.btnEkle.TabIndex = 0;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnExcel
			// 
			this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcel.Location = new System.Drawing.Point(405, 2);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(100, 27);
			this.btnExcel.TabIndex = 5;
			this.btnExcel.Text = "Excel e Aktar";
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuncelle.Location = new System.Drawing.Point(245, 2);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(80, 27);
			this.btnGuncelle.TabIndex = 3;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnKapat
			// 
			this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKapat.Location = new System.Drawing.Point(325, 2);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(80, 27);
			this.btnKapat.TabIndex = 4;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnDegistir
			// 
			this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDegistir.Location = new System.Drawing.Point(165, 2);
			this.btnDegistir.Name = "btnDegistir";
			this.btnDegistir.Size = new System.Drawing.Size(80, 27);
			this.btnDegistir.TabIndex = 2;
			this.btnDegistir.Text = "Değiştir";
			this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
			// 
			// panelControl2
			// 
			this.panelControl2.Controls.Add(this.cmbDurum);
			this.panelControl2.Controls.Add(this.btnEkle);
			this.panelControl2.Controls.Add(this.btnExcel);
			this.panelControl2.Controls.Add(this.btnGuncelle);
			this.panelControl2.Controls.Add(this.btnKapat);
			this.panelControl2.Controls.Add(this.btnSil);
			this.panelControl2.Controls.Add(this.btnDegistir);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl2.Location = new System.Drawing.Point(0, 0);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(804, 31);
			this.panelControl2.TabIndex = 6;
			// 
			// frmCariListe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 478);
			this.Controls.Add(this.gcListe);
			this.Controls.Add(this.panelControl2);
			this.Name = "frmCariListe";
			this.Text = "frmCariListe";
			this.Load += new System.EventHandler(this.frmCariListe_Load);
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
			this.cmsMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbDurum.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnSil;
		private System.Windows.Forms.ToolStripMenuItem cbtnGorunumKaydet;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem cbtnGuncelle;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cbtnIncele;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cbtnDegistir;
		private System.Windows.Forms.ToolStripMenuItem cbtnSil;
		private System.Windows.Forms.ToolStripMenuItem cbtnEkranGorunumuSifirla;
		private System.Windows.Forms.ToolStripMenuItem cbtnEkle;
		private DevExpress.XtraGrid.GridControl gcListe;
		private System.Windows.Forms.ContextMenuStrip cmsMenu;
		private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
		private DevExpress.XtraEditors.ComboBoxEdit cmbDurum;
		private DevExpress.XtraEditors.SimpleButton btnEkle;
		private DevExpress.XtraEditors.SimpleButton btnExcel;
		private DevExpress.XtraEditors.SimpleButton btnGuncelle;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnDegistir;
		private DevExpress.XtraEditors.PanelControl panelControl2;
	}
}