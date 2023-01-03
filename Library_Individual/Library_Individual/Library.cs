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

        public void AddBookToList(Book book)
        {
            allBooks.Add(book);
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
    }

    
}
