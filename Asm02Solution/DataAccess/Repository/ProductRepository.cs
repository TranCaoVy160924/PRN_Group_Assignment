using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;

namespace Ass2.DataAccess.Repository
{
    public class ProductRepository
    {
        private const string BY_NAME = "name";
        private const string BY_PRICE = "price";
        private const string BY_UNIT_IN_STOCK = "unitInStock";
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
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            
            return products;
        }

    }
}
