using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetableShop_DBMS.Controllers;

namespace VegetableShop_DBMS.Views
{
    public partial class frmImportItem : Form
    {
        public string UserName;
        public string PassWord;
        string err;
        public frmImportItem(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
            InitializeComponent();
            txtUserName.Text = UserName;
            txtUserName.ReadOnly = true;
        }

        private void btnImportItem_Click(object sender, EventArgs e)
        {
            string ItemName = cbbItems.SelectedItem.ToString();
            string UserName = txtUserName.Text.Trim();
            float Quantity = float.Parse(txtQuantity.Text.Trim());

            bool check = SellerSettingController.ImportItems(ItemName, UserName, PassWord, Quantity, ref err);
            if (check == true)
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Bạn đã nhập hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    cbbItems.Items.Clear();
                    txtQuantity.Clear();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã nhập hàng thất bại, xin vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "  ^ [0-9]"))
            {
                txtQuantity.Text = "";
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbbItems_Click(object sender, EventArgs e)
        {
            DataTable dt = SellerSettingController.Items_Show(UserName, PassWord).Tables[0];
            cbbItems.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string temp = dr["ItemName"].ToString();
                cbbItems.Items.Add(temp);
            }
        }
    }
}
