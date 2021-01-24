
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lblCancel = new Guna.UI.WinForms.GunaLabel();
            this.lblRefund = new Guna.UI.WinForms.GunaLabel();
            this.lblCompletion = new Guna.UI.WinForms.GunaLabel();
            this.lblPaid = new Guna.UI.WinForms.GunaLabel();
            this.lblDelivery = new Guna.UI.WinForms.GunaLabel();
            this.lblPreparing = new Guna.UI.WinForms.GunaLabel();
            this.lblAll = new Guna.UI.WinForms.GunaLabel();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.btnRefund = new Guna.UI.WinForms.GunaButton();
            this.btnCompletion = new Guna.UI.WinForms.GunaButton();
            this.btnPaid = new Guna.UI.WinForms.GunaButton();
            this.btnDelivering = new Guna.UI.WinForms.GunaButton();
            this.btnPreparing = new Guna.UI.WinForms.GunaButton();
            this.btnAll = new Guna.UI.WinForms.GunaButton();
            this.dtGVBillManagement = new System.Windows.Forms.DataGridView();
            this.clIDBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrderStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnState = new Guna.UI.WinForms.GunaButton();
            this.ptBOpacity = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.pnBillDetail = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.dtGVBillDetailManagement = new Guna.UI.WinForms.GunaDataGridView();
            this.clImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.clItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPaidPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVBillManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBOpacity)).BeginInit();
            this.pnBillDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVBillDetailManagement)).BeginInit();
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
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.lblCancel);
            this.gunaPanel1.Controls.Add(this.lblRefund);
            this.gunaPanel1.Controls.Add(this.lblCompletion);
            this.gunaPanel1.Controls.Add(this.lblPaid);
            this.gunaPanel1.Controls.Add(this.lblDelivery);
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
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.BackColor = System.Drawing.Color.Silver;
            this.lblDelivery.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblDelivery.ForeColor = System.Drawing.Color.Red;
            this.lblDelivery.Location = new System.Drawing.Point(358, 3);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(17, 17);
            this.lblDelivery.TabIndex = 46;
            this.lblDelivery.Text = "1";
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
            // dtGVBillManagement
            // 
            this.dtGVBillManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVBillManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVBillManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIDBill,
            this.clUserName,
            this.clTotalPrice,
            this.clTotalQuantity,
            this.clOrderStateName,
            this.clTime});
            this.dtGVBillManagement.Location = new System.Drawing.Point(12, 262);
            this.dtGVBillManagement.Name = "dtGVBillManagement";
            this.dtGVBillManagement.RowHeadersWidth = 51;
            this.dtGVBillManagement.RowTemplate.Height = 23;
            this.dtGVBillManagement.Size = new System.Drawing.Size(868, 287);
            this.dtGVBillManagement.TabIndex = 33;
            this.dtGVBillManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVBillManagement_CellClick);
            // 
            // clIDBill
            // 
            this.clIDBill.HeaderText = "IDBill";
            this.clIDBill.Name = "clIDBill";
            this.clIDBill.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clIDBill.Width = 150;
            // 
            // clUserName
            // 
            this.clUserName.HeaderText = "Tên tài khoản";
            this.clUserName.Name = "clUserName";
            this.clUserName.Width = 150;
            // 
            // clTotalPrice
            // 
            this.clTotalPrice.HeaderText = "Tổng giá";
            this.clTotalPrice.Name = "clTotalPrice";
            this.clTotalPrice.Width = 150;
            // 
            // clTotalQuantity
            // 
            this.clTotalQuantity.HeaderText = "Tổng số lượng";
            this.clTotalQuantity.Name = "clTotalQuantity";
            // 
            // clOrderStateName
            // 
            this.clOrderStateName.HeaderText = "Trạng thái";
            this.clOrderStateName.Name = "clOrderStateName";
            // 
            // clTime
            // 
            this.clTime.HeaderText = "Thời gian";
            this.clTime.Name = "clTime";
            this.clTime.Width = 150;
            // 
            // btnState
            // 
            this.btnState.AnimationHoverSpeed = 0.07F;
            this.btnState.AnimationSpeed = 0.03F;
            this.btnState.BackColor = System.Drawing.Color.Transparent;
            this.btnState.BaseColor = System.Drawing.Color.Silver;
            this.btnState.BorderColor = System.Drawing.Color.Black;
            this.btnState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnState.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnState.FocusedColor = System.Drawing.Color.Empty;
            this.btnState.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnState.ForeColor = System.Drawing.Color.Black;
            this.btnState.Image = null;
            this.btnState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnState.Location = new System.Drawing.Point(753, 555);
            this.btnState.Name = "btnState";
            this.btnState.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnState.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnState.OnHoverForeColor = System.Drawing.Color.White;
            this.btnState.OnHoverImage = null;
            this.btnState.OnPressedColor = System.Drawing.Color.Black;
            this.btnState.Size = new System.Drawing.Size(120, 38);
            this.btnState.TabIndex = 77;
            this.btnState.Text = "Chuyển state";
            this.btnState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // ptBOpacity
            // 
            this.ptBOpacity.BackColor = System.Drawing.Color.Transparent;
            this.ptBOpacity.BaseColor = System.Drawing.Color.White;
            this.ptBOpacity.BaseDepth = 200;
            this.ptBOpacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptBOpacity.Location = new System.Drawing.Point(0, 0);
            this.ptBOpacity.Name = "ptBOpacity";
            this.ptBOpacity.Size = new System.Drawing.Size(892, 599);
            this.ptBOpacity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBOpacity.TabIndex = 78;
            this.ptBOpacity.TabStop = false;
            this.ptBOpacity.Visible = false;
            // 
            // pnBillDetail
            // 
            this.pnBillDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBillDetail.Controls.Add(this.btnExit);
            this.pnBillDetail.Controls.Add(this.dtGVBillDetailManagement);
            this.pnBillDetail.Controls.Add(this.gunaLabel2);
            this.pnBillDetail.Location = new System.Drawing.Point(15, 108);
            this.pnBillDetail.Name = "pnBillDetail";
            this.pnBillDetail.Size = new System.Drawing.Size(862, 382);
            this.pnBillDetail.TabIndex = 79;
            this.pnBillDetail.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(819, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.Gray;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(33, 28);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtGVBillDetailManagement
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGVBillDetailManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGVBillDetailManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVBillDetailManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVBillDetailManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGVBillDetailManagement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGVBillDetailManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVBillDetailManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGVBillDetailManagement.ColumnHeadersHeight = 21;
            this.dtGVBillDetailManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clImage,
            this.clItemName,
            this.clDescription,
            this.clQuantity,
            this.clPaidPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGVBillDetailManagement.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGVBillDetailManagement.EnableHeadersVisualStyles = false;
            this.dtGVBillDetailManagement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVBillDetailManagement.Location = new System.Drawing.Point(12, 72);
            this.dtGVBillDetailManagement.Name = "dtGVBillDetailManagement";
            this.dtGVBillDetailManagement.RowHeadersVisible = false;
            this.dtGVBillDetailManagement.RowTemplate.Height = 80;
            this.dtGVBillDetailManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVBillDetailManagement.Size = new System.Drawing.Size(836, 292);
            this.dtGVBillDetailManagement.TabIndex = 31;
            this.dtGVBillDetailManagement.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtGVBillDetailManagement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGVBillDetailManagement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGVBillDetailManagement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGVBillDetailManagement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGVBillDetailManagement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGVBillDetailManagement.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtGVBillDetailManagement.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVBillDetailManagement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGVBillDetailManagement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGVBillDetailManagement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGVBillDetailManagement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGVBillDetailManagement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGVBillDetailManagement.ThemeStyle.HeaderStyle.Height = 21;
            this.dtGVBillDetailManagement.ThemeStyle.ReadOnly = false;
            this.dtGVBillDetailManagement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGVBillDetailManagement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGVBillDetailManagement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGVBillDetailManagement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGVBillDetailManagement.ThemeStyle.RowsStyle.Height = 80;
            this.dtGVBillDetailManagement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVBillDetailManagement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clImage
            // 
            this.clImage.HeaderText = "Hình ảnh";
            this.clImage.Name = "clImage";
            // 
            // clItemName
            // 
            this.clItemName.HeaderText = "Tên thực phẩm";
            this.clItemName.Name = "clItemName";
            // 
            // clDescription
            // 
            this.clDescription.HeaderText = "Mô tả";
            this.clDescription.Name = "clDescription";
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
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel2.Location = new System.Drawing.Point(295, 21);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(300, 33);
            this.gunaLabel2.TabIndex = 30;
            this.gunaLabel2.Text = "ĐƠN HÀNG CHI TIẾT";
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(892, 599);
            this.Controls.Add(this.pnBillDetail);
            this.Controls.Add(this.ptBOpacity);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.dtGVBillManagement);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVBillManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBOpacity)).EndInit();
            this.pnBillDetail.ResumeLayout(false);
            this.pnBillDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVBillDetailManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
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
        private Guna.UI.WinForms.GunaLabel lblDelivery;
        private Guna.UI.WinForms.GunaLabel lblPreparing;
        private Guna.UI.WinForms.GunaLabel lblAll;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private System.Windows.Forms.DataGridView dtGVBillManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
        private Guna.UI.WinForms.GunaButton btnState;
        private Guna.UI.WinForms.GunaTransfarantPictureBox ptBOpacity;
        private Guna.UI.WinForms.GunaPanel pnBillDetail;
        private Guna.UI.WinForms.GunaDataGridView dtGVBillDetailManagement;
        private System.Windows.Forms.DataGridViewImageColumn clImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPaidPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnExit;
    }
}