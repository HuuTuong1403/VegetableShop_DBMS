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
    public partial class frmStatistic : Form
    {
        public string UserName;
        public string PassWord;
        public Image image;
        public string Role;
        public frmStatistic(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
            InitializeComponent();
            this.Role = UserController.ShowRole(UserName).Tables[0].Rows[0][0].ToString();
            if(Role == "Customer")
            {
                this.btnStatisticReveneu.Visible = false;
            }
            if(Role == "Seller")
            {
                this.btnStatisticReveneu.Visible = false;
            }    
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DateTime DateStart = this.dtPickerDateStart.Value;
            DateTime DateEnd = this.dtPickerDateEnd.Value;
            this.txtShowTotalReveneu.Text = StatisticController.Sum_Revenue(UserName, PassWord, DateStart, DateEnd).Tables[0].Rows[0][0].ToString() + "₫";
            this.txtShowTotalQuantity.Text = StatisticController.Sum_QuantityRevenue(UserName, PassWord, DateStart, DateEnd).Tables[0].Rows[0][0].ToString();
            DataTable dtReveneu = StatisticController.Statistic_Revenue(UserName, PassWord, DateStart, DateEnd).Tables[0];
            dtGVReveneuStatistic.Rows.Clear();
            foreach(DataRow dr in dtReveneu.Rows)
            {
                string Account = dr["UserName"].ToString();
                string TotalQuantity = dr["TotalQuantity"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString() + "₫";
                string Time = dr["Time"].ToString();
                dtGVReveneuStatistic.Rows.Add(Account, TotalQuantity, TotalPrice, Time);
            }
        }

        private void btnTop5BestSeller_Click(object sender, EventArgs e)
        {
            this.pnTop5BestSeller.Visible = true;
            this.pnTop5Seller.Visible = false;
            this.pnTop5Customer.Visible = false;
            this.pnStatisticReveneu.Visible = false;

            this.btnTop5BestSeller.BaseColor = Color.DarkGray;
            this.btnTop5Seller.BaseColor = Color.Silver;
            this.btnTop5Customer.BaseColor = Color.Silver;
            this.btnStatisticReveneu.BaseColor = Color.Silver;

            DataTable dtTop5BestSeller = StatisticController.Top5BestSeller().Tables[0];
            dtGVTop5BestSeller.Rows.Clear();
            foreach(DataRow dr in dtTop5BestSeller.Rows)
            {
                string ItemName = dr["ItemName"].ToString();
                string ImageTemp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesProduct\" + dr["Image"].ToString();
                image = Image.FromFile(ImageTemp);
                image = new Bitmap(image, new Size(70, 70));
                string Description = dr["Description"].ToString();
                string SalePrice = dr["SalePrice"].ToString();
                string Origin = dr["Orgin"].ToString();
                string SumOrder = dr["SumOrder"].ToString();
                dtGVTop5BestSeller.Rows.Add(ItemName, image, Description, SalePrice, Origin, SumOrder);
            }
        }

        private void btnTop5Seller_Click(object sender, EventArgs e)
        {
            this.pnTop5Seller.Visible = true;
            this.pnTop5BestSeller.Visible = false;
            this.pnTop5Customer.Visible = false;
            this.pnStatisticReveneu.Visible = false;

            this.btnTop5BestSeller.BaseColor = Color.Silver;
            this.btnTop5Seller.BaseColor = Color.DarkGray;
            this.btnTop5Customer.BaseColor = Color.Silver;
            this.btnStatisticReveneu.BaseColor = Color.Silver;

            DataTable dtTop5Seller = StatisticController.Top5Seller().Tables[0];
            dtGVTop5Seller.Rows.Clear();
            foreach(DataRow dr in dtTop5Seller.Rows)
            {
                string Account = dr["UserName"].ToString();
                string ImageTemp;
                if (dr["Image"].ToString() == "")
                {
                    ImageTemp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesUser\Default.png";
                }
                else
                    ImageTemp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesUser\" + dr["Image"].ToString();
                image = Image.FromFile(ImageTemp);
                image = new Bitmap(image, new Size(70, 70));
                string FullName = dr["FullName"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString();
                string PhoneNumber = dr["PhoneNumber"].ToString();
                string Email = dr["Email"].ToString();
                dtGVTop5Seller.Rows.Add(Account, FullName, image, TotalPrice, PhoneNumber, Email);
            }
        }
        private void btnTop5Customer_Click(object sender, EventArgs e)
        {
            this.pnTop5Seller.Visible = false;
            this.pnTop5BestSeller.Visible = false;
            this.pnTop5Customer.Visible = true;
            this.pnStatisticReveneu.Visible = false;

            this.btnTop5BestSeller.BaseColor = Color.Silver;
            this.btnTop5Seller.BaseColor = Color.Silver;
            this.btnTop5Customer.BaseColor = Color.DarkGray;
            this.btnStatisticReveneu.BaseColor = Color.Silver;

            DataTable dtTop5Customer = StatisticController.Top5Customer().Tables[0];
            dtGVTop5Customer.Rows.Clear();
            foreach (DataRow dr in dtTop5Customer.Rows)
            {
                string Account = dr["UserName"].ToString();
                string ImageTemp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesUser\" + dr["Image"].ToString();
                image = Image.FromFile(ImageTemp);
                image = new Bitmap(image, new Size(70, 70));
                string FullName = dr["FullName"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString();
                string PhoneNumber = dr["PhoneNumber"].ToString();
                string Email = dr["Email"].ToString();
                dtGVTop5Customer.Rows.Add(Account, FullName, image, TotalPrice, PhoneNumber, Email);
            }
        }

        private void btnStatisticReveneu_Click(object sender, EventArgs e)
        {
            this.pnTop5Seller.Visible = false;
            this.pnTop5BestSeller.Visible = false;
            this.pnTop5Customer.Visible = false;
            this.pnStatisticReveneu.Visible = true;

            this.btnTop5BestSeller.BaseColor = Color.Silver;
            this.btnTop5Seller.BaseColor = Color.Silver;
            this.btnTop5Customer.BaseColor = Color.Silver;
            this.btnStatisticReveneu.BaseColor = Color.DarkGray;
        }
    }
}
