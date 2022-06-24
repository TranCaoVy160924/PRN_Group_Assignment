using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ass1.BusinessObject;
using Ass1.DataAccess;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate  { get; set; }//False: insert, true: update
        public MemberDTO MemberInfo { get; set; }

        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (InsertOrUpdate == true) //update mode
            {
                //Show current information
                txtID.Text = MemberInfo.MemberID.ToString();
                txtName.Text = MemberInfo.MemberName;
                txtPassword.Text = MemberInfo.Password;
                txtEmail.Text = MemberInfo.MemberEmail;
                txtCountry.Text = MemberInfo.MemberCountry;
                txtCity.Text = MemberInfo.MemberCity;
            }
        }// end form load

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberDTO
                {
                    MemberName = txtName.Text,
                    Password = txtPassword.Text,
                    MemberEmail = txtEmail.Text,
                    MemberCountry = txtCountry.Text,
                    MemberCity = txtCity.Text
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    member.MemberID = int.Parse(txtID.Text);
                    MemberRepository.UpdateMember(member);
                    
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert");
            } 
        }//end button
        
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
            
    }
}
