namespace SalesWinApp
{
    partial class frmProducts
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
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbProductCategory = new System.Windows.Forms.Label();
            this.lbProductWeight = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductPrice = new System.Windows.Forms.Label();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitInPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Location = new System.Drawing.Point(12, 237);
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.RowHeadersWidth = 51;
            this.dgvProductsList.RowTemplate.Height = 29;
            this.dgvProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsList.Size = new System.Drawing.Size(892, 188);
            this.dgvProductsList.TabIndex = 0;
            this.dgvProductsList.DataSourceChanged += new System.EventHandler(this.dgvProductsList_DataSourceChanged);
            this.dgvProductsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsList_CellClick);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(405, 163);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(115, 27);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(22, 29);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(24, 20);
            this.lbProductID.TabIndex = 3;
            this.lbProductID.Text = "ID";
            // 
            // lbProductCategory
            // 
            this.lbProductCategory.AutoSize = true;
            this.lbProductCategory.Location = new System.Drawing.Point(22, 87);
            this.lbProductCategory.Name = "lbProductCategory";
            this.lbProductCategory.Size = new System.Drawing.Size(69, 20);
            this.lbProductCategory.TabIndex = 4;
            this.lbProductCategory.Text = "Category";
            // 
            // lbProductWeight
            // 
            this.lbProductWeight.AutoSize = true;
            this.lbProductWeight.Location = new System.Drawing.Point(623, 29);
            this.lbProductWeight.Name = "lbProductWeight";
            this.lbProductWeight.Size = new System.Drawing.Size(56, 20);
            this.lbProductWeight.TabIndex = 5;
            this.lbProductWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(282, 29);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 6;
            this.lbProductName.Text = "Product Name";
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.AutoSize = true;
            this.lbProductPrice.Location = new System.Drawing.Point(282, 84);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(41, 20);
            this.lbProductPrice.TabIndex = 7;
            this.lbProductPrice.Text = "Price";
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(623, 87);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(88, 20);
            this.lbUnitInStock.TabIndex = 8;
            this.lbUnitInStock.Text = "Unit In Price";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(107, 26);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(125, 27);
            this.txtProductID.TabIndex = 9;
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(107, 84);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(125, 27);
            this.txtProductCategory.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(405, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(185, 27);
            this.txtProductName.TabIndex = 11;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(405, 84);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(185, 27);
            this.txtProductPrice.TabIndex = 12;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(729, 26);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(125, 27);
            this.txtWeight.TabIndex = 13;
            // 
            // txtUnitInPrice
            // 
            this.txtUnitInPrice.Location = new System.Drawing.Point(729, 81);
            this.txtUnitInPrice.Name = "txtUnitInPrice";
            this.txtUnitInPrice.Size = new System.Drawing.Size(125, 27);
            this.txtUnitInPrice.TabIndex = 14;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.txtUnitInPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCategory);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbUnitInStock);
            this.Controls.Add(this.lbProductPrice);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbProductWeight);
            this.Controls.Add(this.lbProductCategory);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dgvProductsList);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProductsList;
        private MaskedTextBox maskedTextBox1;
        private Label lbProductID;
        private Label lbProductCategory;
        private Label lbProductWeight;
        private Label lbProductName;
        private Label lbProductPrice;
        private Label lbUnitInStock;
        private TextBox txtProductID;
        private TextBox txtProductCategory;
        private TextBox txtProductName;
        private TextBox txtProductPrice;
        private TextBox txtWeight;
        private TextBox txtUnitInPrice;
    }
}