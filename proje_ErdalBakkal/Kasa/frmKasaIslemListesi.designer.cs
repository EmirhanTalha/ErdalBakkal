namespace proje_ErdalBakkal.Kasa
{
  partial class frmKasaIslemListesi
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.btnRaporDizayn = new DevExpress.XtraEditors.SimpleButton();
			this.btnRaporla = new DevExpress.XtraEditors.SimpleButton();
			this.lkpKasa = new DevExpress.XtraEditors.LookUpEdit();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.deBitisTarihi = new DevExpress.XtraEditors.DateEdit();
			this.deBaslangicTarihi = new DevExpress.XtraEditors.DateEdit();
			this.btnExceleAktar = new DevExpress.XtraEditors.SimpleButton();
			this.btnSorgula = new DevExpress.XtraEditors.SimpleButton();
			this.gcListe = new DevExpress.XtraGrid.GridControl();
			this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colKasaTanim = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCariTurTanim = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCariGrupTanim = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCariKod = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCariTanim = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKasaIslem = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKasaIslemTipi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIslemTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lkpKasa.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deBitisTarihi.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deBitisTarihi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deBaslangicTarihi.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deBaslangicTarihi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.btnRaporDizayn);
			this.panelControl1.Controls.Add(this.btnRaporla);
			this.panelControl1.Controls.Add(this.lkpKasa);
			this.panelControl1.Controls.Add(this.labelControl10);
			this.panelControl1.Controls.Add(this.labelControl12);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.labelControl4);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.deBitisTarihi);
			this.panelControl1.Controls.Add(this.deBaslangicTarihi);
			this.panelControl1.Controls.Add(this.btnExceleAktar);
			this.panelControl1.Controls.Add(this.btnSorgula);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1009, 71);
			this.panelControl1.TabIndex = 0;
			// 
			// btnRaporDizayn
			// 
			this.btnRaporDizayn.Location = new System.Drawing.Point(804, 12);
			this.btnRaporDizayn.Name = "btnRaporDizayn";
			this.btnRaporDizayn.Size = new System.Drawing.Size(117, 46);
			this.btnRaporDizayn.TabIndex = 24;
			this.btnRaporDizayn.Text = "Rapor Dizayn";
			this.btnRaporDizayn.Click += new System.EventHandler(this.btnRaporDizayn_Click);
			// 
			// btnRaporla
			// 
			this.btnRaporla.Location = new System.Drawing.Point(681, 12);
			this.btnRaporla.Name = "btnRaporla";
			this.btnRaporla.Size = new System.Drawing.Size(117, 46);
			this.btnRaporla.TabIndex = 23;
			this.btnRaporla.Text = "Raporla";
			this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
			// 
			// lkpKasa
			// 
			this.lkpKasa.Location = new System.Drawing.Point(288, 15);
			this.lkpKasa.Name = "lkpKasa";
			this.lkpKasa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.lkpKasa.Properties.NullText = "";
			this.lkpKasa.Size = new System.Drawing.Size(141, 20);
			this.lkpKasa.TabIndex = 20;
			// 
			// labelControl10
			// 
			this.labelControl10.Location = new System.Drawing.Point(279, 19);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(4, 13);
			this.labelControl10.TabIndex = 22;
			this.labelControl10.Text = ":";
			// 
			// labelControl12
			// 
			this.labelControl12.Location = new System.Drawing.Point(243, 19);
			this.labelControl12.Name = "labelControl12";
			this.labelControl12.Size = new System.Drawing.Size(23, 13);
			this.labelControl12.TabIndex = 21;
			this.labelControl12.Text = "Kasa";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(96, 44);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(4, 13);
			this.labelControl3.TabIndex = 19;
			this.labelControl3.Text = ":";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(96, 19);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(4, 13);
			this.labelControl4.TabIndex = 18;
			this.labelControl4.Text = ":";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(11, 44);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(48, 13);
			this.labelControl2.TabIndex = 17;
			this.labelControl2.Text = "Bitiş Tarihi";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(11, 19);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(73, 13);
			this.labelControl1.TabIndex = 16;
			this.labelControl1.Text = "Başlangıç Tarihi";
			// 
			// deBitisTarihi
			// 
			this.deBitisTarihi.EditValue = null;
			this.deBitisTarihi.Location = new System.Drawing.Point(107, 41);
			this.deBitisTarihi.Name = "deBitisTarihi";
			this.deBitisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deBitisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.deBitisTarihi.Size = new System.Drawing.Size(100, 20);
			this.deBitisTarihi.TabIndex = 15;
			// 
			// deBaslangicTarihi
			// 
			this.deBaslangicTarihi.EditValue = null;
			this.deBaslangicTarihi.Location = new System.Drawing.Point(107, 15);
			this.deBaslangicTarihi.Name = "deBaslangicTarihi";
			this.deBaslangicTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deBaslangicTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.deBaslangicTarihi.Size = new System.Drawing.Size(100, 20);
			this.deBaslangicTarihi.TabIndex = 14;
			// 
			// btnExceleAktar
			// 
			this.btnExceleAktar.Location = new System.Drawing.Point(558, 12);
			this.btnExceleAktar.Name = "btnExceleAktar";
			this.btnExceleAktar.Size = new System.Drawing.Size(117, 46);
			this.btnExceleAktar.TabIndex = 9;
			this.btnExceleAktar.Text = "Excel e Aktar";
			this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
			// 
			// btnSorgula
			// 
			this.btnSorgula.Location = new System.Drawing.Point(435, 12);
			this.btnSorgula.Name = "btnSorgula";
			this.btnSorgula.Size = new System.Drawing.Size(117, 46);
			this.btnSorgula.TabIndex = 8;
			this.btnSorgula.Text = "Sorgula";
			this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
			// 
			// gcListe
			// 
			this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcListe.Location = new System.Drawing.Point(0, 71);
			this.gcListe.MainView = this.gvListe;
			this.gcListe.Name = "gcListe";
			this.gcListe.Size = new System.Drawing.Size(1009, 373);
			this.gcListe.TabIndex = 1;
			this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
			// 
			// gvListe
			// 
			this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIslemTarihi,
            this.colKasaTanim,
            this.colCariTurTanim,
            this.colCariGrupTanim,
            this.colCariKod,
            this.colCariTanim,
            this.colKasaIslem,
            this.colGenelToplam,
            this.colKasaIslemTipi});
			this.gvListe.GridControl = this.gcListe;
			this.gvListe.Name = "gvListe";
			this.gvListe.OptionsView.ShowFooter = true;
			// 
			// colKasaTanim
			// 
			this.colKasaTanim.Caption = "Kasa Tanım";
			this.colKasaTanim.FieldName = "KasaTanim";
			this.colKasaTanim.Name = "colKasaTanim";
			this.colKasaTanim.Visible = true;
			this.colKasaTanim.VisibleIndex = 1;
			// 
			// colCariTurTanim
			// 
			this.colCariTurTanim.Caption = "Cari Tür";
			this.colCariTurTanim.FieldName = "CariTurTanim";
			this.colCariTurTanim.Name = "colCariTurTanim";
			this.colCariTurTanim.Visible = true;
			this.colCariTurTanim.VisibleIndex = 2;
			// 
			// colCariGrupTanim
			// 
			this.colCariGrupTanim.Caption = "Cari Grup";
			this.colCariGrupTanim.FieldName = "CariGrupTanim";
			this.colCariGrupTanim.Name = "colCariGrupTanim";
			this.colCariGrupTanim.Visible = true;
			this.colCariGrupTanim.VisibleIndex = 3;
			// 
			// colCariKod
			// 
			this.colCariKod.Caption = "Cari Kod";
			this.colCariKod.FieldName = "CariKod";
			this.colCariKod.Name = "colCariKod";
			this.colCariKod.Visible = true;
			this.colCariKod.VisibleIndex = 4;
			// 
			// colCariTanim
			// 
			this.colCariTanim.Caption = "Cari Tanım";
			this.colCariTanim.FieldName = "CariTanim";
			this.colCariTanim.Name = "colCariTanim";
			this.colCariTanim.Visible = true;
			this.colCariTanim.VisibleIndex = 5;
			// 
			// colKasaIslem
			// 
			this.colKasaIslem.Caption = "Kasa İşlem";
			this.colKasaIslem.FieldName = "KasaIslem";
			this.colKasaIslem.Name = "colKasaIslem";
			this.colKasaIslem.Visible = true;
			this.colKasaIslem.VisibleIndex = 6;
			// 
			// colGenelToplam
			// 
			this.colGenelToplam.Caption = "Genel Toplam";
			this.colGenelToplam.FieldName = "GenelToplam";
			this.colGenelToplam.Name = "colGenelToplam";
			this.colGenelToplam.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GenelToplam", "{0:0.##}")});
			this.colGenelToplam.Visible = true;
			this.colGenelToplam.VisibleIndex = 7;
			// 
			// colKasaIslemTipi
			// 
			this.colKasaIslemTipi.Caption = "Kasa İşlem";
			this.colKasaIslemTipi.FieldName = "KasaIslemTipi";
			this.colKasaIslemTipi.Name = "colKasaIslemTipi";
			// 
			// colIslemTarihi
			// 
			this.colIslemTarihi.Caption = "İşlem Tarihi";
			this.colIslemTarihi.FieldName = "IslemTarihi";
			this.colIslemTarihi.Name = "colIslemTarihi";
			this.colIslemTarihi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IslemTarihi", "{0}")});
			this.colIslemTarihi.Visible = true;
			this.colIslemTarihi.VisibleIndex = 0;
			// 
			// frmKasaIslemListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1009, 444);
			this.Controls.Add(this.gcListe);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmKasaIslemListesi";
			this.Text = "Kasa İşlem Listesi";
			this.Load += new System.EventHandler(this.frmKasaIslemListesi_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lkpKasa.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deBitisTarihi.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deBitisTarihi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deBaslangicTarihi.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deBaslangicTarihi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraGrid.GridControl gcListe;
    private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
    private DevExpress.XtraEditors.SimpleButton btnExceleAktar;
    private DevExpress.XtraEditors.SimpleButton btnSorgula;
    private DevExpress.XtraEditors.LookUpEdit lkpKasa;
    private DevExpress.XtraEditors.LabelControl labelControl10;
    private DevExpress.XtraEditors.LabelControl labelControl12;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.DateEdit deBitisTarihi;
    private DevExpress.XtraEditors.DateEdit deBaslangicTarihi;
    private DevExpress.XtraEditors.SimpleButton btnRaporla;
    private DevExpress.XtraEditors.SimpleButton btnRaporDizayn;
		private DevExpress.XtraGrid.Columns.GridColumn colKasaTanim;
		private DevExpress.XtraGrid.Columns.GridColumn colCariTurTanim;
		private DevExpress.XtraGrid.Columns.GridColumn colCariGrupTanim;
		private DevExpress.XtraGrid.Columns.GridColumn colCariKod;
		private DevExpress.XtraGrid.Columns.GridColumn colCariTanim;
		private DevExpress.XtraGrid.Columns.GridColumn colKasaIslem;
		private DevExpress.XtraGrid.Columns.GridColumn colGenelToplam;
		private DevExpress.XtraGrid.Columns.GridColumn colKasaIslemTipi;
		private DevExpress.XtraGrid.Columns.GridColumn colIslemTarihi;
	}
}