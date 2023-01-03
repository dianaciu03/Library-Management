using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Individual
{
    public class User
    {
        private string name;
        private int id;
        private string email;
        private string password;

        public User(string name, int id, string email, string password)
        {
            this.name = name;
            this.id = id;
            this.email = email;
            this.password = password;
        }
    }
}
