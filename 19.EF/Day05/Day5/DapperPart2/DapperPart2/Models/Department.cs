using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPart2.Models
{
    internal class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public string loc { get; set; }

        public override string ToString()
        {
            return $"{id}-{name}-{loc}";
        }
    }
}
