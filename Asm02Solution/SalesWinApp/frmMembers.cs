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
        //Create a data source
        SortableBindingList<Member> source;

        public frmMembers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var members = MemberRepository.GetMembers();
            LoadMemberList(members);
            foreach (var member in members)
            {
                Member blabla = MemberRepository.GetMemberByID(member.MemberId);
            }
        }

        public void LoadMemberList(IEnumerable<Member> members)
        {
            try
            {
                source = new SortableBindingList<Member>();
                foreach (var member in members)
                {
                    source.Add(member);
                }

                //txtID.DataBindings.Clear();
                //txtName.DataBindings.Clear();
                //txtEmail.DataBindings.Clear();
                //txtPassword.DataBindings.Clear();
                //txtCountry.DataBindings.Clear();
                //txtCity.DataBindings.Clear();

                //txtID.DataBindings.Add("Text", source, "MemberID");
                //txtName.DataBindings.Add("Text", source, "MemberName");
                //txtEmail.DataBindings.Add("Text", source, "MemberEmail");
                //txtPassword.DataBindings.Add("Text", source, "Password");
                //txtCountry.DataBindings.Add("Text", source, "MemberCountry");
                //txtCity.DataBindings.Add("Text", source, "MemberCity");

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("CompanyName", typeof(string));
                dataTable.Columns.Add("City", typeof(string));
                dataTable.Columns.Add("Country", typeof(string));
                dataTable.Columns.Add("Password", typeof(string));
                dataTable.Columns.Add("Role", typeof(bool));

                dataTable.Columns["Role"].ReadOnly = true;

                //load on textbox
                txtID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompany.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                chkAdmin.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "MemberId");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompany.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");
                chkAdmin.DataBindings.Add("Checked", source, "IsAdmin");

                foreach (var member in members)
                {
                    dataTable.Rows.Add(member.MemberId, member.Email,
                        member.CompanyName, member.City, member.Country,
                        member.Password,member.IsAdmin);
                }

                dgvMemberList.DataSource = dataTable;
                //GetCountryChoice((List<MemberDTO>)members);
                //GetCityChoice((List<MemberDTO>)members);

                //if (members.Count() == 0)
                //{
                //    ClearText();
                //    btnRemove.Enabled = false;
                //}
                //else
                //{
                //    btnRemove.Enabled = true;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member list");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }//end btnDelete
    }
}
