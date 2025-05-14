using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD02
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public override string ToString()
        {
            return $"Track ID :{DepartmentID} , Track Name : {DepartmentName}";
        }

    }
}
