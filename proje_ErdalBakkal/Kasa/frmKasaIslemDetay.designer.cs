namespace proje_ErdalBakkal.Kasa
{
  partial class frmKasaIslemDetay
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
			this.lkpCari = new DevExpress.XtraEditors.LookUpEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
			this.lkpKasa = new DevExpress.XtraEditors.LookUpEdit();
			this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.cmbKasaIslemTipi = new DevExpress.XtraEditors.ComboBoxEdit();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
			this.txtGenelToplam = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.deIslemTarihi = new DevExpress.XtraEditors.DateEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lkpCari.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lkpKasa.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbKasaIslemTipi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtGenelToplam.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deIslemTarihi.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deIslemTarihi.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.lkpCari);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl19);
			this.panelControl1.Controls.Add(this.lkpKasa);
			this.panelControl1.Controls.Add(this.labelControl20);
			this.panelControl1.Controls.Add(this.labelControl10);
			this.panelControl1.Controls.Add(this.labelControl12);
			this.panelControl1.Controls.Add(this.cmbKasaIslemTipi);
			this.panelControl1.Location = new System.Drawing.Point(9, 9);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(332, 92);
			this.panelControl1.TabIndex = 0;
			// 
			// lkpCari
			// 
			this.lkpCari.Enabled = false;
			this.lkpCari.Location = new System.Drawing.Point(90, 63);
			this.lkpCari.Name = "lkpCari";
			this.lkpCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lkpCari.Properties.NullText = "";
			this.lkpCari.Size = new System.Drawing.Size(139, 20);
			this.lkpCari.TabIndex = 2;
			this.lkpCari.Enter += new System.EventHandler(this.AktifTextBackColorChange);
			this.lkpCari.Leave += new System.EventHandler(this.PasifTextBackColorChange);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(81, 67);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(4, 13);
			this.labelControl1.TabIndex = 19;
			this.labelControl1.Text = ":";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(13, 67);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(19, 13);
			this.labelControl2.TabIndex = 18;
			this.labelControl2.Text = "Cari";
			// 
			// labelControl19
			// 
			this.labelControl19.Location = new System.Drawing.Point(81, 41);
			this.labelControl19.Name = "labelControl19";
			this.labelControl19.Size = new System.Drawing.Size(4, 13);
			this.labelControl19.TabIndex = 44;
			this.labelControl19.Text = ":";
			// 
			// lkpKasa
			// 
			this.lkpKasa.Location = new System.Drawing.Point(90, 11);
			this.lkpKasa.Name = "lkpKasa";
			this.lkpKasa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lkpKasa.Properties.NullText = "";
			this.lkpKasa.Size = new System.Drawing.Size(139, 20);
			this.lkpKasa.TabIndex = 0;
			this.lkpKasa.Enter += new System.EventHandler(this.AktifTextBackColorChange);
			this.lkpKasa.Leave += new System.EventHandler(this.PasifTextBackColorChange);
			// 
			// labelControl20
			// 
			this.labelControl20.Location = new System.Drawing.Point(13, 41);
			this.labelControl20.Name = "labelControl20";
			this.labelControl20.Size = new System.Drawing.Size(50, 13);
			this.labelControl20.TabIndex = 43;
			this.labelControl20.Text = "İşlem Türü";
			// 
			// labelControl10
			// 
			this.labelControl10.Location = new System.Drawing.Point(81, 15);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(4, 13);
			this.labelControl10.TabIndex = 16;
			this.labelControl10.Text = ":";
			// 
			// labelControl12
			// 
			this.labelControl12.Location = new System.Drawing.Point(13, 15);
			this.labelControl12.Name = "labelControl12";
			this.labelControl12.Size = new System.Drawing.Size(58, 13);
			this.labelControl12.TabIndex = 15;
			this.labelControl12.Text = "İşlem Kasası";
			// 
			// cmbKasaIslemTipi
			// 
			this.cmbKasaIslemTipi.EditValue = "1: Kasadan Alınan Hizmet Faturası";
			this.cmbKasaIslemTipi.Location = new System.Drawing.Point(90, 37);
			this.cmbKasaIslemTipi.Name = "cmbKasaIslemTipi";
			this.cmbKasaIslemTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbKasaIslemTipi.Properties.Items.AddRange(new object[] {
            "1: Kasadan Alınan Hizmet Faturası",
            "2: Kasadan Satış Faturası",
            "3: Kasadan Nakit Tahsilat",
            "4: Kasadan Nakit Ödeme"});
			this.cmbKasaIslemTipi.Size = new System.Drawing.Size(216, 20);
			this.cmbKasaIslemTipi.TabIndex = 1;
			this.cmbKasaIslemTipi.SelectedIndexChanged += new System.EventHandler(this.cmbKasaIslemTipi_SelectedIndexChanged);
			this.cmbKasaIslemTipi.Enter += new System.EventHandler(this.AktifTextBackColorChange);
			this.cmbKasaIslemTipi.Leave += new System.EventHandler(this.PasifTextBackColorChange);
			// 
			// panelControl2
			// 
			this.panelControl2.Controls.Add(this.labelControl25);
			this.panelControl2.Controls.Add(this.labelControl26);
			this.panelControl2.Controls.Add(this.txtGenelToplam);
			this.panelControl2.Controls.Add(this.labelControl3);
			this.panelControl2.Controls.Add(this.deIslemTarihi);
			this.panelControl2.Controls.Add(this.labelControl4);
			this.panelControl2.Location = new System.Drawing.Point(9, 107);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(332, 89);
			this.panelControl2.TabIndex = 1;
			// 
			// labelControl25
			// 
			this.labelControl25.Location = new System.Drawing.Point(81, 38);
			this.labelControl25.Name = "labelControl25";
			this.labelControl25.Size = new System.Drawing.Size(4, 13);
			this.labelControl25.TabIndex = 46;
			this.labelControl25.Text = ":";
			// 
			// labelControl26
			// 
			this.labelControl26.Location = new System.Drawing.Point(13, 38);
			this.labelControl26.Name = "labelControl26";
			this.labelControl26.Size = new System.Drawing.Size(64, 13);
			this.labelControl26.TabIndex = 45;
			this.labelControl26.Text = "Genel Toplam";
			// 
			// txtGenelToplam
			// 
			this.txtGenelToplam.Location = new System.Drawing.Point(90, 34);
			this.txtGenelToplam.Name = "txtGenelToplam";
			this.txtGenelToplam.Properties.Appearance.Options.UseTextOptions = true;
			this.txtGenelToplam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtGenelToplam.Size = new System.Drawing.Size(96, 20);
			this.txtGenelToplam.TabIndex = 1;
			this.txtGenelToplam.Enter += new System.EventHandler(this.AktifTextBackColorChange);
			this.txtGenelToplam.Leave += new System.EventHandler(this.PasifTextBackColorChange);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(81, 12);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(4, 13);
			this.labelControl3.TabIndex = 22;
			this.labelControl3.Text = ":";
			// 
			// deIslemTarihi
			// 
			this.deIslemTarihi.EditValue = null;
			this.deIslemTarihi.Location = new System.Drawing.Point(90, 8);
			this.deIslemTarihi.Name = "deIslemTarihi";
			this.deIslemTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deIslemTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.deIslemTarihi.Properties.Mask.EditMask = "";
			this.deIslemTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
			this.deIslemTarihi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.deIslemTarihi.Size = new System.Drawing.Size(96, 20);
			this.deIslemTarihi.TabIndex = 0;
			this.deIslemTarihi.Enter += new System.EventHandler(this.AktifTextBackColorChange);
			this.deIslemTarihi.Leave += new System.EventHandler(this.PasifTextBackColorChange);
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(13, 12);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(54, 13);
			this.labelControl4.TabIndex = 21;
			this.labelControl4.Text = "İşlem Tarihi";
			// 
			// btnKaydet
			// 
			this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKaydet.Location = new System.Drawing.Point(261, 202);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(80, 25);
			this.btnKaydet.TabIndex = 2;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// frmKasaIslemDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 236);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.panelControl2);
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmKasaIslemDetay";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kasa İşlem Detay";
			this.Load += new System.EventHandler(this.frmKasaIslemDetay_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lkpCari.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lkpKasa.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbKasaIslemTipi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.panelControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtGenelToplam.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deIslemTarihi.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deIslemTarihi.Properties)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.LookUpEdit lkpCari;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.LookUpEdit lkpKasa;
    private DevExpress.XtraEditors.LabelControl labelControl10;
    private DevExpress.XtraEditors.LabelControl labelControl12;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.DateEdit deIslemTarihi;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.LabelControl labelControl25;
    private DevExpress.XtraEditors.LabelControl labelControl26;
    private DevExpress.XtraEditors.TextEdit txtGenelToplam;
    private DevExpress.XtraEditors.LabelControl labelControl19;
    private DevExpress.XtraEditors.LabelControl labelControl20;
    private DevExpress.XtraEditors.ComboBoxEdit cmbKasaIslemTipi;
    private DevExpress.XtraEditors.SimpleButton btnKaydet;
  }
}