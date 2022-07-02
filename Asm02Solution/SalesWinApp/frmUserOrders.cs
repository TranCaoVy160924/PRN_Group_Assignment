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
    public partial class frmUserOrders : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        public UserOrder OrderInfo { get; internal set; }

        public frmUserOrders()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUserOrdersDetails frm = new frmUserOrdersDetails
            {
                Text = "Update order",
                InsertOrUpdate = true,
                orderInfo = GetOrderObject(),
                orderRepository = this.orderRepository
            };
            frm.ShowDialog();
            var orders = orderRepository.GetOrders();
            LoadOrderList(orders);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUserOrdersDetails frm = new frmUserOrdersDetails
            {
                Text = "Add Order",
                InsertOrUpdate = false,
                orderRepository = this.orderRepository
            };
            frm.ShowDialog();
            var orders = orderRepository.GetOrders();
            LoadOrderList(orders);
        }

        private void frmUserOrders_Load(object sender, EventArgs e)
        {
            var order = orderRepository.GetOrders();
            LoadOrderList(order);
        }

        public void LoadOrderList(IEnumerable<UserOrder> orders)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Order Id", typeof(int));
                dataTable.Columns.Add("Member Id", typeof(int));
                dataTable.Columns.Add("Freight", typeof(int));
                dataTable.Columns.Add("Order Date", typeof(string));
                dataTable.Columns.Add("Required Date", typeof(string));
                dataTable.Columns.Add("Shipped Date", typeof(string));

                foreach (var order in orders)
                {
                    dataTable.Rows.Add(order.OrderId, order.MemberId,
                        order.Freight, order.OrderDate, order.RequiredDate,
                        order.ShippedDate);
                }

                dgvOrderList.DataSource = dataTable;

                txtOderID.Text = dataTable.Rows[0][0].ToString();
                txtMemberID.Text = dataTable.Rows[0][1].ToString();
                txtFreight.Text = dataTable.Rows[0][2].ToString();
                txtOrderDate.Text = dataTable.Rows[0][3].ToString();
                txtRequiredDate.Text = dataTable.Rows[0][4].ToString();
                txtShippedDate.Text = dataTable.Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order list");
            }
        }

        private void dgvOrderList_DataSourceChanged(object sender, EventArgs e)
        {
            // Set your desired AutoSize Mode:
            dgvOrderList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrderList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOrderList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgvOrderList.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvOrderList.Columns[i].Width;

                // Remove AutoSizing:
                dgvOrderList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvOrderList.Columns[i].Width = colw;
            }
        }

        //Get order list
        private UserOrder GetOrderObject()
        {
            UserOrder order = null;
            try
            {
                int orderID = int.Parse(txtOderID.Text);
                order = orderRepository.GetOrderByID(orderID);

                //order = new UserOrder
                //{
                //    OrderId = int.Parse(txtOderID.Text),
                //    MemberId = int.Parse(txtMemberID.Text),
                //    Freight = int.Parse(txtFreight.Text),
                //    OrderDate = DateTime.Parse(txtOrderDate.Text),
                //    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                //    ShippedDate = DateTime.Parse(txtShippedDate.Text)
                //};
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return order;
        }//end get member

        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgvOrderList.Rows[e.RowIndex];
                    txtOderID.Text = dgvRow.Cells[0].Value.ToString();
                    txtMemberID.Text = dgvRow.Cells[1].Value.ToString();
                    txtFreight.Text = dgvRow.Cells[2].Value.ToString();
                    txtOrderDate.Text = dgvRow.Cells[3].Value.ToString();
                    txtRequiredDate.Text = dgvRow.Cells[4].Value.ToString();
                    txtShippedDate.Text = dgvRow.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
