using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
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
                
                dBContext.Entry<OrderDetail>(od).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Report> GetSaleByPeriod(DateTime fromDate, DateTime toDate)
        {
            ASS2_DBContext dBContext = new ASS2_DBContext();
            List<Report> reports = new List<Report>();

            ProductRepository productRepository = new ProductRepository();
            var products = productRepository.GetProductsBy("general");

            foreach (Product product in products)
            {
                var orderDetails = dBContext.OrderDetails
                    .Where( detail => DateTime.Compare((DateTime)detail.Order.ShippedDate, fromDate)  >= 0
                    && DateTime.Compare((DateTime)detail.Order.ShippedDate, toDate) < 0
                    && detail.ProductId == product.ProductId);

                double sales = 0;
                int numberSaled = 0;
                int numOfOrder = orderDetails.Count();

                foreach (OrderDetail orderDetail in orderDetails)
                {
                    sales += orderDetail.Quantity * 
                        (double)orderDetail.UnitPrice * (1 - orderDetail.Discount/100);
                    numberSaled += orderDetail.Quantity;
                }

                reports.Add(new Report {
                    ProductID = product.ProductId,
                    ProductName = product.ProductName,
                    Sales = sales,
                    NumberSaled = numberSaled,
                    NumberOfOrders = numOfOrder
                });
            }

            return reports;
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
