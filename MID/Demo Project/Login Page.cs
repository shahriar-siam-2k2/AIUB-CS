namespace Demo_Project
{
    public partial class LoginPage : Form
    {
        string userName = "Erona";
        string userPass = "simba";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            lblUserEmpty.Hide();
            lblPassEmpty.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text != "" && txtUserPass.Text != "")
            {
                lblUserEmpty.Hide();
                lblPassEmpty.Hide();

                if (txtUserPass.Text == userPass)
                {
                    MessageBox.Show("Welcome " + txtUserName.Text);

                    Dashboard db = new Dashboard(txtUserName.Text);
                    db.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            
            if(txtUserName.Text == "" || txtUserPass.Text == "")
            {
                if (txtUserName.Text == "")
                {
                    lblUserEmpty.Show();
                }
                else
                {
                    lblUserEmpty.Hide();
                }
                
                if (txtUserPass.Text == "")
                {
                    lblPassEmpty.Show();
                }
                else
                {
                    lblPassEmpty.Hide();
                }
            }
        }
    }
}
