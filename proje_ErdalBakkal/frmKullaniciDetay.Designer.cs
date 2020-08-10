namespace proje_ErdalBakkal
{
	partial class frmKullaniciDetay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciDetay));
			this.txtKullaniciAdSoyad = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtKullaniciKodu = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtKullaniciSifre = new DevExpress.XtraEditors.TextEdit();
			this.ceAktif = new DevExpress.XtraEditors.CheckEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdSoyad.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ceAktif.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtKullaniciAdSoyad
			// 
			this.txtKullaniciAdSoyad.Location = new System.Drawing.Point(116, 12);
			this.txtKullaniciAdSoyad.Name = "txtKullaniciAdSoyad";
			this.txtKullaniciAdSoyad.Size = new System.Drawing.Size(143, 20);
			this.txtKullaniciAdSoyad.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(15, 16);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(86, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Kullanıcı Ad Soyad";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(15, 42);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(64, 13);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "Kullanıcı Kodu";
			// 
			// txtKullaniciKodu
			// 
			this.txtKullaniciKodu.Location = new System.Drawing.Point(116, 38);
			this.txtKullaniciKodu.Name = "txtKullaniciKodu";
			this.txtKullaniciKodu.Size = new System.Drawing.Size(143, 20);
			this.txtKullaniciKodu.TabIndex = 1;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(15, 68);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(62, 13);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "Kullanıcı Şifre";
			// 
			// txtKullaniciSifre
			// 
			this.txtKullaniciSifre.Location = new System.Drawing.Point(116, 64);
			this.txtKullaniciSifre.Name = "txtKullaniciSifre";
			this.txtKullaniciSifre.Size = new System.Drawing.Size(143, 20);
			this.txtKullaniciSifre.TabIndex = 2;
			// 
			// ceAktif
			// 
			this.ceAktif.Location = new System.Drawing.Point(116, 94);
			this.ceAktif.Name = "ceAktif";
			this.ceAktif.Properties.Caption = "Pasif";
			this.ceAktif.Size = new System.Drawing.Size(75, 19);
			this.ceAktif.TabIndex = 3;
			this.ceAktif.CheckedChanged += new System.EventHandler(this.ceAktif_CheckedChanged);
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(15, 97);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(50, 13);
			this.labelControl4.TabIndex = 7;
			this.labelControl4.Text = "Aktif/Pasif";
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(219, 122);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(40, 35);
			this.btnKaydet.TabIndex = 4;
			this.btnKaydet.Text = "simpleButton5";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnIptal
			// 
			this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnIptal.Location = new System.Drawing.Point(179, 122);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(40, 35);
			this.btnIptal.TabIndex = 5;
			this.btnIptal.Text = "simpleButton4";
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(109, 97);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(4, 13);
			this.labelControl5.TabIndex = 13;
			this.labelControl5.Text = ":";
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(109, 68);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(4, 13);
			this.labelControl6.TabIndex = 12;
			this.labelControl6.Text = ":";
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(109, 42);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(4, 13);
			this.labelControl7.TabIndex = 11;
			this.labelControl7.Text = ":";
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(109, 16);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(4, 13);
			this.labelControl8.TabIndex = 10;
			this.labelControl8.Text = ":";
			// 
			// frmKullaniciDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 169);
			this.ControlBox = false;
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.ceAktif);
			this.Controls.Add(this.txtKullaniciSifre);
			this.Controls.Add(this.txtKullaniciKodu);
			this.Controls.Add(this.txtKullaniciAdSoyad);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.labelControl8);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmKullaniciDetay";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kullanıcı Detay";
			this.Load += new System.EventHandler(this.frmKullaniciDetay_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdSoyad.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ceAktif.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit txtKullaniciAdSoyad;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtKullaniciKodu;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtKullaniciSifre;
		private DevExpress.XtraEditors.CheckEdit ceAktif;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.SimpleButton btnIptal;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl8;
	}
}