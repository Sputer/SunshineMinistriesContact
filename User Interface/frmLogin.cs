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
    public partial class frmLogin : Form
    {
        string adminuser = "admin";
        string adminpass = "pass";
        bool hidden = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtUser.Text.ToLower() == adminuser && txtP.Text.ToLower() == adminpass)
                {
                    //MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                    var start = new frmMainMenu();
                    start.Show();
                }
                else
                    MessageBox.Show("Invalid login.", "Login Failed.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
