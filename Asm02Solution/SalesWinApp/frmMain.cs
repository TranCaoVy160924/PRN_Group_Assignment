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

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;
        public Member user { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Is admin " + user.IsAdmin);
            if (!user.IsAdmin)
            {
                tlsManageProduct.Visible = false;
            }
        }

        private void tlsManageMember_Click(object sender, EventArgs e)
        {
            if (user.IsAdmin)
            {
                frmMembers childForm = new frmMembers();
                childForm.MdiParent = this;
                childForm.Dock = DockStyle.Fill;
                childForm.Show();
            }
            else
            {
                frmMemberForUser childForm = new frmMemberForUser
                {
                    user = user,
                    mainForm = this,
                    addOrUpdate = true
                };
                childForm.MdiParent = this;
                childForm.Dock = DockStyle.Fill;
                childForm.Show();
            }
        }

        private void tlsManageProduct_Click(object sender, EventArgs e)
        {
            frmProducts childForm = new frmProducts();
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void tlsClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserOrders childForm = new frmUserOrders();
            childForm.user = user;
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();           
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleReport childForm = new frmSaleReport();
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }
    }
}
