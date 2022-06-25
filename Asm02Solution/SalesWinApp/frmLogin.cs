using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Ass2.BusinessObject;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void Emailtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelEmail_Click_1(object sender, EventArgs e)
        {
                 
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            this.Hide();
            string Email, password;
            Email = textBoxEmail.Text;
            password = textBoxPassword.Text;

          

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}