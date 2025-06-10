using Dapper;
using DapperD1.Models;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace DapperD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            var physicalmemorey = Process.GetCurrentProcess().WorkingSet64;
            var virualmemory = Process.GetCurrentProcess().VirtualMemorySize64;

            watch.Start();
          //  AdventureWorksContext db = new AdventureWorksContext();
          //  var q1 = db.People.Where(n=>n.FirstName.Contains("mo")).ToList();
            //Console.WriteLine($"{q1[0].FirstName}");
            ////StringBuilder st= new StringBuilder();
            //// for (int i = 0; i < 10000; i++) {
            ////     st.Append( i.ToString());
            //// }

            //dapper
              var con = new SqlConnection("Server=.;Database=AdventureWorks2012;Trusted_Connection=True;Trust Server Certificate=True");
             var q1 = con.Query<Person>("select * from person.person where firstname like'%mo%'").ToList();



            watch.Stop();

            physicalmemorey = Process.GetCurrentProcess().WorkingSet64 - physicalmemorey;
            virualmemory = Process.GetCurrentProcess().VirtualMemorySize64 - virualmemory;

            Console.WriteLine($"Time={watch.Elapsed}");
            Console.WriteLine($"size={physicalmemorey} - {virualmemory}");


       
        }
    }
}
