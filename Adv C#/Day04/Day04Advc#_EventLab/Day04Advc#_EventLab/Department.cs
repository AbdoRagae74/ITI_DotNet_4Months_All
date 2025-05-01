using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day04Advc__EventLab.Program;

namespace Day04Advc__EventLab
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public List<Employee> Staff;
        public Department(int _id, string _name)
        {
            DeptID = _id;
            DeptName = _name;
            Staff = new List<Employee>();
        }

        public void AddStaff(Employee E)
        {
            E.EmployeeLayOff += RemoveStaff;
            Staff.Add(E);

        }

        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            Employee employee = sender as Employee;
            if (e.Cause == LayOffCause.Age || e.Cause == LayOffCause.VacationStock)
            {
                Staff.Remove(employee);
                Console.WriteLine($"{employee.Name} removed from Department");
            }

            Employee emp = sender as Employee;
            Staff.Remove(emp);
        }
    }
}
