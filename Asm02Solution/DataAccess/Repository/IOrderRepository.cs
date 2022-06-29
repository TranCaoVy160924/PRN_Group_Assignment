using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;

namespace Ass2.DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<UserOrder> GetOrders(); 
        void InsertOrder(UserOrder order);
        void DeleteOrder(int orderID);
        void UpdateOrder(UserOrder order);
    }
}
