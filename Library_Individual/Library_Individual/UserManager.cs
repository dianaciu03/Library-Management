using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library_Individual
{
    public class UserManager
    {
        private List<User> allUsers = new List<User>();

        public void AddUserToList(User user)
        {
            allUsers.Add(user);
        }

        public bool RemoveUserFromList(User user)
        {
            if(allUsers.Contains(user))
            {
                allUsers.Remove(user);
                return true;
            }
            else
                return false;       
        }

        public List<User> GetUsers()
        {
            return allUsers;
        }
    }
}
