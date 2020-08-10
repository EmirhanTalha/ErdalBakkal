namespace proje_ErdalBakkal.Cari
{
  partial class frmCariTurEkle
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
			this.txtCariTurTanim = new DevExpress.XtraEditors.TextEdit();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.txtCariTurTanim.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCariTurTanim
			// 
			this.txtCariTurTanim.Location = new System.Drawing.Point(63, 9);
			this.txtCariTurTanim.Name = "txtCariTurTanim";
			this.txtCariTurTanim.Size = new System.Drawing.Size(185, 20);
			this.txtCariTurTanim.TabIndex = 0;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(173, 35);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(75, 23);
			this.btnKaydet.TabIndex = 1;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(45, 13);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Cari Tür :";
			// 
			// frmCariTurEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 70);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtCariTurTanim);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmCariTurEkle";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cari Tür Ekle";
			((System.ComponentModel.ISupportInitialize)(this.txtCariTurTanim.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.TextEdit txtCariTurTanim;
    private DevExpress.XtraEditors.SimpleButton btnKaydet;
    private DevExpress.XtraEditors.LabelControl labelControl1;
  }
}