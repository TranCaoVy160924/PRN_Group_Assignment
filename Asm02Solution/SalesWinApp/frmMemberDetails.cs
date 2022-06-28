
using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberInfo { get; set; }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtID.Text = MemberInfo.MemberID.ToString();
                txtEmail.Text = MemberInfo.MemberEmail.ToString();
                txtCompName.Text = MemberInfo.CompanyName.ToString();
                txtCity.Text = MemberInfo.MemberCity.ToString();
                txtCountry.Text = MemberInfo.MemberCountry.ToString();
                txtPassword.Text = MemberInfo.MemberPassword.ToString();
            }
        }

        private IMemberRepository GetMemberRepository()
        {
            return MemberRepository;
        }

        private void btnSave_Click(object sender, EventArgs e, IMemberRepository memberRepository)
        {
            if (txtCompName.Text.Equals("") || txtEmail.Text.Equals("") || txtPassword.Text.Equals("") || txtCity.Text.Equals("") || txtCountry.Text.Equals(""))
            {
                MessageBox.Show("Missing input !", "Error");
            }
            else
            {
                try
                {
                    var member = new MemberObject
                    {
                        MemberID = int.Parse(txtID.Text),
                        MemberEmail = txtEmail.Text,
                        CompanyName = txtCompName.Text,
                        MemberCity = txtCity.Text,
                        MemberCountry = txtCountry.Text,
                        MemberPassword = txtPassword.Text

                    };
                    if (InsertOrUpdate == false)
                    {
                        memberRepository.InsertMember(member);
                    }
                    else
                    {
                        MemberRepository.UpdateMember(member);
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new member" : "Update member");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
    }

