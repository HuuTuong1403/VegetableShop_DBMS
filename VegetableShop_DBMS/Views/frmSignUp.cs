﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetableShop_DBMS.Views.SignIn;

namespace VegetableShop_DBMS.Views
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            frmSignIn frm = new frmSignIn();
            frm.Show();
            frm.TopMost = true;
            Visible = false;
        }
    }
}