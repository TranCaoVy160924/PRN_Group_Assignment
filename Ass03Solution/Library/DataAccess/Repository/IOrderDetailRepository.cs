using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> getOrderDetail(int orderID);
        OrderDetail GetDetailByID(int orderID);
        void InsertDetail(OrderDetail detail);
        void DeleteDetail(int orderID, int productID);
        void UpdateDetail(OrderDetail detail);
    }
}