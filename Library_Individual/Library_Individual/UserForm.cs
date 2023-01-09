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
            //initialize combo boxes
            cbGenreBook.SelectedIndex = -1;
            comboBoxGenre.SelectedIndex = -1;
            cbAvailableBooksGenre.SelectedIndex = -1;
        }

        //Method to clear fields when a book is added
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

        //
        //MANAGE BOOKS TAB
        //

        //Create book object with input data
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
                            Book book = new Book(title, author, genre, noPages, publicationDate, isbn, description, noCopies);
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

        private void btnSearchForBook_Click(object sender, EventArgs e)
        {
            try
            {
                lbDisplayBooks.Items.Clear();
                string title = tbTitleSearch.Text;
                string author = tbAuthorSearch.Text;
                string genre = comboBoxGenre.Text;

                foreach (Book b in library.GetBooksBySearch(title, author, genre))
                    lbDisplayBooks.Items.Add(b);
            }
            catch(Exception)
            {
                return;
            }
        }

        private void btnDisplayAllBooks_Click(object sender, EventArgs e)
        {
            lbDisplayBooks.Items.Clear();
            foreach (Book b in library.GetBooks())
                lbDisplayBooks.Items.Add(b);
        }

        //Display MessageBox with detailed info about the book
        private void lbDisplayBooks_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Book tempBook = lbDisplayBooks.SelectedItem as Book;
                MessageBox.Show(tempBook.GetInfoBookDetailed());
            }
            catch(Exception)
            {
                return;
            }
           
        }

        //Remove book from list
        private void btnRemoveSelectedBook_Click(object sender, EventArgs e)
        {
            try
            {
                Book tempBook = lbDisplayBooks.SelectedItem as Book;
                if (tempBook != null)
                {
                    if (library.RemoveBookFromList(tempBook) == true)
                    {
                        MessageBox.Show("Selected book has been removed from the inventory!");
                        fileManager.WriteLibraryData(library);
                    }  
                    else
                        MessageBox.Show("Selected book couldn't be found!");
                }
                btnDisplayAllBooks_Click(this, EventArgs.Empty);
            }
            catch(Exception)
            {
                return;
            }  
        }

        //Add copies to already created books
        private void btnAddCopies_Click(object sender, EventArgs e)
        {
            try
            {
                Book tempBook = lbDisplayBooks.SelectedItem as Book;
                int nrCopies = Convert.ToInt32(numCopiesAdd.Text);
                if (tempBook != null)
                {
                    tempBook.CopiesNumber = nrCopies;
                    MessageBox.Show("The number of copies has been successfully modified!");
                    fileManager.WriteLibraryData(library);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        //
        //MANAGE LOANS TAB
        //

        private void btnDisplayAvailableBooks_Click(object sender, EventArgs e)
        {
            lbAvailableTitles.Items.Clear();
            string title = tbAvailableBooksTitle.Text;
            string author = tbAvailableBooksAuthor.Text;
            string genre = cbAvailableBooksGenre.Text;

            foreach (Book b in library.GetBooksBySearch(title, author, genre))
            {
                if(b.CopiesNumber > 0)
                    lbAvailableTitles.Items.Add(b);
            }
        }

        private void btnLoanForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoanForm loanForm = new LoanForm(currentUser, library, fileManager, userManager);
            loanForm.ShowDialog();
            this.Close();
        }

        private void btnSubmitReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
