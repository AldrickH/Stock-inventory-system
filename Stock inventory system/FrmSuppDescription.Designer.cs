namespace Stock_inventory_system
{
    partial class FrmSuppDescription
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
            this.txtBox_suppAddress = new System.Windows.Forms.TextBox();
            this.lbl_SuppAddress = new System.Windows.Forms.Label();
            this.txtBox_suppName = new System.Windows.Forms.TextBox();
            this.lbl_SuppName = new System.Windows.Forms.Label();
            this.txtBox_suppID = new System.Windows.Forms.TextBox();
            this.lbl_SuppID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(390, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(152, 27);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(232, 29);
            this.lbl_Header.TabIndex = 16;
            this.lbl_Header.Text = "Supplier Description";
            // 
            // txtBox_suppAddress
            // 
            this.txtBox_suppAddress.Location = new System.Drawing.Point(218, 194);
            this.txtBox_suppAddress.Multiline = true;
            this.txtBox_suppAddress.Name = "txtBox_suppAddress";
            this.txtBox_suppAddress.Size = new System.Drawing.Size(272, 76);
            this.txtBox_suppAddress.TabIndex = 15;
            // 
            // lbl_SuppAddress
            // 
            this.lbl_SuppAddress.AutoSize = true;
            this.lbl_SuppAddress.Location = new System.Drawing.Point(56, 199);
            this.lbl_SuppAddress.Name = "lbl_SuppAddress";
            this.lbl_SuppAddress.Size = new System.Drawing.Size(60, 17);
            this.lbl_SuppAddress.TabIndex = 14;
            this.lbl_SuppAddress.Text = "Address";
            // 
            // txtBox_suppName
            // 
            this.txtBox_suppName.Location = new System.Drawing.Point(218, 142);
            this.txtBox_suppName.Name = "txtBox_suppName";
            this.txtBox_suppName.Size = new System.Drawing.Size(272, 22);
            this.txtBox_suppName.TabIndex = 13;
            // 
            // lbl_SuppName
            // 
            this.lbl_SuppName.AutoSize = true;
            this.lbl_SuppName.Location = new System.Drawing.Point(56, 147);
            this.lbl_SuppName.Name = "lbl_SuppName";
            this.lbl_SuppName.Size = new System.Drawing.Size(101, 17);
            this.lbl_SuppName.TabIndex = 12;
            this.lbl_SuppName.Text = "Supplier Name";
            // 
            // txtBox_suppID
            // 
            this.txtBox_suppID.Enabled = false;
            this.txtBox_suppID.Location = new System.Drawing.Point(218, 96);
            this.txtBox_suppID.Name = "txtBox_suppID";
            this.txtBox_suppID.ReadOnly = true;
            this.txtBox_suppID.Size = new System.Drawing.Size(117, 22);
            this.txtBox_suppID.TabIndex = 11;
            // 
            // lbl_SuppID
            // 
            this.lbl_SuppID.AutoSize = true;
            this.lbl_SuppID.Location = new System.Drawing.Point(56, 96);
            this.lbl_SuppID.Name = "lbl_SuppID";
            this.lbl_SuppID.Size = new System.Drawing.Size(77, 17);
            this.lbl_SuppID.TabIndex = 10;
            this.lbl_SuppID.Text = "Supplier ID";
            // 
            // FrmSuppDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.txtBox_suppAddress);
            this.Controls.Add(this.lbl_SuppAddress);
            this.Controls.Add(this.txtBox_suppName);
            this.Controls.Add(this.lbl_SuppName);
            this.Controls.Add(this.txtBox_suppID);
            this.Controls.Add(this.lbl_SuppID);
            this.Name = "FrmSuppDescription";
            this.Text = "FrmSuppDescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox txtBox_suppAddress;
        private System.Windows.Forms.Label lbl_SuppAddress;
        private System.Windows.Forms.TextBox txtBox_suppName;
        private System.Windows.Forms.Label lbl_SuppName;
        private System.Windows.Forms.TextBox txtBox_suppID;
        private System.Windows.Forms.Label lbl_SuppID;
    }
}