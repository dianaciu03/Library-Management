using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Individual
{
    public class Book
    {
        private string title;
        private string author;
        private Genre genre;
        private int numberOfPages;
        private DateTime publicationDate;
        private string isbn;
        private string description;
        private Loan currentLoan;
        private List<Loan> loanHistory = new List<Loan>();

        public Book(string title, string author, Genre genre, int numberOfPages, DateTime publicationDate, string isbn, string description)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.numberOfPages = numberOfPages;
            this.publicationDate = publicationDate;
            this.isbn = isbn;
            this.description = description;
        }

        public string Title { get { return this.title; } }

        public string Author { get { return this.author; } }

        public Genre Genre { get { return this.genre; } }

        public Loan CurrentLoan
        { 
            get { return this.currentLoan; } 
            set { this.currentLoan = value; }
        }

        public string GetInfoBookDisplay()
        {
            return $"{this.title} by {this.author}";
        }

        public string GetInfoBookDetailed()
        {
            string info = $"{this.title}\nBy {this.author}\n\nGenre {this.genre}\nNumber of pages: {this.numberOfPages}\n" +
                $"Publication date: {this.publicationDate}\nISBN: {this.isbn}\n\nDescription:\n{this.description}\n\n" +
                $"Current borrower: {this.currentLoan.GetInfoCurrentLoan()}\n";
            foreach (Loan l in loanHistory)
                info += l.GetInfoForThisBook();
            return info;
        }

        public override string ToString()
        {
            return GetInfoBookDisplay();
        }

    }

}
