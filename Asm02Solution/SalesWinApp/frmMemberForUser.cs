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
    public partial class frmMemberForUser : Form
    {
        public Member user { get; set; }
        public frmMain mainForm { get; set; } 
        private MemberRepository memberRepository = new MemberRepository();

        public frmMemberForUser()
        {
            InitializeComponent();
        }

        private void frmMemberForUser_Load(object sender, EventArgs e)
        {
            GetMemberInfo();
        }

        private void GetMemberInfo()
        {
            txtID.Text = user.MemberId.ToString();
            txtEmail.Text = user.Email.ToString();
            txtPassword.Text = user.Password.ToString();
            txtCompany.Text = user.CompanyName.ToString();
            txtCountry.Text = user.Country.ToString();
            txtCity.Text = user.City.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new Member
                {
                    MemberId = int.Parse(txtID.Text),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompany.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text
                };
                memberRepository.UpdateMember(member);
                user = member;
                mainForm.user = this.user;
                GetMemberInfo();
                MessageBox.Show("Update fail successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Update account");
            }
            
        }
    }
}
