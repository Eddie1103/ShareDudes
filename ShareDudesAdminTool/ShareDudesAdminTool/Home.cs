
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

        private void Home_Load(object sender, EventArgs e)
        {
            var userCollection = new UserCollection();
            userCollection.LoadUser();
           

            dgv_user.Columns.Add("username", "Benutzername");
            dgv_user.Columns.Add("banned", "Gebannt");


            foreach (var item in userCollection.Users)
            {
                dgv_user.Rows.Add(new[] { item.UserName, item.IsBanned.ToString() });
            }
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
                var name = string.Empty;
                using (var reader = db.Load("SELECT * FROM users"))
                {
                    while (reader.Read())
                    {
                        name = Database.GetStringValue(reader, "username");
                    }
                }
               
                MessageBox.Show(name);
            }
        }

        private void tc_home_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_home.SelectedIndex == 0)
            {

            } else if (tc_home.SelectedIndex == 1)
            {
                using (var db = Database.Create())
                {
                    var name = string.Empty;
                    using (var reader = db.Load("SELECT * FROM users"))
                    {
                        while (reader.Read())
                        {
                            name = Database.GetStringValue(reader, "username");
                        }
                    }

                    MessageBox.Show(name);
                }
            } else if (tc_home.SelectedIndex == 2)
            {

            } else if (tc_home.SelectedIndex == 3)
            {

            }
        }


    }
}
