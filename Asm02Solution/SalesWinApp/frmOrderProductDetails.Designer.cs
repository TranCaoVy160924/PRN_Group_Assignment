namespace SalesWinApp
{
    partial class frmOrderProductDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtOderID = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.cboProductChoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(380, 160);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 34);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(182, 160);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(118, 108);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(294, 31);
            this.txtUnitPrice.TabIndex = 30;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(11, 111);
            this.lbUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(81, 25);
            this.lbUnitPrice.TabIndex = 29;
            this.lbUnitPrice.Text = "UnitPrice";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(565, 58);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(225, 31);
            this.txtDiscount.TabIndex = 28;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(454, 69);
            this.lbDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(82, 25);
            this.lbDiscount.TabIndex = 27;
            this.lbDiscount.Text = "Discount";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(11, 64);
            this.lbProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(92, 25);
            this.lbProductID.TabIndex = 25;
            this.lbProductID.Text = "ProductID";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(565, 14);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(225, 31);
            this.txtQuantity.TabIndex = 24;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(454, 22);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(80, 25);
            this.lbQuantity.TabIndex = 23;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtOderID
            // 
            this.txtOderID.Location = new System.Drawing.Point(118, 14);
            this.txtOderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOderID.Name = "txtOderID";
            this.txtOderID.ReadOnly = true;
            this.txtOderID.Size = new System.Drawing.Size(294, 31);
            this.txtOderID.TabIndex = 22;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(11, 18);
            this.lbOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(81, 25);
            this.lbOrderID.TabIndex = 21;
            this.lbOrderID.Text = "Order ID";
            // 
            // cboProductChoice
            // 
            this.cboProductChoice.FormattingEnabled = true;
            this.cboProductChoice.Location = new System.Drawing.Point(118, 58);
            this.cboProductChoice.Margin = new System.Windows.Forms.Padding(4);
            this.cboProductChoice.Name = "cboProductChoice";
            this.cboProductChoice.Size = new System.Drawing.Size(294, 33);
            this.cboProductChoice.TabIndex = 35;
            // 
            // frmOrderProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 208);
            this.Controls.Add(this.cboProductChoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtOderID);
            this.Controls.Add(this.lbOrderID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOrderProductDetails";
            this.Text = "frmOrderProductDetails";
            this.Load += new System.EventHandler(this.frmOrderProductDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private TextBox txtUnitPrice;
        private Label lbUnitPrice;
        private TextBox txtDiscount;
        private Label lbDiscount;
        private Label lbProductID;
        private TextBox txtQuantity;
        private Label lbQuantity;
        private TextBox txtOderID;
        private Label lbOrderID;
        private ComboBox cboProductChoice;
    }
}