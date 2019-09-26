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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
