using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Individual
{
    public class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public int NumberOfPages;
        public DateTime PublicationDate;
        public string ISBN;
        public string Description;

        public Book(string title, string author, string genre, int numberOfPages, DateTime publicationDate, string isbn, string description)
        {
            Title = title;
            Author = author;
            Genre = genre;
            NumberOfPages = numberOfPages;
            PublicationDate = publicationDate;
            ISBN = isbn;
            Description = description;
        }
    }


}
