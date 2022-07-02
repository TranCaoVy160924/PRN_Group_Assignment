using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;

namespace Ass2.DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<UserOrder> GetOrders()
            => OrderDAO.Instance.GetOrderList();

        public UserOrder GetOrderByID(int orderID) 
            => OrderDAO.Instance.GetOrderByID(orderID);

        public void InsertOrder(UserOrder order)
            => OrderDAO.Instance.Add(order);

        public void DeleteOrder(int OrderID)
            => OrderDAO.Instance.Delete(OrderID);

        public void UpdateOrder(UserOrder order)
            => OrderDAO.Instance.Update(order);
    }
}
