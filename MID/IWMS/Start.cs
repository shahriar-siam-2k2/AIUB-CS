namespace IWMS
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User_Registration ur = new User_Registration();
            ur.Show();
            this.Hide();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
