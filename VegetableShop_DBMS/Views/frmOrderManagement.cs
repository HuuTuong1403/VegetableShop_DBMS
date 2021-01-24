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
        public string PassWord;
        public string OrderStateNameTemp;
        public Image image;
        public string IDBill;
        public string err;
        public frmOrderManagement(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;         
            InitializeComponent();

            this.lblAll.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Tất cả").Tables[0].Rows[0][0].ToString();
            this.lblPreparing.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Preparing").Tables[0].Rows[0][0].ToString();
            this.lblDelivery.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Delivering").Tables[0].Rows[0][0].ToString();
            this.lblPaid.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Paid").Tables[0].Rows[0][0].ToString();
            this.lblCompletion.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Completion").Tables[0].Rows[0][0].ToString();
            this.lblRefund.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Refund").Tables[0].Rows[0][0].ToString();
            this.lblCancel.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Cancel").Tables[0].Rows[0][0].ToString();

            this.btnState.Visible = false;
            this.btnAll.BaseColor = Color.DarkGray;
            string Temp = "Tất cả";
            DataTable dtAll = ManagementController.OrderManagement(UserName, PassWord, Temp).Tables[0];
            int count = 0;
            foreach(DataRow dr in dtAll.Rows)
            {
                string IDBill = dr["IDBill"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString();
                string TotalQuantity = dr["TotalQuantity"].ToString();
                string OrderStateName = dr["OrderStateName"].ToString();
                string Time = dr["Time"].ToString();
                string Account = dr["Username"].ToString();
                dtGVBillManagement.Rows.Add(IDBill, Account, TotalPrice, TotalQuantity, OrderStateName, Time);
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
            this.btnState.Visible = true;

            dtGVBillManagement.Rows.Clear();
            string Temp = btnPreparing.Text;
            OrderStateNameTemp = Temp;
            DataTable dtAll = ManagementController.OrderManagement(UserName, PassWord, Temp).Tables[0];
            foreach (DataRow dr in dtAll.Rows)
            {
                string IDBill = dr["IDBill"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString();
                string TotalQuantity = dr["TotalQuantity"].ToString();
                string OrderStateName = dr["OrderStateName"].ToString();
                string Time = dr["Time"].ToString();
                string Account = dr["Username"].ToString();
                dtGVBillManagement.Rows.Add(IDBill, Account, TotalPrice, TotalQuantity, OrderStateName, Time);
            }
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
            this.btnState.Visible = false;

            dtGVBillManagement.Rows.Clear();
            string Temp = "Tất cả";
            DataTable dtAll = ManagementController.OrderManagement(UserName, PassWord, Temp).Tables[0];
            foreach (DataRow dr in dtAll.Rows)
            {
                string IDBill = dr["IDBill"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString();
                string TotalQuantity = dr["TotalQuantity"].ToString();
                string OrderStateName = dr["OrderStateName"].ToString();
                string Time = dr["Time"].ToString();
                string Account = dr["Username"].ToString();
                dtGVBillManagement.Rows.Add(IDBill, Account, TotalPrice, TotalQuantity, OrderStateName, Time);
            }
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
            this.btnState.Visible = true;

            dtGVBillManagement.Rows.Clear();
            string Temp = btnDelivering.Text;
            OrderStateNameTemp = Temp;
            DataTable dtAll = ManagementController.OrderManagement(UserName, PassWord, Temp).Tables[0];
            foreach (DataRow dr in dtAll.Rows)
            {
                string IDBill = dr["IDBill"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString();
                string TotalQuantity = dr["TotalQuantity"].ToString();
                string OrderStateName = dr["OrderStateName"].ToString();
                string Time = dr["Time"].ToString();
                string Account = dr["Username"].ToString();
                dtGVBillManagement.Rows.Add(IDBill, Account, TotalPrice, TotalQuantity, OrderStateName, Time);
            }
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
            this.btnState.Visible = true;

            dtGVBillManagement.Rows.Clear();
            string Temp = btnPaid.Text;
            OrderStateNameTemp = Temp;
            DataTable dtAll = ManagementController.OrderManagement(UserName, PassWord, Temp).Tables[0];
            foreach (DataRow dr in dtAll.Rows)
            {
                string IDBill = dr["IDBill"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString();
                string TotalQuantity = dr["TotalQuantity"].ToString();
                string OrderStateName = dr["OrderStateName"].ToString();
                string Time = dr["Time"].ToString();
                string Account = dr["Username"].ToString();
                dtGVBillManagement.Rows.Add(IDBill, Account, TotalPrice, TotalQuantity, OrderStateName, Time);
            }
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
            this.btnState.Visible = false;

            dtGVBillManagement.Rows.Clear();
            string Temp = btnCompletion.Text;
            DataTable dtAll = ManagementController.OrderManagement(UserName, PassWord, Temp).Tables[0];
            foreach (DataRow dr in dtAll.Rows)
            {
                string IDBill = dr["IDBill"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString();
                string TotalQuantity = dr["TotalQuantity"].ToString();
                string OrderStateName = dr["OrderStateName"].ToString();
                string Time = dr["Time"].ToString();
                string Account = dr["Username"].ToString();
                dtGVBillManagement.Rows.Add(IDBill, Account, TotalPrice, TotalQuantity, OrderStateName, Time);
            }
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
            this.btnState.Visible = false;

            dtGVBillManagement.Rows.Clear();
            string Temp = btnRefund.Text;
            DataTable dtAll = ManagementController.OrderManagement(UserName, PassWord, Temp).Tables[0];
            foreach (DataRow dr in dtAll.Rows)
            {
                string IDBill = dr["IDBill"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString();
                string TotalQuantity = dr["TotalQuantity"].ToString();
                string OrderStateName = dr["OrderStateName"].ToString();
                string Time = dr["Time"].ToString();
                string Account = dr["Username"].ToString();
                dtGVBillManagement.Rows.Add(IDBill, Account, TotalPrice, TotalQuantity, OrderStateName, Time);
            }
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
            this.btnState.Visible = false;

            dtGVBillManagement.Rows.Clear();
            string Temp = btnCancel.Text;
            DataTable dtAll = ManagementController.OrderManagement(UserName, PassWord, Temp).Tables[0];
            foreach (DataRow dr in dtAll.Rows)
            {
                string IDBill = dr["IDBill"].ToString();
                string TotalPrice = dr["TotalPrice"].ToString();
                string TotalQuantity = dr["TotalQuantity"].ToString();
                string OrderStateName = dr["OrderStateName"].ToString();
                string Time = dr["Time"].ToString();
                string Account = dr["Username"].ToString();
                dtGVBillManagement.Rows.Add(IDBill, Account, TotalPrice, TotalQuantity, OrderStateName, Time);
            }
        }

        private void dtGVBillManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn muốn xem đơn hàng chi tiết?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dialog == DialogResult.OK)
            {
                this.pnBillDetail.Visible = true;
                this.ptBOpacity.Visible = true;
                IDBill = dtGVBillManagement.CurrentRow.Cells["clIDBill"].Value.ToString();  
                DataTable dtBillDetail = ManagementController.OrderManagementDetail(UserName, PassWord, IDBill).Tables[0];
                dtGVBillDetailManagement.Rows.Clear();
                foreach(DataRow dr in dtBillDetail.Rows)
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
                    dtGVBillDetailManagement.Rows.Add(image, ItemName, Description, Quantity, PaidPrice);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.pnBillDetail.Visible = false;
            this.ptBOpacity.Visible = false;
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            if(IDBill == null)
            {
                MessageBox.Show("Bạn chưa chọn Bill nào để chuyển state", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool check = ManagementController.ChangeState(UserName, PassWord, IDBill, OrderStateNameTemp, ref err);
                if(check == true)
                {
                    DialogResult dialog = MessageBox.Show("Bạn đã chuyển state đơn hàng có ID: " + IDBill, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(dialog == DialogResult.OK)
                    {
                        this.lblAll.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Tất cả").Tables[0].Rows[0][0].ToString();
                        this.lblPreparing.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Preparing").Tables[0].Rows[0][0].ToString();
                        this.lblDelivery.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Delivering").Tables[0].Rows[0][0].ToString();
                        this.lblPaid.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Paid").Tables[0].Rows[0][0].ToString();
                        this.lblCompletion.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Completion").Tables[0].Rows[0][0].ToString();
                        this.lblRefund.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Refund").Tables[0].Rows[0][0].ToString();
                        this.lblCancel.Text = ManagementController.ShowCountOrder(UserName, PassWord, "Cancel").Tables[0].Rows[0][0].ToString();

                        dtGVBillManagement.Rows.Clear();
                        string Temp = OrderStateNameTemp;
                        DataTable dtAll = ManagementController.OrderManagement(UserName, PassWord, Temp).Tables[0];
                        foreach (DataRow dr in dtAll.Rows)
                        {
                            string IDBill = dr["IDBill"].ToString();
                            string TotalPrice = dr["TotalPrice"].ToString();
                            string TotalQuantity = dr["TotalQuantity"].ToString();
                            string OrderStateName = dr["OrderStateName"].ToString();
                            string Time = dr["Time"].ToString();
                            string Account = dr["Username"].ToString();
                            dtGVBillManagement.Rows.Add(IDBill, Account, TotalPrice, TotalQuantity, OrderStateName, Time);
                        }
                    }
                }
            }    
        }
    }
}
