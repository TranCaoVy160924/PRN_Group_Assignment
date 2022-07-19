using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private string ConnectionString;

        public OrderDetailRepository(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public IEnumerable<OrderDetail> getOrderDetail(int orderID)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            var OrderDetail = dBContext.OrderDetails
                .Where(detail => detail.OrderId == orderID).ToList();

            return OrderDetail;
        }
           
        public OrderDetail GetDetailByID(int orderID)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            OrderDetail detail = dBContext.OrderDetails
                .Where(detail => detail.OrderId == orderID).FirstOrDefault();

            return detail;
        }

        public void InsertDetail(OrderDetail detail)
        {
            try
            {
                using ASS2_DBContext dBContext
                    = new ASS2_DBContext();
                dBContext.OrderDetails.Add(detail);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void DeleteDetail(int orderID, int productID)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();
        }

        public void UpdateDetail(OrderDetail detail)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();
        }

        public List<Report> GetSaleReport(DateTime from, DateTime to)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            return null;
        }
    }
}
