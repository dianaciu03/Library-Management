using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library_Individual
{
    [DataContract]
    public class Member : User
    {
        [DataMember] private long phone;

        public Member(string name, int id, string email, long phone) : base(name, id, email)
        {
            this.phone = phone;
        }

        public long Phone { get { return phone; } }
    }
}
