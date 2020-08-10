namespace proje_ErdalBakkal.Tanimlamalar
{
  partial class frmKullanici
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
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
      this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
      this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
      this.btnSil = new DevExpress.XtraEditors.SimpleButton();
      this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
      this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.gcKullanici = new DevExpress.XtraGrid.GridControl();
      this.gvKullanici = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.txtKullaniciKodu = new DevExpress.XtraEditors.TextEdit();
      this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.lkpSkinName = new DevExpress.XtraEditors.LookUpEdit();
      this.txtKullaniciSifre = new DevExpress.XtraEditors.TextEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gcKullanici)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvKullanici)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
      this.panelControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lkpSkinName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).BeginInit();
      this.SuspendLayout();
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
      this.panelControl1.TabIndex = 2;
      // 
      // btnVazgec
      // 
      this.btnVazgec.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnVazgec.Location = new System.Drawing.Point(241, 2);
      this.btnVazgec.Name = "btnVazgec";
      this.btnVazgec.Size = new System.Drawing.Size(80, 25);
      this.btnVazgec.TabIndex = 3;
      this.btnVazgec.Text = "Vazgeç";
      this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
      // 
      // btnKaydet
      // 
      this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnKaydet.Location = new System.Drawing.Point(321, 2);
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
      this.btnSil.Location = new System.Drawing.Point(81, 2);
      this.btnSil.Name = "btnSil";
      this.btnSil.Size = new System.Drawing.Size(80, 25);
      this.btnSil.TabIndex = 1;
      this.btnSil.Text = "Sil";
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnDegistir
      // 
      this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDegistir.Location = new System.Drawing.Point(161, 2);
      this.btnDegistir.Name = "btnDegistir";
      this.btnDegistir.Size = new System.Drawing.Size(80, 25);
      this.btnDegistir.TabIndex = 2;
      this.btnDegistir.Text = "Değiştir";
      this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
      // 
      // btnEkle
      // 
      this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnEkle.Location = new System.Drawing.Point(1, 2);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(80, 25);
      this.btnEkle.TabIndex = 0;
      this.btnEkle.Text = "Ekle";
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(7, 15);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(64, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Kullanıcı Kodu";
      // 
      // gcKullanici
      // 
      this.gcKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcKullanici.Location = new System.Drawing.Point(0, 0);
      this.gcKullanici.MainView = this.gvKullanici;
      this.gcKullanici.Name = "gcKullanici";
      this.gcKullanici.Size = new System.Drawing.Size(550, 378);
      this.gcKullanici.TabIndex = 0;
      this.gcKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKullanici});
      // 
      // gvKullanici
      // 
      this.gvKullanici.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gvKullanici.GridControl = this.gcKullanici;
      this.gvKullanici.Name = "gvKullanici";
      this.gvKullanici.OptionsBehavior.AllowIncrementalSearch = true;
      this.gvKullanici.OptionsBehavior.Editable = false;
      this.gvKullanici.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gvKullanici.OptionsSelection.EnableAppearanceFocusedRow = false;
      this.gvKullanici.OptionsView.EnableAppearanceEvenRow = true;
      this.gvKullanici.OptionsView.EnableAppearanceOddRow = true;
      // 
      // txtKullaniciKodu
      // 
      this.txtKullaniciKodu.EditValue = "";
      this.txtKullaniciKodu.Enabled = false;
      this.txtKullaniciKodu.Location = new System.Drawing.Point(84, 11);
      this.txtKullaniciKodu.Name = "txtKullaniciKodu";
      this.txtKullaniciKodu.Size = new System.Drawing.Size(75, 20);
      this.txtKullaniciKodu.TabIndex = 0;
      this.txtKullaniciKodu.Enter += new System.EventHandler(this.AktifTextBackColorChange);
      this.txtKullaniciKodu.Leave += new System.EventHandler(this.PasifTextBackColorChange);
      // 
      // panelControl2
      // 
      this.panelControl2.Controls.Add(this.labelControl5);
      this.panelControl2.Controls.Add(this.labelControl6);
      this.panelControl2.Controls.Add(this.lkpSkinName);
      this.panelControl2.Controls.Add(this.txtKullaniciKodu);
      this.panelControl2.Controls.Add(this.txtKullaniciSifre);
      this.panelControl2.Controls.Add(this.labelControl3);
      this.panelControl2.Controls.Add(this.labelControl4);
      this.panelControl2.Controls.Add(this.labelControl2);
      this.panelControl2.Controls.Add(this.labelControl1);
      this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControl2.Location = new System.Drawing.Point(0, 378);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new System.Drawing.Size(550, 42);
      this.panelControl2.TabIndex = 1;
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(382, 13);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(4, 13);
      this.labelControl5.TabIndex = 8;
      this.labelControl5.Text = ":";
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(333, 14);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(43, 13);
      this.labelControl6.TabIndex = 7;
      this.labelControl6.Text = "Görünüm";
      // 
      // lkpSkinName
      // 
      this.lkpSkinName.Enabled = false;
      this.lkpSkinName.Location = new System.Drawing.Point(392, 10);
      this.lkpSkinName.Name = "lkpSkinName";
      this.lkpSkinName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lkpSkinName.Properties.NullText = "";
      this.lkpSkinName.Size = new System.Drawing.Size(153, 20);
      this.lkpSkinName.TabIndex = 6;
      this.lkpSkinName.EditValueChanged += new System.EventHandler(this.lkpSkinName_EditValueChanged);
      // 
      // txtKullaniciSifre
      // 
      this.txtKullaniciSifre.EditValue = "1234567890";
      this.txtKullaniciSifre.Enabled = false;
      this.txtKullaniciSifre.Location = new System.Drawing.Point(246, 10);
      this.txtKullaniciSifre.Name = "txtKullaniciSifre";
      this.txtKullaniciSifre.Properties.PasswordChar = '*';
      this.txtKullaniciSifre.Size = new System.Drawing.Size(75, 20);
      this.txtKullaniciSifre.TabIndex = 1;
      this.txtKullaniciSifre.Enter += new System.EventHandler(this.AktifTextBackColorChange);
      this.txtKullaniciSifre.Leave += new System.EventHandler(this.PasifTextBackColorChange);
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(238, 14);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(4, 13);
      this.labelControl3.TabIndex = 5;
      this.labelControl3.Text = ":";
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(167, 14);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(62, 13);
      this.labelControl4.TabIndex = 3;
      this.labelControl4.Text = "Kullanıcı Şifre";
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(76, 15);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(4, 13);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = ":";
      // 
      // frmKullanici
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gcKullanici);
      this.Controls.Add(this.panelControl2);
      this.Controls.Add(this.panelControl1);
      this.Name = "frmKullanici";
      this.Size = new System.Drawing.Size(550, 450);
      this.Tag = "frmKullanici";
      this.Load += new System.EventHandler(this.frmAdresTuru_Load);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gcKullanici)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvKullanici)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lkpSkinName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.SimpleButton btnVazgec;
    private DevExpress.XtraEditors.SimpleButton btnKaydet;
    private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    private DevExpress.XtraEditors.SimpleButton btnSil;
    private DevExpress.XtraEditors.SimpleButton btnDegistir;
    private DevExpress.XtraEditors.SimpleButton btnEkle;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraGrid.GridControl gcKullanici;
    private DevExpress.XtraGrid.Views.Grid.GridView gvKullanici;
    private DevExpress.XtraEditors.TextEdit txtKullaniciKodu;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.TextEdit txtKullaniciSifre;
    private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LookUpEdit lkpSkinName;
  }
}
