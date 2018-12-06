using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock_Library;

namespace Stock_inventory_system
{
    public partial class FrmSuppDescription : Form
    {
        Supplier supp = null;
        SupplierDAO dao = null;

        bool editMode = false;

        public FrmSuppDescription(SupplierDAO _dao, bool _editMode, Supplier _temp = null)
        {
            InitializeComponent();

            dao = _dao;
            editMode = _editMode;

            if (editMode == true)
            {
                supp = _temp;
                this.txtBox_suppID.Text = _temp.suppID;
                this.txtBox_suppName.Text = _temp.suppName;
                this.txtBox_suppAddress.Text = _temp.suppAddress;
            }
            else
            {
                this.txtBox_suppID.Text = dao.GetSuppIDNext();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtBox_suppName.Text.Trim() == "")
            {
                MessageBox.Show("Please insert 'Item Name' ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBox_suppName.Focus();
            }
            else if (this.txtBox_suppAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please insert 'Address' ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBox_suppAddress.Focus();
            }
            else
            {
                if (editMode == true)
                {
                    dao.EditSupplier(GetTxtBoxData(), supp);
                }
                else
                {
                    dao.AddNewSupplier(GetTxtBoxData());
                }

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Supplier GetTxtBoxData()
        {
            Supplier newSupp = new Supplier
            {
                suppID = this.txtBox_suppID.Text.ToString().Trim(),
                suppName = this.txtBox_suppName.Text.ToString().Trim(),
                suppAddress = this.txtBox_suppAddress.Text.ToString().Trim()
            };

            return newSupp;
        }
    }
}
