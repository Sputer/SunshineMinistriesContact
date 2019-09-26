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
    public partial class frmChurchNew : Form
    {
        public frmChurchNew()
        {
            InitializeComponent();
        }

        private void BtnNewContact_Click(object sender, EventArgs e)
        {
            var frm = new frmNewContact();
            frm.ShowDialog();
        }
    }
}
