using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ass2.BusinessObject;
using Ass2.DataAccess.Repository;
using Ass2.DataAccess;

namespace SalesWinApp
{
    public partial class frmOrderProduct : Form
    {
        OrderDetailRepository OrderDetaiRepository= new OrderDetailRepository();

        public int orderId { get; set; }

        public OrderDetail OrderDetailInfo { get; internal set; }
        public frmOrderProduct()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrderProductDetails frm = new frmOrderProductDetails
            {
                orderId = int.Parse(txtOderID.Text),
                Text = "Add Order",
                InsertOrUpdate = false,
                OrderDetaiRepository = this.OrderDetaiRepository
            };
            frm.ShowDialog();
            var orders = OrderDetaiRepository.getOrderDetail(orderId);
            LoadOrderDetailList(orders);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderProductDetails frm = new frmOrderProductDetails
            {
                orderId = int.Parse(txtOderID.Text),
                Text = "Update detail",
                InsertOrUpdate = true,
                OrderDetailInfo = GetDetailObject(),
                OrderDetaiRepository = this.OrderDetaiRepository
            };
            frm.ShowDialog();
            var orders = OrderDetaiRepository.getOrderDetail(orderId);
            LoadOrderDetailList (orders);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var detail = GetDetailObject();
                OrderDetaiRepository.DeleteDetail(detail.OrderId, detail.ProductId);
                var details = OrderDetaiRepository.getOrderDetail(orderId);
                LoadOrderDetailList(details);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmOrderProduct_Load(object sender, EventArgs e)
        {
            var orderDetails = OrderDetaiRepository.getOrderDetail(this.orderId);
            LoadOrderDetailList(orderDetails);
        }

        private void LoadOrderDetailList(IEnumerable<OrderDetail> orderDetails)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Order ID", typeof(int));
                dataTable.Columns.Add("Product ID", typeof(int));
                dataTable.Columns.Add("Quantity", typeof(int));
                dataTable.Columns.Add("Discount", typeof(double));
                dataTable.Columns.Add("Unit Price", typeof(decimal));

                foreach (var orderDetail in orderDetails)
                {
                    dataTable.Rows.Add(orderDetail.ProductId, orderDetail.ProductId,
                        orderDetail.Quantity, orderDetail.Discount, orderDetail.UnitPrice);
                }

                dgvOrderDetailList.DataSource = dataTable;

                txtOderID.Text = dataTable.Rows[0][0].ToString();
                txtProductID.Text = dataTable.Rows[0][1].ToString();
                txtQuantity.Text = dataTable.Rows[0][2].ToString();
                txtDiscount.Text = dataTable.Rows[0][3].ToString();
                txtUnitPrice.Text = dataTable.Rows[0][4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Load Order Detail list");
            }
        }

        private void dgvOrderDetailList_DataSourceChanged(object sender, EventArgs e)
        {
            // Set your desired AutoSize Mode:
            dgvOrderDetailList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrderDetailList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrderDetailList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgvOrderDetailList.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvOrderDetailList.Columns[i].Width;

                // Remove AutoSizing:
                dgvOrderDetailList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvOrderDetailList.Columns[i].Width = colw;
            }

        }

        private OrderDetail GetDetailObject()
        {
            OrderDetail detail = null;
            try
            {
                int orderID = orderId;
                detail = OrderDetaiRepository.GetDetailByID(orderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return detail;
        }
    }
}
