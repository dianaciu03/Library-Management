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
        private List<Employee> allEmployees = new List<Employee>();
        private List<Member> allMembers = new List<Member>();

        public void AddEmployeeToList(Employee employee)
        {
            allEmployees.Add(employee);
        }

        public void AddMemberToList(Member member)
        {
            allMembers.Add(member);
        }

        public List<Employee> GetEmployees()
        {
            return allEmployees;
        }

        public List<Member> GetMembers()
        {
            return allMembers;
        }
    }
}
