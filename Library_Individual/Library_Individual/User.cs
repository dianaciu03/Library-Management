using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library_Individual
{
    [DataContract]
    public class User
    {
        [DataMember] private string name;
        [DataMember] private int id;
        [DataMember] private string email;
        [DataMember] private string password;

        public User(string name, int id, string email, string password)
        {
            this.name = name;
            this.id = id;
            this.email = email;
            this.password = password;
        }

        public string Name { get { return name; } }
        public int Id { get { return id; } }
        public string Email { get { return email; } }
        public string Password { get { return password; } }

    }
}
