
namespace VegetableShop_DBMS.Views
{
    partial class frmShoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShoppingCart));
            this.dtGVShoppingCart = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnDeleteCart = new Guna.UI.WinForms.GunaButton();
            this.btnOrderCart = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVShoppingCart
            // 
            this.dtGVShoppingCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVShoppingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colItemName,
            this.colDescription,
            this.colSalePrice,
            this.colOrigin,
            this.colQuantity});
            this.dtGVShoppingCart.Location = new System.Drawing.Point(4, 238);
            this.dtGVShoppingCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGVShoppingCart.Name = "dtGVShoppingCart";
            this.dtGVShoppingCart.RowHeadersWidth = 51;
            this.dtGVShoppingCart.RowTemplate.Height = 80;
            this.dtGVShoppingCart.Size = new System.Drawing.Size(1061, 354);
            this.dtGVShoppingCart.TabIndex = 0;
            this.dtGVShoppingCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVShoppingCart_CellClick);
            this.dtGVShoppingCart.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVShoppingCart_CellEndEdit);
            this.dtGVShoppingCart.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVShoppingCart_CellMouseEnter);
            // 
            // colImage
            // 
            this.colImage.HeaderText = "Image";
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            this.colImage.Width = 125;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Tên món ăn";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Width = 140;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Thành phần";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 150;
            // 
            // colSalePrice
            // 
            this.colSalePrice.HeaderText = "Giá";
            this.colSalePrice.MinimumWidth = 6;
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.ReadOnly = true;
            this.colSalePrice.Width = 125;
            // 
            // colOrigin
            // 
            this.colOrigin.HeaderText = "Xuất xứ";
            this.colOrigin.MinimumWidth = 6;
            this.colOrigin.Name = "colOrigin";
            this.colOrigin.ReadOnly = true;
            this.colOrigin.Width = 125;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 80;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(440, 181);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(195, 41);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "GIỎ HÀNG";
            // 
            // btnDeleteCart
            // 
            this.btnDeleteCart.AnimationHoverSpeed = 0.07F;
            this.btnDeleteCart.AnimationSpeed = 0.03F;
            this.btnDeleteCart.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCart.BaseColor = System.Drawing.Color.Silver;
            this.btnDeleteCart.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteCart.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteCart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCart.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCart.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCart.Image")));
            this.btnDeleteCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteCart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteCart.Location = new System.Drawing.Point(701, 599);
            this.btnDeleteCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteCart.Name = "btnDeleteCart";
            this.btnDeleteCart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteCart.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteCart.OnHoverImage = null;
            this.btnDeleteCart.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteCart.Radius = 10;
            this.btnDeleteCart.Size = new System.Drawing.Size(161, 52);
            this.btnDeleteCart.TabIndex = 23;
            this.btnDeleteCart.Text = "Xóa";
            this.btnDeleteCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteCart.Click += new System.EventHandler(this.btnDeleteCart_Click);
            // 
            // btnOrderCart
            // 
            this.btnOrderCart.AnimationHoverSpeed = 0.07F;
            this.btnOrderCart.AnimationSpeed = 0.03F;
            this.btnOrderCart.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderCart.BaseColor = System.Drawing.Color.Silver;
            this.btnOrderCart.BorderColor = System.Drawing.Color.Black;
            this.btnOrderCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrderCart.FocusedColor = System.Drawing.Color.Empty;
            this.btnOrderCart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCart.ForeColor = System.Drawing.Color.Black;
            this.btnOrderCart.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderCart.Image")));
            this.btnOrderCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnOrderCart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOrderCart.Location = new System.Drawing.Point(871, 599);
            this.btnOrderCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrderCart.Name = "btnOrderCart";
            this.btnOrderCart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOrderCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOrderCart.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOrderCart.OnHoverImage = null;
            this.btnOrderCart.OnPressedColor = System.Drawing.Color.Black;
            this.btnOrderCart.Radius = 10;
            this.btnOrderCart.Size = new System.Drawing.Size(180, 52);
            this.btnOrderCart.TabIndex = 22;
            this.btnOrderCart.Text = "Đặt hàng";
            this.btnOrderCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOrderCart.Click += new System.EventHandler(this.btnOrderCart_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(253, 15);
            this.gunaPictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(797, 146);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 21;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(16, 15);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(168, 146);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 20;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 666);
            this.Controls.Add(this.btnDeleteCart);
            this.Controls.Add(this.btnOrderCart);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dtGVShoppingCart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmShoppingCart";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVShoppingCart;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnOrderCart;
        private Guna.UI.WinForms.GunaButton btnDeleteCart;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
    }
}