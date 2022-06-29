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
using Ass2.DataAccess;
using Ass2.DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmUserOrdersDetails : Form
    {
        public UserOrder orderInfo = new UserOrder();
        public bool InsertOrUpdate { get; set; }//False: insert, true: update
        public IOrderRepository orderRepository { get; set; }

        public frmUserOrdersDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new UserOrder
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Freight = int.Parse(txtFreight.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text)
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
                this.Close();
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
                txtMemberID.Text = orderInfo.MemberId.ToString();
                txtFreight.Text = orderInfo.Freight.ToString();
                txtOrderDate.Text =  orderInfo.OrderDate.ToString();
                txtRequiredDate.Text = orderInfo.RequiredDate.ToString();
                txtShippedDate.Text = orderInfo.ShippedDate.ToString();
            }
        }
    }
}
