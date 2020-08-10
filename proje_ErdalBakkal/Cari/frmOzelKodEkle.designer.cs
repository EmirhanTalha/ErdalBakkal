namespace proje_ErdalBakkal.Cari
{
  partial class frmOzelKodEkle
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
      this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
      this.txtOzelKod = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.txtOzelKod.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // btnKaydet
      // 
      this.btnKaydet.Location = new System.Drawing.Point(226, 35);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(75, 23);
      this.btnKaydet.TabIndex = 1;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // txtOzelKod
      // 
      this.txtOzelKod.Location = new System.Drawing.Point(61, 9);
      this.txtOzelKod.Name = "txtOzelKod";
      this.txtOzelKod.Size = new System.Drawing.Size(240, 20);
      this.txtOzelKod.TabIndex = 0;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(13, 13);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(42, 13);
      this.labelControl1.TabIndex = 2;
      this.labelControl1.Text = "Özel Kod";
      // 
      // frmOzelKodEkle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(306, 65);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.txtOzelKod);
      this.Controls.Add(this.btnKaydet);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmOzelKodEkle";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Özel Kod";
      ((System.ComponentModel.ISupportInitialize)(this.txtOzelKod.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.SimpleButton btnKaydet;
    private DevExpress.XtraEditors.TextEdit txtOzelKod;
    private DevExpress.XtraEditors.LabelControl labelControl1;
  }
}