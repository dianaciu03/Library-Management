using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class LoanForm : Form
    {
        UserManager userManager;
        FileManager fileManager;
        Library library;
        User currentUser;
        public LoanForm(User user, Library library, FileManager fileManager, UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
            this.fileManager = fileManager;
            this.library = library;
            this.currentUser = user;
        }

        private void btnSubmitLoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm(currentUser, library, fileManager, userManager);
            userForm.ShowDialog();
            this.Close();
        }
    }
}
