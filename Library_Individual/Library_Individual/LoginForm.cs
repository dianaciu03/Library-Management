namespace Library_Individual
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbEmailLogin.Text == "user" && tbPasswordLogin.Text == "user")
            {
                this.Hide();
                UserForm userForm = new UserForm();
                userForm.ShowDialog();
                this.Close();
            }
        }

    }
}