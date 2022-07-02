using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;


namespace Ass2.DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> getOrderDetail(int orderID)
            => OrderDetailDAO.Instance.GetOrderDetailList(orderID);

        public OrderDetail GetDetailByID(int orderID)
           => OrderDetailDAO.Instance.GetDetailByID(orderID);

        public void InsertDetail(OrderDetail detail)
            => OrderDetailDAO.Instance.Add(detail);

        public void DeleteDetail(int orderID, int productID)
            => OrderDetailDAO.Instance.Delete(orderID, productID);

        public void UpdateDetail(OrderDetail detail)
            => OrderDetailDAO.Instance.Update(detail);
    }
}
