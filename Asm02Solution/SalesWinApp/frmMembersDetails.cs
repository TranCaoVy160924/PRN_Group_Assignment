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
    public partial class frmMembersDetails : Form
    {
        public Member memberInfo = new Member();
        public bool InsertOrUpdate { get; set; }//False: insert, true: update
        public IMemberRepository MemberRepository { get; set; }

        public frmMembersDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    Email = txtEmail.Text,
                    CompanyName = txtCompany.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text,
                    IsAdmin = chkAdmin.Checked
                };
                if (InsertOrUpdate == false)
                {
                    //MessageBox.Show(member.MemberId.ToString(), "hello");
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    member.MemberId = int.Parse(txtID.Text);
                    MemberRepository.UpdateMember(member);

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
        

        private void frmMembersDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (InsertOrUpdate == true) //update mode
            {
                //Show current information
                txtID.Text = memberInfo.MemberId.ToString();
                txtEmail.Text = memberInfo.Email;
                txtCompany.Text = memberInfo.CompanyName;
                txtCity.Text = memberInfo.City;
                txtCountry.Text = memberInfo.Country;
                txtPassword.Text = memberInfo.Password;
                chkAdmin.Checked = Convert.ToBoolean(memberInfo.IsAdmin);
            }
        }
    }
}
