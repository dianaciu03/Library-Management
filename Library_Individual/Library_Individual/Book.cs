using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library_Individual
{
    [DataContract]
    public class Book
    {
        [DataMember] private string title;
        [DataMember] private string author;
        [DataMember] private BookGenre genre;
        [DataMember] private int numberOfPages;
        [DataMember] private DateTime publicationDate;
        [DataMember] private long isbn;
        [DataMember] private string description;
        [DataMember] private Loan currentLoan;
        [DataMember] private List<Loan> loanHistory = new List<Loan>();

        public Book(string title, string author, BookGenre genre, int numberOfPages, DateTime publicationDate, long isbn, string description)
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

        public BookGenre Genre { get { return this.genre; } }

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
            string info = $"{this.title}\nBy {this.author}\n\nGenre: {this.genre}\nNumber of pages: {this.numberOfPages}\n" +
                $"Publication date: {this.publicationDate.Date}\nISBN: {this.isbn}\n\nDescription:\n{this.description}\n\n";
            if (currentLoan != null)
                info += $"Current borrower: {this.currentLoan.GetInfoCurrentLoan()}\n";
            else
                info += $"Current borrower: none\n";
            if (loanHistory.Count > 0)
            {
                foreach (Loan l in loanHistory)
                    info += l.GetInfoForThisBook();
            }
            else
                info += $"Loan history: no data available";
            return info;
        }

        public override string ToString()
        {
            return GetInfoBookDisplay();
        }

    }

}
