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
    public partial class frmUserManagement : Form
    {
        public string UserName;
        public string PassWord;
        public string UserNameUser;
        public string err;
        public frmUserManagement(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
            InitializeComponent();
            DataTable dtUserManagement = ManagementController.UserManagement().Tables[0];
            foreach (DataRow dr in dtUserManagement.Rows)
            {
                string Acccount = dr["UserName"].ToString();
                string FullName = dr["Fullname"].ToString();
                string Gender = dr["Gender"].ToString();
                string DOB = dr["DateofBirth"].ToString();
                string PhoneNumber = dr["PhoneNumber"].ToString();
                string Email = dr["Email"].ToString();
                string Role = dr["Role"].ToString();
                dtGVUserManagement.Rows.Add(Acccount, FullName, Gender, DOB, PhoneNumber, Email, Role);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (UserNameUser != null)
            {
                bool check = ManagementController.DeleteUser(UserNameUser, UserName, PassWord, ref err);
                if(check == true)
                {
                    DialogResult dialogResult;
                    dialogResult = MessageBox.Show("Bạn có muốn xóa người dùng có tài khoản " + UserNameUser, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if(dialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Bạn đã xóa người dùng khỏi hệ thống thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dtUserManagement = ManagementController.UserManagement().Tables[0];
                        dtGVUserManagement.Rows.Clear();
                        foreach (DataRow dr in dtUserManagement.Rows)
                        {
                            string Account = dr["UserName"].ToString();
                            string FullName = dr["Fullname"].ToString();
                            string Gender = dr["Gender"].ToString();
                            string DOB = dr["DateofBirth"].ToString();
                            string PhoneNumber = dr["PhoneNumber"].ToString();
                            string Email = dr["Email"].ToString();
                            string Role = dr["Role"].ToString();
                            dtGVUserManagement.Rows.Add(Account, FullName, Gender, DOB, PhoneNumber, Email, Role);
                        }
                    }      
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn người dùng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void dtGVUserManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserNameUser = dtGVUserManagement.CurrentRow.Cells["clUserName"].Value.ToString();
        }
    }
}
