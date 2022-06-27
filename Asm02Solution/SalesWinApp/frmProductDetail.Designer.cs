namespace SalesWinApp
{
    partial class frmProductDetail
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
            this.lbProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbProductWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lbProductCategory = new System.Windows.Forms.Label();
            this.lbProductPrice = new System.Windows.Forms.Label();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtProductCategory = new System.Windows.Forms.MaskedTextBox();
            this.txtProductPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtUnitInPrice = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(29, 31);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(24, 20);
            this.lbProductID.TabIndex = 4;
            this.lbProductID.Text = "ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(100, 29);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(149, 27);
            this.txtProductID.TabIndex = 10;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(297, 31);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 11;
            this.lbProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(422, 29);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(149, 27);
            this.txtProductName.TabIndex = 12;
            // 
            // lbProductWeight
            // 
            this.lbProductWeight.AutoSize = true;
            this.lbProductWeight.Location = new System.Drawing.Point(29, 92);
            this.lbProductWeight.Name = "lbProductWeight";
            this.lbProductWeight.Size = new System.Drawing.Size(56, 20);
            this.lbProductWeight.TabIndex = 13;
            this.lbProductWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(100, 90);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(149, 27);
            this.txtWeight.TabIndex = 14;
            // 
            // lbProductCategory
            // 
            this.lbProductCategory.AutoSize = true;
            this.lbProductCategory.Location = new System.Drawing.Point(297, 94);
            this.lbProductCategory.Name = "lbProductCategory";
            this.lbProductCategory.Size = new System.Drawing.Size(69, 20);
            this.lbProductCategory.TabIndex = 15;
            this.lbProductCategory.Text = "Category";
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.AutoSize = true;
            this.lbProductPrice.Location = new System.Drawing.Point(29, 154);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(41, 20);
            this.lbProductPrice.TabIndex = 17;
            this.lbProductPrice.Text = "Price";
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(297, 154);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(88, 20);
            this.lbUnitInStock.TabIndex = 19;
            this.lbUnitInStock.Text = "Unit In Price";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(145, 271);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 27);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(394, 271);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 27);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(422, 89);
            this.txtProductCategory.Mask = "000";
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(149, 27);
            this.txtProductCategory.TabIndex = 23;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(100, 151);
            this.txtProductPrice.Mask = "00000.000";
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(149, 27);
            this.txtProductPrice.TabIndex = 24;
            // 
            // txtUnitInPrice
            // 
            this.txtUnitInPrice.Location = new System.Drawing.Point(422, 151);
            this.txtUnitInPrice.Mask = "0000000";
            this.txtUnitInPrice.Name = "txtUnitInPrice";
            this.txtUnitInPrice.Size = new System.Drawing.Size(149, 27);
            this.txtUnitInPrice.TabIndex = 25;
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.txtUnitInPrice);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductCategory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbUnitInStock);
            this.Controls.Add(this.lbProductPrice);
            this.Controls.Add(this.lbProductCategory);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lbProductWeight);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbProductID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProductDetail";
            this.Text = "frmProductDetail";
            this.Load += new System.EventHandler(this.frmProductDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbProductID;
        private TextBox txtProductID;
        private Label lbProductName;
        private TextBox txtProductName;
        private Label lbProductWeight;
        private TextBox txtWeight;
        private Label lbProductCategory;
        private Label lbProductPrice;
        private Label lbUnitInStock;
        private Button btnSave;
        private Button btnClose;
        private MaskedTextBox txtProductCategory;
        private MaskedTextBox txtProductPrice;
        private MaskedTextBox txtUnitInPrice;
    }
}