using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;

namespace Ass2.DataAccess
{
    public class OrderDetailDAO
    { 
        //---------------------------------------------
        //singleton
            private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }

        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        //---------------------------------------------
        public IEnumerable<OrderDetail> GetOrderDetailList(int orderID)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            var OrderDetail = dBContext.OrderDetails
                .Where(detail => detail.OrderId == orderID).ToList();
            return OrderDetail;
        }

        public void Delete(int OrderID, int ProductID)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            OrderDetail order = dBContext.OrderDetails.Where(ord => ord.OrderId == OrderID && ord.ProductId == ProductID).FirstOrDefault();
            dBContext.OrderDetails.Remove(order);
            dBContext.SaveChanges();
        }

        public void Add(OrderDetail order)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();
                dBContext.OrderDetails.Add(order);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public void Update(OrderDetail od)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();
                //var member = dBContext.Members.SingleOrDefault(mem => mem.MemberId == m.MemberId);
                dBContext.Entry<OrderDetail>(od).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();
                //if (member != null)
                //{
                //    dBContext.Members.Update(member);
                //    dBContext.SaveChanges();
                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OrderDetail GetDetailByID(int orderID)
        {
            ASS2_DBContext dBContext = new ASS2_DBContext();
            OrderDetail detail = dBContext.OrderDetails
                .Where(detail => detail.OrderId == orderID).FirstOrDefault();
            return detail;
        }

    }
}
