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
using Ass2.DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmProductDetail : Form
    {
        public Product productInfo { get; set; }
        public bool InsertOrUpdate { get; set; }//False: insert, true: update
        public ProductRepository ProductRepository { get; set; }

        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    Category = int.Parse(txtProductCategory.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitInPrice.Text),
                    UnitsInStock = int.Parse(txtUnitInPrice.Text)
                };
                if (InsertOrUpdate == false)
                {
                    ProductRepository.AddProduct(product);
                }
                else
                {
                    product.ProductId = int.Parse(txtProductID.Text);
                    ProductRepository.UpdateProduct(product);

                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Close form");
            }
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = false;
            if (InsertOrUpdate == true) //update mode
            {
                //Show current information
                txtProductID.Text = productInfo.ProductId.ToString();
                txtProductCategory.Text = productInfo.Category.ToString();
                txtProductName.Text = productInfo.ProductName;
                txtWeight.Text = productInfo.Weight.ToString();
                txtProductPrice.Text = productInfo.UnitPrice.ToString();
                txtUnitInPrice.Text = productInfo.UnitPrice.ToString();
            }
        }
    }
}
