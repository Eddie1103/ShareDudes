using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareDudesAdminTool
{
    public partial class UserEdit : Form
    {

        User _user;
        public UserEdit(User user)
        {
            InitializeComponent();
            _user = user;
            this.CenterToParent();
        }
        private void UserEdit_Load(object sender, EventArgs e)
        {
            tb_username.Text = _user.UserName;
            cb_isAdmin.Checked = _user.IsAdmin;
            cb_isBanned.Checked = _user.IsBanned;
        }


        private void cb_isBanned_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
