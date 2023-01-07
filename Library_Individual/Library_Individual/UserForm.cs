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
            cbGenreBook.DataSource = Enum.GetValues(typeof(BookGenre));
            comboBoxGenre.DataSource = Enum.GetValues(typeof(BookGenre));
            cbAvailableBooksGenre.DataSource = Enum.GetValues(typeof(BookGenre));

            this.userManager = userManager;
            this.fileManager = fileManager;
            this.library = library;
            this.currentUser = user;
            //change tab name based on who is logged in
            this.Text = $"{currentUser}";
            
        }

        private void ClearFields()
        {
            tbTitleBook.Clear();
            tbAuthorBook.Clear();
            cbGenreBook.SelectedIndex = -1;
            dateTimePublicationDateBook.Value = DateTime.Now;
            tbISBNBook.Clear();
            tbDescriptionBook.Clear();
            tbNoPages.Clear();
            numCopies.Value = 0;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbTitleBook.Text;
                string author = tbAuthorBook.Text;
                BookGenre genre = (BookGenre)cbGenreBook.SelectedItem;
                DateTime publicationDate = dateTimePublicationDateBook.Value.Date;
                long isbn = Convert.ToInt64(tbISBNBook.Text);
                string description = tbDescriptionBook.Text;
                int noPages = Convert.ToInt32(tbNoPages.Text);
                int noCopies = Convert.ToInt32(numCopies.Value);

                if (!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(author) && !String.IsNullOrEmpty(description) && !String.IsNullOrEmpty(isbn.ToString()) && !String.IsNullOrEmpty(noPages.ToString()))
                {
                    if (Enum.IsDefined(typeof(BookGenre), genre))
                    {
                        if (isbn.ToString().Length == 13)
                        {
                            Book book = new Book(title, author, genre, noPages, publicationDate, isbn, description);
                            library.AddBookToList(book);
                            MessageBox.Show("New book has been added!");
                            ClearFields();
                            fileManager.WriteLibraryData(library);
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnLoanForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoanForm loanForm = new LoanForm(currentUser, library, fileManager, userManager);
            loanForm.ShowDialog();
            this.Close();
        }

        private void btnDisplayAllBooks_Click(object sender, EventArgs e)
        {
            lbDisplayBooks.Items.Clear();
            foreach (Book b in library.GetBooks())
                lbDisplayBooks.Items.Add(b);
        }
    }
}
