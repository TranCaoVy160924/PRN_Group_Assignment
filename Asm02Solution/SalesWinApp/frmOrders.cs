using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        OrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        OrderObject order;
        MemberObject isUser;
        public frmOrders()
        {
            InitializeComponent();
        }
        
        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isUser.MemberEmail.Equals("admin@fstore.com"))
            {
                frmOrderDetails frm = new frmOrderDetails
                {
                    Text = "Update order",
                    InsertOrUpdate = true,
                    OrderInfo = GetOrderObject(),
                    OrderRepository = orderRepository
                };
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadOrderList();
                    source.Position = source.Count - 1;
                }
            }
        }
    }
}
