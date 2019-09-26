using SunshineMinistriesContact.Data_Acess_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineMinistriesContact.User_Interface
{
    public partial class frmOrganization : Form
    {

        List<Organization> list = OrganizationDB.TestPopulate();

        public frmOrganization()
        {
            InitializeComponent();
        }

        private void FrmOrganization_Load(object sender, EventArgs e)
        {
            dgvOrganization.DataSource = list;
            dgvOrganization.Refresh();
        }

        private void BtnRefreshOrg_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreateOrg_Click(object sender, EventArgs e)
        {
            var frm = new frmOrganizationNew();
            frm.ShowDialog();
        }

        private void BtnReadOrg_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateOrg_Click(object sender, EventArgs e)
        {
            var frm = new frmOrganizationNew();
            frm.ShowDialog();
        }

        private void BtnDeleteOrg_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchOrg_Click(object sender, EventArgs e)
        {

        }

        private void BtnSortOrg_Click(object sender, EventArgs e)
        {

        }
    }
}
