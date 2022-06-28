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
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            var products = dBContext.Products.ToList();
            return products;
        }

        public IEnumerable<Product> GetProductByID(string txtProductID)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            int productID = int.Parse(txtProductID);
            IEnumerable<Product> product = dBContext.Products
                .Where(pro => pro.ProductId == productID).ToList();
            return product;
        }

        public IEnumerable<Product> GetProductByName(string productName)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            IEnumerable<Product> products = dBContext.Products
                .Where(pro => pro.ProductName.Contains(productName)).ToList();
            return products;
        }

        public IEnumerable<Product> GetProductByPrice(string txtPrice)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            decimal price = decimal.Parse(txtPrice);
            IEnumerable<Product> products = dBContext.Products
                .Where(pro => pro.UnitPrice <= price).ToList();
            return products;
        }

        public IEnumerable<Product> GetProductByUnit(string txtUnit)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            int unit = int.Parse(txtUnit);
            IEnumerable<Product> products = dBContext.Products
                .Where(pro => pro.UnitsInStock >= unit).ToList();
            return products;
        }

        public void Delete(int productID)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            Product product = dBContext.Products.Where(pro => pro.ProductId == productID).FirstOrDefault();
            dBContext.Products.Remove(product);
            dBContext.SaveChanges();
        }

        public void Add(Product product)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();
                dBContext.Products.Add(product);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void Update(Product product)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();
                dBContext.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
