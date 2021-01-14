
namespace VegetableShop_DBMS.Views.SignIn
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.txtAccount = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnSignIn = new Guna.UI.WinForms.GunaButton();
            this.lblPassword = new Guna.UI.WinForms.GunaLabel();
            this.lblAccount = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnSignUp = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.Transparent;
            this.txtAccount.BaseColor = System.Drawing.Color.White;
            this.txtAccount.BorderColor = System.Drawing.Color.Transparent;
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAccount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAccount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(179, 67);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.Radius = 5;
            this.txtAccount.SelectedText = "";
            this.txtAccount.Size = new System.Drawing.Size(294, 30);
            this.txtAccount.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(179, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 5;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(294, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(172, 14);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(181, 33);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "ĐĂNG NHẬP";
            // 
            // btnSignIn
            // 
            this.btnSignIn.AnimationHoverSpeed = 0.07F;
            this.btnSignIn.AnimationSpeed = 0.03F;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BaseColor = System.Drawing.Color.Silver;
            this.btnSignIn.BorderColor = System.Drawing.Color.Black;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Image = null;
            this.btnSignIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignIn.Location = new System.Drawing.Point(72, 169);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnSignIn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSignIn.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSignIn.OnHoverImage = null;
            this.btnSignIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignIn.Radius = 10;
            this.btnSignIn.Size = new System.Drawing.Size(401, 36);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(68, 121);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(68, 69);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(121, 30);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Tài khoản:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(144, 237);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(161, 18);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Bạn chưa có tài khoản?";
            // 
            // btnSignUp
            // 
            this.btnSignUp.AnimationHoverSpeed = 0.07F;
            this.btnSignUp.AnimationSpeed = 0.03F;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BaseColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderColor = System.Drawing.Color.Black;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignUp.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSignUp.Image = null;
            this.btnSignUp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignUp.Location = new System.Drawing.Point(302, 237);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSignUp.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSignUp.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSignUp.OnHoverImage = null;
            this.btnSignUp.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignUp.Radius = 10;
            this.btnSignUp.Size = new System.Drawing.Size(76, 18);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Đăng kí";
            this.btnSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 299);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSignIn";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtAccount;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnSignIn;
        private Guna.UI.WinForms.GunaLabel lblPassword;
        private Guna.UI.WinForms.GunaLabel lblAccount;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnSignUp;
    }
}