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
            if(tb_benutzer.Text != "")
            {
           
            }
            else
            {
                MessageBox.Show("Warning!");
            }
        }
    }
}