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
        public frmVegetableShop()
        {
            InitializeComponent();
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
    }
}
