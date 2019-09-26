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
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            //Code by Chase Wille

            var userList = UserDB.TestPopulate();
            foreach (var user in userList)
            {
                string item = ($"{user.ID}: {user.LastName}, {user.FirstName}           Username: {user.UserName}           Access Level: {user.AccessLevel} ");
                lbUserList.Items.Add(item);

            }

            lbUserList.Refresh();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            var frm = new frmNewUser();
            frm.ShowDialog();
        }
    }
}
