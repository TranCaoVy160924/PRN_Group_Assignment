using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ass2.BusinessObject;
using Ass2.DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmSaleReport : Form
    {
        OrderDetaiRepository OrderDetaiRepository = new OrderDetaiRepository();

        public frmSaleReport()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFormDate.Text.Trim().Length < 0 || txtToDate.Text.Trim().Length < 0)
                {
                    throw new Exception("Invalid input");
                } 
                else
                {
                    DateTime fromDate = DateTime.ParseExact(txtFormDate.Text, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture);
                    DateTime toDate = DateTime.ParseExact(txtToDate.Text, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture);

                    if (DateTime.Compare(fromDate, toDate) < 0)
                    {
                        txtFormDate.Text = fromDate.ToString("dd/MM/yyyy");
                        txtToDate.Text = toDate.ToString("dd/MM/yyyy");

                        var reports = OrderDetaiRepository.GetSaleReport(fromDate, toDate);
                        if (reports.Count > 0)
                        {
                            LoadReportList(reports);
                        }
                        else
                        {
                            MessageBox.Show("No sale in period");
                        }
                    } 
                    else
                    {
                        throw new Exception("Invalid input");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LoadReportList(List<Report> reports)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Product Name", typeof(string));
                dataTable.Columns.Add("Number Of Order", typeof(double));
                dataTable.Columns.Add("Number Saled", typeof(int));
                dataTable.Columns.Add("Sales", typeof(int));

                foreach (var report in reports)
                {
                    dataTable.Rows.Add(report.ProductID, report.ProductName,
                        report.NumberOfOrders, report.NumberSaled, report.Sales);
                }

                dgvReport.DataSource = dataTable;

                dgvReport.Sort(dgvReport.Columns[4], ListSortDirection.Descending);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product list");
            }
        }

        private void dgvReport_DataSourceChanged(object sender, EventArgs e)
        {
            // Set your desired AutoSize Mode:
            dgvReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgvReport.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvReport.Columns[i].Width;

                // Remove AutoSizing:
                dgvReport.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvReport.Columns[i].Width = colw;
            }
        }
    }
}
