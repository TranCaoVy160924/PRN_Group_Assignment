using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ass3.Library
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private string ConnectionString;

        public OrderDetailRepository()
        {
        }
        public List<Report> GetAll()
        {
            ASS2_DBContext dBContext = new ASS2_DBContext();
            List<Report> reports = new List<Report>();

            ProductRepository productRepository = new ProductRepository();
            var products = productRepository.GetProductList();

            foreach (Product product in products)
            {
                var orderDetails = dBContext.OrderDetails
                    .Where(detail => detail.ProductId == product.ProductId);

                double sales = 0;
                int numberSaled = 0;
                int numOfOrder = orderDetails.Count();

                foreach (OrderDetail orderDetail in orderDetails)
                {
                    sales += orderDetail.Quantity *
                        (double)orderDetail.UnitPrice * (1 - orderDetail.Discount / 100);
                    numberSaled += orderDetail.Quantity;
                }

                reports.Add(new Report
                {
                    ProductID = product.ProductId,
                    ProductName = product.ProductName,
                    Sales = sales,
                    NumberSaled = numberSaled,
                    NumberOfOrders = numOfOrder
                });
            }

            return reports;
        }

        public IEnumerable<OrderDetail> GetOrderDetail(int orderID)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            var OrderDetail = dBContext.OrderDetails
                .Where(detail => detail.OrderId == orderID && detail.Order != null)
                .Include(detail => detail.Order)
                .Include(detail => detail.Product).ToList();

            return OrderDetail;
        }
           
        public OrderDetail GetDetailByID(int orderID)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            OrderDetail detail = dBContext.OrderDetails
                .Where(detail => detail.OrderId == orderID)
                .Include(detail => detail.Order)
                .Include(detail => detail.Product)
                .FirstOrDefault();

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

        public List<Report> GetSaleReport(DateTime fromDate, DateTime toDate)
        {
            ASS2_DBContext dBContext = new ASS2_DBContext();
            List<Report> reports = new List<Report>();

            ProductRepository productRepository = new ProductRepository();
            var products = productRepository.GetProductList();

            foreach (Product product in products)
            {
                var orderDetails = dBContext.OrderDetails
                    .Where(detail => DateTime.Compare((DateTime)detail.Order.ShippedDate, fromDate) >= 0
                    && DateTime.Compare((DateTime)detail.Order.ShippedDate, toDate) < 0
                    && detail.ProductId == product.ProductId);

                double sales = 0;
                int numberSaled = 0;
                int numOfOrder = orderDetails.Count();

                foreach (OrderDetail orderDetail in orderDetails)
                {
                    sales += orderDetail.Quantity *
                        (double)orderDetail.UnitPrice * (1 - orderDetail.Discount / 100);
                    numberSaled += orderDetail.Quantity;
                }

                reports.Add(new Report
                {
                    ProductID = product.ProductId,
                    ProductName = product.ProductName,
                    Sales = sales,
                    NumberSaled = numberSaled,
                    NumberOfOrders = numOfOrder
                });
            }

            return reports;
        }
    }
}
