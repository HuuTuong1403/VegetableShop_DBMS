
namespace VegetableShop_DBMS.Views
{
    partial class frmImportItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportItem));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblAccount = new Guna.UI.WinForms.GunaLabel();
            this.lblPassword = new Guna.UI.WinForms.GunaLabel();
            this.txtItemName = new Guna.UI.WinForms.GunaTextBox();
            this.txtImportPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtSalePrice = new Guna.UI.WinForms.GunaTextBox();
            this.btnRegister = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoScroll = true;
            this.gunaPanel1.Controls.Add(this.btnRegister);
            this.gunaPanel1.Controls.Add(this.txtSalePrice);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.txtImportPrice);
            this.gunaPanel1.Controls.Add(this.txtItemName);
            this.gunaPanel1.Controls.Add(this.lblPassword);
            this.gunaPanel1.Controls.Add(this.lblAccount);
            this.gunaPanel1.Location = new System.Drawing.Point(183, 186);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(485, 275);
            this.gunaPanel1.TabIndex = 31;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(344, 150);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(181, 33);
            this.gunaLabel1.TabIndex = 28;
            this.gunaLabel1.Text = "NHẬP HÀNG";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(197, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(598, 119);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 30;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(126, 119);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 29;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(52, 23);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(121, 30);
            this.lblAccount.TabIndex = 45;
            this.lblAccount.Text = "Tài khoản:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(56, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 46;
            this.lblPassword.Text = "Tên món:";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.Transparent;
            this.txtItemName.BaseColor = System.Drawing.Color.White;
            this.txtItemName.BorderColor = System.Drawing.Color.Transparent;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItemName.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtItemName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItemName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(167, 16);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.Radius = 5;
            this.txtItemName.SelectedText = "";
            this.txtItemName.Size = new System.Drawing.Size(294, 35);
            this.txtItemName.TabIndex = 47;
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtImportPrice.BaseColor = System.Drawing.Color.White;
            this.txtImportPrice.BorderColor = System.Drawing.Color.Transparent;
            this.txtImportPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImportPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtImportPrice.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtImportPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtImportPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportPrice.Location = new System.Drawing.Point(167, 69);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.PasswordChar = '\0';
            this.txtImportPrice.Radius = 5;
            this.txtImportPrice.SelectedText = "";
            this.txtImportPrice.Size = new System.Drawing.Size(294, 36);
            this.txtImportPrice.TabIndex = 48;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(56, 134);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(121, 30);
            this.gunaLabel3.TabIndex = 49;
            this.gunaLabel3.Text = "Số lượng:";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.txtSalePrice.BaseColor = System.Drawing.Color.White;
            this.txtSalePrice.BorderColor = System.Drawing.Color.Transparent;
            this.txtSalePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalePrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSalePrice.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtSalePrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSalePrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(167, 134);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PasswordChar = '\0';
            this.txtSalePrice.Radius = 5;
            this.txtSalePrice.SelectedText = "";
            this.txtSalePrice.Size = new System.Drawing.Size(294, 35);
            this.txtSalePrice.TabIndex = 51;
            // 
            // btnRegister
            // 
            this.btnRegister.Animated = true;
            this.btnRegister.AnimationHoverSpeed = 0.07F;
            this.btnRegister.AnimationSpeed = 0.03F;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BaseColor = System.Drawing.Color.Silver;
            this.btnRegister.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegister.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Image = null;
            this.btnRegister.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegister.Location = new System.Drawing.Point(56, 194);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnRegister.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRegister.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnRegister.OnHoverImage = null;
            this.btnRegister.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegister.Radius = 10;
            this.btnRegister.Size = new System.Drawing.Size(405, 51);
            this.btnRegister.TabIndex = 69;
            this.btnRegister.Text = "NHẬP HÀNG";
            this.btnRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmImportItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(820, 482);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnRegister;
        private Guna.UI.WinForms.GunaTextBox txtSalePrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtImportPrice;
        private Guna.UI.WinForms.GunaTextBox txtItemName;
        private Guna.UI.WinForms.GunaLabel lblPassword;
        private Guna.UI.WinForms.GunaLabel lblAccount;
    }
}