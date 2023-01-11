﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
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

        private void btnSearchLoan_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbBookTitleLoan.Text;
                List<Book> foundBooks = library.GetBooksByTitle(title);

                lbLoanBooksSearch.Items.Clear();
                foreach (Book book in foundBooks)
                    lbLoanBooksSearch.Items.Add(book);
            }
            catch(Exception)
            {
                return;
            }
            
        }

        private void btnSubmitLoan_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbNameBorrower.Text;
                int id = Convert.ToInt32(tbIDBorrower.Text);
                string email = tbEmailBorrower.Text;
                int phone = Convert.ToInt32(tbPhoneNumberBorrower.Text);
                DateTime dateLoan = DateTime.Now;
                List<Book> loanedBooks = new List<Book>();

                foreach (Book book in lbLoanBooks.Items)
                    loanedBooks.Add(book);

                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(id.ToString()) && !String.IsNullOrEmpty(phone.ToString()) && (loanedBooks.Count > 0))
                {
                    Loan loan = new Loan(name, id, email, phone, loanedBooks, dateLoan);
                    library.AddLoanToList(loan);
                    MessageBox.Show("Loan submitted successfully!");

                    foreach (Book book in loanedBooks)
                    {
                        book.CopiesNumber--;
                        book.AddCurrentLoan(loan);
                    }
                        
                    fileManager.WriteLibraryData(library);
                    fileManager.WriteMembersToCSV(library);
                }
                //Close loan form and return to the main page
                btnBack_Click(this, EventArgs.Empty);
            }
            catch(Exception)
            {
                return;
            }
        }

        private void lbLoanBooksSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbLoanBooks.Items.Add(lbLoanBooksSearch.SelectedItem);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //UserForm userForm = new UserForm(currentUser, library, fileManager, userManager);
            //userForm.ShowDialog();
            this.Close();
        }

    }
}
