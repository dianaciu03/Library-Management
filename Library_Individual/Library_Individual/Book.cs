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
        [DataMember] private int copiesNumber;
        [DataMember] private List<string> currentLoan = new List<string>();
        [DataMember] private List<string> loanHistory = new List<string>();

        public Book(string title, string author, BookGenre genre, int numberOfPages, DateTime publicationDate, long isbn, string description, int nrCopies)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.numberOfPages = numberOfPages;
            this.publicationDate = publicationDate;
            this.isbn = isbn;
            this.description = description;
            this.copiesNumber = nrCopies;
        }

        public string Title { get { return this.title; } }

        public string Author { get { return this.author; } }

        public BookGenre Genre { get { return this.genre; } }

        public void AddCurrentLoan(Loan loan)
        {
            if(!currentLoan.Contains(loan.GetInfoCurrentLoanForThisBook()))
                currentLoan.Add(loan.GetInfoCurrentLoanForThisBook());
        }

        public List<string> GetCurrentLoans()
        {
            return this.currentLoan;
        }

        public List<string> GetHistoryLoans()
        {
            return this.currentLoan;
        }

        public void MoveCurrentLoanToHistory(Loan loan)
        {
            if (currentLoan.Contains(loan.GetInfoCurrentLoanForThisBook()))
            {
                currentLoan.Remove(loan.GetInfoCurrentLoanForThisBook());
                loanHistory.Add(loan.GetInfoHistoryLoanForThisBook());
            }
        }

        public int CopiesNumber
        {
            get { return this.copiesNumber; }
            set { this.copiesNumber = value; }
        }

        public string GetInfoBookDisplay()
        {
            return $"{this.title} by {this.author}";
        }

        public string GetInfoBookDetailed()
        {
            string info = $"{this.title}\nBy {this.author}\n\nGenre: {this.genre}\nNumber of pages: {this.numberOfPages}\n" +
                $"Publication date: {this.publicationDate:dd-MM-yyyy}\nISBN: {this.isbn}\n\nDescription:\n{this.description}\n\n";

            if (currentLoan.Count() > 0)
            {
                info += $"Current borrowers:\n";
                foreach (string l in currentLoan)
                    info += $"{l}\n";
            }

            else
                info += $"Current borrowers: none\n";
            info += $"Number of copies left: {this.copiesNumber}\n";
            if (loanHistory.Count > 0)
            {
                info += $"Loan history:\n";
                foreach (string l in loanHistory)
                    info += $"{l}\n";
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