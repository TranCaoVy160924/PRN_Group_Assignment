namespace SalesWinApp
{
    partial class frmSaleReport
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
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.txtFormDate = new System.Windows.Forms.MaskedTextBox();
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(41, 33);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(43, 20);
            this.lbFrom.TabIndex = 0;
            this.lbFrom.Text = "From";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(378, 33);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(25, 20);
            this.lbTo.TabIndex = 1;
            this.lbTo.Text = "To";
            // 
            // txtFormDate
            // 
            this.txtFormDate.Location = new System.Drawing.Point(112, 30);
            this.txtFormDate.Mask = "00/00/0000";
            this.txtFormDate.Name = "txtFormDate";
            this.txtFormDate.Size = new System.Drawing.Size(228, 27);
            this.txtFormDate.TabIndex = 2;
            this.txtFormDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(426, 30);
            this.txtToDate.Mask = "00/00/0000";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(237, 27);
            this.txtToDate.TabIndex = 3;
            this.txtToDate.ValidatingType = typeof(System.DateTime);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(12, 98);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 29;
            this.dgvReport.Size = new System.Drawing.Size(887, 350);
            this.dgvReport.TabIndex = 4;
            this.dgvReport.DataSourceChanged += new System.EventHandler(this.dgvReport_DataSourceChanged);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(702, 24);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(197, 29);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // frmSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFormDate);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Name = "frmSaleReport";
            this.Text = "frmSaleReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbFrom;
        private Label lbTo;
        private MaskedTextBox txtFormDate;
        private MaskedTextBox txtToDate;
        private DataGridView dgvReport;
        private Button btnGenerateReport;
    }
}