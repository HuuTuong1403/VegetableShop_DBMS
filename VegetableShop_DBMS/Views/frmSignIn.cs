using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetableShop_DBMS.Views;
using VegetableShop_DBMS.Controllers;

namespace VegetableShop_DBMS.Views.SignIn
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp frm = new frmSignUp();
            frm.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string UserName = txtAccount.Text.Trim();
            string PassWord = txtPassword.Text.Trim();

            DataTable dt = SignInController.SignIn(UserName,PassWord).Tables[0];
            string role = dt.Rows[0][0].ToString();
            if (role != "")
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    this.Hide();
                    frmVegetableShop form = new frmVegetableShop(UserName, role);
                    form.ShowDialog();
                    this.ShowInTaskbar = false;
                    this.Close();
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPassword.Clear();
            }
        }
    }
}
