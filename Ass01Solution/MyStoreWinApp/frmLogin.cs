using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*if (isValid())
            {
                using(SqlConnection conn=new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;
                AttachDbFilename=|DataDirectory|\ASS1_DB.mdf;Integrated Security=true"))
                {
                    string query = "select * from FStore where Email = '" +
                    txtEmail.Text.Trim() + "'and Password = " + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if(dta.Rows.Count == 1)
                    {
                        frmMemberManagement frmMemberManagement = new frmMemberManagement();
                        this.Hide();
                        frmMemberManagement.Show();
                    }
               }
            }*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isValid()
        {
            if (txtEmail.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Invalid email!");
                return false;
            }else if(txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Invalid password");
                return false;
            }
            return true;
        }
    }
}
