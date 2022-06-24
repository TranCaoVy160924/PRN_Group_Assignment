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
    public partial class frmMemberManagement : Form
    {
        IMemberRepository MemberRepository = new MemberRepository();
        //Create a data source
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadMemberList();
            btnRemove.Enabled = false;
            //Register this event to open the from that performs updating
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
        }

        //-----------------------------------------------
        

        public void LoadMemberList()
        {
            var members = MemberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtCity.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "MemberID");
                txtName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "MemberEmail");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCountry.DataBindings.Add("Text", source, "MemberCountry");
                txtCity.DataBindings.Add("Text", source, "MemberCity");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }
        }

        private void dgvMemberList_DataSourceChanged(object sender, EventArgs e)
        {
            // Set your desired AutoSize Mode:
            dgvMemberList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMemberList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMemberList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgvMemberList.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvMemberList.Columns[i].Width;

                // Remove AutoSizing:
                dgvMemberList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvMemberList.Columns[i].Width = colw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = MemberRepository,
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                MemberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = this.MemberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //set focus member update
                source.Position = source.Count - 1;
            }
        }

        private MemberDTO GetMemberObject()
        {
            MemberDTO member = null;
            try
            {
                member = new MemberDTO
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    Password = txtPassword.Text,
                    MemberEmail = txtEmail.Text,
                    MemberCity = txtCity.Text,
                    MemberCountry = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }// end get member
    }
}
