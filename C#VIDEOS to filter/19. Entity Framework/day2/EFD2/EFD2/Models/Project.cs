using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2.Models
{
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public int duration { get; set; }

       // public virtual List<Employee> Employees { get; set; }
        public virtual List<empProj> Employees { get;  }= new List<empProj>();
    }
}
