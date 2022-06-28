using BusinessObject;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;
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
    public partial class frmMembers : Form
    {
        MemberRepository memberRepository = new MemberRepository ();
        BindingSource source;
        MemberObject member;
        
        public frmMembers(MemberObject member)
        {
            InitializeComponent();
            this.member = member;
            List<MemberObject> members = new List<MemberObject>();
            if (member.MemberEmail.Equals("admin@fstore.com")) { }
            else
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSearch.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private MemberObject GetMemberObject()
        {
            MemberObject member = (MemberObject)dgvMemberList.CurrentRow.DataBoundItem;
            return member;
        }
        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frm = new frmMemberDetails
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                member = memberRepository.GetMemberByID(member.MemberID);
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }
        public void LoadMemberList()
        {
            List<MemberObject> members = new List<MemberObject>();
            if (member.MemberEmail.Equals("admin@fstore.com"))
            {
                members = (List<MemberObject>)memberRepository.GetMembers();
                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
            }
            else { members.Add(member); }
            try
            {
                source = new BindingSource();
                source.DataSource = members;
                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetails frm = new frmMemberDetails
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails =
                new frmMemberDetails
                {
                    Text = "Update Member",
                    InsertOrUpdate = true,
                    MemberInfo = GetMemberObject(),
                    MemberRepository = this.memberRepository
                };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }
    }
}
