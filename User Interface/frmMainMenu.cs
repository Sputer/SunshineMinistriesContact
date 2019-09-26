using SunshineMinistriesContact.User_Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineMinistriesContact
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void IndividualsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmIndividual();
            frm.ShowDialog();
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ChurchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmChurch();
            frm.ShowDialog();
        }

        private void OrganizationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmOrganization();
            frm.ShowDialog();
        }

        private void CreateUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmNewUser();
            frm.ShowDialog();
        }

        private void ManageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmUserList();
            frm.ShowDialog();
        }
    }
}
