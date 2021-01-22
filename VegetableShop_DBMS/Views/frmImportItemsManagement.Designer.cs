
namespace VegetableShop_DBMS.Views
{
    partial class frmImportItemsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportItemsManagement));
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtGVImportItemsManagement = new System.Windows.Forms.DataGridView();
            this.clItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVImportItemsManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(178, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(467, 131);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 37;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(133, 131);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 36;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(172, 166);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(310, 33);
            this.gunaLabel1.TabIndex = 35;
            this.gunaLabel1.Text = "QUẢN LÝ NHẬP HÀNG";
            // 
            // dtGVImportItemsManagement
            // 
            this.dtGVImportItemsManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVImportItemsManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVImportItemsManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clItemName,
            this.clUserName,
            this.clQuantity,
            this.clDateImport});
            this.dtGVImportItemsManagement.Location = new System.Drawing.Point(12, 214);
            this.dtGVImportItemsManagement.Name = "dtGVImportItemsManagement";
            this.dtGVImportItemsManagement.RowHeadersWidth = 51;
            this.dtGVImportItemsManagement.Size = new System.Drawing.Size(655, 288);
            this.dtGVImportItemsManagement.TabIndex = 34;
            // 
            // clItemName
            // 
            this.clItemName.HeaderText = "Tên thực phẩm";
            this.clItemName.Name = "clItemName";
            this.clItemName.Width = 150;
            // 
            // clUserName
            // 
            this.clUserName.HeaderText = "Người nhập hàng";
            this.clUserName.Name = "clUserName";
            this.clUserName.Width = 150;
            // 
            // clQuantity
            // 
            this.clQuantity.HeaderText = "Số lượng món ăn";
            this.clQuantity.Name = "clQuantity";
            this.clQuantity.Width = 150;
            // 
            // clDateImport
            // 
            this.clDateImport.HeaderText = "Ngày nhập hàng";
            this.clDateImport.Name = "clDateImport";
            this.clDateImport.Width = 150;
            // 
            // frmImportItemsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(679, 523);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dtGVImportItemsManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmImportItemsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVImportItemsManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridView dtGVImportItemsManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateImport;
    }
}