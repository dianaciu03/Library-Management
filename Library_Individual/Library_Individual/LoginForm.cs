namespace Library_Individual
{
    public partial class LoginForm : Form
    {
        UserManager userManager = new UserManager();
        FileManager fileManager = new FileManager();
        Library library = new Library();
        Employee currentUser;

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
                bool foundEmployee = false;

                foreach (Employee employee in userManager.GetEmployees())
                {
                    if (employee.Email == email && employee.Password == password)
                    {
                        foundEmployee = true;
                        currentUser = employee;
                    }
                }

                if(foundEmployee == true)
                {
                    //If credentials are correct, open user form
                    this.Hide();
                    UserForm userForm = new UserForm(currentUser, library, fileManager, userManager);
                    userForm.ShowDialog();
                    this.Close();
                }
                else
                    lblEmailPasswordIncorrect.Visible = true;
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
                        foreach (Employee employee in userManager.GetEmployees())
                        {
                            if (employee.Id == id) //if the id matches, the account is already registered
                            {
                                exists = true;
                            }
                        }

                        if (exists == false) //create an account
                        {
                            Employee employee = new Employee(name, id, email, password);
                            userManager.AddEmployeeToList(employee);
                            MessageBox.Show("Account created successfully!");
                            fileManager.WriteEmployeesToCSV(userManager);
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

        //method to load data from files
        private void LoadData()
        {
            try
            {
                userManager = fileManager.LoadEmployeesData(userManager);
                userManager = fileManager.LoadMembersData(userManager);
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