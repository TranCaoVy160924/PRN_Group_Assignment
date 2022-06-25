using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ass2.BusinessObject;
using Ass2.DataAccess;
using Ass2.DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            //ProductRepository productRepository = new ProductRepository();
            //productRepository.GetProductsBy = 
            //    new Func<string, IEnumerable<Product>>(
            //        ProductDAO.Instance.GetProductList);

            //productRepository.GetProductsBy.Invoke("dsf");
        }
    }
}
