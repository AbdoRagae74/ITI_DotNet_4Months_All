using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day04Advc__EventLab.Program;

namespace Day04Advc__EventLab
{
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        public List<Employee> Members;
        public Club(int cID, string cName)
        {
            ClubID = cID;
            ClubName = cName;
            Members = new List<Employee>();
        }

        public void AddMember(Employee E)
        {
            E.EmployeeLayOff += RemoveMember;
            Members.Add(E);
        }
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            Employee employee = sender as Employee;
            if (e.Cause == LayOffCause.VacationStock)
            {
                Members.Remove(employee);
                Console.WriteLine($"{employee.Name} is removed from Club");
            }
        }
    }

}
