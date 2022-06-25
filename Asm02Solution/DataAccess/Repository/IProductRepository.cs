using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;

namespace Ass2.DataAccess.Repository
{  
    public interface IProductRepository
    {
        Func<string, IEnumerable<Product>> GetProducts();
        IEnumerable<Product> GetProducts<T>(T searchKey);
        Product GetProductByID(int productID);
        void InsertProduct(Product product);
        void DeleteMember(int productID);
        void UpdateMember(Product product);
    }
}
