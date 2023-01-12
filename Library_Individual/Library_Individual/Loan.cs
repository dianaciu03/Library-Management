using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library_Individual
{
    [DataContract]
    public class Loan
    {
        [DataMember] private Member borrower;
        [DataMember] private List<Book> books = new List<Book>();
        [DataMember] private DateTime borrowDate;
        [DataMember] private DateTime returnDate;

        public Loan(Member borrower, List<Book> books, DateTime borrowDate)
        {
            this.borrower = borrower;
            this.books = books;
            this.borrowDate = borrowDate;
        }

        public Member Borrower { get { return borrower; } }

        public List<Book> Books { get { return this.books; } }

        public string StringBooks()
        {
            string booksString = "";
            foreach (Book book in this.books)
                booksString += $"{book.Title}, ";
            string finalBookString = booksString.Substring(0, booksString.Length - 2);
            return finalBookString;
        }

        public DateTime BorowDate { get { return this.borrowDate; } }

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        public string GetInfoLoanDetailed()
        {
            string info = $"{this.borrower.Name}({this.borrower.Id})\n\nBorrow date: {this.borrowDate:dd-MM-yyyy}\nReturn date:";
            if (returnDate.Year == 1)
                info += "\n";
            else
                info += $"{this.returnDate:dd-MM-yyyy}\n";
            info += "\nContents:\n";
            foreach(Book book in books)
                info += $"{book.GetInfoBookDisplay()}\n";
            return info;
        }

        public string GetInfoLoan()
        {
            return $"{this.borrower.Name}({this.borrower.Id}) borrowed {books.Count} books on: {this.borrowDate:dd-MM-yyyy}";
        }

        public string GetInfoCurrentLoanForThisBook()
        {
            return $"{this.borrower.Name}({this.borrower.Id}) Borrow date: {this.borrowDate:dd-MM-yyyy}";
        }

        public string GetInfoHistoryLoanForThisBook()
        {
            return $"{this.borrower.Name}({this.borrower.Id}) Borrow date: {this.borrowDate:dd-MM-yyyy}, Return date: {this.returnDate:dd-MM-yyyy}";
        }

        public override string ToString()
        {
            return GetInfoLoan();
        }

    }
}
