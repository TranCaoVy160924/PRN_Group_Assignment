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


namespace SalesWinApp
{
    public partial class frmOrderProductDetails : Form
    {
        public OrderDetail orderDetailInfo = new OrderDetail();
        public bool InsertOrUpdate { get; set; }//False: insert, true: update
        public IOrderDetaiRepository OrderDetaiRepository { get; set; }
        public frmOrderProductDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var orderDetail = new OrderDetail
            //    {
            //        UnitPrice = decimal.Parse(txtUnitPrice.Text),
            //        Quantity = int.Parse(txtQuantity.Text),
            //        Discount = double.Parse(txtDiscount.Text),
            //    };
            //    if (InsertOrUpdate == false)
            //    {
            //        MessageBox.Show(member.MemberId.ToString(), "hello");
            //        OrderDetailRepository.InsertOrderDetail(orderDetail);
            //        OrderDetaiRepository.
            //    }
            //    else
            //    {
            //        member.MemberId = int.Parse(txtID.Text);
            //        MemberRepository.UpdateMember(member);

            //    }
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Insert");
            //}

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
    

