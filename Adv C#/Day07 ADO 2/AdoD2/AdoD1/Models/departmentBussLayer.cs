using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoD1.Models
{
    internal class departmentBussLayer
    {
        public static DataTable getall()
        {
            return DBLayer.select("select * from department");
        }

    }
}
