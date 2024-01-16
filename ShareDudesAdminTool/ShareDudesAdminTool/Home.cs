using Connection;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public void UserConnection()
        {
            
        }


        private void btn_logout_Click(object sender, EventArgs e)
        {



                // open new Form, in this case "Login"

                this.Close();
            var login = new Login();
            login.Show();
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = Database.Create())
            {
                var test = db.Load("SELECT * FROM User;");
                var test2 = test.ToString();
                MessageBox.Show(test2);
            }
        }
    }
}
