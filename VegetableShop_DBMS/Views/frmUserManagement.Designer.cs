
namespace VegetableShop_DBMS.Views
{
    partial class frmUserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManagement));
            this.btnDeleteUser = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtGVUserManagement = new System.Windows.Forms.DataGridView();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVUserManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AnimationHoverSpeed = 0.07F;
            this.btnDeleteUser.AnimationSpeed = 0.03F;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.BaseColor = System.Drawing.Color.Silver;
            this.btnDeleteUser.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteUser.Location = new System.Drawing.Point(614, 487);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.OnHoverImage = null;
            this.btnDeleteUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Radius = 10;
            this.btnDeleteUser.Size = new System.Drawing.Size(173, 42);
            this.btnDeleteUser.TabIndex = 29;
            this.btnDeleteUser.Text = "Xóa người dùng";
            this.btnDeleteUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(189, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(598, 119);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 27;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(11, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(126, 119);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 26;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(252, 145);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(331, 33);
            this.gunaLabel1.TabIndex = 25;
            this.gunaLabel1.Text = "QUẢN LÝ NGƯỜI DÙNG";
            // 
            // dtGVUserManagement
            // 
            this.dtGVUserManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVUserManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVUserManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clUserName,
            this.clFullName,
            this.clGender,
            this.clDOB,
            this.clPhoneNumber,
            this.clEmail,
            this.clRole});
            this.dtGVUserManagement.Location = new System.Drawing.Point(2, 193);
            this.dtGVUserManagement.Name = "dtGVUserManagement";
            this.dtGVUserManagement.RowHeadersWidth = 51;
            this.dtGVUserManagement.Size = new System.Drawing.Size(796, 288);
            this.dtGVUserManagement.TabIndex = 24;
            this.dtGVUserManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVUserManagement_CellClick);
            // 
            // clUserName
            // 
            this.clUserName.HeaderText = "Tên tài khoản";
            this.clUserName.Name = "clUserName";
            // 
            // clFullName
            // 
            this.clFullName.HeaderText = "Họ Tên";
            this.clFullName.Name = "clFullName";
            // 
            // clGender
            // 
            this.clGender.HeaderText = "Giới tính";
            this.clGender.Name = "clGender";
            // 
            // clDOB
            // 
            this.clDOB.HeaderText = "Ngày sinh";
            this.clDOB.Name = "clDOB";
            // 
            // clPhoneNumber
            // 
            this.clPhoneNumber.HeaderText = "Số điện thoại";
            this.clPhoneNumber.Name = "clPhoneNumber";
            // 
            // clEmail
            // 
            this.clEmail.HeaderText = "Email";
            this.clEmail.Name = "clEmail";
            this.clEmail.Width = 140;
            // 
            // clRole
            // 
            this.clRole.HeaderText = "Chức vụ";
            this.clRole.Name = "clRole";
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dtGVUserManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVUserManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnDeleteUser;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridView dtGVUserManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRole;
    }
}