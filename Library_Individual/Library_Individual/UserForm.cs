using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Individual
{
    public partial class UserForm : Form
    {
        UserManager userManager;
        FileManager fileManager;
        Library library;
        User currentUser;
        public UserForm(User user, Library library, FileManager fileManager, UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
            this.fileManager = fileManager;
            this.library = library;
            this.currentUser = user;
            //change tab name based on who is logged in
            this.Text = $"{currentUser}";
        }

        private void btnLoanForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoanForm loanForm = new LoanForm(currentUser, library, fileManager, userManager);
            loanForm.ShowDialog();
            this.Close();
        }
    }
}
