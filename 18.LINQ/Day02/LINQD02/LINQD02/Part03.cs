using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD02
{
    public class Part03
    {

        static void Main(string[] args)
        {

           
            #region Q1
 var q41 = SampleData.Books.Select(b => new { Title = b.Title , ISBN =b.Isbn });
            //q41.loop();
            #endregion

            #region Q2

            var q42 = SampleData.Books.Where(b => b.Price > 25);
            //q42.loop();

            #endregion

            #region Q3

            var q43 = SampleData.Books.Select(b => new { b.Title, b.Publisher.Name });
            //q43.loop();

            #endregion

            #region Q4

            var q44 = SampleData.Books.Count(b=>b.Price>20);
            //Console.WriteLine(q44);


            #endregion

            #region Q5

            var q45 = SampleData.Books.Select(b => new { Title = b.Title , price = b.Price , Name = b.Subject }).OrderBy(b=>b.Name.Name).OrderByDescending(b=>b.price) ;
            //q45.loop();
            #endregion

           
            #region Q6
            var q61 = SampleData.Books.Join(SampleData.Subjects,
                b => b.Subject.Name,
                s => s.Name,
                (b, s) => new { title = b.Title, subject = s.Name }
                ).GroupBy(su => su.subject);

            var q6 = SampleData.Books.GroupBy(b => b.Subject.Name);

           var q610 = SampleData.Subjects.Select(s => new { SubjectName = s.Name,
               BookTitle = SampleData.Books.Where(b => b.Subject.Name == s.Name) });


            //q61.loopObject();
            //foreach (var group in q61)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var book in group)
            //    {
            //        Console.WriteLine(book.title);
            //    }
            //    Console.WriteLine("");
            //}


            #endregion


            #region Q7

            var q76 = SampleData.Books.GroupBy(b => new { b.Subject, b.Publisher });
            foreach (var group in q76)
            {
                Console.WriteLine(group.Key.Subject);
                foreach (var book in group)
                {
                    Console.WriteLine(book);
                }
                Console.WriteLine("");
            }

            #endregion
        }
    }
}
