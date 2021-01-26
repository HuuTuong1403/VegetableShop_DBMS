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
using VegetableShop_DBMS.Controllers;


namespace VegetableShop_DBMS
{
    public partial class frmVegetableShop : Form
    {
        private bool flaqMenuAccount = true;
        private bool flaqMenuManagement = true;
        private bool flaqMenuCategory = true;
        public string UserName;
        public string Role;
        public string PassWord;
        public string ImageUser;
        DataTable dtItem;
        public int countPaging;
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
                this.lblShowCart.Visible = false;
            }
            else
            {
                this.lblShowCart.Text = OrderItemsController.ShowTotalDetails(UserName, PassWord).Tables[0].Rows[0][0].ToString();
                ImageUser = UserController.ImageUser(UserName).Tables[0].Rows[0][0].ToString();
                if (ImageUser != "")
                {
                    string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesUser\";
                    string FileName = appPath + ImageUser;
                    btnAccount.Image = Image.FromFile(FileName);
                }
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
                this.btnStatistic.Visible = true;
            }
            if (Role == "Seller")
            {
                this.btnImportItem.Visible = true;
                this.btnManagement.Visible = true;
                this.pnManagement.Height = 56;
                this.btnStatistic.Visible = true;
            }
            if (Role == "Customer")
            {
                this.btnStatistic.Visible = true;
            }
            int xptb = 65;
            int xbtn = 65;
            int xlbl = 111;
            int count = 0;
            dtItem = HomeController.ShowItem(UserName).Tables[0];
            countPaging = dtItem.Rows.Count / 6;
            this.lblShowPage.Text =  "1 / " + countPaging.ToString();
            while (count < 6 && count < dtItem.Rows.Count)
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
                btn.Font = new Font("Tahoma", 10, FontStyle.Bold);
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
            countPaging = i;
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
                    this.lblShowCart.Text = OrderItemsController.ShowTotalDetails(UserName, PassWord).Tables[0].Rows[0][0].ToString();
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
                while (i < 6 && i < dtItem.Rows.Count)
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
                    btn.Font = new Font("Tahoma", 10, FontStyle.Bold);
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
                while (i < 6 && index < dtItem.Rows.Count)
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
                    btn.Font = new Font("Tahoma", 10, FontStyle.Bold);
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
            this.lblShowPage.Text = btnPagingTemp.Text + " / " + countPaging.ToString();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignIn frmSignIn = new frmSignIn();
            frmSignIn.ShowDialog();
            this.Show();
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
                this.Hide();
                frmShoppingCart frmCart = new frmShoppingCart(UserName, PassWord);
                frmCart.ShowDialog();
                this.lblShowCart.Text = OrderItemsController.ShowTotalDetails(UserName, PassWord).Tables[0].Rows[0][0].ToString();
                this.Show();
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
            frmVegetableShop frm = new frmVegetableShop("", "", "");
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

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStatistic frmStatistic = new frmStatistic(UserName, PassWord);
            frmStatistic.ShowDialog();
            this.Show();
        }

        private void btnProductCategory_Click(object sender, EventArgs e)
        {
            int ybtn = 4;
            if (flaqMenuCategory == true)
            {
                this.pnCategory.Visible = true;
                flaqMenuCategory = false;
            }
            else
            {
                this.pnCategory.Visible = false;
                this.pnPanel.Visible = false;
                flaqMenuCategory = true;
            }
            DataTable dtCategory = AdminSettingController.Category_Show().Tables[0];
            int count = 0;
            foreach (DataRow dr in dtCategory.Rows)
            {
                Guna.UI.WinForms.GunaButton btnCategory = new Guna.UI.WinForms.GunaButton();
                btnCategory.Location = new Point(3, ybtn);
                btnCategory.Size = new Size(215, 35);
                btnCategory.Animated = true;
                btnCategory.BackColor = Color.Transparent;
                btnCategory.BaseColor = Color.Silver;
                btnCategory.BorderColor = Color.Black;
                btnCategory.ForeColor = Color.Black;
                btnCategory.BorderSize = 1;
                btnCategory.Cursor = Cursors.Hand;
                btnCategory.Font = new Font("Tahoma", 13, FontStyle.Bold);
                btnCategory.Image = null;
                btnCategory.OnHoverBaseColor = Color.DarkGray;
                btnCategory.Radius = 5;
                btnCategory.TextAlign = HorizontalAlignment.Center;
                btnCategory.Text = dr["CategoryName"].ToString();
                btnCategory.Click += BtnCategory_Click;
                btnCategory.DoubleClick += BtnCategory_DoubleClick;
                ybtn += 34;
                pnCategory.Controls.Add(btnCategory);
                count++;
            }
            pnCategory.Height = 36 * count;
        }

        private void BtnCategory_DoubleClick(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton btntemp = sender as Guna.UI.WinForms.GunaButton;
            string ItemName = btntemp.Text.Trim();
            this.pnCategory.Visible = false;
            this.pnPanel.Visible = false;
            flaqMenuCategory = true;
            int xptb = 65;
            int xbtn = 65;
            int xlbl = 111;
            int count = 0;
            dtItem.Clear();
            dtItem = HomeController.FindItems_Category(ItemName).Tables[0];
            pnItems.Controls.Clear();
            countPaging = dtItem.Rows.Count / 6;
            
            if(countPaging < 1)
            {
                this.lblShowPage.Visible = false;
                this.lblPage.Visible = false;
            }
            else
            {
                this.lblShowPage.Visible = true;
                this.lblPage.Visible = true;
            }    
            this.lblShowPage.Text = "1 / " + countPaging.ToString();

            while (count < 6 && count < dtItem.Rows.Count)
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
                btn.Font = new Font("Tahoma", 10, FontStyle.Bold);
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

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            pnPanel.Controls.Clear();
            this.pnPanel.Visible = true;
            Guna.UI.WinForms.GunaButton btn = sender as Guna.UI.WinForms.GunaButton;
            Guna.UI.WinForms.GunaPanel pn = new Guna.UI.WinForms.GunaPanel();
            string CategoryName = btn.Text;
            if (CategoryName == "Rau")
            {
                pn.Location = new Point(3, 4);
                pnPanel.Location = new Point(233, 215);
            }
            if (CategoryName == "Củ")
            {
                pn.Location = new Point(3, 4);//38);
                pnPanel.Location = new Point(233, 249);
            }
            if (CategoryName == "Quả")
            {
                pn.Location = new Point(3, 4);//72);
                pnPanel.Location = new Point(233, 283);
            }
            if (CategoryName == "Hạt giống")
            {
                pn.Location = new Point(3, 4);//106);
                pnPanel.Location = new Point(233, 317);
            }
            if (CategoryName == "Phân bón")
            {
                pn.Location = new Point(3, 4);//140);
                pnPanel.Location = new Point(233, 351);
            }

            string IDCategory = AdminSettingController.IDCategory_Find(CategoryName).Tables[0].Rows[0][0].ToString();
            DataTable dtSubCategory = AdminSettingController.SubCategory_Show(IDCategory).Tables[0];
            pn.BackColor = Color.Silver;
            pn.Width = 217;

            pnPanel.Controls.Add(pn);
            int ybtn = 0;
            int count = 0;
            foreach (DataRow dr in dtSubCategory.Rows)
            {
                Guna.UI.WinForms.GunaButton btnSubCategory = new Guna.UI.WinForms.GunaButton();
                btnSubCategory.Location = new Point(0, ybtn);
                btnSubCategory.Size = new Size(215, 35);
                btnSubCategory.Animated = true;
                btnSubCategory.BackColor = Color.Transparent;
                btnSubCategory.BaseColor = Color.Silver;
                btnSubCategory.BorderColor = Color.Black;
                btnSubCategory.ForeColor = Color.Black;
                btnSubCategory.BorderSize = 1;
                btnSubCategory.Cursor = Cursors.Hand;
                btnSubCategory.Font = new Font("Tahoma", 13, FontStyle.Bold);
                btnSubCategory.Image = null;
                btnSubCategory.OnHoverBaseColor = Color.DarkGray;
                btnSubCategory.Radius = 5;
                btnSubCategory.TextAlign = HorizontalAlignment.Center;
                btnSubCategory.Text = dr["SubCategoryName"].ToString();
                btnSubCategory.Click += BtnSubCategory_Click;
                ybtn += 34;
                count++;
                pn.Controls.Add(btnSubCategory);
            }
            pn.Height = 35 * count;
            pnPanel.Height = 37 * count;
        }

        private void BtnSubCategory_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton btntemp = sender as Guna.UI.WinForms.GunaButton;
            string ItemName = btntemp.Text.Trim();

            int xptb = 65;
            int xbtn = 65;
            int xlbl = 111;
            int count = 0;
            dtItem.Clear();
            dtItem = HomeController.FindItems_SubCategory(ItemName).Tables[0];
            pnItems.Controls.Clear();
            countPaging = dtItem.Rows.Count / 6;

            if (countPaging < 1)
            {
                this.lblShowPage.Visible = false;
                this.lblPage.Visible = false;
            }
            else
            {
                this.lblShowPage.Visible = true;
                this.lblPage.Visible = true;
            }
            this.lblShowPage.Text = "1 / " + countPaging.ToString();

            while (count < 6 && count < dtItem.Rows.Count)
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
                btn.Font = new Font("Tahoma", 10, FontStyle.Bold);
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
            this.pnPanel.Visible = false;
            this.pnCategory.Visible = false;
            flaqMenuCategory = true;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ItemName = txtSearch.Text.Trim();

            int xptb = 65;
            int xbtn = 65;
            int xlbl = 111;
            int count = 0;
            dtItem.Clear();
            dtItem = HomeController.FindItems_ItemName(ItemName).Tables[0];
            pnItems.Controls.Clear();
            while (count < 6 && count < dtItem.Rows.Count)
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
                btn.Font = new Font("Tahoma", 10, FontStyle.Bold);
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
    }
}
