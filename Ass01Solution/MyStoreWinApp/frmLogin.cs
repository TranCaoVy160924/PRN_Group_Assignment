using Ass1.BusinessObject;
using Ass1.DataAccess;
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
        IMemberRepository memberRepository = new MemberRepository();

        BindingSource source;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string text = txtEmail.Text;
            string Email = text;
            string Password = txtPassword.Text;
            MemberDTO mem = memberRepository.GetMemberObjectByEmailAndPassword(email, password);
            if (mem != null)
            {
                frmMemberManagement frmMemberManagement = new frmMemberManagement
                {
                    Text = "User " + mem.MemberEmail,
                    MemberInfo = mem,
                    InsertOrUpdate = true,
                    MemberRepository = memberRepository

                };
                if (frmMemberManagement.ShowDialog() == DialogResult.OK)
                {
                    source.Position = source.Count - 1;
                }
            }
            else
            {
                MessageBox.Show("Email or password does not match.");
            }
            frmMemberManagement frm = new frmMemberManagement();
            frm.Show();
            this.Hide();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want Close?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private bool isValid()
        {
            if (txtEmail.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Invalid email!");
                return false;
            }
            else if (txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Invalid password");
                return false;
            }
            return true;
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {

        }
    }
}

