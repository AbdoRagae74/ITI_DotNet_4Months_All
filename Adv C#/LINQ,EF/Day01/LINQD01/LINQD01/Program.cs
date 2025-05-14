using System.Collections.Generic;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace LINQD01
{
    internal class Program
    {



       
        static void Main(string[] args)
        {
            var stds = Repo.GetStudents();
            var tracks = Repo.GetTracks();

            //1.	Display all Student using LINQ Query Expression.

            //var allStds = from s in stds
            //              select s;
            //foreach(var st in allStds)
            //{
            //    Console.WriteLine(st);
            //}


            //2.Display all Student using LINQ Method Syntax[fluent syntax].

            //var allStds2 = stds.Select(s => s);

            //foreach (var st in allStds2)
            //{
            //    Console.WriteLine(st);
            //}


            //3.Display all Students with Age > 30 using LINQ Query Expression.

            //var allStds3 = from s in stds
            //               where s.Age > 30
            //               select s;

            //foreach (var st in allStds3)
            //{
            //    Console.WriteLine(st);
            //}


            //4.Display all Students with Salary< 5000 using LINQ Method Syntax[fluent syntax].

            //var allStds4 = stds.Where(s=>s.Salary>5000);

            //foreach (var st in allStds4)
            //{
            //    Console.WriteLine(st);
            //}

            // 5.Display all Students with TrackId = 1 and salary > 4000 OrderBy Name descending using LINQ Query Expression.

            //var allStds5 = from s in stds
            //               where s.TrackId == 1 && s.Salary > 4000
            //               orderby s.Name
            //               select s;
            //foreach (var st in allStds5)
            //{
            //    Console.WriteLine(st);
            //}

            //6.Display all Students with TrackId = 1 and first name Contains ‘m’ OrderBy Salary Ascending using LINQ Method Syntax[fluent syntax].

            //var allStds6 = stds.Where(s => s.TrackId == 1 && s.FirstName.ToLower().Contains('m')).OrderBy(s => s.Salary);
            //foreach (var st in allStds6)
            //{
            //    Console.WriteLine(st);
            //}

            //7.Find First Student with Salary more than 5000.

            //var std7 = stds.FirstOrDefault(s => s.Salary > 5000);
            //var std77 = stds.First(s => s.Salary > 5000);
            //if(std7!=null) Console.WriteLine(std7);
            //else Console.WriteLine("No student");


            //8.Find Last Student in Track number 10.

            //var std8 = stds.LastOrDefault(s => s.TrackId==10);
            //var std88 = stds.Last(s => s.TrackId==10);
            //if (std8 != null) Console.WriteLine(std8);
            //else Console.WriteLine("No student");

            //9.	Find Student with Age equal 25.
            //try
            //{
            //var std9 = stds.SingleOrDefault(s => s.Age == 25);
            //var std99 = stds.Single(s => s.Age == 25);
            //    Console.WriteLine(std9);
            //    Console.WriteLine(std99);
            //}
            //catch
            //{

            //Console.WriteLine("Invalid operation");
            //}

            //10.	Find Student with TrackId equal 8.
            //try
            //{
            //    var std10 = stds.SingleOrDefault(s => s.TrackId == 8);
            //    var std100 = stds.Single(s => s.TrackId == 8);
            //    Console.WriteLine(std10);
            //    Console.WriteLine(std100);
            //}
            //catch
            //{

            //    Console.WriteLine("Invalid operation");
            //}


            //11.	Find Student in index 4.
            //try
            //{
            //    var std11 = stds.ElementAt(444);
            //    Console.WriteLine(std11);
            //}
            //catch
            //{

            //    Console.WriteLine("Invalid operation");
            //}


            //12


            //Console.WriteLine("Enter sorting method\n1-Name \n2-Age\n3-Salary\n4-Track ID");

            //int choice;
            //do
            //{
            //    Console.WriteLine("Enter value from 1 to 4");
            //    int.TryParse(Console.ReadLine(), out choice);
            //} while (choice < 1 || choice > 4);

            //Console.WriteLine("Enter sorting Way\n1-ASC \n2-DESC");

            //int choice2 = 0;
            //do
            //{
            //    Console.WriteLine("Enter value 1 or 2");
            //    int.TryParse(Console.ReadLine(), out choice2);
            //} while (choice2 < 1 || choice2 > 4) ;

            //    var ans = Utils.FindStudentsSorted(stds,choice, choice2);

            //foreach(var item in ans )
            //    Console.WriteLine(item);


            var q = stds.OrderBy(e => e.Salary).OrderBy(e => e.Age);
            foreach (var item in q)
                Console.WriteLine(item);
            var q2 = stds.OrderBy(e => e.Age).ThenBy(e => e.Salary);
            Console.WriteLine("**************************************");
            foreach (var item in q2)
                Console.WriteLine(item);

        }
    }
}
