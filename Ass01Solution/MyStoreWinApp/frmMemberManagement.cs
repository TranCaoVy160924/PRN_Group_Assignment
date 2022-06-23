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
        MemberRepository memberRepository = new MemberRepository();
        //Create a data source
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadCarList();
        }

        public void LoadCarList()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = members;                
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
    }
}
