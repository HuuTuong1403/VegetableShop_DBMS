using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetableShop_DBMS.Controllers;


namespace VegetableShop_DBMS.Views
{
    public partial class frmInformationAccount : Form
    {
        string UserName;
        string ImageNameEdit = "1";
        string ImageTemp;
        string err;
        public frmInformationAccount(string UserName)
        {
            this.UserName = UserName;
            InitializeComponent();
            ImageTemp = UserController.ImageUser(UserName).Tables[0].Rows[0][0].ToString();
            DataTable dataTable = UserController.User_Infor(UserName).Tables[0];
            DataRow dr = dataTable.Rows[0];
            txtAccount.Text = dr["UserName"].ToString();
            txtAccount.ReadOnly = true;
            txtFullName.Text = dr["FullName"].ToString();
            txtPhone.Text = dr["PhoneNumber"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            cbbGender.SelectedItem = dr["Gender"].ToString();
            dtpDateOfBirth.Value = DateTime.Parse(dr["DateofBirth"].ToString());
            if (ImageTemp != "")
            {
                string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesUser\";
                string FileName = appPath + ImageTemp;
                ptBImageUser.Image = Image.FromFile(FileName);
                ptBImageUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void frmInformationAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select a Image";
            openFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesUser\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ImageNameEdit = openFile.SafeFileName;
                string filepath = openFile.FileName;
                string fileName = appPath + ImageNameEdit;
                if (File.Exists(fileName) == false)
                {
                    File.Copy(filepath, fileName);
                    ptbImageEdit.Image = new Bitmap(fileName);
                }
                else
                {
                    MessageBox.Show("Hình ảnh bạn chọn bị trùng. Vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveInfor_Click(object sender, EventArgs e)
        {
            string UserName = txtAccount.Text.Trim();
            string FullName = txtFullName.Text.Trim();
            string Gender = cbbGender.SelectedItem.ToString();
            DateTime DateofBirth = dtpDateOfBirth.Value;
            string PhoneNumber = txtPhone.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string ImageName = "";
            if (ImageNameEdit == "1")
            {
                ImageName = ImageTemp;
            }
            else
            {
                ImageName = ImageNameEdit;
            }
            bool check = UserController.EditUser(UserName, FullName, Gender, DateofBirth, PhoneNumber, Email, ImageName, ref err);
            if (check == true)
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Bạn đã chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    DataTable dataTable = UserController.User_Infor(UserName).Tables[0];
                    DataRow dr = dataTable.Rows[0];
                    txtAccount.Text = dr["UserName"].ToString();
                    txtAccount.ReadOnly = true;
                    txtFullName.Text = dr["FullName"].ToString();
                    txtPhone.Text = dr["PhoneNumber"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    cbbGender.SelectedItem = dr["Gender"].ToString();
                    dtpDateOfBirth.Value = DateTime.Parse(dr["DateofBirth"].ToString());
                    ImageTemp = UserController.ImageUser(UserName).Tables[0].Rows[0][0].ToString();
                    if (ImageTemp != "")
                    {
                        string appPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\images\imagesUser\";
                        string FileName = appPath + ImageTemp;
                        ptBImageUser.Image = Image.FromFile(FileName);
                        ptBImageUser.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại, xin thử lại lần nữa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
