namespace Day1
{
    class Student
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
            return $"{id}-{name}-{age}years old";
        }
        public override bool Equals(object? obj)
        {
            Student s2 = (Student)obj;
            return (id==s2.id &&name==s2.name &&age==s2.age);
        }
        public override int GetHashCode()
        {
            return id;
        }


    }
     struct complex
    {
        public int real { get; set; }
        public int img { get; set; }
        public complex(int real, int img) 
        {
            this .real = real;
            this .img = img;
        }
        public override string ToString()
        {
            return $"{real}+{img}i";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  system.object
            // employee em;
            // em.
            //// employee em = new employee();

            // test t;



            // object obj = new object();
            // obj = 3;
            // obj = "ali";
            // obj = 2.2f;

            //object[] arr = new object[4];
            //arr[0] = 1;
            //arr[1] = "ali";
            //arr[2] = 3.2f;
            //arr[3] = new employee();

            //int x = (int)arr[0];//unboxing
            //x++;
            //arr[0] = x;//boxing

            //tostring
            // Student s = new Student(1, "ali ahmed", 20);
            //// Console.WriteLine(s.ToString());


            // complex c1 = new complex(2, 3);
            // Console.WriteLine(c1.ToString());

            //equals

            complex c1 = new complex(1, 2);
            complex c2 = new complex(1, 2);

            Student s1 = new Student(1, "ali", 22);
            Student s2 = s1;
           // Student s2 = new Student(1, "ali", 22);

            //if (s1.Equals(s2))
            //{
            //    Console.WriteLine("equals");
            //}
            //else
            //{
            //    Console.WriteLine("not equals");
            //}

            //gettype
            //Console.WriteLine(s1.GetType().BaseType);

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            #endregion
        }
    }
}
