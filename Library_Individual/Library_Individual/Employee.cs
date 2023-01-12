using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library_Individual
{
    public class Employee : User
    {
        private string password;

        public Employee(string name, int id, string email, string password) : base(name, id, email)
        {
            this.password = password;
        }

        public string Password { get { return password; } }

        public override string ToString()
        {
            return Name;
        }

    }
}
