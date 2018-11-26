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
    public partial class FrmItemDescription : Form
    {
        ItemDAO dao = null;
        bool editMode = false;
        Item itm = null;

        public FrmItemDescription(ItemDAO _dao, bool _editMode, Item _temp = null)
        {
            InitializeComponent();
            dao = _dao;
            editMode = _editMode;

            if (editMode == true)
            {
                itm = _temp;
                this.txtBox_ItemID.Text = _temp.itemID;
                this.txtBox_ItemName.Text = _temp.itemName;
                this.txtBox_Quantity.Text = _temp.qty.ToString();
            }
            else
            {
                this.txtBox_ItemID.Text = dao.GetKodeBarangBerikutnya();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtBox_ItemName.Text.Trim() == "")
            {
                MessageBox.Show("Please insert 'Item Name' ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBox_ItemName.Focus();
            }
            else if (this.txtBox_Quantity.Text.Trim() == "")
            {
                MessageBox.Show("Please insert 'Quantity' ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBox_Quantity.Focus();
            }
            else
            {
                if (editMode == true)
                {
                    dao.EditItem(GetTxtBoxData(), itm);
                }
                else
                {
                    dao.AddNewItem(GetTxtBoxData());
                }

                this.Close();
            }
        }

        private Item GetTxtBoxData()
        {
            Item newItem = new Item
            {
                itemID = this.txtBox_ItemID.Text.ToString().Trim(),
                itemName = this.txtBox_ItemName.Text.ToString().Trim(),
                qty = Convert.ToInt32(this.txtBox_Quantity.Text.Trim())
            };

            return newItem;
        }

        private void textAngka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
