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
        public frmStatistic(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
            InitializeComponent();
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
    }
}
