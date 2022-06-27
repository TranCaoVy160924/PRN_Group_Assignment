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
        private const string BY_NAME = "name";
        private const string BY_PRICE = "price";
        private const string BY_UNIT_IN_STOCK = "unitInStock";
        private const string GENERAL = "general";
        private const string BY_ID = "id";

        ProductRepository ProductRepository = new ProductRepository();
        //Create a data source
        SortableBindingList<Product> source;

        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            var products = ProductRepository.GetProductsBy(GENERAL);
            LoadProductList(products);
        }

        private void LoadProductList(IEnumerable<Product> products)
        {
            try
            {
                source = new SortableBindingList<Product>();
                foreach (var product in products)
                {
                    source.Add(product);
                }

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Category", typeof(int));
                dataTable.Columns.Add("Product Name", typeof(string));
                dataTable.Columns.Add("Weight", typeof(string));
                dataTable.Columns.Add("Price", typeof(decimal));
                dataTable.Columns.Add("Unit In Stock", typeof(int));

                foreach (var product in products)
                {
                    dataTable.Rows.Add(product.ProductId, product.Category,
                        product.ProductName, product.Weight, product.UnitPrice,
                        product.UnitsInStock);
                }

                dgvProductsList.DataSource = dataTable;

                txtProductID.Text = dataTable.Rows[0][0].ToString();
                txtProductCategory.Text = dataTable.Rows[0][1].ToString();
                txtProductName.Text = dataTable.Rows[0][2].ToString();
                txtWeight.Text = dataTable.Rows[0][3].ToString();
                txtProductPrice.Text = dataTable.Rows[0][4].ToString();
                txtUnitInStock.Text = dataTable.Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product list");
            }
        }

        private void dgvProductsList_DataSourceChanged(object sender, EventArgs e)
        {
            // Set your desired AutoSize Mode:
            dgvProductsList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProductsList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProductsList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgvProductsList.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvProductsList.Columns[i].Width;

                // Remove AutoSizing:
                dgvProductsList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvProductsList.Columns[i].Width = colw;
            }
        }

        private void dgvProductsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvProductsList.Rows[e.RowIndex];
                txtProductID.Text = dgvRow.Cells[0].Value.ToString();
                txtProductCategory.Text = dgvRow.Cells[1].Value.ToString();
                txtProductName.Text = dgvRow.Cells[2].Value.ToString();
                txtWeight.Text = dgvRow.Cells[3].Value.ToString();
                txtProductPrice.Text = dgvRow.Cells[4].Value.ToString();
                txtUnitInStock.Text = dgvRow.Cells[5].Value.ToString();
            }
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtSearchID.Text.Equals(""))
                {
                    IEnumerable<Product> products
                        = ProductRepository.GetProductsBy(BY_ID, txtSearchID.Text);
                    LoadProductList(products);
                }      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void btnSearchByPrice_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUptoPrice.Text.Equals(""))
                {
                    IEnumerable<Product> products
                        = ProductRepository.GetProductsBy(BY_PRICE, txtUptoPrice.Text);
                    LoadProductList(products);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeachByUnit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtSearchByUnit.Text.Equals(""))
                {
                    IEnumerable<Product> products
                        = ProductRepository.GetProductsBy(
                            BY_UNIT_IN_STOCK, txtSearchByUnit.Text);
                    LoadProductList(products);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtSearchName.Text.Equals(""))
                {
                    IEnumerable<Product> products
                        = ProductRepository.GetProductsBy(BY_NAME, txtSearchName.Text);
                    LoadProductList(products);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchID.Text = "";
            txtSearchName.Text = "";
            txtSearchByUnit.Text = "";
            txtUptoPrice.Text = "";

            var products = ProductRepository.GetProductsBy(GENERAL);
            LoadProductList(products);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                ProductRepository.DeleteProduct(product.ProductId);
                var products = ProductRepository.GetProductsBy(GENERAL);
                LoadProductList(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private Product GetProductObject()
        {
            Product product = null;
            try
            {
                product = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    Category = int.Parse(txtProductCategory.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitInStock.Text),
                    UnitsInStock = int.Parse(txtUnitInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }//end get member

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductDetail frm = new frmProductDetail
            {
                Text = "Add Product",
                InsertOrUpdate = false,
                ProductRepository = ProductRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //Set focus car inserted 
                //source.Position = source.Count - 1;
            }
            var products = ProductRepository.GetProductsBy(GENERAL);
            LoadProductList(products);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                frmProductDetail frm = new frmProductDetail
                {
                    Text = "Update Member",
                    InsertOrUpdate = true,
                    productInfo = GetProductObject(),
                    ProductRepository = this.ProductRepository
                };
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    
                    //set focus member update
                    //source.Position = source.Count - 1;
                }
                var products = ProductRepository.GetProductsBy(GENERAL);
                LoadProductList(products);
            }
        }
    }
}
