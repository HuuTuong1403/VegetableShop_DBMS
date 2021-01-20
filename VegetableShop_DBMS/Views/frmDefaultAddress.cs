using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetableShop_DBMS.Controller;

namespace VegetableShop_DBMS.Views
{
    public partial class frmDefaultAddress : Form
    {
        string err;
        private bool flaqNewAddress = true;
        public string UserName;
        public string DefaultAddress;
        public frmDefaultAddress(string UserName, string DefaultAddress)
        {
            this.UserName = UserName;
            this.DefaultAddress = DefaultAddress;        
            InitializeComponent();
            this.cbbDefalutAddress.Text = DefaultAddress;
        }

        private void lblAddNewAddress_MouseHover(object sender, EventArgs e)
        {
            this.lblAddNewAddress.Font = new Font(lblAddNewAddress.Font, FontStyle.Bold);
        }

        private void lblAddNewAddress_MouseLeave(object sender, EventArgs e)
        {
            this.lblAddNewAddress.Font = new Font(lblAddNewAddress.Font, FontStyle.Regular);
        }

        private void lblAddNewAddress_MouseClick(object sender, MouseEventArgs e)
        {
            if (flaqNewAddress == true)
            {
                this.pnNewAddress.Visible = true;
                this.Height = 706;
                flaqNewAddress = false;
            }
            else
            {
                this.pnNewAddress.Visible = false;
                this.Height = 328;
                flaqNewAddress = true;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.pnNewAddress.Visible = false;
            this.Height = 328;
            flaqNewAddress = true;
            this.txtFullName.Clear();
            this.txtPhone.Clear();
            this.cbbProvince.Text = "Chọn Tỉnh/Thành phố";
            this.cbbProvince.Items.Clear();
            this.cbbDistrict.Text = "Chọn Quận/Huyện";
            this.cbbDistrict.Items.Clear();
            this.cbbWard.Text = "Chọn Phường/Xã";
            this.cbbWard.Items.Clear();
            this.txtStreet.Clear();
        }

        private void cbbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ProvinceNametemp = cbbProvince.SelectedItem.ToString();
            string ProvinceName = "";
            if (ProvinceNametemp.Contains("Tỉnh"))
            {
                ProvinceName = ProvinceNametemp.Substring(5);
            }
            if (ProvinceNametemp.Contains("Thành Phố"))
            {
                ProvinceName = ProvinceNametemp.Substring(10);
            }
            DataTable dt = SignUpController.IDProvince_Find(ProvinceName).Tables[0];
            string IDTemp = dt.Rows[0][0].ToString();
            int ID = int.Parse(IDTemp);

            DataTable District = SignUpController.District_Show(ID).Tables[0];
            cbbDistrict.Items.Clear();
            foreach (DataRow dr in District.Rows)
            {
                string temp = dr["DistrictName"].ToString();
                cbbDistrict.Items.Add(temp);
            }
        }

        private void cbbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DistrictNametemp = cbbDistrict.SelectedItem.ToString();
            string DistrictName = "";
            if (DistrictNametemp.Contains("Thành Phố"))
            {
                DistrictName = DistrictNametemp.Substring(10);
            }
            if (DistrictNametemp.Contains("Huyện"))
            {
                DistrictName = DistrictNametemp.Substring(6);
            }
            if (DistrictNametemp.Contains("Quận"))
            {
                DistrictName = DistrictNametemp.Substring(5);
            }
            if (DistrictNametemp.Contains("Thị Xã"))
            {
                DistrictName = DistrictNametemp.Substring(7);
            }
            DataTable dt = SignUpController.IDDistrict_Find(DistrictName).Tables[0];
            string IDTemp = dt.Rows[0][0].ToString();
            int ID = int.Parse(IDTemp);

            DataTable Ward = SignUpController.Ward_Show(ID).Tables[0];
            cbbWard.Items.Clear();
            foreach (DataRow dr in Ward.Rows)
            {
                string temp = dr["WardName"].ToString();
                cbbWard.Items.Add(temp);
            }
        }

        private void cbbProvince_Click(object sender, EventArgs e)
        {
            DataSet dataSet = SignUpController.Province_Show();
            DataTable dt = new DataTable();
            dt = dataSet.Tables[0] as DataTable;
            cbbProvince.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string temp = dr["ProvinceName"].ToString();
                cbbProvince.Items.Add(temp);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DataTable dtIDUser = OrderItemsController.IDUser_Find(UserName).Tables[0];
            string IDUser = dtIDUser.Rows[0][0].ToString();

            string FullName = txtFullName.Text;
            string PhoneNumber = txtPhone.Text;
            string Province = cbbProvince.SelectedItem.ToString();
            string District = cbbDistrict.SelectedItem.ToString();
            string Ward = cbbWard.SelectedItem.ToString();
            string Street = txtStreet.Text;

            bool check = OrderItemsController.Add_AddressForUser(IDUser, Province, District, Ward, Street, PhoneNumber, FullName, ref err);
            if (check == true)
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Bạn đã thêm địa chỉ khác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    this.txtFullName.Clear();
                    this.txtPhone.Clear();
                    this.cbbProvince.Text = "Chọn Tỉnh/Thành phố";
                    this.cbbProvince.Items.Clear();
                    this.cbbDistrict.Text = "Chọn Quận/Huyện";
                    this.cbbDistrict.Items.Clear();
                    this.cbbWard.Text = "Chọn Phường/Xã";
                    this.cbbWard.Items.Clear();
                    this.txtStreet.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm địa chỉ khác thất bại, xin thử lại lần nữa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbbDefalutAddress_Click(object sender, EventArgs e)
        {
            DataTable dtIDUser = OrderItemsController.IDUser_Find(UserName).Tables[0];
            string IDUser = dtIDUser.Rows[0][0].ToString();
            cbbDefalutAddress.Items.Clear();
            DataTable dtAddress_User = OrderItemsController.All_Address_Show(IDUser).Tables[0];
            foreach (DataRow dr in dtAddress_User.Rows)
            {
                string temp = dr["Street"].ToString() + ", " + dr["Ward"].ToString() + ", " + dr["District"].ToString() + ", " + dr["Province"].ToString();
                cbbDefalutAddress.Items.Add(temp);
            }
        }
    }
}
