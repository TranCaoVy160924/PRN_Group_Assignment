using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
{  
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductsBy(
            string searchChoice, string searchKey = "");

        void DeleteProduct(int productID);

        void AddProduct(Product product);

        void UpdateProduct(Product product);
    }
}
