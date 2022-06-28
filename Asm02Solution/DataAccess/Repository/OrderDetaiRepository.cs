using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public OrderDetailObject GetOrderDetailByOrIDAndProID(int OrderID, int ProductID) => OrderDetailDAO.Instance.GetOrderDetailByOrIDAndProID(OrderID, ProductID);
        public IEnumerable<OrderDetailObject> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();
        public void InsertOrderDetail(OrderDetailObject orderDetail) => OrderDetailDAO.Instance.AddNew(orderDetail);
        public void DeleteOrderDetail(int OrderID, int ProductID) => OrderDetailDAO.Instance.Remove(OrderID, ProductID);
        public void UpdateOrderDetail(OrderDetailObject orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);
    }
}
