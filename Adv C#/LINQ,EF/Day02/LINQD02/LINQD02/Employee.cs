using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD02
{
    public class Employee
    {


        public int Id { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int DepartmentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override string ToString()
        {
            return $"ID : {Id} Name : {FirstName} {LastName} Age: {Age} Salary : {Salary} TrackId : {DepartmentID} ";
            //return $" Age: {Age} Salary : {Salary} ";
        }
    }
}
