namespace LINQR3DotNetMNFD01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-------------------------------------------------------------------------*/
            #region Named Obj
            //Student student = new Student() { ID = 1, Name = "Ali" };
            //// Named Obj => Object has reference name
            //Console.WriteLine(student); // namespace.classname => tostring
            //student.Name = "Test";
            //var std1 = new Student();
            //Student std2 = new Student();
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Collection
            // Base for all collection
            // 1- ICollection
            // 2- IEnumerable
            //List<int> ints = new List<int>();
            //Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            //IEnumerable<int> ints1 = new List<int>();
            //IEnumerable<KeyValuePair<int, string>> keyValuePairs1 = new Dictionary<int, string>();

            //IEnumerable<string> strings = new IEnumerable<string>(); // XXXX Interface
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Anonymous Obj 
            //// Obj withoutName
            //List<Student> students = new List<Student>()
            //{
            //    new Student() {ID=1, Name="Ali" },
            //    new Student() {ID=2, Name="Mohamed" }
            //};

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}

            //new Student(); // obj on the fly
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Anonymous Function
            ////(int x, int y) => { return x + y; };
            //Func<int, int, int> func = (int x, int y) => { return x + y; };

            //// Delegate
            //// 3

            //// 1- Predicate => Return type bool and take only 1 input param
            //Predicate<Student> predicate = std => std != null;

            //// 2- Action => Return type void form 0 to 16 input param
            //Action action1 = () => Console.WriteLine("Action");

            //Action<int, int> action2 = (x, y) => Console.WriteLine("Hello");

            //// 3- Func => More Generic => return type Generic take from 0 to 16 input param
            //Func<int> func1 = () => { return 1; };
            //Func<int,int> func2 = (x) => { return 1; };
            //Func<int,string> func3 = (x) => { return ""; };
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Anonymous Type
            //// var => LINQ
            //// var z; => // XXXXXXX
            //var s1 = new { SSN = 1, Fullname = "Mohamed Ahmed", Salary = 2000.5 };
            //Console.WriteLine(s1); // 
            //Console.WriteLine(s1.GetType()); // 
            //// Object on the fly
            //// Readonly
            ////s1.Fullname = "hamada";


            //// var
            //var z; // XXXX
            //var x = 5;
            //x = 1.5; // XXXX
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Before LINQ
            //List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> list2 = new List<int>();

            //foreach (var item in list1)
            //{
            //    if (item % 2 == 0)
            //    {
            //        list2.Add(item);
            //    }
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region LINQ
            // Features Added on Collections
            // 40 Additional Methods (Extention Methods) System.linq
            // "LINQ stands for Language Integrated Query, a Microsoft .NET Framework
            //that provides a standardized way to query data from various data sources using
            //a common syntax within programming languages like C#
            //Extention Method	
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Extention Method
            //string str = "Hello World From ITI";
            //int count1 = Helper.GetWordsCount(str);
            //Console.WriteLine(count1);

            //int count2 = str.GetWordsCount();
            //Console.WriteLine(count2);

            //int count3 = ExtentionMethod.GetWordsCount(str);
            #endregion
            /*-------------------------------------------------------------------------*/
            #region LINQ
            // 1- Query Syntax [Limited = 12/40 Method]
            // 2- Method Syntax [Fluent API] [Fluent Syntax] [40]
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Repository
            var emps = Repository.GetEmployees();
            var depts = Repository.GetDepartments();

            //foreach (var item in emps)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Fluent API [Fluent Syntax] => Function Chaining
            //// Enumerable => Class that contain linq methods
            //var minId = emps.Min(e => e.Id);
            //var minId2 = Enumerable.Min(emps, e => e.Id);
            //Console.WriteLine(minId2);


            //var q1 = emps.Where(e => e.Age > 25);
            ////IEnumerable<Employee> q2 = emps.Where(e => e.Age > 25);
            ////List<Employee> q3 = emps.Where(e => e.Age > 25).ToList();


            //var q2 = emps // 10
            //    .Where(e => e.Age < 25);  // 2

            //var q3 = emps.Where(e => e.Age < 35).Where(e=>e.DeptId == 3);

            //var q4 = emps.Where(e => e.Age < 35 && e.DeptId == 3);

            //var q5 = emps.Where(e=>e.Salary >2000).OrderByDescending(e => e.Age);

            //var q6 = emps
            //    //.Where(e=>e.Salary >2000)
            //    .OrderByDescending(e=>e.Salary)
            //    .OrderBy(e => e.Age);

            //var q7 = emps
            //    //.Where(e => e.Salary > 2000)
            //    .OrderBy(e => e.Age)
            //    .ThenBy(e => e.Salary);


            //foreach (var item in q6)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------------");
            //foreach (var item in q7)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Query Syntax
            // select * from emp where age > 25
            // from select where

            // Query Syntax Limited for 12/40
            var q8 = from item in emps
                     where item.Age > 25
                     select item;

            var q9 = from item in emps
                     where item.Salary > 2500
                     orderby item.Age ascending // by def. desc
                     select item;


            var q10 = from item in emps
                      where item.DeptId == 1
                      select item;

            var q11 = from item in emps
                      where item.DeptId == 2 && item.Age > 25
                      select item;

            // Console.WriteLine(q11); // XXXXXXX // Where is always return IEnu
            //foreach (var item in q11)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Single Obj => These Operators return a single element from a sequesnce
            // First
            // FirstOrDefault
            // Last
            // LastOrDefault
            // Single
            // SingleOrDefault
            // ElementAt
            // ElementAtOrDefault
            // Find => EFCore

                #region First
                //Employee q1 = emps.First();
                //var q2 = emps.First();
                //var q3 = emps.First(e => e.Age > 30);

                //var q4 = emps.First(e => e.DeptId == 1);
                //var q5 = emps.First(e => e.DeptId == 15);

                //Console.WriteLine(q5);

                // First 
                // if no input return 1st element in list
                // if found return elemnt 
                // if not Unhandled exception. System.InvalidOperationException: Sequence contains no matching element

                //var q2 = emps.FirstOrDefault();
                //var q3 = emps.FirstOrDefault(e => e.Age > 30);

                ////var q4 = emps.FirstOrDefault(e => e.DeptId == 1);
                //var q5 = emps.FirstOrDefault(e => e.DeptId == 15);
                //if (q5 is null)
                //{
                //    Console.WriteLine("Not found");
                //}
                //else
                //{
                //    Console.WriteLine(q5);
                //}

                // FirstOrDefault if found return element
                // if not no error and return null
                #endregion

                #region Last
                //var q6 = emps.Last();
                //var q7 = emps.Last(e=>e.DeptId == 2);
                ////var q90 = emps.Last(e=>e.DeptId == 20);
                //var q90 = emps.LastOrDefault(e=>e.DeptId == 20);
                //Console.WriteLine(q90);

                //// Last if found element return element 
                //// if not found System.InvalidOperationException: Sequence contains no matching element
                #endregion

                #region Single
                //var q20 = emps.Single();
                //var q21 = emps.Single(e => e.DeptId == 2);

                // Single 
                // if found more than one element 
                // System.InvalidOperationException: Sequence contains more than one element
                // if not found
                // System.InvalidOperationException: Sequence contains no matching element
                //var q22 = emps.Single(e => e.DeptId == 20);
                //var q22 = emps.Single(e => e.Id == 1);
                //Console.WriteLine(q22);

                // Single Or Default
                // if found more than one element 
                // System.InvalidOperationException: Sequence contains more than one element
                // if not found
                // return null


                //var q23 = emps.SingleOrDefault();
                //var q24 = emps.SingleOrDefault(e => e.DeptId == 20);
                //var q25 = emps.SingleOrDefault(e => e.DeptId == 2);
                //Console.WriteLine(q25);
                #endregion

                #region ElementAt
                //var q26 = emps.ElementAt(1);
                //var q27 = emps.ElementAtOrDefault(1);
                //Console.WriteLine(q26);
                //Console.WriteLine(q27);


                //var q26 = emps.ElementAt(111);
                var q27 = emps.ElementAtOrDefault(111);
                    //Console.WriteLine(q26);
                    Console.WriteLine(q27);

                    // ElementAt if index more than len
                    //  System.ArgumentOutOfRangeException:
                    //  Index was out of range. Must be non-negative and less than the
                    //  size of the collection.

                    // ElementAtOrDefault if index more than len
                    //  null
                    #endregion

            #endregion
            /*-------------------------------------------------------------------------*/
        }
    }
}
