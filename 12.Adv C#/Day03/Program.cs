using static System.Console;
namespace Day3
{
    #region  exception handling
    //class AgeRangeException : Exception
    //{
    //    public int oldage { get; set; }
    //    public AgeRangeException(int oldage):base("invalid age ,age must between 6 and 20")
    //    {
    //        this.oldage = oldage;
    //    }
    //}

    //class Student
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    int age;
    //    public int Age { get { return age; } set {

    //            if (value > 6) age = value;
    //            else throw new AgeRangeException(value);

    //        } }
    //    public Subject mysubj { get; set; }

    //}
    //class Subject
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public int duration { get; set; }
    //    public override bool Equals(object obj)
    //    {
    //        return base.Equals(obj);
    //    }
    //    //public override bool Equals(object? obj)
    //    //{
    //    //    Student s=obj as Student;

    //    ////   return  s?.id == id ?? false;
    //    //   //return (s?.id??0 ? id)
    //    //    //if (s==null)
    //    //    //{
    //    //    //    return false;

    //    //    //}
    //    //    //else
    //    //    //{
    //    //    //    return s.id == id;
    //    //    //}
    //    //}

    //}
    //class operation
    //{
    //    public static int display(int[] arr)
    //    {
    //        //return arr?[0];
    //        return arr?.Length ?? 0;
    //    }
    //}
    #endregion
    //define delegate
    public delegate int mydel(int a, int b);

    public delegate void mydel2<t, t1>(t a, t1 b);

    public delegate void mydel3(int x, int y, mydel d);
    class operation
    {
        public int sum(int x , int y) {
            Console.WriteLine($"sum={x+y}");
        return x + y;
        }
        public int sub(int x, int y)
        {
            Console.WriteLine($"sub={x - y}");

            return x - y;
        }
        public static int mul(int x, int y)
        {
            Console.WriteLine($"mul={x * y}");

            return x * y;
        }
    }
    internal class Program
    {
        static void calc(int x , int y , mydel d)
        {
            Console.WriteLine(  d(x, y));
        }
        static void calc(int x, int y, mydel2<int ,int> d)
        {
            d(x, y);
        }

        static void Main(string[] args)
        {
            #region null codational operator ?. ,?[]

            // Student s = new Student();
            //  Console.WriteLine(s.mysubj?.id);

            //Console.WriteLine(operation.display(null));
            #endregion
            #region null coallasing operator ,null coalllasing assign operator

            //Student s = new Student();
            //Console.WriteLine(s.mysubj?.id ?? 0);


            //string txt = "hi";
            //if (txt == null)
            //{
            //    txt = "ali";
            //}
            //  txt ??= "ali";
            // Console.WriteLine(txt);

            #endregion
            #region nullable datatype
            //?nullable datatype
            //   Nullable<int> x = 4;
            //int? x = 4;
            // x = null;
            // string txt = null;

            //?: ternary operator
            //  int x = -4;
            // Console.WriteLine((x >= 0) ? "x greater than 0":" x in negative");

            //?. ?[]
            //??
            //??=


            #endregion
            #region check ,uncheck

            //checked
            //{
            //    long x = int.MaxValue;
            //    x += 10;
            //    unchecked
            //    {
            //        int y = (int)x;
            //        Console.WriteLine($"interger negative range:{int.MinValue}");
            //        Console.WriteLine(y);
            //    }
            //}


            #endregion
            #region  try ..catch ,finally

            //try
            //{
            //    Console.WriteLine(" enter number");
            //    int num = int.Parse(Console.ReadLine());
            //    int z = 100 / num;
            //    Console.WriteLine(z);
            //    //
            //}

            //catch (FormatException ex)
            //{

            //}
            //catch(DivideByZeroException ex)
            //{

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.TargetSite);
            //    Console.WriteLine(DateTime.Now.ToShortDateString());
            //    Console.WriteLine(DateTime.Now.ToShortTimeString());
            //    //
            //}

            //finally
            //{

            //}T

            //try
            //{
            //    Student s = new Student();
            //    s.Age = 6;

            //    Console.WriteLine(s.Age);
            //}
            //catch(AgeRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.oldage);
            //    WriteLine("test");
            //}
            #endregion
            #region  delegate 

            //sort(data ,fun)

            //            operation op = new operation();

            ////mydel d = new mydel(op.sum);//define object from delegate
            ////d = op.sub;

            //mydel d = op.sum;

            ////    int r = d.Invoke(5, 3);//invoke delegate
            //int r = d(5, 2);
            //Console.WriteLine(r);


            //mydel d1 = op.sub;
            //d1 = operation.mul;
            //Console.WriteLine(d1(4,3));


            //calc(5, 2, operation.mul);

            //mydel d = calc;


            //mydel d = op.sub;
            //d += op.sum;
            //d += operation.mul;

            //calc(4, 5, d);

            //int r = d(5, 3);
            //Console.WriteLine(r);
            //   Console.WriteLine(d.GetInvocationList().Length);


            //   mydel d = op.sub;
            //   d += op.sum;
            //   d += operation.mul;
            //   d += op.sub;
            ////   d(3, 4);
            //   mydel d2 = op.sub;
            // //  d2 += operation.mul;


            //  //mydel d3 = d + d2;
            //   mydel d3 = d - d2;

            //   d3(5, 1);

            // mydel2<int ,int> d=

            #endregion
            #region  anynoums fun

            mydel d = delegate (int x, int y)
            {
               return x + y;
            };

            calc(5, 2, delegate (int x, int y) { return x - y; });

         //   Console.WriteLine(  d(5, 2));

            #endregion

        }
    }
}

