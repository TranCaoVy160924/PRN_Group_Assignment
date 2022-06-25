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

        public Product GetProductByID(string productID)
        {
            Product product = (Product)dBContext.Products
                .Where(pro => pro.ProductId.ToString().Equals(productID));
            return product;
        }
    }
}
