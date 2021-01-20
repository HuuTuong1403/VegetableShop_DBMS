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
            if (Role == "Admin")
            {
                this.btnAddItem.Visible = true;
                this.btnAddSeller.Visible = true;
                this.btnImportItem.Visible = true;
            }
            if (Role == "Seller")
            {
                this.btnImportItem.Visible = true;
            }
            int xptb = 65;
            int xbtn = 192;
            int xlbl = 65;
            for (int i = 0; i <= 5; i++)
            {
                Guna.UI.WinForms.GunaPictureBox ptb = new Guna.UI.WinForms.GunaPictureBox();
                Guna.UI.WinForms.GunaButton btn = new Guna.UI.WinForms.GunaButton();
                Guna.UI.WinForms.GunaLabel lbl = new Guna.UI.WinForms.GunaLabel();

                //PictureBox
                ptb.Location = new Point(xptb, 33);
                ptb.Size = new Size(162, 162);
                ptb.Image = Image.FromFile(@"E:\Đại học 2020\Year 3 Semester 1\Hệ quản trị cơ sở dữ liệu (DBMS)\VegetableShop_DBMS\VegetableShop_DBMS\images\trash.png");
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                ptb.BorderStyle = BorderStyle.FixedSingle;

                //Button
                btn.Location = new Point(xbtn, 196);
                btn.Size = new Size(35, 36);
                string image = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\cart-plus.png";
                btn.Image = Image.FromFile(image);
                btn.ImageAlign = HorizontalAlignment.Center;
                btn.ImageSize = new Size(30, 30);
                btn.BaseColor = Color.Transparent;
                btn.Cursor = Cursors.Hand;
                btn.OnHoverBaseColor = Color.LightGray;

                //Label
                lbl.Location = new Point(xlbl, 207);
                lbl.Font = new Font("Tahoma", 12, FontStyle.Bold);
                lbl.Text = "";

                xlbl += 212;
                xptb += 212;
                xbtn += 212;

                pnItems.Controls.Add(ptb);
                pnItems.Controls.Add(btn);
                pnItems.Controls.Add(lbl);
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
            if (flaqMenuAccount == true)
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
            frmInformationAccount frmInfor = new frmInformationAccount(UserName);
            frmInfor.ShowDialog();
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            if (UserName != "")
            {
                frmShoppingCart frmCart = new frmShoppingCart(UserName);
                frmCart.ShowDialog();
            }
            else
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Mời bạn đăng nhập để sử dụng tính năng này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
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
            frmImportItem frmImport = new frmImportItem(UserName);
            frmImport.ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVegetableShop frm = new frmVegetableShop("", "", "");
            frm.ShowDialog();
            this.Close();
        }

        private void frmVegetableShop_Load(object sender, EventArgs e)
        {

        }
    }
}
