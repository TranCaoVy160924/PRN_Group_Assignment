namespace SalesWinApp
{
    partial class frmUserOrders
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
            this.lbOrderID = new System.Windows.Forms.Label();
            this.txtOderID = new System.Windows.Forms.TextBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(11, 9);
            this.lbOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(81, 25);
            this.lbOrderID.TabIndex = 2;
            this.lbOrderID.Text = "Order ID";
            // 
            // txtOderID
            // 
            this.txtOderID.Location = new System.Drawing.Point(115, 6);
            this.txtOderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOderID.Name = "txtOderID";
            this.txtOderID.ReadOnly = true;
            this.txtOderID.Size = new System.Drawing.Size(150, 31);
            this.txtOderID.TabIndex = 3;
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(313, 9);
            this.lbMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(97, 25);
            this.lbMemberID.TabIndex = 4;
            this.lbMemberID.Text = "MemberID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(431, 6);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(150, 31);
            this.txtMemberID.TabIndex = 5;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(636, 9);
            this.lbFreight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(67, 25);
            this.lbFreight.TabIndex = 6;
            this.lbFreight.Text = "Freight";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(752, 6);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(2);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(150, 31);
            this.txtFreight.TabIndex = 7;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(11, 86);
            this.lbOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(100, 25);
            this.lbOrderDate.TabIndex = 8;
            this.lbOrderDate.Text = "Order Date";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(115, 83);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(150, 31);
            this.txtOrderDate.TabIndex = 9;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(303, 89);
            this.lbRequiredDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(124, 25);
            this.lbRequiredDate.TabIndex = 10;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(431, 83);
            this.txtRequiredDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(150, 31);
            this.txtRequiredDate.TabIndex = 11;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(636, 86);
            this.lbShippedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(120, 25);
            this.lbShippedDate.TabIndex = 12;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(752, 83);
            this.txtShippedDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.ReadOnly = true;
            this.txtShippedDate.Size = new System.Drawing.Size(150, 31);
            this.txtShippedDate.TabIndex = 13;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(11, 201);
            this.dgvOrderList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(891, 317);
            this.dgvOrderList.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(378, 148);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 148);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(566, 148);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUserOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 531);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.txtOderID);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmUserOrders";
            this.Text = "User Orders";
            this.Load += new System.EventHandler(this.frmUserOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbOrderID;
        private TextBox txtOderID;
        private Label lbMemberID;
        private TextBox txtMemberID;
        private Label lbFreight;
        private TextBox txtFreight;
        private Label lbOrderDate;
        private TextBox txtOrderDate;
        private Label lbRequiredDate;
        private TextBox txtRequiredDate;
        private Label lbShippedDate;
        private TextBox txtShippedDate;
        private DataGridView dgvOrderList;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
    }
}