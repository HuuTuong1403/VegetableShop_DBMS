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
    public partial class frmOrderManagement : Form
    {
        public string UserName;
        public Image image;
        public frmOrderManagement(string UserName)
        {
            this.UserName = UserName;
            InitializeComponent();
            
            this.btnAll.BaseColor = Color.DarkGray;
            DataTable dtAll = ManagementController.OrderManagement(UserName, "Tất cả").Tables[0];
            int count = 0;
            foreach(DataRow dr in dtAll.Rows)
            {
                string ImageTemp = dr["Image"].ToString();
                string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesProduct\";
                string FileName = appPath + ImageTemp;
                image = Image.FromFile(FileName);
                image = new Bitmap(image, new Size(70, 70));
                string ItemName = dr["ItemName"].ToString();
                string Description = dr["Description"].ToString();
                string Quantity = dr["Quantity"].ToString();
                string PaidPrice = dr["PaidPrice"].ToString() + "₫";
                string UserNameTemp = dr["UserName"].ToString();
                dtGVOrderManagement.Rows.Add(image, ItemName, Description, Quantity, PaidPrice, UserNameTemp);
                count++;
            }
            this.lblAll.Text = count.ToString();
        }

        private void btnPreparing_Click(object sender, EventArgs e)
        {
            this.btnAll.BaseColor = Color.Silver;
            this.btnPreparing.BaseColor = Color.DarkGray;
            this.btnDelivering.BaseColor = Color.Silver;
            this.btnPaid.BaseColor = Color.Silver;
            this.btnCompletion.BaseColor = Color.Silver;
            this.btnRefund.BaseColor = Color.Silver;
            this.btnCancel.BaseColor = Color.Silver;
            dtGVOrderManagement.Rows.Clear();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.btnAll.BaseColor = Color.DarkGray;
            this.btnPreparing.BaseColor = Color.Silver;
            this.btnDelivering.BaseColor = Color.Silver;
            this.btnPaid.BaseColor = Color.Silver;
            this.btnCompletion.BaseColor = Color.Silver;
            this.btnRefund.BaseColor = Color.Silver;
            this.btnCancel.BaseColor = Color.Silver;

            DataTable dtAll = ManagementController.OrderManagement(UserName, "Tất cả").Tables[0];
            int count = 0;
            foreach (DataRow dr in dtAll.Rows)
            {
                string ImageTemp = dr["Image"].ToString();
                string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesProduct\";
                string FileName = appPath + ImageTemp;
                image = Image.FromFile(FileName);
                image = new Bitmap(image, new Size(70, 70));
                string ItemName = dr["ItemName"].ToString();
                string Description = dr["Description"].ToString();
                string Quantity = dr["Quantity"].ToString();
                string PaidPrice = dr["PaidPrice"].ToString() + "₫";
                string UserNameTemp = dr["UserName"].ToString();
                dtGVOrderManagement.Rows.Add(image, ItemName, Description, Quantity, PaidPrice, UserNameTemp);
                count++;
            }
            this.lblAll.Text = count.ToString();
        }

        private void btnDelivering_Click(object sender, EventArgs e)
        {
            this.btnAll.BaseColor = Color.Silver;
            this.btnPreparing.BaseColor = Color.Silver;
            this.btnDelivering.BaseColor = Color.DarkGray;
            this.btnPaid.BaseColor = Color.Silver;
            this.btnCompletion.BaseColor = Color.Silver;
            this.btnRefund.BaseColor = Color.Silver;
            this.btnCancel.BaseColor = Color.Silver;

            dtGVOrderManagement.Rows.Clear();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            this.btnAll.BaseColor = Color.Silver;
            this.btnPreparing.BaseColor = Color.Silver;
            this.btnDelivering.BaseColor = Color.Silver;
            this.btnPaid.BaseColor = Color.DarkGray;
            this.btnCompletion.BaseColor = Color.Silver;
            this.btnRefund.BaseColor = Color.Silver;
            this.btnCancel.BaseColor = Color.Silver;

            dtGVOrderManagement.Rows.Clear();
        }

        private void btnCompletion_Click(object sender, EventArgs e)
        {
            this.btnAll.BaseColor = Color.Silver;
            this.btnPreparing.BaseColor = Color.Silver;
            this.btnDelivering.BaseColor = Color.Silver;
            this.btnPaid.BaseColor = Color.Silver;
            this.btnCompletion.BaseColor = Color.DarkGray;
            this.btnRefund.BaseColor = Color.Silver;
            this.btnCancel.BaseColor = Color.Silver;

            dtGVOrderManagement.Rows.Clear();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            this.btnAll.BaseColor = Color.Silver;
            this.btnPreparing.BaseColor = Color.Silver;
            this.btnDelivering.BaseColor = Color.Silver;
            this.btnPaid.BaseColor = Color.Silver;
            this.btnCompletion.BaseColor = Color.Silver;
            this.btnRefund.BaseColor = Color.DarkGray;
            this.btnCancel.BaseColor = Color.Silver;

            dtGVOrderManagement.Rows.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnAll.BaseColor = Color.Silver;
            this.btnPreparing.BaseColor = Color.Silver;
            this.btnDelivering.BaseColor = Color.Silver;
            this.btnPaid.BaseColor = Color.Silver;
            this.btnCompletion.BaseColor = Color.Silver;
            this.btnRefund.BaseColor = Color.Silver;
            this.btnCancel.BaseColor = Color.DarkGray;

            dtGVOrderManagement.Rows.Clear();
        }
    }
}
