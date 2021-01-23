
namespace VegetableShop_DBMS.Views
{
    partial class frmOrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderManagement));
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtGVOrderManagement = new System.Windows.Forms.DataGridView();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnRefund = new Guna.UI.WinForms.GunaButton();
            this.btnCompletion = new Guna.UI.WinForms.GunaButton();
            this.btnPaid = new Guna.UI.WinForms.GunaButton();
            this.btnDelivering = new Guna.UI.WinForms.GunaButton();
            this.btnPreparing = new Guna.UI.WinForms.GunaButton();
            this.btnAll = new Guna.UI.WinForms.GunaButton();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.lblAll = new Guna.UI.WinForms.GunaLabel();
            this.lblPreparing = new Guna.UI.WinForms.GunaLabel();
            this.lblDilivery = new Guna.UI.WinForms.GunaLabel();
            this.lblPaid = new Guna.UI.WinForms.GunaLabel();
            this.lblCompletion = new Guna.UI.WinForms.GunaLabel();
            this.lblRefund = new Guna.UI.WinForms.GunaLabel();
            this.lblCancel = new Guna.UI.WinForms.GunaLabel();
            this.clImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.clItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPaidPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVOrderManagement)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(187, 12);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(686, 137);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 31;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(141, 137);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 30;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(301, 152);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(297, 33);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // dtGVOrderManagement
            // 
            this.dtGVOrderManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVOrderManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVOrderManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clImage,
            this.clItemName,
            this.clDescription,
            this.clQuantity,
            this.clPaidPrice,
            this.clUserName});
            this.dtGVOrderManagement.Location = new System.Drawing.Point(12, 262);
            this.dtGVOrderManagement.Name = "dtGVOrderManagement";
            this.dtGVOrderManagement.RowHeadersWidth = 51;
            this.dtGVOrderManagement.RowTemplate.Height = 80;
            this.dtGVOrderManagement.Size = new System.Drawing.Size(868, 287);
            this.dtGVOrderManagement.TabIndex = 28;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.lblCancel);
            this.gunaPanel1.Controls.Add(this.lblRefund);
            this.gunaPanel1.Controls.Add(this.lblCompletion);
            this.gunaPanel1.Controls.Add(this.lblPaid);
            this.gunaPanel1.Controls.Add(this.lblDilivery);
            this.gunaPanel1.Controls.Add(this.lblPreparing);
            this.gunaPanel1.Controls.Add(this.lblAll);
            this.gunaPanel1.Controls.Add(this.btnCancel);
            this.gunaPanel1.Controls.Add(this.btnRefund);
            this.gunaPanel1.Controls.Add(this.btnCompletion);
            this.gunaPanel1.Controls.Add(this.btnPaid);
            this.gunaPanel1.Controls.Add(this.btnDelivering);
            this.gunaPanel1.Controls.Add(this.btnPreparing);
            this.gunaPanel1.Controls.Add(this.btnAll);
            this.gunaPanel1.Location = new System.Drawing.Point(12, 198);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(868, 48);
            this.gunaPanel1.TabIndex = 32;
            // 
            // btnRefund
            // 
            this.btnRefund.AnimationHoverSpeed = 0.07F;
            this.btnRefund.AnimationSpeed = 0.03F;
            this.btnRefund.BackColor = System.Drawing.Color.Transparent;
            this.btnRefund.BaseColor = System.Drawing.Color.Silver;
            this.btnRefund.BorderColor = System.Drawing.Color.Black;
            this.btnRefund.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefund.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefund.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefund.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.ForeColor = System.Drawing.Color.Black;
            this.btnRefund.Image = null;
            this.btnRefund.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefund.Location = new System.Drawing.Point(621, 3);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnRefund.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefund.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefund.OnHoverImage = null;
            this.btnRefund.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefund.Size = new System.Drawing.Size(120, 38);
            this.btnRefund.TabIndex = 43;
            this.btnRefund.Text = "Refund";
            this.btnRefund.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnCompletion
            // 
            this.btnCompletion.AnimationHoverSpeed = 0.07F;
            this.btnCompletion.AnimationSpeed = 0.03F;
            this.btnCompletion.BackColor = System.Drawing.Color.Transparent;
            this.btnCompletion.BaseColor = System.Drawing.Color.Silver;
            this.btnCompletion.BorderColor = System.Drawing.Color.Black;
            this.btnCompletion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompletion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCompletion.FocusedColor = System.Drawing.Color.Empty;
            this.btnCompletion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletion.ForeColor = System.Drawing.Color.Black;
            this.btnCompletion.Image = null;
            this.btnCompletion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCompletion.Location = new System.Drawing.Point(501, 3);
            this.btnCompletion.Name = "btnCompletion";
            this.btnCompletion.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnCompletion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCompletion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCompletion.OnHoverImage = null;
            this.btnCompletion.OnPressedColor = System.Drawing.Color.Black;
            this.btnCompletion.Size = new System.Drawing.Size(120, 38);
            this.btnCompletion.TabIndex = 42;
            this.btnCompletion.Text = "Completion";
            this.btnCompletion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCompletion.Click += new System.EventHandler(this.btnCompletion_Click);
            // 
            // btnPaid
            // 
            this.btnPaid.AnimationHoverSpeed = 0.07F;
            this.btnPaid.AnimationSpeed = 0.03F;
            this.btnPaid.BackColor = System.Drawing.Color.Transparent;
            this.btnPaid.BaseColor = System.Drawing.Color.Silver;
            this.btnPaid.BorderColor = System.Drawing.Color.Black;
            this.btnPaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPaid.FocusedColor = System.Drawing.Color.Empty;
            this.btnPaid.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaid.ForeColor = System.Drawing.Color.Black;
            this.btnPaid.Image = null;
            this.btnPaid.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPaid.Location = new System.Drawing.Point(381, 3);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnPaid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPaid.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPaid.OnHoverImage = null;
            this.btnPaid.OnPressedColor = System.Drawing.Color.Black;
            this.btnPaid.Size = new System.Drawing.Size(120, 38);
            this.btnPaid.TabIndex = 41;
            this.btnPaid.Text = "Paid";
            this.btnPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // btnDelivering
            // 
            this.btnDelivering.AnimationHoverSpeed = 0.07F;
            this.btnDelivering.AnimationSpeed = 0.03F;
            this.btnDelivering.BackColor = System.Drawing.Color.Transparent;
            this.btnDelivering.BaseColor = System.Drawing.Color.Silver;
            this.btnDelivering.BorderColor = System.Drawing.Color.Black;
            this.btnDelivering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelivering.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelivering.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelivering.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivering.ForeColor = System.Drawing.Color.Black;
            this.btnDelivering.Image = null;
            this.btnDelivering.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelivering.Location = new System.Drawing.Point(261, 3);
            this.btnDelivering.Name = "btnDelivering";
            this.btnDelivering.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnDelivering.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelivering.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelivering.OnHoverImage = null;
            this.btnDelivering.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelivering.Size = new System.Drawing.Size(120, 38);
            this.btnDelivering.TabIndex = 40;
            this.btnDelivering.Text = "Delivering";
            this.btnDelivering.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelivering.Click += new System.EventHandler(this.btnDelivering_Click);
            // 
            // btnPreparing
            // 
            this.btnPreparing.AnimationHoverSpeed = 0.07F;
            this.btnPreparing.AnimationSpeed = 0.03F;
            this.btnPreparing.BackColor = System.Drawing.Color.Transparent;
            this.btnPreparing.BaseColor = System.Drawing.Color.Silver;
            this.btnPreparing.BorderColor = System.Drawing.Color.Black;
            this.btnPreparing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreparing.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPreparing.FocusedColor = System.Drawing.Color.Empty;
            this.btnPreparing.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreparing.ForeColor = System.Drawing.Color.Black;
            this.btnPreparing.Image = null;
            this.btnPreparing.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPreparing.Location = new System.Drawing.Point(141, 3);
            this.btnPreparing.Name = "btnPreparing";
            this.btnPreparing.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnPreparing.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPreparing.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPreparing.OnHoverImage = null;
            this.btnPreparing.OnPressedColor = System.Drawing.Color.Black;
            this.btnPreparing.Size = new System.Drawing.Size(120, 38);
            this.btnPreparing.TabIndex = 39;
            this.btnPreparing.Text = "Preparing";
            this.btnPreparing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPreparing.Click += new System.EventHandler(this.btnPreparing_Click);
            // 
            // btnAll
            // 
            this.btnAll.AnimationHoverSpeed = 0.07F;
            this.btnAll.AnimationSpeed = 0.03F;
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.BaseColor = System.Drawing.Color.Silver;
            this.btnAll.BorderColor = System.Drawing.Color.Black;
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAll.FocusedColor = System.Drawing.Color.Empty;
            this.btnAll.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.Image = null;
            this.btnAll.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAll.Location = new System.Drawing.Point(21, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAll.OnHoverImage = null;
            this.btnAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnAll.Size = new System.Drawing.Size(120, 38);
            this.btnAll.TabIndex = 38;
            this.btnAll.Text = "Tất cả";
            this.btnAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(741, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.BackColor = System.Drawing.Color.Silver;
            this.lblAll.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblAll.ForeColor = System.Drawing.Color.Red;
            this.lblAll.Location = new System.Drawing.Point(119, 3);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(17, 17);
            this.lblAll.TabIndex = 33;
            this.lblAll.Text = "1";
            // 
            // lblPreparing
            // 
            this.lblPreparing.AutoSize = true;
            this.lblPreparing.BackColor = System.Drawing.Color.Silver;
            this.lblPreparing.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPreparing.ForeColor = System.Drawing.Color.Red;
            this.lblPreparing.Location = new System.Drawing.Point(244, 3);
            this.lblPreparing.Name = "lblPreparing";
            this.lblPreparing.Size = new System.Drawing.Size(17, 17);
            this.lblPreparing.TabIndex = 45;
            this.lblPreparing.Text = "1";
            // 
            // lblDilivery
            // 
            this.lblDilivery.AutoSize = true;
            this.lblDilivery.BackColor = System.Drawing.Color.Silver;
            this.lblDilivery.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblDilivery.ForeColor = System.Drawing.Color.Red;
            this.lblDilivery.Location = new System.Drawing.Point(358, 3);
            this.lblDilivery.Name = "lblDilivery";
            this.lblDilivery.Size = new System.Drawing.Size(17, 17);
            this.lblDilivery.TabIndex = 46;
            this.lblDilivery.Text = "1";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.BackColor = System.Drawing.Color.Silver;
            this.lblPaid.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaid.ForeColor = System.Drawing.Color.Red;
            this.lblPaid.Location = new System.Drawing.Point(488, 3);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(17, 17);
            this.lblPaid.TabIndex = 47;
            this.lblPaid.Text = "1";
            // 
            // lblCompletion
            // 
            this.lblCompletion.AutoSize = true;
            this.lblCompletion.BackColor = System.Drawing.Color.Silver;
            this.lblCompletion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompletion.ForeColor = System.Drawing.Color.Red;
            this.lblCompletion.Location = new System.Drawing.Point(609, 3);
            this.lblCompletion.Name = "lblCompletion";
            this.lblCompletion.Size = new System.Drawing.Size(17, 17);
            this.lblCompletion.TabIndex = 48;
            this.lblCompletion.Text = "1";
            // 
            // lblRefund
            // 
            this.lblRefund.AutoSize = true;
            this.lblRefund.BackColor = System.Drawing.Color.Silver;
            this.lblRefund.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblRefund.ForeColor = System.Drawing.Color.Red;
            this.lblRefund.Location = new System.Drawing.Point(707, 3);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(17, 17);
            this.lblRefund.TabIndex = 49;
            this.lblRefund.Text = "1";
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.BackColor = System.Drawing.Color.Silver;
            this.lblCancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCancel.ForeColor = System.Drawing.Color.Red;
            this.lblCancel.Location = new System.Drawing.Point(834, 3);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(17, 17);
            this.lblCancel.TabIndex = 50;
            this.lblCancel.Text = "1";
            // 
            // clImage
            // 
            this.clImage.HeaderText = "Hình ảnh";
            this.clImage.Name = "clImage";
            this.clImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clImage.Width = 150;
            // 
            // clItemName
            // 
            this.clItemName.HeaderText = "Tên thực phẩm";
            this.clItemName.Name = "clItemName";
            this.clItemName.Width = 150;
            // 
            // clDescription
            // 
            this.clDescription.HeaderText = "Mô tả";
            this.clDescription.Name = "clDescription";
            this.clDescription.Width = 150;
            // 
            // clQuantity
            // 
            this.clQuantity.HeaderText = "Số lượng";
            this.clQuantity.Name = "clQuantity";
            // 
            // clPaidPrice
            // 
            this.clPaidPrice.HeaderText = "Giá";
            this.clPaidPrice.Name = "clPaidPrice";
            // 
            // clUserName
            // 
            this.clUserName.HeaderText = "Tên tài khoản";
            this.clUserName.Name = "clUserName";
            this.clUserName.Width = 140;
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(892, 599);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dtGVOrderManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVOrderManagement)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridView dtGVOrderManagement;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnRefund;
        private Guna.UI.WinForms.GunaButton btnCompletion;
        private Guna.UI.WinForms.GunaButton btnPaid;
        private Guna.UI.WinForms.GunaButton btnDelivering;
        private Guna.UI.WinForms.GunaButton btnPreparing;
        private Guna.UI.WinForms.GunaButton btnAll;
        private Guna.UI.WinForms.GunaLabel lblCancel;
        private Guna.UI.WinForms.GunaLabel lblRefund;
        private Guna.UI.WinForms.GunaLabel lblCompletion;
        private Guna.UI.WinForms.GunaLabel lblPaid;
        private Guna.UI.WinForms.GunaLabel lblDilivery;
        private Guna.UI.WinForms.GunaLabel lblPreparing;
        private Guna.UI.WinForms.GunaLabel lblAll;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private System.Windows.Forms.DataGridViewImageColumn clImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPaidPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
    }
}