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
using Ass2.DataAccess;
using Ass2.DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmUserOrdersDetails : Form
    {
        public UserOrder orderInfo = new UserOrder();
        public bool InsertOrUpdate { get; set; }//False: insert, true: update
        public IOrderRepository orderRepository { get; set; }
        public Member user { get; set; }

        public frmUserOrdersDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtMemberId.Text) || String.IsNullOrEmpty(txtFreight.Text)
                    || String.IsNullOrEmpty(txtOrderDate.Text) || String.IsNullOrEmpty(txtRequiredDate.Text)
                    || String.IsNullOrEmpty(txtShippedDate.Text))
                {
                    throw new Exception("Invalid input");
                }
                DateTime orderDate = DateTime.ParseExact(
                        txtOrderDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime requiredDate = DateTime.ParseExact(
                        txtRequiredDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime shippedDate = DateTime.ParseExact(
                        txtShippedDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (DateTime.Compare(orderDate, requiredDate) > 0 
                    || DateTime.Compare(orderDate, shippedDate) > 0)
                {
                    throw new Exception("Invalid date time input");
                }

                var order = new UserOrder
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    OrderDate = orderDate,
                    RequiredDate = requiredDate,
                    ShippedDate = shippedDate
                };
                if (InsertOrUpdate == false)
                {
                    orderRepository.InsertOrder(order);
                }
                else
                {
                    order.OrderId = int.Parse(txtOderID.Text);
                    orderRepository.UpdateOrder(order);

                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Close form");
            }
        }

        private void frmUserOrdersDetails_Load(object sender, EventArgs e)
        {
            txtOderID.Enabled = false;
            if (InsertOrUpdate == true) //update mode
            {

                //Show current information
                txtOderID.Text = orderInfo.OrderId.ToString();
                txtMemberId.Text = orderInfo.MemberId.ToString();
                txtFreight.Text = orderInfo.Freight.ToString();
                txtOrderDate.Text = orderInfo.OrderDate.ToString("dd/MM/yyyy");
                txtRequiredDate.Text = orderInfo.RequiredDate.ToString("dd/MM/yyyy");
                txtShippedDate.Text = orderInfo.ShippedDate.ToString("dd/MM/yyyy");
            }

            if (!user.IsAdmin)
            {
                txtMemberId.Text = user.MemberId.ToString();
                txtMemberId.ReadOnly = true;
            }
        }
    }
}
