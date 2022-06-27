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
            this.txtSearchID = new System.Windows.Forms.MaskedTextBox();
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
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.txtUptoPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtSearchByUnit = new System.Windows.Forms.MaskedTextBox();
            this.btnSearchByPrice = new System.Windows.Forms.Button();
            this.btnSeachByUnit = new System.Windows.Forms.Button();
            this.lbUptoPrice = new System.Windows.Forms.Label();
            this.lbMoreThanUnit = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Location = new System.Drawing.Point(12, 392);
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.RowHeadersWidth = 51;
            this.dgvProductsList.RowTemplate.Height = 29;
            this.dgvProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsList.Size = new System.Drawing.Size(892, 248);
            this.dgvProductsList.TabIndex = 0;
            this.dgvProductsList.DataSourceChanged += new System.EventHandler(this.dgvProductsList_DataSourceChanged);
            this.dgvProductsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsList_CellClick);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(49, 195);
            this.txtSearchID.Mask = "00000";
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(57, 27);
            this.txtSearchID.TabIndex = 2;
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
            this.lbUnitInStock.Size = new System.Drawing.Size(92, 20);
            this.lbUnitInStock.TabIndex = 8;
            this.lbUnitInStock.Text = "Unit In Stock";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(107, 26);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(125, 27);
            this.txtProductID.TabIndex = 9;
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(107, 84);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.ReadOnly = true;
            this.txtProductCategory.Size = new System.Drawing.Size(125, 27);
            this.txtProductCategory.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(405, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(185, 27);
            this.txtProductName.TabIndex = 11;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(405, 84);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.ReadOnly = true;
            this.txtProductPrice.Size = new System.Drawing.Size(185, 27);
            this.txtProductPrice.TabIndex = 12;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(729, 26);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(125, 27);
            this.txtWeight.TabIndex = 13;
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(729, 81);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.ReadOnly = true;
            this.txtUnitInStock.Size = new System.Drawing.Size(125, 27);
            this.txtUnitInStock.TabIndex = 14;
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(112, 193);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(139, 29);
            this.btnSearchByID.TabIndex = 15;
            this.btnSearchByID.Text = "Search By ID";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(49, 245);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(651, 27);
            this.txtSearchName.TabIndex = 16;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(706, 243);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(198, 29);
            this.btnSearchByName.TabIndex = 17;
            this.btnSearchByName.Text = "Search By Name";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // txtUptoPrice
            // 
            this.txtUptoPrice.Location = new System.Drawing.Point(328, 195);
            this.txtUptoPrice.Mask = "0000000";
            this.txtUptoPrice.Name = "txtUptoPrice";
            this.txtUptoPrice.Size = new System.Drawing.Size(99, 27);
            this.txtUptoPrice.TabIndex = 18;
            // 
            // txtSearchByUnit
            // 
            this.txtSearchByUnit.Location = new System.Drawing.Point(691, 196);
            this.txtSearchByUnit.Mask = "00000";
            this.txtSearchByUnit.Name = "txtSearchByUnit";
            this.txtSearchByUnit.Size = new System.Drawing.Size(70, 27);
            this.txtSearchByUnit.TabIndex = 19;
            this.txtSearchByUnit.ValidatingType = typeof(int);
            // 
            // btnSearchByPrice
            // 
            this.btnSearchByPrice.Location = new System.Drawing.Point(433, 193);
            this.btnSearchByPrice.Name = "btnSearchByPrice";
            this.btnSearchByPrice.Size = new System.Drawing.Size(130, 29);
            this.btnSearchByPrice.TabIndex = 20;
            this.btnSearchByPrice.Text = "Search By Price";
            this.btnSearchByPrice.UseVisualStyleBackColor = true;
            this.btnSearchByPrice.Click += new System.EventHandler(this.btnSearchByPrice_Click);
            // 
            // btnSeachByUnit
            // 
            this.btnSeachByUnit.Location = new System.Drawing.Point(767, 194);
            this.btnSeachByUnit.Name = "btnSeachByUnit";
            this.btnSeachByUnit.Size = new System.Drawing.Size(137, 29);
            this.btnSeachByUnit.TabIndex = 21;
            this.btnSeachByUnit.Text = "Search By Unit";
            this.btnSeachByUnit.UseVisualStyleBackColor = true;
            this.btnSeachByUnit.Click += new System.EventHandler(this.btnSeachByUnit_Click);
            // 
            // lbUptoPrice
            // 
            this.lbUptoPrice.AutoSize = true;
            this.lbUptoPrice.Location = new System.Drawing.Point(264, 198);
            this.lbUptoPrice.Name = "lbUptoPrice";
            this.lbUptoPrice.Size = new System.Drawing.Size(48, 20);
            this.lbUptoPrice.TabIndex = 22;
            this.lbUptoPrice.Text = "Up To";
            // 
            // lbMoreThanUnit
            // 
            this.lbMoreThanUnit.AutoSize = true;
            this.lbMoreThanUnit.Location = new System.Drawing.Point(599, 199);
            this.lbMoreThanUnit.Name = "lbMoreThanUnit";
            this.lbMoreThanUnit.Size = new System.Drawing.Size(80, 20);
            this.lbMoreThanUnit.TabIndex = 23;
            this.lbMoreThanUnit.Text = "More Than";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(729, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(86, 333);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 29);
            this.Delete.TabIndex = 25;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(306, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(523, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 669);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbMoreThanUnit);
            this.Controls.Add(this.lbUptoPrice);
            this.Controls.Add(this.btnSeachByUnit);
            this.Controls.Add(this.btnSearchByPrice);
            this.Controls.Add(this.txtSearchByUnit);
            this.Controls.Add(this.txtUptoPrice);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.txtUnitInStock);
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
            this.Controls.Add(this.txtSearchID);
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
        private MaskedTextBox txtSearchID;
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
        private TextBox txtUnitInStock;
        private Button btnSearchByID;
        private TextBox txtSearchName;
        private Button btnSearchByName;
        private MaskedTextBox txtUptoPrice;
        private MaskedTextBox txtSearchByUnit;
        private Button btnSearchByPrice;
        private Button btnSeachByUnit;
        private Label lbUptoPrice;
        private Label lbMoreThanUnit;
        private Button btnClear;
        private Button Delete;
        private Button btnAdd;
        private Button btnUpdate;
    }
}