using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
{  
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductList();

        Product GetProductByID(int productID);

        IEnumerable<Product> SearchProducts(string productName = "",
            int lowerPrice = 0, int upperPrice = 0);

        void DeleteProduct(int productID);

        void AddProduct(Product product);

        void UpdateProduct(Product product);
    }
}
