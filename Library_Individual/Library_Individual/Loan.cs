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
        [DataMember] private string name;
        [DataMember] private int ID;
        [DataMember] private string email;
        [DataMember] private int phone;
        [DataMember] private List<Book> books = new List<Book>();
        [DataMember] private DateTime borrowDate;
        [DataMember] private DateTime returnDate;

        public Loan(string name, int id, string email, int phone, List<Book> books, DateTime borrowDate)
        {
            this.name = name;
            this.ID = id;
            this.email = email;
            this.phone = phone;
            this.books = books;
            this.borrowDate = borrowDate;
        }

        public string Name { get { return name; } }

        public int Id { get { return ID; } }

        public string Email { get { return email; } }

        public int Phone { get { return phone; } }

        public List<Book> Books { get { return this.books; } }

        public string StringBooks()
        {
            string booksString = "";
            foreach (Book book in this.books)
                booksString += $"{book.Title}, ";
            return booksString;
        }

        public DateTime BorowDate { get { return this.borrowDate; } }

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        public string GetInfoLoanDetailed()
        {
            string info = $"{this.name}({this.ID})\n\nBorrow date: {this.borrowDate:dd-MM-yyyy}\nReturn date:";
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
            return $"{this.name}({this.ID}) borrowed {books.Count} books on: {this.borrowDate:dd-MM-yyyy}";
        }

        public string GetInfoCurrentLoanForThisBook()
        {
            return $"{this.name}({this.ID}) Borrow date: {this.borrowDate:dd-MM-yyyy}";
        }

        public string GetInfoHistoryLoanForThisBook()
        {
            return $"{this.name}({this.ID}) Borrow date: {this.borrowDate:dd-MM-yyyy}, Return date: {this.returnDate:dd-MM-yyyy}";
        }

        public override string ToString()
        {
            return GetInfoLoan();
        }

    }
}
