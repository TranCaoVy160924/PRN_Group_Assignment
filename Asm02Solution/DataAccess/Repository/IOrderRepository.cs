using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<OrderObject> GetOrders();
        OrderObject GetOrderByID(int OrderID);
        void InsertOrder(OrderObject order);
        void DeleteOrder(int OrderID);
        void UpdateOrder(OrderObject order);
    }
}
