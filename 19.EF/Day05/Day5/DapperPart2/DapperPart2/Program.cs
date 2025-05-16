using Dapper;
using DapperPart2.Models;
using Microsoft.Data.SqlClient;

namespace DapperPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define connection

            var con = new SqlConnection("Server=.;Database=EFD1;Trusted_Connection=True;Trust Server Certificate= True");


            //   var query = "Select age from student where id=4";

            //   object q1 = con.ExecuteScalar(query);
            //int q1 = con.ExecuteScalar<int>(query);
            //Console.WriteLine(q1);

            //  var q2 = con.QuerySingleOrDefault<Student>("select * from student where id=4");

            // var q3 = con.Query<Student>("select  * from student").ToList();


            //int id = 3;
            //int age = 22;

            //var q4 = con.Query<Student>("select * from student where id>@id and age>@age", new { id = id, age = age }).ToList();

            //foreach (var item in q4) {

            //    Console.WriteLine(item);

            //}


            //var q3 = con.Query<Student,Department,Student>(
            //    "select s.*,D.* from student s inner join department d on s.deptid=d.id",

            //    (st, d) => { st.department = d;return st; }

            //    ).ToList();

            //foreach (var item in q3) {
            //    Console.WriteLine(item);
            //    Console.WriteLine(item.department);

            //}

            //var q4 = con.Query<Student>("select s.name ,s.id,s.age ,d.name as deptname ,d.loc from student s inner join department d on s.deptid=d.id").ToList();
            //foreach (var item in q4) {

            //    Console.WriteLine(item);
            //}


            //var q3 = con.Query<Student>("getstudentbyage", new { age = 20 },commandType:System.Data.CommandType.StoredProcedure).ToList();

            //foreach (var item in q3) {
            //    Console.WriteLine(item);

            //}

            //var query = "insert into student values(@name ,@age,@addres,@deptid)";

            //var q1 = con.Execute(query, new { name = "ehab", age = 22, addres = "monufia", deptid = 1 });
            //Console.WriteLine(q1);

            var query2 = con.Execute("delete from student where id >@id", new { id = 2000 });
            Console.WriteLine(query2);
            
        }
    }
}
