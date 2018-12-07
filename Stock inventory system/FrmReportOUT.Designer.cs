namespace Stock_inventory_system
{
    partial class FrmReportOUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportOUT));
            this.RptViewerOUT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.listBoxTransID = new System.Windows.Forms.ListBox();
            this.gBoxTransID = new System.Windows.Forms.GroupBox();
            this.gBoxCust = new System.Windows.Forms.GroupBox();
            this.listBoxCustID = new System.Windows.Forms.ListBox();
            this.gBoxClose = new System.Windows.Forms.GroupBox();
            this.toolStripClose = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.gBoxTransID.SuspendLayout();
            this.gBoxCust.SuspendLayout();
            this.gBoxClose.SuspendLayout();
            this.toolStripClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // RptViewerOUT
            // 
            this.RptViewerOUT.ActiveViewIndex = -1;
            this.RptViewerOUT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RptViewerOUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptViewerOUT.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptViewerOUT.Location = new System.Drawing.Point(0, 133);
            this.RptViewerOUT.Name = "RptViewerOUT";
            this.RptViewerOUT.Size = new System.Drawing.Size(800, 317);
            this.RptViewerOUT.TabIndex = 0;
            this.RptViewerOUT.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // listBoxTransID
            // 
            this.listBoxTransID.FormattingEnabled = true;
            this.listBoxTransID.ItemHeight = 16;
            this.listBoxTransID.Location = new System.Drawing.Point(6, 21);
            this.listBoxTransID.Name = "listBoxTransID";
            this.listBoxTransID.ScrollAlwaysVisible = true;
            this.listBoxTransID.Size = new System.Drawing.Size(203, 84);
            this.listBoxTransID.TabIndex = 2;
            // 
            // gBoxTransID
            // 
            this.gBoxTransID.Controls.Add(this.listBoxTransID);
            this.gBoxTransID.Location = new System.Drawing.Point(12, 12);
            this.gBoxTransID.Name = "gBoxTransID";
            this.gBoxTransID.Size = new System.Drawing.Size(215, 115);
            this.gBoxTransID.TabIndex = 3;
            this.gBoxTransID.TabStop = false;
            this.gBoxTransID.Text = "Transaction ID";
            // 
            // gBoxCust
            // 
            this.gBoxCust.Controls.Add(this.listBoxCustID);
            this.gBoxCust.Location = new System.Drawing.Point(233, 12);
            this.gBoxCust.Name = "gBoxCust";
            this.gBoxCust.Size = new System.Drawing.Size(215, 115);
            this.gBoxCust.TabIndex = 4;
            this.gBoxCust.TabStop = false;
            this.gBoxCust.Text = "Customer ID";
            // 
            // listBoxCustID
            // 
            this.listBoxCustID.FormattingEnabled = true;
            this.listBoxCustID.ItemHeight = 16;
            this.listBoxCustID.Location = new System.Drawing.Point(6, 21);
            this.listBoxCustID.Name = "listBoxCustID";
            this.listBoxCustID.ScrollAlwaysVisible = true;
            this.listBoxCustID.Size = new System.Drawing.Size(203, 84);
            this.listBoxCustID.TabIndex = 2;
            // 
            // gBoxClose
            // 
            this.gBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxClose.Controls.Add(this.toolStripClose);
            this.gBoxClose.Location = new System.Drawing.Point(682, 12);
            this.gBoxClose.Name = "gBoxClose";
            this.gBoxClose.Size = new System.Drawing.Size(106, 99);
            this.gBoxClose.TabIndex = 6;
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
            this.toolStripClose.Size = new System.Drawing.Size(117, 63);
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
            // FrmReportOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxClose);
            this.Controls.Add(this.gBoxCust);
            this.Controls.Add(this.gBoxTransID);
            this.Controls.Add(this.RptViewerOUT);
            this.Name = "FrmReportOUT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.gBoxTransID.ResumeLayout(false);
            this.gBoxCust.ResumeLayout(false);
            this.gBoxClose.ResumeLayout(false);
            this.gBoxClose.PerformLayout();
            this.toolStripClose.ResumeLayout(false);
            this.toolStripClose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptViewerOUT;
        private System.Windows.Forms.ListBox listBoxTransID;
        private System.Windows.Forms.GroupBox gBoxTransID;
        private System.Windows.Forms.GroupBox gBoxCust;
        private System.Windows.Forms.ListBox listBoxCustID;
        private System.Windows.Forms.GroupBox gBoxClose;
        private System.Windows.Forms.ToolStrip toolStripClose;
        private System.Windows.Forms.ToolStripButton btnClose;
    }
}