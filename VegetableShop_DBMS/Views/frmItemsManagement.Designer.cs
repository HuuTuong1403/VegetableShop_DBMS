
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
            this.btnDeleteItems = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtGVItemsManagement = new System.Windows.Forms.DataGridView();
            this.clItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clImage = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.dtGVItemsManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVItemsManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVItemsManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clItemName,
            this.clImportPrice,
            this.clSalePrice,
            this.clDescription,
            this.clOrigin,
            this.clCategory,
            this.clSubCategory,
            this.clQuantity,
            this.clImage});
            this.dtGVItemsManagement.Location = new System.Drawing.Point(2, 193);
            this.dtGVItemsManagement.Name = "dtGVItemsManagement";
            this.dtGVItemsManagement.RowHeadersWidth = 51;
            this.dtGVItemsManagement.RowTemplate.Height = 80;
            this.dtGVItemsManagement.Size = new System.Drawing.Size(851, 309);
            this.dtGVItemsManagement.TabIndex = 30;
            // 
            // clItemName
            // 
            this.clItemName.HeaderText = "Tên thực phẩm";
            this.clItemName.Name = "clItemName";
            // 
            // clImportPrice
            // 
            this.clImportPrice.HeaderText = "Giá nhập";
            this.clImportPrice.Name = "clImportPrice";
            this.clImportPrice.Width = 80;
            // 
            // clSalePrice
            // 
            this.clSalePrice.HeaderText = "Giá bán";
            this.clSalePrice.Name = "clSalePrice";
            this.clSalePrice.Width = 80;
            // 
            // clDescription
            // 
            this.clDescription.HeaderText = "Mô tả";
            this.clDescription.Name = "clDescription";
            this.clDescription.Width = 140;
            // 
            // clOrigin
            // 
            this.clOrigin.HeaderText = "Xuất xứ";
            this.clOrigin.Name = "clOrigin";
            this.clOrigin.Width = 70;
            // 
            // clCategory
            // 
            this.clCategory.HeaderText = "Phân loại";
            this.clCategory.Name = "clCategory";
            this.clCategory.Width = 80;
            // 
            // clSubCategory
            // 
            this.clSubCategory.HeaderText = "Danh mục";
            this.clSubCategory.Name = "clSubCategory";
            this.clSubCategory.Width = 80;
            // 
            // clQuantity
            // 
            this.clQuantity.HeaderText = "Số lượng";
            this.clQuantity.Name = "clQuantity";
            this.clQuantity.Width = 50;
            // 
            // clImage
            // 
            this.clImage.HeaderText = "Hình ảnh";
            this.clImage.Name = "clImage";
            this.clImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmItemsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(865, 562);
            this.Controls.Add(this.btnDeleteItems);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dtGVItemsManagement);
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
        private System.Windows.Forms.DataGridView dtGVItemsManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clImportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewImageColumn clImage;
    }
}