using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD01
{
    public class Student
    {


        public int Id { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int TrackId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        public override string ToString()
        {
            //return $"ID : {Id} Name : {FirstName} {LastName} Age: {Age} Salary : {Salary} TrackId : {TrackId} " ;
            return $" Age: {Age} Salary : {Salary} " ;
        }
    }
}
