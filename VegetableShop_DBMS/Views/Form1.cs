using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetableShop_DBMS.Views.SignIn;
using VegetableShop_DBMS.Views;

namespace VegetableShop_DBMS
{
    public partial class frmVegetableShop : Form
    {
        private bool flaqMenuAccount = true;
        public string UserName;
        public string PassWord;
        public string Role;
        public frmVegetableShop(string UserName, string PassWord, string Role)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Role = Role;  
            InitializeComponent();
            if (UserName == "")
            {
                btnAccount.Text = "Username ▼";
            }
            else
            {
                this.btnLogOut.Visible = true;
                btnAccount.Text = UserName + "▼";
                this.btnSignIn.Visible = false;
                this.btnSignUp.Visible = false;
                this.btnInformationAccount.Visible = true;
                this.btnInformationAccount.Location = new Point(3, 6);
                this.btnLogOut.Location = new Point(3, 54);
            }
            if(Role == "Admin")
            {
                this.btnAddItem.Visible = true;
                this.btnAddSeller.Visible = true;
                this.btnImportItem.Visible = true;
            }    
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            frmSignIn frmSignIn = new frmSignIn();
            frmSignIn.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.ShowDialog();
        }

        private void btnAccount_MouseClick(object sender, MouseEventArgs e)
        {
            if(flaqMenuAccount == true)
            {
                pnUser.Visible = true;
                flaqMenuAccount = false;
            }    
            else
            {
                pnUser.Visible = false;
                flaqMenuAccount = true;
            }    
        }

        private void btnInformationAccount_Click(object sender, EventArgs e)
        {
            frmInformationAccount frmInfor = new frmInformationAccount();
            frmInfor.ShowDialog();
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            if(UserName != "")
            {
                frmShoppingCart frmCart = new frmShoppingCart();
                frmCart.ShowDialog();
            }
            else
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Mời bạn đăng nhập để sử dụng tính năng này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dialogResult == DialogResult.OK)
                {
                    this.Hide();
                    frmSignIn frmSign = new frmSignIn();
                    frmSign.ShowDialog();
                } 
            }    
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterSeller frmRS = new frmRegisterSeller();
            frmRS.ShowDialog();
            this.Show();      
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddItem frmAdd = new frmAddItem();
            frmAdd.ShowDialog();
            this.Show();
        }

        private void btnImportItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmImportItem frmImport = new frmImportItem();
            frmImport.ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
        }
    }
}
