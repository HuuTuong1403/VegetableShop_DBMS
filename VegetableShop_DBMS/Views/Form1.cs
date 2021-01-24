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
using VegetableShop_DBMS.Views;
using VegetableShop_DBMS.Controllers;


namespace VegetableShop_DBMS
{
    public partial class frmVegetableShop : Form
    {
        private bool flaqMenuAccount = true;
        private bool flaqMenuManagement = true;
        public string UserName;
        public string Role;
        public string PassWord;
        DataTable dtItem;
        string err;
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
                this.btnManagement.Visible = true;
            }
            if (Role == "Seller")
            {
                this.btnImportItem.Visible = true;
                this.btnManagement.Visible = true;
                this.pnManagement.Height = 56;
            }
            int xptb = 65;
            int xbtn = 65;
            int xlbl = 111;
            int count = 0;
            dtItem = HomeController.ShowItem(UserName).Tables[0];
            while (count < 6)
            {
                DataRow dr = dtItem.Rows[count];
                Guna.UI.WinForms.GunaPictureBox ptb = new Guna.UI.WinForms.GunaPictureBox();
                Guna.UI.WinForms.GunaButton btn = new Guna.UI.WinForms.GunaButton();
                Guna.UI.WinForms.GunaLabel lbl = new Guna.UI.WinForms.GunaLabel();
                string ImageTemp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesProduct\" + dr["Image"].ToString();
                
                //PictureBox
                ptb.Location = new Point(xptb, 33);
                ptb.Size = new Size(162, 162);
                ptb.Image = Image.FromFile(ImageTemp);
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                ptb.BorderStyle = BorderStyle.FixedSingle;

                //Button
                btn.Location = new Point(xbtn, 220);
                btn.Size = new Size(162, 36);
                string image = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\cart-plus.png";
                btn.Image = Image.FromFile(image);
                btn.Text = dr["ItemName"].ToString();
                btn.Font = new Font("Tahoma", 12, FontStyle.Bold);
                btn.ForeColor = Color.Black;
                btn.OnHoverForeColor = Color.Black;
                btn.ImageAlign = HorizontalAlignment.Right;
                btn.ImageSize = new Size(20, 20);
                btn.BaseColor = Color.Transparent;
                btn.Cursor = Cursors.Hand;
                btn.OnHoverBaseColor = Color.LightGray;
                btn.Click += Btn_Click;

                //Label
                lbl.Location = new Point(xlbl, 198);
                lbl.Font = new Font("Tahoma", 12, FontStyle.Bold);
                lbl.Text = dr["SalePrice"].ToString() + "₫";

                

                xlbl += 212;
                xptb += 212;
                xbtn += 212;
                

                pnItems.Controls.Add(ptb);
                pnItems.Controls.Add(btn);
                pnItems.Controls.Add(lbl);

                count = count + 1;
                
            }
            int i = dtItem.Rows.Count / 6;
            int xbtnPaing = 450;
            for (int j = 1; j <= i; j++) 
            {
                //Button Paging
                Guna.UI.WinForms.GunaButton btnPaging = new Guna.UI.WinForms.GunaButton();
                btnPaging.Location = new Point(xbtnPaing, 327);
                btnPaging.Size = new Size(35, 35);
                btnPaging.BaseColor = Color.Silver;
                btnPaging.BorderColor = Color.Black;
                btnPaging.BorderSize = 1;
                btnPaging.Font = new Font("Tahoma", 9, FontStyle.Bold);
                btnPaging.ForeColor = Color.Black;
                btnPaging.Image = null;
                btnPaging.Text = j.ToString();
                btnPaging.Cursor = Cursors.Hand;
                btnPaging.TextAlign = HorizontalAlignment.Center;
                btnPaging.OnHoverBaseColor = Color.LightGray;
                btnPaging.OnHoverForeColor = Color.Black;
                btnPaging.Click += BtnPaging_Click;
                xbtnPaing += 34;

                pnItems.Controls.Add(btnPaging);
            }    
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
            Guna.UI.WinForms.GunaButton btn = sender as Guna.UI.WinForms.GunaButton;
            if (UserName != "")
            {
                string UserName = this.UserName;
                string ItemName = btn.Text;
                float SalePrice = float.Parse(HomeController.PriceItem(ItemName).Tables[0].Rows[0][0].ToString());
                float Quantity = 1;
                bool check = OrderItemsController.AddCart(UserName, PassWord, ItemName, SalePrice, Quantity, ref err); 
                if (check == true)
                {
                    MessageBox.Show("Bạn đã thêm " + ItemName + " vào giỏ hàng thành công");
                }
                else
                {
                    MessageBox.Show("Bạn đã thêm món ăn vào giỏ hàng thất bại");
                }

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
                    this.Close();
                }
            }
        }

        private void BtnPaging_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton btnPagingTemp = sender as Guna.UI.WinForms.GunaButton;
            if (btnPagingTemp.Text == "1")
            {
                pnItems.Controls.Clear();
                int i = 0;
                int xptb = 65;
                int xbtn = 65;
                int xlbl = 111;
                while (i < 6)
                {
                    DataRow dr = dtItem.Rows[i];
                    Guna.UI.WinForms.GunaPictureBox ptb = new Guna.UI.WinForms.GunaPictureBox();
                    Guna.UI.WinForms.GunaButton btn = new Guna.UI.WinForms.GunaButton();
                    Guna.UI.WinForms.GunaLabel lbl = new Guna.UI.WinForms.GunaLabel();
                    string ImageTemp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesProduct\" + dr["Image"].ToString();

                    //PictureBox
                    ptb.Location = new Point(xptb, 33);
                    ptb.Size = new Size(162, 162);
                    ptb.Image = Image.FromFile(ImageTemp);
                    ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptb.BorderStyle = BorderStyle.FixedSingle;

                    //Button
                    btn.Location = new Point(xbtn, 220);
                    btn.Size = new Size(162, 36);
                    string image = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\cart-plus.png";
                    btn.Image = Image.FromFile(image);
                    btn.Text = dr["ItemName"].ToString();
                    btn.Font = new Font("Tahoma", 12, FontStyle.Bold);
                    btn.ForeColor = Color.Black;
                    btn.OnHoverForeColor = Color.Black;
                    btn.ImageAlign = HorizontalAlignment.Right;
                    btn.ImageSize = new Size(20, 20);
                    btn.BaseColor = Color.Transparent;
                    btn.Cursor = Cursors.Hand;
                    btn.OnHoverBaseColor = Color.LightGray;
                    btn.Click += Btn_Click;

                    //Label
                    lbl.Location = new Point(xlbl, 198);
                    lbl.Font = new Font("Tahoma", 12, FontStyle.Bold);
                    lbl.Text = dr["SalePrice"].ToString() + "₫";



                    xlbl += 212;
                    xptb += 212;
                    xbtn += 212;


                    pnItems.Controls.Add(ptb);
                    pnItems.Controls.Add(btn);
                    pnItems.Controls.Add(lbl);

                    int k = dtItem.Rows.Count / 6;
                    int xbtnPaing = 450;
                    for (int j = 1; j <= k; j++)
                    {
                        //Button Paging
                        Guna.UI.WinForms.GunaButton btnPaging = new Guna.UI.WinForms.GunaButton();
                        btnPaging.Location = new Point(xbtnPaing, 327);
                        btnPaging.Size = new Size(35, 35);
                        btnPaging.BaseColor = Color.Silver;
                        btnPaging.BorderColor = Color.Black;
                        btnPaging.BorderSize = 1;
                        btnPaging.Font = new Font("Tahoma", 9, FontStyle.Bold);
                        btnPaging.ForeColor = Color.Black;
                        btnPaging.Image = null;
                        btnPaging.Text = j.ToString();
                        btnPaging.Cursor = Cursors.Hand;
                        btnPaging.TextAlign = HorizontalAlignment.Center;
                        btnPaging.OnHoverBaseColor = Color.LightGray;
                        btnPaging.OnHoverForeColor = Color.Black;
                        btnPaging.Click += BtnPaging_Click;
                        xbtnPaing += 34;

                        pnItems.Controls.Add(btnPaging);
                    }
                    i = i + 1;
                }
            }
            else
            {
                pnItems.Controls.Clear();
                int i = 0;
                int xptb = 65;
                int xbtn = 65;
                int xlbl = 111;
                int index = (int.Parse(btnPagingTemp.Text) - 1) * 6;
                while (i < 6)
                {
                    DataRow dr = dtItem.Rows[index];
                    Guna.UI.WinForms.GunaPictureBox ptb = new Guna.UI.WinForms.GunaPictureBox();
                    Guna.UI.WinForms.GunaButton btn = new Guna.UI.WinForms.GunaButton();
                    Guna.UI.WinForms.GunaLabel lbl = new Guna.UI.WinForms.GunaLabel();
                    string ImageTemp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesProduct\" + dr["Image"].ToString();

                    //PictureBox
                    ptb.Location = new Point(xptb, 33);
                    ptb.Size = new Size(162, 162);
                    ptb.Image = Image.FromFile(ImageTemp);
                    ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptb.BorderStyle = BorderStyle.FixedSingle;

                    //Button
                    btn.Location = new Point(xbtn, 220);
                    btn.Size = new Size(162, 36);
                    string image = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\cart-plus.png";
                    btn.Image = Image.FromFile(image);
                    btn.Text = dr["ItemName"].ToString();
                    btn.Font = new Font("Tahoma", 12, FontStyle.Bold);
                    btn.ForeColor = Color.Black;
                    btn.OnHoverForeColor = Color.Black;
                    btn.ImageAlign = HorizontalAlignment.Right;
                    btn.ImageSize = new Size(20, 20);
                    btn.BaseColor = Color.Transparent;
                    btn.Cursor = Cursors.Hand;
                    btn.OnHoverBaseColor = Color.LightGray;
                    btn.Click += Btn_Click;

                    //Label
                    lbl.Location = new Point(xlbl, 198);
                    lbl.Font = new Font("Tahoma", 12, FontStyle.Bold);
                    lbl.Text = dr["SalePrice"].ToString() + "₫";



                    xlbl += 212;
                    xptb += 212;
                    xbtn += 212;


                    pnItems.Controls.Add(ptb);
                    pnItems.Controls.Add(btn);
                    pnItems.Controls.Add(lbl);

                    int k = dtItem.Rows.Count / 6;
                    int xbtnPaing = 450;
                    for (int j = 1; j <= k; j++)
                    {
                        //Button Paging
                        Guna.UI.WinForms.GunaButton btnPaging = new Guna.UI.WinForms.GunaButton();
                        btnPaging.Location = new Point(xbtnPaing, 327);
                        btnPaging.Size = new Size(35, 35);
                        btnPaging.BaseColor = Color.Silver;
                        btnPaging.BorderColor = Color.Black;
                        btnPaging.BorderSize = 1;
                        btnPaging.Font = new Font("Tahoma", 9, FontStyle.Bold);
                        btnPaging.ForeColor = Color.Black;
                        btnPaging.Image = null;
                        btnPaging.Text = j.ToString();
                        btnPaging.Cursor = Cursors.Hand;
                        btnPaging.TextAlign = HorizontalAlignment.Center;
                        btnPaging.OnHoverBaseColor = Color.LightGray;
                        btnPaging.OnHoverForeColor = Color.Black;
                        btnPaging.Click += BtnPaging_Click;
                        xbtnPaing += 34;

                        pnItems.Controls.Add(btnPaging);
                    }
                    i = i + 1;
                    index = index + 1;
                }
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignIn frmSignIn = new frmSignIn();
            frmSignIn.ShowDialog();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.ShowDialog();
            this.Show();
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
            this.Hide();
            frmInformationAccount frmInfor = new frmInformationAccount(UserName, PassWord);
            frmInfor.ShowDialog();
            this.Show();
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            if (UserName != "")
            {
                frmShoppingCart frmCart = new frmShoppingCart(UserName, PassWord);
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
            frmRegisterSeller frmRS = new frmRegisterSeller(UserName, PassWord);
            frmRS.ShowDialog();
            this.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddItem frmAdd = new frmAddItem(UserName, PassWord);
            frmAdd.ShowDialog();
            this.Show();
        }

        private void btnImportItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmImportItem frmImport = new frmImportItem(UserName, PassWord);
            frmImport.ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVegetableShop frm = new frmVegetableShop("", "","");
            frm.ShowDialog();
            this.Close();
        }

        private void frmVegetableShop_Load(object sender, EventArgs e)
        {

        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            if (flaqMenuManagement == true)
            {
                pnManagement.Visible = true;
                flaqMenuManagement = false;
            }
            else
            {
                pnManagement.Visible = false;
                flaqMenuManagement = true;
            }
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserManagement frmUser = new frmUserManagement(UserName, PassWord);
            frmUser.ShowDialog();
            this.Show();
        }

        private void btnItemsManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmItemsManagement frmItems = new frmItemsManagement(UserName, PassWord);
            frmItems.ShowDialog();
            this.Show();
        }

        private void btnImportItemsManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmImportItemsManagement frmImport = new frmImportItemsManagement(UserName, PassWord);
            frmImport.ShowDialog();
            this.Show();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrderManagement frmOrder = new frmOrderManagement(UserName, PassWord);
            frmOrder.ShowDialog();
            this.Show();
        }
    }
}
