using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoD1.Models
{
    internal class studentBussLayer
    {
        //select all
        public static DataTable getall()
        {
            return DBLayer.select("select * from student");
        }


        //select by id
        public static DataTable getbyid(int id)
        {
            return DBLayer.select($"select * from student where id={id}");
        }


        //add

        public static int add(string name ,int age , string address , int deptid)
        {
            return DBLayer.DML($"insert into student values('{name}',{age},'{address}',{deptid})");
        }

    }
}
