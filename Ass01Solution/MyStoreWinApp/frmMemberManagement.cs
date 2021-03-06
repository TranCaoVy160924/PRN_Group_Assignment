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
using System.Collections.Generic;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        //IMemberRepository MemberRepository = new MemberRepository();
        public MemberDTO MemberInfo { get; internal set; }
        public bool InsertOrUpdate { get; internal set; }
        public IMemberRepository MemberRepository = new MemberRepository();
        //Create a data source
        SortableBindingList<MemberDTO> source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            LoadMemberList();
            //Register this event to open the from that performs updating
            //dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
        }

        //-----------------------------------------------
        

        public void LoadMemberList()
        {
            var members = MemberRepository.GetMembers();
            if (members.Count() > 0)
            {
                try
                {
                    source = new SortableBindingList<MemberDTO>();
                    foreach (var member in members)
                    {
                        source.Add(member);
                    }

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

                    //dgvMemberList.DataSource = null;
                    dgvMemberList.DataSource = source;
                    GetCountryChoice((List<MemberDTO>)members);
                    GetCityChoice((List<MemberDTO>)members);

                    if (members.Count() == 0)
                    {
                        ClearText();
                        btnRemove.Enabled = false;
                    }
                    else
                    {
                        btnRemove.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Member list");
                }
            }
        }

        private void GetCountryChoice(List<MemberDTO> members)
        {
            cbxCountryChoice.Items.Clear();
            var distinctCountry = 
                members.Select(member => member.MemberCountry).Distinct();
            cbxCountryChoice.Items.Add("");
            foreach (var country in distinctCountry)
            {
                cbxCountryChoice.Items.Add(country);
            }
        }

        private void GetCityChoice(List<MemberDTO> members)
        {
            cbxCityChoice.Items.Clear();
            var distinctCity =
                members.Select(member => member.MemberCity).Distinct();
            cbxCityChoice.Items.Add("");
            foreach (var city in distinctCity)
            {
                cbxCityChoice.Items.Add(city);
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
            frmMemberDetails frmCarDEtails =
                new frmMemberDetails
                {
                    Text = "Add Member",
                    InsertOrUpdate = false,
                    MemberRepository = MemberRepository,
                };
            if (frmCarDEtails.ShowDialog() == DialogResult.OK)
            {
                //Set focus car inserted 
                //source.Position = source.Count - 1;
            }
            LoadMemberList();
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

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            frmMemberDetails frmMemberDetails = (frmMemberDetails)sender;
            LoadMemberList();
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //dgvMemberList = new DataGridView();
            LoadMemberList();
            //dgvMemberList.Refresh();
        }

        private void ClearText()
        {
            txtID.Text = String.Empty;
            txtName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtCountry.Text = String.Empty;
            txtCity.Text = String.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails =
                new frmMemberDetails
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
                //source.Position = source.Count - 1;
            }
            LoadMemberList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            this.dgvMemberList.Sort(this.dgvMemberList.Columns["MemberName"], ListSortDirection.Ascending);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var members = MemberRepository.GetMemberObjectByName(txtSearch.Text);
            try
            {
                source = new SortableBindingList<MemberDTO>();
                foreach (var member in members)
                {
                    source.Add(member);
                }

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

                //dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                GetCountryChoice((List<MemberDTO>)members);
                GetCityChoice((List<MemberDTO>)members);

                if (members.Count() == 0)
                {
                    ClearText();
                    btnRemove.Enabled = false;
                }
                else
                {
                    btnRemove.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member list");
            }
        }
       

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            string country = cbxCountryChoice.Text;
            string city = cbxCityChoice.Text;
            if (country.Equals(""))
            {
                country = "%";
            } 
            if (city.Equals(""))
            {
                city = "%";
            }
            var members = MemberRepository.FilterMember(country, city);
            try
            {
                source = new SortableBindingList<MemberDTO>();
                foreach (var member in members)
                {
                    source.Add(member);
                }

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

                //dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                GetCountryChoice((List<MemberDTO>)members);
                GetCityChoice((List<MemberDTO>)members);

                if (members.Count() == 0)
                {
                    ClearText();
                    btnRemove.Enabled = false;
                }
                else
                {
                    btnRemove.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member list");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxCityChoice.SelectedIndex = 0;
            cbxCountryChoice.SelectedIndex = 0;
            txtSearch.Text = "";
            LoadMemberList();
        }
    }
}

