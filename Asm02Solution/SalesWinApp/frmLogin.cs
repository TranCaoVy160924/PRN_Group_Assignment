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
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;

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
            lbErrorMessage.Visible = false;

            string username;
            string password;
            try
            {

                IConfiguration config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();
                username = config["DefaulAccount:USERNAME"];
                password = config["DefaulAccount:PASSWORD"];

                Member member = new Member();
                member.Email = username;
                member.Password = password;
                member.Country = "dfasdf";
                member.City = "sdafsadf";
                member.CompanyName = "";
                member.IsAdmin = true;

                Member pre = db.GetMailAndPassword(username, password);

                if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password)
                    && pre == null)
                {
                    db.InsertMember(member);
                    MessageBox.Show("Insert Default member " + username + " " + password);
                }  
            }
            catch (Exception ex)
            {
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string EmailIn, passwordIn;
            EmailIn = tbEmail.Text;
            passwordIn = tbPassword.Text;

            //test for admin
            //EmailIn = "vdhoa@gmail.com";
            //passwordIn = "12345678";

            //test for normal user
            //EmailIn = "dnbchau@gmail.com";
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmMemberForUser signUpFrm = new frmMemberForUser
            {
                user = null,
                mainForm = null,
                addOrUpdate = false
            };
            signUpFrm.ShowDialog();
        }
    }
}