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


            //
            dgv_user.Columns.Add("username", "Benutzername");
            dgv_user.Columns["username"].Width = 500;
            //
            //
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Gebannt";
            checkBoxColumn.Name = "banned";
            dgv_user.Columns.Add(checkBoxColumn);

            // Update database
            dgv_user.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgv_user.Columns["banned"].Index)
                {
                    DataGridViewCheckBoxCell checkBoxCell = dgv_user.Rows[e.RowIndex].Cells["banned"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        bool newValue = !(bool)checkBoxCell.Value;
                        checkBoxCell.Value = newValue;

                        // updata database code
                    }
                }
            };
            //
            //
            DataGridViewCheckBoxColumn checkBoxColumnAdmin = new DataGridViewCheckBoxColumn();
            checkBoxColumnAdmin.HeaderText = "Admin";
            checkBoxColumnAdmin.Name = "is_admin";
            dgv_user.Columns.Add(checkBoxColumnAdmin);

            // Update database
            dgv_user.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgv_user.Columns["banned"].Index)
                {
                    DataGridViewCheckBoxCell checkBoxCell = dgv_user.Rows[e.RowIndex].Cells["banned"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        bool newValue = !(bool)checkBoxCell.Value;
                        checkBoxCell.Value = newValue;
                    }
                    // updata database code
                }
            };
            //

            foreach (var item in userCollection.Users)
            {
                dgv_user.Rows.Add(new[] { item.UserName, item.IsBanned.ToString(), item.IsAdmin.ToString() });
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
