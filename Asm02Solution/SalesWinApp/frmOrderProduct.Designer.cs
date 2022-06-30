namespace SalesWinApp
{
    partial class frmOrderProduct
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvOrderDetailList = new System.Windows.Forms.DataGridView();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.txtOderID = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(865, 103);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(865, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(865, 53);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvOrderDetailList
            // 
            this.dgvOrderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetailList.Location = new System.Drawing.Point(10, 143);
            this.dgvOrderDetailList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderDetailList.Name = "dgvOrderDetailList";
            this.dgvOrderDetailList.RowHeadersWidth = 51;
            this.dgvOrderDetailList.RowTemplate.Height = 29;
            this.dgvOrderDetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailList.Size = new System.Drawing.Size(967, 317);
            this.dgvOrderDetailList.TabIndex = 32;
            this.dgvOrderDetailList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellContentClick);
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(430, 59);
            this.txtRequiredDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(370, 31);
            this.txtRequiredDate.TabIndex = 29;
            this.txtRequiredDate.TextChanged += new System.EventHandler(this.txtRequiredDate_TextChanged);
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(299, 59);
            this.lbDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(82, 25);
            this.lbDiscount.TabIndex = 28;
            this.lbDiscount.Text = "Discount";
            this.lbDiscount.Click += new System.EventHandler(this.lbRequiredDate_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(430, 9);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(370, 31);
            this.txtOrderDate.TabIndex = 27;
            this.txtOrderDate.TextChanged += new System.EventHandler(this.txtOrderDate_TextChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(299, 15);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(80, 25);
            this.lbQuantity.TabIndex = 26;
            this.lbQuantity.Text = "Quantity";
            this.lbQuantity.Click += new System.EventHandler(this.lbOrderDate_Click);
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(111, 106);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(2);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(150, 31);
            this.txtFreight.TabIndex = 25;
            this.txtFreight.TextChanged += new System.EventHandler(this.txtFreight_TextChanged);
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(12, 106);
            this.lbFreight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(86, 25);
            this.lbFreight.TabIndex = 24;
            this.lbFreight.Text = "Unit Price";
            this.lbFreight.Click += new System.EventHandler(this.lbFreight_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(111, 59);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(150, 31);
            this.txtMemberID.TabIndex = 23;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(10, 62);
            this.lbProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(92, 25);
            this.lbProductID.TabIndex = 22;
            this.lbProductID.Text = "ProductID";
            this.lbProductID.Click += new System.EventHandler(this.lbMemberID_Click);
            // 
            // txtOderID
            // 
            this.txtOderID.Location = new System.Drawing.Point(111, 9);
            this.txtOderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOderID.Name = "txtOderID";
            this.txtOderID.ReadOnly = true;
            this.txtOderID.Size = new System.Drawing.Size(150, 31);
            this.txtOderID.TabIndex = 21;
            this.txtOderID.TextChanged += new System.EventHandler(this.txtOderID_TextChanged);
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(10, 12);
            this.lbOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(81, 25);
            this.lbOrderID.TabIndex = 20;
            this.lbOrderID.Text = "Order ID";
            this.lbOrderID.Click += new System.EventHandler(this.lbOrderID_Click);
            // 
            // frmOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 468);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvOrderDetailList);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.txtOderID);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmOrderProduct";
            this.Text = "frmOrderProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private DataGridView dgvOrderDetailList;
        private TextBox txtRequiredDate;
        private Label lbDiscount;
        private TextBox txtOrderDate;
        private Label lbQuantity;
        private TextBox txtFreight;
        private Label lbFreight;
        private TextBox txtMemberID;
        private Label lbProductID;
        private TextBox txtOderID;
        private Label lbOrderID;
    }
}