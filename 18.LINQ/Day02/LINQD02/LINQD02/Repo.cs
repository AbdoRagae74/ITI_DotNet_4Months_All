using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD02
{
    public class Repo
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
    {
        new Employee { Id = 1, FirstName = "Ahmed", LastName = "Osama", Age = 26 , Salary = 1234, DepartmentID = 1},
        new Employee { Id = 2, FirstName = "Mohamed", LastName = "Hatem", Age = 37 , Salary = 2234, DepartmentID = 2},
        new Employee { Id = 3, FirstName = "Sara", LastName = "Hamada", Age = 46 , Salary = 4234, DepartmentID = 3},
        new Employee { Id = 4, FirstName = "Omar", LastName = "Ramy", Age = 25 , Salary = 5234, DepartmentID = 4},
        new Employee { Id = 5, FirstName = "Ali", LastName = "Osama", Age = 25 , Salary = 6234, DepartmentID = 1},
        new Employee { Id = 6, FirstName = "Mai", LastName = "Ahmed", Age = 36 , Salary = 7234, DepartmentID = 2},
        new Employee { Id = 7, FirstName = "Ramy", LastName = "Omar", Age = 49 , Salary = 8234, DepartmentID = 3},
        new Employee { Id = 8, FirstName = "Hamada", LastName = "Osama", Age = 18 , Salary = 9234, DepartmentID = 4},
        new Employee { Id = 8, FirstName = "Hamada", LastName = "Osama", Age = 18 , Salary = 9234, DepartmentID = 4},
        new Employee { Id = 9, FirstName = "Hatem", LastName = "Mohamed", Age = 26 , Salary = 10234, DepartmentID    = 1},
        new Employee { Id = 10, FirstName = "Osama", LastName = "Ahmed", Age = 25 , Salary = 17234, DepartmentID = 2},
        new Employee { Id = 10, FirstName = "Osama", LastName = "Ahmed", Age = 25 , Salary = 17234, DepartmentID = 2},
    };
        }

        public static List<Department> GetDepartments()
        {
            return new List<Department>()
    {
        new Department {  DepartmentID = 1 , DepartmentName = "SD" },
        new Department {  DepartmentID = 2 , DepartmentName = "UI" },
        new Department {  DepartmentID = 3 , DepartmentName = "Mob" },
        new Department {  DepartmentID = 4 , DepartmentName = "Network" },
    };
        }

    }
}
