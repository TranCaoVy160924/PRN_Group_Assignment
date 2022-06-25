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
        MemberRepository MemberRepository = new MemberRepository();
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

                //dgvMemberList.DataSource = null;
                dhvMemberList.DataSource = source;
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
    }
}
