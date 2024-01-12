namespace ShareDudesAdminTool
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void tb_benutzer_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_benutzer.Text) && !String.IsNullOrEmpty(tb_password.Text))
            {

                // open new Form, in this case "Home and hides the current form"

                this.Hide();

                var home = new Home();
                
                home.Show();
                
            }
            else
            {
                MessageBox.Show("Benutzer und Passwort darf nicht leer sein!");
            }
        }

        private void lb_headline_Click(object sender, EventArgs e)
        {

        }
    }
}