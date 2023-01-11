namespace Library_Individual
{
    public partial class LoginForm : Form
    {
        UserManager userManager = new UserManager();
        FileManager fileManager = new FileManager();
        Library library = new Library();
        User currentUser;

        public LoginForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbEmailLogin.Text;
                string password = tbPasswordLogin.Text;

                foreach (User u in userManager.GetUsers())
                {
                    if (u.Email == email && u.Password == password)
                    {
                        currentUser = u;
                        fileManager.WriteUsersToCSV(userManager);
                        //If credentials are correct, open user form
                        this.Hide();
                        UserForm userForm = new UserForm(currentUser, library, fileManager, userManager);
                        userForm.ShowDialog();
                        this.Close();
                        break;
                    }
                    else
                        lblEmailPasswordIncorrect.Visible = true;                        
                }

            }
            catch(Exception)
            {
                return;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //get info from text boxes
                string name = tbNameRegister.Text;
                int id = Convert.ToInt32(tbIDRegister.Text);
                string email = tbEmailRegister.Text;
                string password = tbPasswordRegister.Text;
                bool exists = false;

                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(id.ToString()) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(password))
                {
                    if (!password.Contains(","))
                    {
                        foreach (User u in userManager.GetUsers())
                        {
                            if (u.Id == id) //if the id matches, the account is already registered
                            {
                                exists = true;
                            }
                        }

                        if (exists == false) //create an account
                        {
                            User user = new User(name, id, email, password);
                            userManager.AddUserToList(user);
                            MessageBox.Show("Account created successfully!");
                            fileManager.WriteUsersToCSV(userManager);
                            ClearFields();
                        }
                        else 
                        {
                            lblAccountAlreadyExists.Visible = true;
                            ClearFields();
                        }
                    }
                    else
                        MessageBox.Show("Password can't contain commas!");
                }
            }
            catch(Exception)
            {
                return;
            } 
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fileManager.WriteUsersToCSV(userManager);
        }

        //method to load data from files
        private void LoadData()
        {
            try
            {
                userManager = fileManager.LoadUsersData();
                library = fileManager.LoadLibraryData();
            }
            catch (Exception)
            {
                return;
            }
        }

        //method for clearing all fields
        private void ClearFields()
        {
            //register tab fields
            tbNameRegister.Clear();
            tbIDRegister.Clear();
            tbEmailRegister.Clear();
            tbPasswordRegister.Clear();

            //login tab fields
            tbEmailLogin.Clear();
            tbPasswordLogin.Clear();
        }
    }
}