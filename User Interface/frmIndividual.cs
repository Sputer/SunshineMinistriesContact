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
    public partial class frmIndividual : Form
    {
        List<Individual> indList = IndividualDB.TestPopulate();

        public frmIndividual()
        {
            InitializeComponent();
        }

        private void FrmIndividual_Load(object sender, EventArgs e)
        {
            dgvIndividuals.DataSource = indList;
            dgvIndividuals.Refresh();
        }

        private void BtnCreateInd_Click(object sender, EventArgs e)
        {
            var frm = new frmIndividualNew();
            frm.ShowDialog();
        }

        private void BtnReadInd_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateInd_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteInd_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchInd_Click(object sender, EventArgs e)
        {

        }

        private void BtnSortInd_Click(object sender, EventArgs e)
        {

        }
    }
}
