using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;

namespace Ass2.DataAccess
{
    public class ProductDAO
    {
        //---------------------------------------------
        //singleton
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        ASS2_DBContext dBContext = new ASS2_DBContext();

        private ProductDAO() { }

        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        //---------------------------------------------

        public IEnumerable<Product> GetProductList()
        {
            var products = dBContext.Products.ToList();
            return products;
        }

        public Product GetProductByID(int productID)
        {
            Product product = dBContext.Products
                .Where(pro => pro.ProductId == productID).FirstOrDefault();
            return product;
        }

        public IEnumerable<Product> GetProductByName(string productName)
        {
            IEnumerable<Product> products = dBContext.Products
                .Where(pro => pro.ProductName.Contains(productName)).ToList();
            return products;
        }

        public IEnumerable<Product> GetProductByPrice(string txtPrice)
        {
            decimal price = decimal.Parse(txtPrice);
            IEnumerable<Product> products = dBContext.Products
                .Where(pro => pro.UnitPrice == price).ToList();
            return products;
        }

        public IEnumerable<Product> GetProductByUnit(string txtUnit)
        {
            int unit = int.Parse(txtUnit);
            IEnumerable<Product> products = dBContext.Products
                .Where(pro => pro.UnitsInStock == unit).ToList();
            return products;
        }


    }
}
