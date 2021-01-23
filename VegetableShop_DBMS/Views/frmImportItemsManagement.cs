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
        public frmImportItemsManagement()
        {
            InitializeComponent();
            DataTable dtImportDetailsManagement = ManagementController.ImportDetailsManagement().Tables[0];
            foreach(DataRow dr in dtImportDetailsManagement.Rows)
            {
                string ItemName = dr["ItemName"].ToString();
                string UserName = dr["UserName"].ToString();
                string Quantity = dr["Quantity"].ToString();
                string Time = dr["Time"].ToString();
                dtGVImportItemsManagement.Rows.Add(ItemName, UserName, Quantity, Time);
            }
        }
    }
}
