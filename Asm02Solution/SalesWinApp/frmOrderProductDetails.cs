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
    public partial class frmOrderProductDetails : Form
    {
        public int orderId { get; set; }
        public OrderDetail OrderDetailInfo = new OrderDetail();
        public Product ProductInfo = new Product();
        public bool InsertOrUpdate { get; set; }//False: insert, true: update
        public IOrderDetailRepository OrderDetaiRepository { get; set; }
        public frmOrderProductDetails()
        {
            InitializeComponent();        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductRepository productRepository = new ProductRepository();
            try
            {
                if (String.IsNullOrEmpty(txtQuantity.Text) 
                    || String.IsNullOrEmpty(txtDiscount.Text) 
                    || String.IsNullOrEmpty(txtUnitPrice.Text))
                {
                    throw new Exception("Invalid input");
                }

                if (float.Parse(txtDiscount.Text) > 100)
                {
                    throw new Exception("Discount must smaller than 100");
                }

                Product choice = (Product)cboProductChoice.SelectedItem;
                var detail = new OrderDetail
                {
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = float.Parse(txtDiscount.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    OrderId = orderId,
                    ProductId = choice.ProductId,
                };
                if (InsertOrUpdate == false)
                {
                    OrderDetaiRepository.InsertDetail(detail);
                }
                else
                {
                    
                    OrderDetaiRepository.UpdateDetail(detail);
                }
                Close();
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

        private void frmOrderProductDetails_Load(object sender, EventArgs e)
        {
            ProductRepository productRepository = new ProductRepository();
            var products = productRepository.GetProductsBy("general");
            var currentProducts = productRepository.GetProductsBy("id", OrderDetailInfo.ProductId.ToString());
            txtOderID.Text = orderId.ToString();


            foreach (Product product in products)
            {
                cboProductChoice.Items.Add(product);
            }

            txtOderID.Enabled = false;
            
            if (InsertOrUpdate == true) //update mode
            {
                cboProductChoice.Enabled = false;

                int numberOfItem = cboProductChoice.Items.Count;
                for (int i = 0; i < numberOfItem; i++)
                {
                    Product product =(Product) cboProductChoice.Items[i];
                    if (product.ProductId == OrderDetailInfo.ProductId)
                    {
                        cboProductChoice.SelectedIndex = i;
                    }
                }
                //Show current information
                txtDiscount.Text = OrderDetailInfo.Discount.ToString();
                txtQuantity.Text = OrderDetailInfo.Quantity.ToString();
                txtUnitPrice.Text = OrderDetailInfo.UnitPrice.ToString();
            } 
        }
    }
}
    

