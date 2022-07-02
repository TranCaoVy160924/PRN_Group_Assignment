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
        IOrderRepository OrderRepository= new OrderRepository();

        public OrderDetail OrderDetailInfo { get; internal set; }
        public frmOrderProduct()
        {
            InitializeComponent();
        }

        private void lbMemberID_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrderProductDetails frm = new frmOrderProductDetails
            {
                OrderID = txtOrderID
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtShippedDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbShippedDate_Click(object sender, EventArgs e)
        {

        }

        private void txtRequiredDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbRequiredDate_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbOrderDate_Click(object sender, EventArgs e)
        {

        }

        private void txtFreight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbFreight_Click(object sender, EventArgs e)
        {

        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtOderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbOrderID_Click(object sender, EventArgs e)
        {

        }
    }
}
