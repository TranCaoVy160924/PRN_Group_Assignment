using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<UserOrder> GetOrders(int memberID = 0)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            IEnumerable<UserOrder> orders = null;
            if (memberID == 0)
            {
                orders = dBContext.UserOrders.ToList();
            }
            else
            {
                orders = dBContext.UserOrders.Where(
                    order => order.MemberId == memberID).ToList();
            }

            return orders;
        }

        public UserOrder GetOrderByID(int orderID)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            UserOrder order = dBContext.UserOrders.Where(
                ord => ord.OrderId == orderID).FirstOrDefault();
            return order;
        }

        public void InsertOrder(UserOrder order)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            try
            {
                dBContext.UserOrders.Add(order);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteOrder(int OrderID)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            UserOrder order = dBContext.UserOrders.Where(
                ord => ord.OrderId == OrderID).FirstOrDefault();
            dBContext.UserOrders.Remove(order);
            dBContext.SaveChanges();
        }

        public void UpdateOrder(UserOrder order)
        {
            using ASS2_DBContext dBContext 
                = new ASS2_DBContext();
            try
            {
                
                dBContext.Entry<UserOrder>(order).State
                    = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
