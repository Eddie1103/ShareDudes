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
            //
            // Load user array
            //
            var userCollection = new UserCollection();
            userCollection.LoadUser();
            
            dgv_user.Columns.Add("username", "Benutzername");
            //
            //
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Gebannt";
            checkBoxColumn.Name = "banned";
            dgv_user.Columns.Add(checkBoxColumn);
            //
            //
            DataGridViewCheckBoxColumn checkBoxColumnAdmin = new DataGridViewCheckBoxColumn();
            checkBoxColumnAdmin.HeaderText = "Admin";
            checkBoxColumnAdmin.Name = "is_admin";
            dgv_user.Columns.Add(checkBoxColumnAdmin);

            // Insert data
            foreach (var item in userCollection.Users)
            {
                dgv_user.Rows.Add(new[] { item.UserName, item.IsBanned.ToString(), item.IsAdmin.ToString() });
                dgv_user.Rows[0].Tag = item;
                // var casting = (User)item;
            }

            //
            // Load offer array
            //
            var offerCollection = new OfferCollection();
            offerCollection.LoadOffer();

            dgv_offer.Columns.Add("title", "Titel");
            dgv_offer.Columns.Add("description", "Text");
            dgv_offer.Columns.Add("status", "Status");

            foreach (var item in offerCollection.Offers)
            {
                dgv_offer.Rows.Add(new[] { item.Title, item.Description });
            }


            // Load report array
            /*
            var reportCollection = new ReportCollection();
            reportCollection.LoadReport();

            dgv_reports.Columns.Add("title", "Titel");
            dgv_reports.Columns.Add("text", "Text");

            foreach (var item in reportCollection.Reports)
            {
                dgv_reports.Rows.Add(new[] { item.ReportTitle, item.ReportText });
            }
            */
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

        private void dgv_user_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            
        }

        private void dgv_user_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgv_user.SelectedRows[0];
            // selectedRow.Tag;

            using (var window = new UserEdit((User)selectedRow.Tag))
            {
                // window.parent
                window.ShowDialog(this);
            }

        }

        // Probably dead code
        /*
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
        */

    }
}
