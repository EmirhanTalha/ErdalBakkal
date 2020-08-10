namespace proje_ErdalBakkal.Tanimlamalar
{
	partial class frmTanimlamalar
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
			this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.tlstMenu = new DevExpress.XtraTreeList.TreeList();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tlstMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// treeListColumn1
			// 
			this.treeListColumn1.Caption = "Genel Tanımlar";
			this.treeListColumn1.FieldName = "treeListColumn1";
			this.treeListColumn1.MinWidth = 52;
			this.treeListColumn1.Name = "treeListColumn1";
			this.treeListColumn1.Visible = true;
			this.treeListColumn1.VisibleIndex = 0;
			// 
			// panelControl1
			// 
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(180, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(554, 452);
			this.panelControl1.TabIndex = 4;
			// 
			// tlstMenu
			// 
			this.tlstMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
			this.tlstMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.tlstMenu.Location = new System.Drawing.Point(0, 0);
			this.tlstMenu.Name = "tlstMenu";
			this.tlstMenu.BeginUnboundLoad();
			this.tlstMenu.AppendNode(new object[] {
            "Genel Tanımlamalar"}, -1);
			this.tlstMenu.AppendNode(new object[] {
            "Program Genel Tanımlamalar"}, 0);
			this.tlstMenu.AppendNode(new object[] {
            "Cari Tür"}, 0);
			this.tlstMenu.AppendNode(new object[] {
            "Cari Grup"}, 0);
			this.tlstMenu.AppendNode(new object[] {
            "Stok Birim"}, 0);
			this.tlstMenu.AppendNode(new object[] {
            "Proje Tanım"}, 0);
			this.tlstMenu.AppendNode(new object[] {
            "Özel Kod"}, 0);
			this.tlstMenu.AppendNode(new object[] {
            "Stok Marka"}, 0);
			this.tlstMenu.AppendNode(new object[] {
            "KDV Oran"}, 0);
			this.tlstMenu.AppendNode(new object[] {
            "Kasa Tanım"}, 0);
			this.tlstMenu.AppendNode(new object[] {
            "Kullanıcı Tanımlama"}, 0);
			this.tlstMenu.EndUnboundLoad();
			this.tlstMenu.Size = new System.Drawing.Size(180, 452);
			this.tlstMenu.TabIndex = 3;
			this.tlstMenu.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlstMenu_FocusedNodeChanged);
			this.tlstMenu.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.tlstMenu_CustomDrawNodeCell);
			// 
			// frmTanimlamalar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 452);
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.tlstMenu);
			this.Name = "frmTanimlamalar";
			this.Text = "frmTanimlamalar";
			this.Load += new System.EventHandler(this.frmTanimlamalar_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tlstMenu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraTreeList.TreeList tlstMenu;
	}
}