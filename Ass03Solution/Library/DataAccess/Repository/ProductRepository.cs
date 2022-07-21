using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
{
    public class ProductRepository: IProductRepository
    {
        private const string BY_NAME = "name";
        private const string BY_PRICE = "price";
        private const string BY_UNIT_IN_STOCK = "unitInStock";
        private const string BY_ID = "id";
        private const string GENERAL = "general";

        public IEnumerable<Product> GetProductList()
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            var products = dBContext.Products.ToList();
            return products;
        }

        public Product GetProductByID(int productID)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            Product product = dBContext.Products
                .Where(pro => pro.ProductId == productID).FirstOrDefault();
            return product;
        }

        public IEnumerable<Product> SearchProducts(string productName = "",
            int lowerPrice = 0, int upperPrice = 0)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            IEnumerable<Product> products = null;
            if (!string.IsNullOrEmpty(productName))
            {
                products = dBContext.Products
                .Where(pro => pro.ProductName.Contains(productName)).ToList();
            }
            if (lowerPrice > 0)
            {
                products = products.Where(pro => pro.UnitPrice > lowerPrice).ToList();
            }
            if (upperPrice > 0)
            {
                products = products.Where(pro => pro.UnitPrice < upperPrice).ToList();
            }

            return products;
        }

        public void DeleteProduct(int productID)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            Product product = dBContext.Products
                .Where(pro => pro.ProductId == productID).FirstOrDefault();
            dBContext.Products.Remove(product);
            dBContext.SaveChanges();
        }

        public void AddProduct(Product product)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();
                dBContext.Products.Add(product);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();
                dBContext.Entry<Product>(product).State 
                    = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

    }
}
