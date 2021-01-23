
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtPickerDateStart = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dtPickerDateEnd = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtGVReveneuStatistic = new System.Windows.Forms.DataGridView();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatisticRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtPickerDateStart.Location = new System.Drawing.Point(311, 48);
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
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(138, 58);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(171, 19);
            this.gunaLabel2.TabIndex = 28;
            this.gunaLabel2.Text = "Doanh thu từ ngày: ";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(506, 58);
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
            this.dtPickerDateEnd.Location = new System.Drawing.Point(613, 48);
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
            // dtGVReveneuStatistic
            // 
            this.dtGVReveneuStatistic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVReveneuStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVReveneuStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clUserName,
            this.clStatisticRevenue,
            this.clDateStart,
            this.clDateEnd});
            this.dtGVReveneuStatistic.Location = new System.Drawing.Point(142, 92);
            this.dtGVReveneuStatistic.Name = "dtGVReveneuStatistic";
            this.dtGVReveneuStatistic.RowHeadersWidth = 51;
            this.dtGVReveneuStatistic.Size = new System.Drawing.Size(660, 279);
            this.dtGVReveneuStatistic.TabIndex = 35;
            // 
            // clUserName
            // 
            this.clUserName.HeaderText = "Tên nhân viên";
            this.clUserName.Name = "clUserName";
            this.clUserName.Width = 150;
            // 
            // clStatisticRevenue
            // 
            this.clStatisticRevenue.HeaderText = "Doanh thu";
            this.clStatisticRevenue.Name = "clStatisticRevenue";
            this.clStatisticRevenue.Width = 150;
            // 
            // clDateStart
            // 
            this.clDateStart.HeaderText = "Từ ngày";
            this.clDateStart.Name = "clDateStart";
            this.clDateStart.Width = 150;
            // 
            // clDateEnd
            // 
            this.clDateEnd.HeaderText = "Đến ngày";
            this.clDateEnd.Name = "clDateEnd";
            this.clDateEnd.Width = 150;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatisticRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateEnd;
    }
}