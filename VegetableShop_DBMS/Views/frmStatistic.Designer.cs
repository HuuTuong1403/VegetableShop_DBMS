
namespace VegetableShop_DBMS.Views
{
    partial class frmStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistic));
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.pnStatistic = new Guna.UI.WinForms.GunaPanel();
            this.dtGVReveneuStatistic = new System.Windows.Forms.DataGridView();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dtPickerDateEnd = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.dtPickerDateStart = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtShowTotalReveneu = new Guna.UI.WinForms.GunaTextBox();
            this.txtShowTotalQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.btnAccept = new Guna.UI.WinForms.GunaButton();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.pnStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVReveneuStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(216, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(598, 119);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 28;
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
            this.gunaPictureBox1.TabIndex = 27;
            this.gunaPictureBox1.TabStop = false;
            // 
            // pnStatistic
            // 
            this.pnStatistic.Controls.Add(this.btnAccept);
            this.pnStatistic.Controls.Add(this.txtShowTotalQuantity);
            this.pnStatistic.Controls.Add(this.txtShowTotalReveneu);
            this.pnStatistic.Controls.Add(this.gunaLabel5);
            this.pnStatistic.Controls.Add(this.gunaLabel4);
            this.pnStatistic.Controls.Add(this.dtGVReveneuStatistic);
            this.pnStatistic.Controls.Add(this.gunaLabel3);
            this.pnStatistic.Controls.Add(this.dtPickerDateEnd);
            this.pnStatistic.Controls.Add(this.gunaLabel2);
            this.pnStatistic.Controls.Add(this.dtPickerDateStart);
            this.pnStatistic.Controls.Add(this.gunaLabel1);
            this.pnStatistic.Location = new System.Drawing.Point(12, 155);
            this.pnStatistic.Name = "pnStatistic";
            this.pnStatistic.Size = new System.Drawing.Size(917, 374);
            this.pnStatistic.TabIndex = 29;
            // 
            // dtGVReveneuStatistic
            // 
            this.dtGVReveneuStatistic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVReveneuStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVReveneuStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clUserName,
            this.clTotalRevenue,
            this.clTotalQuantity,
            this.clTime});
            this.dtGVReveneuStatistic.Location = new System.Drawing.Point(142, 195);
            this.dtGVReveneuStatistic.Name = "dtGVReveneuStatistic";
            this.dtGVReveneuStatistic.RowHeadersWidth = 51;
            this.dtGVReveneuStatistic.Size = new System.Drawing.Size(660, 176);
            this.dtGVReveneuStatistic.TabIndex = 35;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(451, 61);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(101, 19);
            this.gunaLabel3.TabIndex = 30;
            this.gunaLabel3.Text = "- đến ngày:";
            // 
            // dtPickerDateEnd
            // 
            this.dtPickerDateEnd.BaseColor = System.Drawing.Color.White;
            this.dtPickerDateEnd.BorderColor = System.Drawing.Color.Silver;
            this.dtPickerDateEnd.CustomFormat = null;
            this.dtPickerDateEnd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPickerDateEnd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerDateEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPickerDateEnd.ForeColor = System.Drawing.Color.Black;
            this.dtPickerDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDateEnd.Location = new System.Drawing.Point(558, 51);
            this.dtPickerDateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerDateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerDateEnd.Name = "dtPickerDateEnd";
            this.dtPickerDateEnd.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtPickerDateEnd.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerDateEnd.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerDateEnd.OnPressedColor = System.Drawing.Color.Black;
            this.dtPickerDateEnd.Size = new System.Drawing.Size(189, 38);
            this.dtPickerDateEnd.TabIndex = 29;
            this.dtPickerDateEnd.Text = "1/23/2021";
            this.dtPickerDateEnd.Value = new System.DateTime(2021, 1, 23, 22, 14, 37, 94);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(83, 61);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(171, 19);
            this.gunaLabel2.TabIndex = 28;
            this.gunaLabel2.Text = "Doanh thu từ ngày: ";
            // 
            // dtPickerDateStart
            // 
            this.dtPickerDateStart.BaseColor = System.Drawing.Color.White;
            this.dtPickerDateStart.BorderColor = System.Drawing.Color.Silver;
            this.dtPickerDateStart.CustomFormat = null;
            this.dtPickerDateStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPickerDateStart.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerDateStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPickerDateStart.ForeColor = System.Drawing.Color.Black;
            this.dtPickerDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDateStart.Location = new System.Drawing.Point(256, 51);
            this.dtPickerDateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerDateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerDateStart.Name = "dtPickerDateStart";
            this.dtPickerDateStart.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtPickerDateStart.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerDateStart.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerDateStart.OnPressedColor = System.Drawing.Color.Black;
            this.dtPickerDateStart.Size = new System.Drawing.Size(189, 38);
            this.dtPickerDateStart.TabIndex = 27;
            this.dtPickerDateStart.Text = "1/23/2021";
            this.dtPickerDateStart.Value = new System.DateTime(2021, 1, 23, 22, 14, 37, 94);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(307, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(334, 33);
            this.gunaLabel1.TabIndex = 26;
            this.gunaLabel1.Text = "THỐNG KÊ DOANH THU";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(268, 115);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(143, 19);
            this.gunaLabel4.TabIndex = 36;
            this.gunaLabel4.Text = "Tổng doanh thu:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.Location = new System.Drawing.Point(221, 159);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(190, 19);
            this.gunaLabel5.TabIndex = 37;
            this.gunaLabel5.Text = "Tổng số lượng đã bán:";
            // 
            // txtShowTotalReveneu
            // 
            this.txtShowTotalReveneu.BackColor = System.Drawing.Color.Transparent;
            this.txtShowTotalReveneu.BaseColor = System.Drawing.Color.White;
            this.txtShowTotalReveneu.BorderColor = System.Drawing.Color.Transparent;
            this.txtShowTotalReveneu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShowTotalReveneu.FocusedBaseColor = System.Drawing.Color.White;
            this.txtShowTotalReveneu.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtShowTotalReveneu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtShowTotalReveneu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowTotalReveneu.Location = new System.Drawing.Point(417, 108);
            this.txtShowTotalReveneu.Name = "txtShowTotalReveneu";
            this.txtShowTotalReveneu.PasswordChar = '\0';
            this.txtShowTotalReveneu.Radius = 5;
            this.txtShowTotalReveneu.ReadOnly = true;
            this.txtShowTotalReveneu.SelectedText = "";
            this.txtShowTotalReveneu.Size = new System.Drawing.Size(294, 35);
            this.txtShowTotalReveneu.TabIndex = 48;
            // 
            // txtShowTotalQuantity
            // 
            this.txtShowTotalQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtShowTotalQuantity.BaseColor = System.Drawing.Color.White;
            this.txtShowTotalQuantity.BorderColor = System.Drawing.Color.Transparent;
            this.txtShowTotalQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShowTotalQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtShowTotalQuantity.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtShowTotalQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtShowTotalQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowTotalQuantity.Location = new System.Drawing.Point(417, 150);
            this.txtShowTotalQuantity.Name = "txtShowTotalQuantity";
            this.txtShowTotalQuantity.PasswordChar = '\0';
            this.txtShowTotalQuantity.Radius = 5;
            this.txtShowTotalQuantity.ReadOnly = true;
            this.txtShowTotalQuantity.SelectedText = "";
            this.txtShowTotalQuantity.Size = new System.Drawing.Size(294, 35);
            this.txtShowTotalQuantity.TabIndex = 49;
            // 
            // btnAccept
            // 
            this.btnAccept.Animated = true;
            this.btnAccept.AnimationHoverSpeed = 0.07F;
            this.btnAccept.AnimationSpeed = 0.03F;
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BaseColor = System.Drawing.Color.Silver;
            this.btnAccept.BorderColor = System.Drawing.Color.Black;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccept.FocusedColor = System.Drawing.Color.Empty;
            this.btnAccept.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Image = null;
            this.btnAccept.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAccept.Location = new System.Drawing.Point(762, 54);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAccept.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAccept.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAccept.OnHoverImage = null;
            this.btnAccept.OnPressedColor = System.Drawing.Color.Black;
            this.btnAccept.Radius = 10;
            this.btnAccept.Size = new System.Drawing.Size(134, 32);
            this.btnAccept.TabIndex = 70;
            this.btnAccept.Text = "XÁC NHẬN";
            this.btnAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // clUserName
            // 
            this.clUserName.HeaderText = "Tên nhân viên";
            this.clUserName.Name = "clUserName";
            this.clUserName.Width = 150;
            // 
            // clTotalRevenue
            // 
            this.clTotalRevenue.HeaderText = "Tổng doanh thu";
            this.clTotalRevenue.Name = "clTotalRevenue";
            this.clTotalRevenue.Width = 150;
            // 
            // clTotalQuantity
            // 
            this.clTotalQuantity.HeaderText = "Tổng số lượng";
            this.clTotalQuantity.Name = "clTotalQuantity";
            this.clTotalQuantity.Width = 150;
            // 
            // clTime
            // 
            this.clTime.HeaderText = "Thời gian";
            this.clTime.Name = "clTime";
            this.clTime.Width = 150;
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(941, 541);
            this.Controls.Add(this.pnStatistic);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.pnStatistic.ResumeLayout(false);
            this.pnStatistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVReveneuStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel pnStatistic;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDateTimePicker dtPickerDateEnd;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaDateTimePicker dtPickerDateStart;
        private System.Windows.Forms.DataGridView dtGVReveneuStatistic;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtShowTotalQuantity;
        private Guna.UI.WinForms.GunaTextBox txtShowTotalReveneu;
        private Guna.UI.WinForms.GunaButton btnAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
    }
}