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

        public IEnumerable<Product> GetProductsBy(
            string searchChoice, string searchKey = "")
        {
            IEnumerable<Product> products = null;
            try
            {
                if (searchChoice.Equals(GENERAL))
                {
                    products = ProductDAO.Instance.GetProductList();
                }
                if (searchChoice.Equals(BY_NAME) && !searchKey.Equals(""))
                {
                    products = ProductDAO.Instance.GetProductByName(searchKey);
                }
                if (searchChoice.Equals(BY_PRICE) && !searchKey.Equals(""))
                {
                    products = ProductDAO.Instance.GetProductByPrice(searchKey);
                }
                if (searchChoice.Equals(BY_UNIT_IN_STOCK) && !searchKey.Equals(""))
                {
                    products = ProductDAO.Instance.GetProductByUnit(searchKey);
                }
                if (searchChoice.Equals(BY_ID) && !searchKey.Equals(""))
                {
                    products = ProductDAO.Instance.GetProductByID(searchKey);
                }
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            
            return products;
        }

        public void DeleteProduct(int productID) 
            => ProductDAO.Instance.Delete(productID);

        public void AddProduct(Product product)
            => ProductDAO.Instance.Add(product);

        public void UpdateProduct(Product product)
            => ProductDAO.Instance.Update(product);

    }
}
