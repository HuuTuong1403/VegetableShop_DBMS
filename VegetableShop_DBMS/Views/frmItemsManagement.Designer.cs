
namespace VegetableShop_DBMS.Views
{
    partial class frmItemsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteItems = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtGVItemsManagement = new Guna.UI.WinForms.GunaDataGridView();
            this.clItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImageTop5Customer = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVItemsManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.AnimationHoverSpeed = 0.07F;
            this.btnDeleteItems.AnimationSpeed = 0.03F;
            this.btnDeleteItems.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItems.BaseColor = System.Drawing.Color.Silver;
            this.btnDeleteItems.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteItems.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItems.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteItems.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItems.Image")));
            this.btnDeleteItems.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteItems.Location = new System.Drawing.Point(680, 508);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteItems.OnHoverImage = null;
            this.btnDeleteItems.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteItems.Radius = 10;
            this.btnDeleteItems.Size = new System.Drawing.Size(173, 42);
            this.btnDeleteItems.TabIndex = 34;
            this.btnDeleteItems.Text = "Xóa thực phẩm";
            this.btnDeleteItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteItems.Click += new System.EventHandler(this.btnDeleteItems_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(189, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(598, 119);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 33;
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
            this.gunaPictureBox1.TabIndex = 32;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(252, 145);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(310, 33);
            this.gunaLabel1.TabIndex = 31;
            this.gunaLabel1.Text = "QUẢN LÝ THỰC PHẨM";
            // 
            // dtGVItemsManagement
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGVItemsManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGVItemsManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVItemsManagement.BackgroundColor = System.Drawing.Color.White;
            this.dtGVItemsManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGVItemsManagement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGVItemsManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVItemsManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGVItemsManagement.ColumnHeadersHeight = 41;
            this.dtGVItemsManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clItemName,
            this.clImportPrice,
            this.clSalePrice,
            this.clDescription,
            this.clOrigin,
            this.clCategory,
            this.clSubCategory,
            this.clQuantity,
            this.colImageTop5Customer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGVItemsManagement.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGVItemsManagement.EnableHeadersVisualStyles = false;
            this.dtGVItemsManagement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVItemsManagement.Location = new System.Drawing.Point(11, 181);
            this.dtGVItemsManagement.Name = "dtGVItemsManagement";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVItemsManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGVItemsManagement.RowHeadersVisible = false;
            this.dtGVItemsManagement.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtGVItemsManagement.RowTemplate.Height = 80;
            this.dtGVItemsManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVItemsManagement.Size = new System.Drawing.Size(842, 321);
            this.dtGVItemsManagement.TabIndex = 36;
            this.dtGVItemsManagement.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtGVItemsManagement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGVItemsManagement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGVItemsManagement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGVItemsManagement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGVItemsManagement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGVItemsManagement.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGVItemsManagement.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVItemsManagement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGVItemsManagement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtGVItemsManagement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGVItemsManagement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGVItemsManagement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGVItemsManagement.ThemeStyle.HeaderStyle.Height = 41;
            this.dtGVItemsManagement.ThemeStyle.ReadOnly = false;
            this.dtGVItemsManagement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGVItemsManagement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGVItemsManagement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGVItemsManagement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGVItemsManagement.ThemeStyle.RowsStyle.Height = 80;
            this.dtGVItemsManagement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVItemsManagement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGVItemsManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVItemsManagement_CellClick);
            // 
            // clItemName
            // 
            this.clItemName.FillWeight = 140F;
            this.clItemName.HeaderText = "Tên thực phẩm";
            this.clItemName.Name = "clItemName";
            // 
            // clImportPrice
            // 
            this.clImportPrice.HeaderText = "Giá nhập";
            this.clImportPrice.Name = "clImportPrice";
            // 
            // clSalePrice
            // 
            this.clSalePrice.FillWeight = 80F;
            this.clSalePrice.HeaderText = "Giá bán";
            this.clSalePrice.Name = "clSalePrice";
            // 
            // clDescription
            // 
            this.clDescription.FillWeight = 200F;
            this.clDescription.HeaderText = "Mô tả";
            this.clDescription.Name = "clDescription";
            // 
            // clOrigin
            // 
            this.clOrigin.FillWeight = 120F;
            this.clOrigin.HeaderText = "Xuất xứ";
            this.clOrigin.Name = "clOrigin";
            // 
            // clCategory
            // 
            this.clCategory.HeaderText = "Phân loại";
            this.clCategory.Name = "clCategory";
            // 
            // clSubCategory
            // 
            this.clSubCategory.HeaderText = "Danh mục";
            this.clSubCategory.Name = "clSubCategory";
            // 
            // clQuantity
            // 
            this.clQuantity.HeaderText = "Số lượng";
            this.clQuantity.Name = "clQuantity";
            // 
            // colImageTop5Customer
            // 
            this.colImageTop5Customer.HeaderText = "Hình ảnh";
            this.colImageTop5Customer.Name = "colImageTop5Customer";
            // 
            // frmItemsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(865, 562);
            this.Controls.Add(this.dtGVItemsManagement);
            this.Controls.Add(this.btnDeleteItems);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmItemsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thực phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVItemsManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnDeleteItems;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dtGVItemsManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clImportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewImageColumn colImageTop5Customer;
    }
}