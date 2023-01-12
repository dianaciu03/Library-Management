using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library_Individual
{
    [DataContract]
    public abstract class User
    {
        [DataMember] private string _name;
        [DataMember] private int _id;
        [DataMember] private string _email;

        public User(string name, int id, string email)
        {
            Name = name;
            Id = id;
            Email = email;
        }

        public string Name { get { return _name; } set { _name = value; } }

        public int Id { get { return _id; } set { _id = value; } }

        public string Email { get { return _email; } set { _email = value; } }
    }
}
