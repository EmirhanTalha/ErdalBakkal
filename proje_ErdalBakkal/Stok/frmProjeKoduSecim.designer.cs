namespace proje_ErdalBakkal.stok
{
  partial class frmProjeKoduSecim
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
      this.btnSec = new DevExpress.XtraEditors.SimpleButton();
      this.gcListe = new DevExpress.XtraGrid.GridControl();
      this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
      this.SuspendLayout();
      // 
      // panelControl1
      // 
      this.panelControl1.Controls.Add(this.btnSec);
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControl1.Location = new System.Drawing.Point(0, 389);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(385, 39);
      this.panelControl1.TabIndex = 0;
      // 
      // btnSec
      // 
      this.btnSec.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSec.Location = new System.Drawing.Point(300, 9);
      this.btnSec.Name = "btnSec";
      this.btnSec.Size = new System.Drawing.Size(80, 25);
      this.btnSec.TabIndex = 3;
      this.btnSec.Text = "S e ç";
      this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
      // 
      // gcListe
      // 
      this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcListe.Location = new System.Drawing.Point(0, 0);
      this.gcListe.MainView = this.gvListe;
      this.gcListe.Name = "gcListe";
      this.gcListe.Size = new System.Drawing.Size(385, 389);
      this.gcListe.TabIndex = 1;
      this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
      // 
      // gvListe
      // 
      this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gvListe.GridControl = this.gcListe;
      this.gvListe.Name = "gvListe";
      this.gvListe.OptionsBehavior.AllowIncrementalSearch = true;
      this.gvListe.OptionsBehavior.Editable = false;
      this.gvListe.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gvListe.OptionsSelection.EnableAppearanceFocusedRow = false;
      this.gvListe.OptionsView.ShowGroupPanel = false;
      this.gvListe.DoubleClick += new System.EventHandler(this.btnSec_Click);
      // 
      // frmProjeKoduSecim
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(385, 428);
      this.Controls.Add(this.gcListe);
      this.Controls.Add(this.panelControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmProjeKoduSecim";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Özel Kod";
      this.Load += new System.EventHandler(this.frmStokBarkodSecim_Load);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.SimpleButton btnSec;
    private DevExpress.XtraGrid.GridControl gcListe;
    private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
  }
}