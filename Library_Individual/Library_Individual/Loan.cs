using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Individual
{
    public class Loan
    {
        private string name;
        private int ID;
        private string email;
        private int phone;
        private List<Book> books = new List<Book>();
        private DateTime borrowDate;
        private DateTime returnDate;

        public string GetInfoForThisBook()
        {
            return $"{this.name}({this.ID}) Borrow date: {this.borrowDate}, Return date: {this.returnDate}";
        }

        public string GetInfoCurrentLoan()
        {
            return $"{this.name}({this.ID}) on: {this.borrowDate}";
        }

        public string GetInfoLoanDisplay()
        {
            return $"{this.name}({this.ID})";
        }

        public override string ToString()
        {
            return GetInfoLoanDisplay();
        }



    }
}
