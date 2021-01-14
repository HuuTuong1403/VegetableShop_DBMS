
namespace VegetableShop_DBMS
{
    partial class frmVegetableShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVegetableShop));
            this.ptBImage = new Guna.UI.WinForms.GunaPictureBox();
            this.btnSignIn = new Guna.UI.WinForms.GunaButton();
            this.btnSignUp = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptBImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptBImage
            // 
            this.ptBImage.BaseColor = System.Drawing.Color.White;
            this.ptBImage.Location = new System.Drawing.Point(12, 153);
            this.ptBImage.Name = "ptBImage";
            this.ptBImage.Size = new System.Drawing.Size(770, 389);
            this.ptBImage.TabIndex = 0;
            this.ptBImage.TabStop = false;
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
            this.btnSignIn.Location = new System.Drawing.Point(403, 12);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSignIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignIn.OnHoverImage = null;
            this.btnSignIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignIn.Radius = 10;
            this.btnSignIn.Size = new System.Drawing.Size(102, 42);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.AnimationHoverSpeed = 0.07F;
            this.btnSignUp.AnimationSpeed = 0.03F;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BaseColor = System.Drawing.Color.Silver;
            this.btnSignUp.BorderColor = System.Drawing.Color.Black;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnSignUp.Image = null;
            this.btnSignUp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignUp.Location = new System.Drawing.Point(511, 12);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSignUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignUp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignUp.OnHoverImage = null;
            this.btnSignUp.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignUp.Radius = 10;
            this.btnSignUp.Size = new System.Drawing.Size(86, 42);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Đăng kí";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(145, 135);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 9;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmVegetableShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.ptBImage);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVegetableShop";
            this.Text = "Vegetable Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptBImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox ptBImage;
        private Guna.UI.WinForms.GunaButton btnSignIn;
        private Guna.UI.WinForms.GunaButton btnSignUp;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}

