using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;

namespace Ass2.DataAccess.Repository
{
    public interface IOrderDetaiRepository
    {
        Func<string, IEnumerable<Product>> getOrderDetail();
        void InsertProduct(Product product);
        void DeleteMember(int productID);
        void UpdateMember(Product product);
    }
}
