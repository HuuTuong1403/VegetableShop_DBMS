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
                btnAccount.Text = UserName + "▼";
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
            frmShoppingCart frmCart = new frmShoppingCart();
            frmCart.ShowDialog();
        }
    }
}
