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
    public partial class frmChurch : Form
    {
        List<Church> list = ChurchDB.TestPopulate();
        public frmChurch()
        {
            InitializeComponent();
        }

        private void FrmChurch_Load(object sender, EventArgs e)
        {
            dgvChurch.DataSource = list;
            dgvChurch.Refresh();
            var userList = ChurchDB.TestPopulate();
            foreach (var user in userList)
            {
                string item = ($"{user.ID}: {user.LastName}, {user.FirstName} ");
                listBox1.Items.Add(item);

            }

            listBox1.Refresh();
        }

        private void BtnRefreshChurch_Click(object sender, EventArgs e)
        {
            dgvChurch.Refresh();
        }

        private void BtnCreateChurch_Click(object sender, EventArgs e)
        {
            var frm = new frmChurchNew();
            frm.ShowDialog();
        }

        private void BtnReadChurch_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateChurch_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteChurch_Click(object sender, EventArgs e)
        {

        }

        private void BtnSortChurch_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchChurch_Click(object sender, EventArgs e)
        {

        }
    }
}
