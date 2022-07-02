using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;


namespace Ass2.DataAccess.Repository
{
    public class OrderDetaiRepository /*IOrderRepository*/
    {
        public IEnumerable<OrderDetail> GetOrderDetails(int orderID)
            => OrderDetailDAO.Instance.GetOrderDetailList(orderID);

        /*public void InsertOrder(UserOrder order)
            => OrderDetailDAO.Instance.Add(order);
        */

        public void DeleteOrderDetail(int orderID)
            => OrderDetailDAO.Instance.Delete(orderID);

        public void UpdateOrder(OrderDetail orderDetail)
            => OrderDetailDAO.Instance.Update(orderDetail);

       
    }
}
