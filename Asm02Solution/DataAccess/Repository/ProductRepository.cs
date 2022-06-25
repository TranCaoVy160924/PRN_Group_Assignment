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
        private const string BY_ID = "id";

        public Func<string, IEnumerable<Product>> GetProducts { get; set; }
        //public IEnumerable<Product> GetProductsBy(string searchChoice)
        //{
        //    Func<string, IEnumerable<Product>> searchOption;
        //    if (searchChoice.Equals(BY_ID))
        //    {
        //        searchOption = ProductDAO.Instance.GetProductByID;
        //    }
        //}
        
    }
}
