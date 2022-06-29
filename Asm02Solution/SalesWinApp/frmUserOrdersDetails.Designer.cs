namespace SalesWinApp
{
    partial class frmUserOrdersDetails
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
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(11, 9);
            this.lbOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(81, 25);
            this.lbOrderID.TabIndex = 3;
            this.lbOrderID.Text = "Order ID";
            // 
            // txtOderID
            // 
            this.txtOderID.Location = new System.Drawing.Point(117, 6);
            this.txtOderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOderID.Name = "txtOderID";
            this.txtOderID.ReadOnly = true;
            this.txtOderID.Size = new System.Drawing.Size(150, 31);
            this.txtOderID.TabIndex = 4;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(281, 9);
            this.lbOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(100, 25);
            this.lbOrderDate.TabIndex = 9;
            this.lbOrderDate.Text = "Order Date";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(419, 9);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(370, 31);
            this.txtOrderDate.TabIndex = 10;
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(11, 56);
            this.lbMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(97, 25);
            this.lbMemberID.TabIndex = 11;
            this.lbMemberID.Text = "MemberID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(117, 53);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(150, 31);
            this.txtMemberID.TabIndex = 12;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(281, 56);
            this.lbRequiredDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(124, 25);
            this.lbRequiredDate.TabIndex = 13;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(419, 53);
            this.txtRequiredDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(370, 31);
            this.txtRequiredDate.TabIndex = 14;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(11, 103);
            this.lbFreight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(67, 25);
            this.lbFreight.TabIndex = 15;
            this.lbFreight.Text = "Freight";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(117, 100);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(2);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(150, 31);
            this.txtFreight.TabIndex = 16;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(285, 103);
            this.lbShippedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(120, 25);
            this.lbShippedDate.TabIndex = 17;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(419, 100);
            this.txtShippedDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.ReadOnly = true;
            this.txtShippedDate.Size = new System.Drawing.Size(370, 31);
            this.txtShippedDate.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(182, 152);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(380, 152);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 34);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUserOrdersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 208);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.txtOderID);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmUserOrdersDetails";
            this.Text = "frmUserOrderDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbOrderID;
        private TextBox txtOderID;
        private Label lbOrderDate;
        private TextBox txtOrderDate;
        private Label lbMemberID;
        private TextBox txtMemberID;
        private Label lbRequiredDate;
        private TextBox txtRequiredDate;
        private Label lbFreight;
        private TextBox txtFreight;
        private Label lbShippedDate;
        private TextBox txtShippedDate;
        private Button btnSave;
        private Button btnClose;
    }
}