using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD02
{
    internal class Part02
    {

        static void Main01(string[] args)
        {

            #region Q1

            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            var q1 = numbers.Distinct().OrderBy(n => n);
            //q1.loop();
            var squared = q1.Zip(q1, (a, b) => new { Number = a, Mutiply = a * b });
            //squared.loop();

            #endregion


            #region Q2
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            var names3 = names.Where(e => e.Length == 3);
            var names3_1 = from name in names
                           where name.Length == 3
                           select name;
            //names3_1.loop();

            var orderd = names.Where(n => n.ToLower().Contains('a')).OrderBy(n => n.Length);
            var orderd_1 = from name in names
                           where name.ToLower().Contains('a')
                           orderby name.Length
                           select name;
            //orderd_1.loop();

            #endregion

            #region Q3

            List<Student2> students = new List<Student2>(){
          new Student2(){ ID=1, FirstName="Ali", LastName="Mohammed", Subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){ Code=33,Name="UML"}}},
          new Student2(){ ID=2, FirstName="Mona", LastName="Gala", Subjects=new Subject []{ new Subject(){ Code=22,Name="EF"}, new Subject (){ Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}},
          new Student2(){ ID=3, FirstName="Yara", LastName="Yousf", Subjects=new Subject []{ new Subject (){ Code=22,Name="EF"}, new Subject (){ Code=25,Name="JS"}}},
          new Student2(){ ID=1, FirstName="Ali", LastName="Ali", Subjects=new Subject []{ new Subject (){ Code=33,Name="UML"}}},
};

            var q31 = students.Zip(students,
                (a, b) => new { FullName = $"{a.FirstName} {a.LastName} ", NoOfSubjects = b.Subjects.Count() });
            //q31.loop();

            var q32 = students.Select(s => s).OrderByDescending(s => s.FirstName).
                ThenBy(s => s.LastName).Select(s => $"{s.FirstName} {s.LastName}");
            //q32.loop();
            var q33 = students.SelectMany(s => s.Subjects,
                (name, sub) => new { StudentName = $"{name.FirstName} {name.LastName}", SubjectName = $"{sub.Name}" });
            //q33.loop();



            var q34 =  students.GroupBy(s=>s.FirstName+s.LastName);
           foreach(var item in q34)
            {
                Console.WriteLine(item.Key);

                foreach(var item2 in item.SelectMany(s=>s.Subjects))
                {
                    Console.WriteLine(item2.Name);
                }
            }
            //q34.loopObject();
            #endregion




        }
    }
}
