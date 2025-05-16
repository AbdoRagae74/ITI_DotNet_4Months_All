namespace Day2
{
    #region  user-define interface
    //interface Istudent
    //{
    //    public void show();

    //    public int getresult(int studentid);

    //}

    //interface Iplayer
    //{

    //    public int x { get; set; }
    //    public void play()
    //    {
    //        Console.WriteLine("play");
    //    }
    //    public void show();

    //}

    //interface typeA<t>
    //{
    //    public t test(t a);
    //}
    //class masterstudent:Istudent,Iplayer,typeA<int>
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public int age { get; set; }
    //    int y;
    //    public int x { get {
    //            return y;
    //        } set {
    //            y = value;


    //        } }

    //    public int getresult(int studentid)
    //    {
    //        return studentid;
    //    }

    //    //public void play()
    //    //{
    //    //    Console.WriteLine($"{name} play in position number 10");
    //    //}
    //    void Iplayer.show()
    //    {

    //    }
    //    void Istudent.show()
    //    {

    //    }

    //    public void show()
    //    {
    //        Console.WriteLine($"{id}-{name}-{age}years old");
    //    }

    //    public int test(int a)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //internal class Program
    //{
    //    static void display(Istudent s)
    //    {
    //        s.show();
    //    }

    //    static void playerdata(Iplayer p)
    //    {
    //        p.play();
    //    }
    //    static void Main(string[] args)
    //    {
    //        display(new masterstudent());
    //        playerdata(new masterstudent());
    //    }
    //}
    #endregion

    class Student : IComparable<Student>, IDisposable
    {
       
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Student(int id = 0, string name = "", int age = 0)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{id}-{name} \t {age}years old";
        }

        //public int CompareTo(object? obj)
        //{
        //    Student s = (Student)obj;
        //    //if (age > s.age) return 1;
        //    //else if (age < s.age) return -1;
        //    //else return 0;
        //    return age.CompareTo(s.age);
        //}
        public override bool Equals(object? obj)
        {
            //is
            //if (obj is Student s)
            //{
            //    return (id == s.id);
            //}
            //else return false;

            //as
            Student s = obj as Student;
            if (s == null) return false;
            else return s.id == id;
        }

        public int CompareTo(Student? other)
        {
            return age.CompareTo(other.age);
        }

      

   

        public void Dispose()
        {
            Console.WriteLine("finallizer");
         
        }
    }
    class operation
    {
        //public int calc( int x , int y ,ref int sub)
        //{
        //   // sub = x - y;
        //    return x + y;
        //}
        public int calc(int x, int y, out int sub  ,out int mul)
        {
            sub = x - y;
            mul = x * y;
            return x + y;
        }

        //public int sum(int a , int b=0 , int c=0 , int d=0)
        //{
        //    return a + b + c + d;
        //}

        public int sum(int y,params int[] arr)
        {
            int sum = 0;
            foreach (int x in arr) {
            sum += x;
            }
            return sum;

        }
    }

    internal class Program
    {
      
        static void Main(string[] args)
        {
            #region interface
            // int[] arr = { 4, 5, 2, 3, 8, 9 };
            //Array.Sort(arr);
            // foreach (int i in arr) {

            //     Console.WriteLine(i);
            // }

            //Student[] arr2 = new Student[]
            //{
            //    new Student(1,"ali",22),
            //    new Student(4,"mona",20),
            //    new Student(3,"aya",21),
            //    new Student(2,"ahmed",25)
            //};
            //Array.Sort(arr2);
            //foreach (Student s in arr2)
            //{
            //    Console.WriteLine(s);

            //}

            //{
            //    int x = 5;



            //}

            ////using statment

            //using(Student s = new Student(1, "mostafa", 22))
            //{
            //    s.name = "mostafa ahmed";
            //    Console.WriteLine(s.ToString());
            //}
            #endregion
            #region  paramter
            //    operation op = new operation();
            //  int s,m ;
            //  int a = 5;
            //// int r =op.calc(1, 2,ref s);
            //  int r =op.calc(a, 2,out s ,out m);
            //  Console.WriteLine($"sum={r},sub={s} ,mul={m}");

            //op.sum(1, 2, 3, 4);
            //op.sum(1, 2, 3);
            //op.sum(1, 2);
            //op.sum(1);

            //Student s1 = new Student();
            //Student s2 = new Student(1);
            //Student s3 = new Student(1,"ali");
            //Student s4 = new Student(1,"ali",22);
            //Student s5 = new Student(age:20);//named paramter
            //Student s6 = new Student(age:22,name:"ali");
            //Student s7 = new Student(name:"ali");
            //Student s8 = new Student(age:22,id:1);

            //int r1=  op.sum(44,new int[] { 2, 66, 7, 88, 33, 5, 2, 9, 88, 55 });
            //  int r =  op.sum( 2, 66, 7, 88, 33, 5, 2, 9, 88, 55 ,345,377,838);

            //  Console.WriteLine(r);
            #endregion
            #region  exception handling

            //is ,as ,tryparse,nullcondational

            //object obj = new Student();
            //if (obj is operation op)
            //{
            //   // operation op = (operation)obj;
            //}

            operation op = new operation();
            Student s = new Student(1, "ali", 22);
            Student s1= new Student(1, "ali", 22);

            //if (s.Equals(s1))
            //{
            //    Console.WriteLine("equals");
            //}
            //else
            //{
            //    Console.WriteLine("notequals");
            //}

            //as

            //object obj = new operation();

            //operation oop = obj as operation;
            // Console.WriteLine(oop);


            //tryparse
            //  int x = int.Parse(Console.ReadLine());
            // Console.WriteLine(x);

            // bool status=    int.TryParse(Console.ReadLine(),out int x);
            //bool status = false;
            //int x=0;
            //do
            //{
            //    Console.WriteLine("enter number");

            //    status = int.TryParse(Console.ReadLine(), out x);
            //} while (status == false);
            //Console.WriteLine($"status={status} ,x={x}");

            #endregion
        }
    }
}
