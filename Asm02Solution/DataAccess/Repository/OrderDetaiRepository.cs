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

        public void DeleteOrderDetail(int orderID, int productID)
            => OrderDetailDAO.Instance.Delete(orderID, productID);

        public void UpdateOrder(OrderDetail orderDetail)
            => OrderDetailDAO.Instance.Update(orderDetail);

        public List<Report> GetSaleReport(DateTime from, DateTime to)
            => OrderDetailDAO.Instance.GetSaleByPeriod(from, to);
       
    }
}
