
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
            this.cbbItems = new System.Windows.Forms.ComboBox();
            this.btnImportItem = new Guna.UI.WinForms.GunaButton();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtUserName = new Guna.UI.WinForms.GunaTextBox();
            this.lblPassword = new Guna.UI.WinForms.GunaLabel();
            this.lblAccount = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoScroll = true;
            this.gunaPanel1.Controls.Add(this.cbbItems);
            this.gunaPanel1.Controls.Add(this.btnImportItem);
            this.gunaPanel1.Controls.Add(this.txtQuantity);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.txtUserName);
            this.gunaPanel1.Controls.Add(this.lblPassword);
            this.gunaPanel1.Controls.Add(this.lblAccount);
            this.gunaPanel1.Location = new System.Drawing.Point(183, 186);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(485, 275);
            this.gunaPanel1.TabIndex = 31;
            // 
            // cbbItems
            // 
            this.cbbItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbItems.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbItems.ForeColor = System.Drawing.Color.Gray;
            this.cbbItems.FormattingEnabled = true;
            this.cbbItems.Location = new System.Drawing.Point(166, 76);
            this.cbbItems.Name = "cbbItems";
            this.cbbItems.Size = new System.Drawing.Size(294, 27);
            this.cbbItems.TabIndex = 70;
            this.cbbItems.Text = "Chọn món ăn";
            this.cbbItems.Click += new System.EventHandler(this.cbbItems_Click);
            // 
            // btnImportItem
            // 
            this.btnImportItem.Animated = true;
            this.btnImportItem.AnimationHoverSpeed = 0.07F;
            this.btnImportItem.AnimationSpeed = 0.03F;
            this.btnImportItem.BackColor = System.Drawing.Color.Transparent;
            this.btnImportItem.BaseColor = System.Drawing.Color.Silver;
            this.btnImportItem.BorderColor = System.Drawing.Color.Black;
            this.btnImportItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImportItem.FocusedColor = System.Drawing.Color.Empty;
            this.btnImportItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportItem.ForeColor = System.Drawing.Color.Black;
            this.btnImportItem.Image = null;
            this.btnImportItem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImportItem.Location = new System.Drawing.Point(56, 194);
            this.btnImportItem.Name = "btnImportItem";
            this.btnImportItem.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnImportItem.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnImportItem.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnImportItem.OnHoverImage = null;
            this.btnImportItem.OnPressedColor = System.Drawing.Color.Black;
            this.btnImportItem.Radius = 10;
            this.btnImportItem.Size = new System.Drawing.Size(405, 51);
            this.btnImportItem.TabIndex = 69;
            this.btnImportItem.Text = "NHẬP HÀNG";
            this.btnImportItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImportItem.Click += new System.EventHandler(this.btnImportItem_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantity.BaseColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.Transparent;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(167, 134);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.Radius = 5;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(294, 35);
            this.txtQuantity.TabIndex = 51;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
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
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BaseColor = System.Drawing.Color.LightGray;
            this.txtUserName.BorderColor = System.Drawing.Color.Transparent;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserName.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtUserName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(167, 16);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.Radius = 5;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(294, 35);
            this.txtUserName.TabIndex = 47;
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
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(52, 23);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(121, 30);
            this.lblAccount.TabIndex = 45;
            this.lblAccount.Text = "Tài khoản:";
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
            this.MaximizeBox = false;
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
        private Guna.UI.WinForms.GunaButton btnImportItem;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtUserName;
        private Guna.UI.WinForms.GunaLabel lblPassword;
        private Guna.UI.WinForms.GunaLabel lblAccount;
        private System.Windows.Forms.ComboBox cbbItems;
    }
}