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
