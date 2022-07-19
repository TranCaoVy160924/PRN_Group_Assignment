using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
{
    public class OrderDAO
    {
        //---------------------------------------------
        //singleton
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }

        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        //---------------------------------------------
        public IEnumerable<UserOrder> GetOrderList(int memberID = 0)
        {
            IEnumerable<UserOrder> orders = null;
            ASS2_DBContext dBContext = new ASS2_DBContext();
            if (memberID == 0)
            {
                orders = dBContext.UserOrders.ToList();
            } 
            else
            {
                orders = dBContext.UserOrders.Where(order => order.MemberId == memberID);
            }
            
            return orders;
        }

        public UserOrder GetOrderByID(int orderID)
        {
            ASS2_DBContext dBContext = new ASS2_DBContext();
            UserOrder order = dBContext.UserOrders
                .Where(order => order.OrderId == orderID).FirstOrDefault();
            return order;
        }

        public void Delete(int OrderID)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            UserOrder order = dBContext.UserOrders
                .Where(ord => ord.OrderId == OrderID).FirstOrDefault();
            dBContext.UserOrders.Remove(order);
            dBContext.SaveChanges();
        }

        public void Add(UserOrder order)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();
                dBContext.UserOrders.Add(order);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(UserOrder order)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();
                dBContext.Entry<UserOrder>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
