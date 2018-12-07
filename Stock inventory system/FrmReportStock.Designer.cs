namespace Stock_inventory_system
{
    partial class FrmReportStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportStock));
            this.gBoxClose = new System.Windows.Forms.GroupBox();
            this.toolStripClose = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.gBoxItemID = new System.Windows.Forms.GroupBox();
            this.listBoxItemID = new System.Windows.Forms.ListBox();
            this.RptViewerStock = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gBoxClose.SuspendLayout();
            this.toolStripClose.SuspendLayout();
            this.gBoxItemID.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxClose
            // 
            this.gBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxClose.Controls.Add(this.toolStripClose);
            this.gBoxClose.Location = new System.Drawing.Point(682, 6);
            this.gBoxClose.Name = "gBoxClose";
            this.gBoxClose.Size = new System.Drawing.Size(106, 99);
            this.gBoxClose.TabIndex = 10;
            this.gBoxClose.TabStop = false;
            this.gBoxClose.Text = "Close";
            // 
            // toolStripClose
            // 
            this.toolStripClose.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripClose.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripClose.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose});
            this.toolStripClose.Location = new System.Drawing.Point(3, 18);
            this.toolStripClose.Name = "toolStripClose";
            this.toolStripClose.Size = new System.Drawing.Size(78, 63);
            this.toolStripClose.TabIndex = 0;
            this.toolStripClose.Text = "toolStrip1";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 60);
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gBoxItemID
            // 
            this.gBoxItemID.Controls.Add(this.listBoxItemID);
            this.gBoxItemID.Location = new System.Drawing.Point(12, 6);
            this.gBoxItemID.Name = "gBoxItemID";
            this.gBoxItemID.Size = new System.Drawing.Size(215, 115);
            this.gBoxItemID.TabIndex = 8;
            this.gBoxItemID.TabStop = false;
            this.gBoxItemID.Text = "Item ID";
            // 
            // listBoxItemID
            // 
            this.listBoxItemID.FormattingEnabled = true;
            this.listBoxItemID.ItemHeight = 16;
            this.listBoxItemID.Location = new System.Drawing.Point(6, 21);
            this.listBoxItemID.Name = "listBoxItemID";
            this.listBoxItemID.ScrollAlwaysVisible = true;
            this.listBoxItemID.Size = new System.Drawing.Size(203, 84);
            this.listBoxItemID.TabIndex = 2;
            // 
            // RptViewerStock
            // 
            this.RptViewerStock.ActiveViewIndex = -1;
            this.RptViewerStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RptViewerStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptViewerStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptViewerStock.Location = new System.Drawing.Point(0, 127);
            this.RptViewerStock.Name = "RptViewerStock";
            this.RptViewerStock.Size = new System.Drawing.Size(800, 317);
            this.RptViewerStock.TabIndex = 7;
            this.RptViewerStock.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReportStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxClose);
            this.Controls.Add(this.gBoxItemID);
            this.Controls.Add(this.RptViewerStock);
            this.Name = "FrmReportStock";
            this.Text = "FrmReportStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportStock_Load);
            this.gBoxClose.ResumeLayout(false);
            this.gBoxClose.PerformLayout();
            this.toolStripClose.ResumeLayout(false);
            this.toolStripClose.PerformLayout();
            this.gBoxItemID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxClose;
        private System.Windows.Forms.ToolStrip toolStripClose;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox gBoxItemID;
        private System.Windows.Forms.ListBox listBoxItemID;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptViewerStock;
    }
}