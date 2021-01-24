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
    public partial class frmRegisterSeller : Form
    {
        public string UserName;
        public string PassWord;
        string err;
        public frmRegisterSeller(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string UserNameSeller = txtUsername.Text.Trim();
            string PassWordSeller = txtPassword.Text.Trim();
            string FullName = txtFullName.Text.Trim();
            string Gender = cbbGender.SelectedItem.ToString();
            DateTime DateofBirth = dtpDateOfBirth.Value;
            string PhoneNumber = txtPhone.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string Image = "";

            bool check = AdminSettingController.Register_Seller(UserName, UserNameSeller, PassWord, PassWordSeller, FullName, Gender, DateofBirth, PhoneNumber, Email, Image, ref err);
            if (check == true)
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Bạn đã đăng ký nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại, xin thử lại lần nữa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
