namespace proje_ErdalBakkal.Tanimlamalar
{
  partial class frmStokBirim
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
      this.txtStokBirimTanim = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
      this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
      this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
      this.btnSil = new DevExpress.XtraEditors.SimpleButton();
      this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
      this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
      this.gcStokBirim = new DevExpress.XtraGrid.GridControl();
      this.gvStokBirim = new DevExpress.XtraGrid.Views.Grid.GridView();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
      this.panelControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtStokBirimTanim.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gcStokBirim)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvStokBirim)).BeginInit();
      this.SuspendLayout();
      // 
      // panelControl2
      // 
      this.panelControl2.Controls.Add(this.txtStokBirimTanim);
      this.panelControl2.Controls.Add(this.labelControl1);
      this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControl2.Location = new System.Drawing.Point(0, 383);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new System.Drawing.Size(550, 37);
      this.panelControl2.TabIndex = 9;
      // 
      // txtStokBirimTanim
      // 
      this.txtStokBirimTanim.Enabled = false;
      this.txtStokBirimTanim.Location = new System.Drawing.Point(78, 8);
      this.txtStokBirimTanim.Name = "txtStokBirimTanim";
      this.txtStokBirimTanim.Size = new System.Drawing.Size(323, 20);
      this.txtStokBirimTanim.TabIndex = 0;
      this.txtStokBirimTanim.Enter += new System.EventHandler(this.AktifTextBackColorChange);
      this.txtStokBirimTanim.Leave += new System.EventHandler(this.PasifTextBackColorChange);
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(5, 12);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(53, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Stok Birim :";
      // 
      // panelControl1
      // 
      this.panelControl1.Controls.Add(this.btnVazgec);
      this.panelControl1.Controls.Add(this.btnKaydet);
      this.panelControl1.Controls.Add(this.btnGuncelle);
      this.panelControl1.Controls.Add(this.btnSil);
      this.panelControl1.Controls.Add(this.btnDegistir);
      this.panelControl1.Controls.Add(this.btnEkle);
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControl1.Location = new System.Drawing.Point(0, 420);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(550, 30);
      this.panelControl1.TabIndex = 10;
      // 
      // btnVazgec
      // 
      this.btnVazgec.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnVazgec.Enabled = false;
      this.btnVazgec.Location = new System.Drawing.Point(241, 3);
      this.btnVazgec.Name = "btnVazgec";
      this.btnVazgec.Size = new System.Drawing.Size(80, 25);
      this.btnVazgec.TabIndex = 3;
      this.btnVazgec.Text = "Vazgeç";
      this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
      // 
      // btnKaydet
      // 
      this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnKaydet.Enabled = false;
      this.btnKaydet.Location = new System.Drawing.Point(321, 3);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(80, 25);
      this.btnKaydet.TabIndex = 4;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // btnGuncelle
      // 
      this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnGuncelle.Location = new System.Drawing.Point(465, 2);
      this.btnGuncelle.Name = "btnGuncelle";
      this.btnGuncelle.Size = new System.Drawing.Size(80, 25);
      this.btnGuncelle.TabIndex = 5;
      this.btnGuncelle.Text = "Güncelle";
      this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
      // 
      // btnSil
      // 
      this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSil.Location = new System.Drawing.Point(81, 3);
      this.btnSil.Name = "btnSil";
      this.btnSil.Size = new System.Drawing.Size(80, 25);
      this.btnSil.TabIndex = 1;
      this.btnSil.Text = "Sil";
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnDegistir
      // 
      this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDegistir.Location = new System.Drawing.Point(161, 3);
      this.btnDegistir.Name = "btnDegistir";
      this.btnDegistir.Size = new System.Drawing.Size(80, 25);
      this.btnDegistir.TabIndex = 2;
      this.btnDegistir.Text = "Değiştir";
      this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
      // 
      // btnEkle
      // 
      this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnEkle.Location = new System.Drawing.Point(1, 3);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(80, 25);
      this.btnEkle.TabIndex = 0;
      this.btnEkle.Text = "Ekle";
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // gcStokBirim
      // 
      this.gcStokBirim.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcStokBirim.Location = new System.Drawing.Point(0, 0);
      this.gcStokBirim.MainView = this.gvStokBirim;
      this.gcStokBirim.Name = "gcStokBirim";
      this.gcStokBirim.Size = new System.Drawing.Size(550, 383);
      this.gcStokBirim.TabIndex = 11;
      this.gcStokBirim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStokBirim});
      // 
      // gvStokBirim
      // 
      this.gvStokBirim.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gvStokBirim.GridControl = this.gcStokBirim;
      this.gvStokBirim.Name = "gvStokBirim";
      this.gvStokBirim.OptionsBehavior.AllowIncrementalSearch = true;
      this.gvStokBirim.OptionsBehavior.Editable = false;
      this.gvStokBirim.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gvStokBirim.OptionsSelection.EnableAppearanceFocusedRow = false;
      this.gvStokBirim.OptionsView.EnableAppearanceEvenRow = true;
      this.gvStokBirim.OptionsView.EnableAppearanceOddRow = true;
      // 
      // frmStokBirim
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gcStokBirim);
      this.Controls.Add(this.panelControl2);
      this.Controls.Add(this.panelControl1);
      this.Name = "frmStokBirim";
      this.Size = new System.Drawing.Size(550, 450);
      this.Load += new System.EventHandler(this.frmStokBirim_Load);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtStokBirimTanim.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gcStokBirim)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvStokBirim)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.TextEdit txtStokBirimTanim;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.SimpleButton btnVazgec;
    private DevExpress.XtraEditors.SimpleButton btnKaydet;
    private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    private DevExpress.XtraEditors.SimpleButton btnSil;
    private DevExpress.XtraEditors.SimpleButton btnDegistir;
    private DevExpress.XtraEditors.SimpleButton btnEkle;
    private DevExpress.XtraGrid.GridControl gcStokBirim;
    private DevExpress.XtraGrid.Views.Grid.GridView gvStokBirim;

  }
}
