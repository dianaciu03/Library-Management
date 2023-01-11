using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library_Individual
{
    [DataContract]
    public class Library
    {
        [DataMember] private string name = "Midnight Reads";
        [DataMember] private List<Book> allBooks = new List<Book>();
        [DataMember] private List<Loan> allLoans = new List<Loan>();

        public void AddBookToList(Book book)
        {
            allBooks.Add(book);
        }

        public void AddLoanToList(Loan loan)
        {
            allLoans.Add(loan);
        }

        public bool RemoveBookFromList(Book book)
        {
            if (allBooks.Contains(book))
            {
                allBooks.Remove(book);
                return true;
            }
            else
                return false;
        }

        public List<Book> GetBooks()
        {
            return allBooks;
        }

        public List<Loan> GetLoans()
        {
            return allLoans;
        }

        public List<Book> GetBooksBySearch(string title, string author, string genre)
        {
            List<Book> tempList = new List<Book>();
            foreach(Book book in allBooks)
            {
                if((book.Title == title || title == String.Empty) && 
                    (book.Author == author || author == String.Empty) && 
                    (book.Genre.ToString() == genre || genre == String.Empty))
                    tempList.Add(book);
            }
            return tempList;
        }

        public List<Book> GetBooksByTitle(string title)
        {
            List<Book> tempList = new List<Book>();
            foreach (Book book in allBooks)
            {
                if (book.Title == title && book.CopiesNumber > 0)
                    tempList.Add(book);
            }
            return tempList;
        }

    }

    
}
