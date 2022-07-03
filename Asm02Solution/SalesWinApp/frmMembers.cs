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
using Ass2.DataAccess;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        IMemberRepository MemberRepository = new MemberRepository();
        public Member MemberInfo { get; internal set; }

        public frmMembers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var members = MemberRepository.GetMembers();
            LoadMemberList(members);
        }

        public void LoadMemberList(IEnumerable<Member> members)
        {
            if (members.Count() > 0)
            {
                try
                {

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("ID", typeof(int));
                    dataTable.Columns.Add("Email", typeof(string));
                    dataTable.Columns.Add("CompanyName", typeof(string));
                    dataTable.Columns.Add("City", typeof(string));
                    dataTable.Columns.Add("Country", typeof(string));
                    dataTable.Columns.Add("Password", typeof(string));
                    dataTable.Columns.Add("Role", typeof(bool));

                    dataTable.Columns["Role"].ReadOnly = true;

                    foreach (var member in members)
                    {
                        dataTable.Rows.Add(member.MemberId, member.Email,
                            member.CompanyName, member.City, member.Country,
                            member.Password, member.IsAdmin);
                    }

                    dgvMemberList.DataSource = dataTable;

                    txtID.Text = dataTable.Rows[0][0].ToString();
                    txtEmail.Text = dataTable.Rows[0][1].ToString();
                    txtCompany.Text = dataTable.Rows[0][2].ToString();
                    txtCity.Text = dataTable.Rows[0][3].ToString();
                    txtCountry.Text = dataTable.Rows[0][4].ToString();
                    txtPassword.Text = dataTable.Rows[0][5].ToString();
                    chkAdmin.Checked = Convert.ToBoolean(dataTable.Rows[0][6]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Member list");
                }
            } 
            else
            {
                try
                {
                    dgvMemberList.DataSource = null;
                }
                catch{}
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
        //Get member list
        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = int.Parse(txtID.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompany.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text,
                    IsAdmin = chkAdmin.Checked
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }//end get member

        //btn Detle
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                MemberRepository.DeleteMember(member.MemberId);
                var members = MemberRepository.GetMembers();
                LoadMemberList(members);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//end btnDelete

        private void dgvMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgvMemberList.Rows[e.RowIndex];
                    txtID.Text = dgvRow.Cells[0].Value.ToString();
                    txtEmail.Text = dgvRow.Cells[1].Value.ToString();
                    txtCompany.Text = dgvRow.Cells[2].Value.ToString();
                    txtCity.Text = dgvRow.Cells[3].Value.ToString();
                    txtCountry.Text = dgvRow.Cells[4].Value.ToString();
                    txtPassword.Text = dgvRow.Cells[5].Value.ToString();
                    chkAdmin.Checked = Convert.ToBoolean(dgvRow.Cells[6].Value);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
                frmMembersDetails frm = new frmMembersDetails
                    {
                        Text = "Update Member",
                        InsertOrUpdate = true,
                        memberInfo = GetMemberObject(),
                        MemberRepository = this.MemberRepository
                    };
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var m1 = MemberRepository.GetMembers();
                    LoadMemberList(m1);
                    //set focus member update
                    //source.Position = source.Count - 1;
                }
                var m2 = MemberRepository.GetMembers();
                LoadMemberList(m2);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMembersDetails frm = new frmMembersDetails
            {
                    Text = "Add Member",
                    InsertOrUpdate = false,
                    MemberRepository = MemberRepository,
                };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //Set focus car inserted 
                //source.Position = source.Count - 1;
            }
            var m = MemberRepository.GetMembers();
            LoadMemberList(m);
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
