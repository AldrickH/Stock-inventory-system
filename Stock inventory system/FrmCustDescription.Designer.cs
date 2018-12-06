namespace Stock_inventory_system
{
    partial class FrmCustDescription
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.txtBox_CustAddress = new System.Windows.Forms.TextBox();
            this.lbl_CustAddress = new System.Windows.Forms.Label();
            this.txtBox_CustName = new System.Windows.Forms.TextBox();
            this.lbl_CustName = new System.Windows.Forms.Label();
            this.txtBox_CustID = new System.Windows.Forms.TextBox();
            this.lbl_CustID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(383, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(277, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(145, 23);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(245, 29);
            this.lbl_Header.TabIndex = 25;
            this.lbl_Header.Text = "Customer Description";
            // 
            // txtBox_CustAddress
            // 
            this.txtBox_CustAddress.Location = new System.Drawing.Point(211, 191);
            this.txtBox_CustAddress.Multiline = true;
            this.txtBox_CustAddress.Name = "txtBox_CustAddress";
            this.txtBox_CustAddress.Size = new System.Drawing.Size(272, 76);
            this.txtBox_CustAddress.TabIndex = 24;
            // 
            // lbl_CustAddress
            // 
            this.lbl_CustAddress.AutoSize = true;
            this.lbl_CustAddress.Location = new System.Drawing.Point(49, 196);
            this.lbl_CustAddress.Name = "lbl_CustAddress";
            this.lbl_CustAddress.Size = new System.Drawing.Size(60, 17);
            this.lbl_CustAddress.TabIndex = 23;
            this.lbl_CustAddress.Text = "Address";
            // 
            // txtBox_CustName
            // 
            this.txtBox_CustName.Location = new System.Drawing.Point(211, 139);
            this.txtBox_CustName.Name = "txtBox_CustName";
            this.txtBox_CustName.Size = new System.Drawing.Size(272, 22);
            this.txtBox_CustName.TabIndex = 22;
            // 
            // lbl_CustName
            // 
            this.lbl_CustName.AutoSize = true;
            this.lbl_CustName.Location = new System.Drawing.Point(49, 144);
            this.lbl_CustName.Name = "lbl_CustName";
            this.lbl_CustName.Size = new System.Drawing.Size(109, 17);
            this.lbl_CustName.TabIndex = 21;
            this.lbl_CustName.Text = "Customer Name";
            // 
            // txtBox_CustID
            // 
            this.txtBox_CustID.Enabled = false;
            this.txtBox_CustID.Location = new System.Drawing.Point(211, 93);
            this.txtBox_CustID.Name = "txtBox_CustID";
            this.txtBox_CustID.ReadOnly = true;
            this.txtBox_CustID.Size = new System.Drawing.Size(117, 22);
            this.txtBox_CustID.TabIndex = 20;
            // 
            // lbl_CustID
            // 
            this.lbl_CustID.AutoSize = true;
            this.lbl_CustID.Location = new System.Drawing.Point(49, 93);
            this.lbl_CustID.Name = "lbl_CustID";
            this.lbl_CustID.Size = new System.Drawing.Size(85, 17);
            this.lbl_CustID.TabIndex = 19;
            this.lbl_CustID.Text = "Customer ID";
            // 
            // FrmCustDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.txtBox_CustAddress);
            this.Controls.Add(this.lbl_CustAddress);
            this.Controls.Add(this.txtBox_CustName);
            this.Controls.Add(this.lbl_CustName);
            this.Controls.Add(this.txtBox_CustID);
            this.Controls.Add(this.lbl_CustID);
            this.Name = "FrmCustDescription";
            this.Text = "FrmCustDescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox txtBox_CustAddress;
        private System.Windows.Forms.Label lbl_CustAddress;
        private System.Windows.Forms.TextBox txtBox_CustName;
        private System.Windows.Forms.Label lbl_CustName;
        private System.Windows.Forms.TextBox txtBox_CustID;
        private System.Windows.Forms.Label lbl_CustID;
    }
}