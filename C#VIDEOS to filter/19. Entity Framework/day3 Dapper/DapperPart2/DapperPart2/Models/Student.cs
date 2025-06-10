using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPart2.Models
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string  adddress { get; set; }
        public int  deptid { get; set; }

        public Department department { get; set; }
        public override string ToString()
        {
            return $"{id}-{name}-{age}-{adddress}-{deptid}";
        }

    }
}
