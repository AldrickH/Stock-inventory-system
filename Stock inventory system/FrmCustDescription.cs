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
    public partial class FrmCustDescription : Form
    {
        Customer cust = null;
        CustomerDAO dao = null;

        bool editMode = false;

        public FrmCustDescription(CustomerDAO _dao, bool _editMode, Customer _temp = null)
        {
            InitializeComponent();

            dao = _dao;
            editMode = _editMode;

            if (editMode == true)
            {
                cust = _temp;
                this.txtBox_CustID.Text = _temp.custID;
                this.txtBox_CustName.Text = _temp.custName;
                this.txtBox_CustAddress.Text = _temp.custAddress;
            }
            else
            {
                this.txtBox_CustID.Text = dao.GetCustomerIDNext();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtBox_CustName.Text.Trim() == "")
            {
                MessageBox.Show("Please insert 'Item Name' ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBox_CustName.Focus();
            }
            else if (this.txtBox_CustAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please insert 'Address' ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBox_CustAddress.Focus();
            }
            else
            {
                if (editMode == true)
                {
                    dao.EditCustomer(GetTxtBoxData(), cust);
                }
                else
                {
                    dao.AddNewCustomer(GetTxtBoxData());
                }

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Customer GetTxtBoxData()
        {
            Customer newCust = new Customer
            {
                custID = this.txtBox_CustID.Text.ToString().Trim(),
                custName = this.txtBox_CustName.Text.ToString().Trim(),
                custAddress = this.txtBox_CustAddress.Text.ToString().Trim()
            };

            return newCust;
        }
    }
}
