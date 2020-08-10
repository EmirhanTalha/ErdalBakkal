namespace proje_ErdalBakkal
{
	partial class frmKullaniciGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGiris));
			this.txtKullaniciKodu = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtKullaniciSifre = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
			this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtKullaniciKodu
			// 
			this.txtKullaniciKodu.EnterMoveNextControl = true;
			this.txtKullaniciKodu.Location = new System.Drawing.Point(436, 107);
			this.txtKullaniciKodu.Name = "txtKullaniciKodu";
			this.txtKullaniciKodu.Size = new System.Drawing.Size(100, 20);
			this.txtKullaniciKodu.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(354, 111);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(64, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Kullanıcı Kodu";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(354, 137);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(62, 13);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "Kullanıcı Şifre";
			// 
			// txtKullaniciSifre
			// 
			this.txtKullaniciSifre.EnterMoveNextControl = true;
			this.txtKullaniciSifre.Location = new System.Drawing.Point(436, 133);
			this.txtKullaniciSifre.Name = "txtKullaniciSifre";
			this.txtKullaniciSifre.Properties.MaxLength = 50;
			this.txtKullaniciSifre.Properties.PasswordChar = '*';
			this.txtKullaniciSifre.Size = new System.Drawing.Size(100, 20);
			this.txtKullaniciSifre.TabIndex = 1;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(429, 137);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(4, 13);
			this.labelControl3.TabIndex = 8;
			this.labelControl3.Text = ":";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(429, 111);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(4, 13);
			this.labelControl4.TabIndex = 7;
			this.labelControl4.Text = ":";
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureEdit1.EditValue = global::proje_ErdalBakkal.Properties.Resources.bakkal;
			this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.ShowMenu = false;
			this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
			this.pictureEdit1.Size = new System.Drawing.Size(274, 206);
			this.pictureEdit1.TabIndex = 6;
			// 
			// btnIptal
			// 
			this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.ImageOptions.Image")));
			this.btnIptal.Location = new System.Drawing.Point(380, 168);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(75, 26);
			this.btnIptal.TabIndex = 3;
			this.btnIptal.Text = "İptal";
			// 
			// btnGiris
			// 
			this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
			this.btnGiris.Location = new System.Drawing.Point(461, 168);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(75, 26);
			this.btnGiris.TabIndex = 2;
			this.btnGiris.Text = "G i r i ş";
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// frmKullaniciGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 206);
			this.ControlBox = false;
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.pictureEdit1);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.txtKullaniciSifre);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.txtKullaniciKodu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmKullaniciGiris";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Proje Erdal Bakkal";
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSifre.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit txtKullaniciKodu;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtKullaniciSifre;
		private DevExpress.XtraEditors.SimpleButton btnGiris;
		private DevExpress.XtraEditors.SimpleButton btnIptal;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
	}
}