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
    public partial class frmImportItemsManagement : Form
    {
        public string UserName;
        public string PassWord;
        public frmImportItemsManagement(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
            InitializeComponent();
            DataTable dtImportDetailsManagement = ManagementController.ImportDetailsManagement(UserName, PassWord).Tables[0];
            foreach(DataRow dr in dtImportDetailsManagement.Rows)
            {
                string ItemName = dr["ItemName"].ToString();
                string Account = dr["UserName"].ToString();
                string Quantity = dr["Quantity"].ToString();
                string Time = dr["Time"].ToString();
                dtGVImportItemsManagement.Rows.Add(ItemName, Account, Quantity, Time);
            }
        }
    }
}
