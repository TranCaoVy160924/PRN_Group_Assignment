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
using Ass2.DataAccess.Repository;
using Ass2.BusinessObject;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        MemberRepository db = new MemberRepository();
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            string EmailIn, passwordIn;
            EmailIn = tbEmail.Text;
            passwordIn = tbPassword.Text;

            //test for admin
            //EmailIn = "tlhnhan@gmail.com";
            //passwordIn = "12345678";

            //test for normal user
            //EmailIn = "dnbchau@";
            //passwordIn = "12345678";


            Member check = db.GetMailAndPassword(EmailIn, passwordIn);

            if(check == null)
            {
                lbErrorMessage.Show();
            }
            else
            {
                frmMain mainForm = new frmMain();
                mainForm.user = check;
                mainForm.Show();
                this.Hide();
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lbErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}