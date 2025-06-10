namespace ConsoleApp1
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        private Student(int id = 0, string name = "", int age = 0)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        static Student st=null;
        public static Student getstudent()
        {
            if (st == null)
            {
                st = new Student();
                return st;
            }
            else
                return st;

          
        }
        public override string ToString()
        {
            return $"{id}-{name} \t {age}years old";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = Student.getstudent();
            Student s2 = Student.getstudent();
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
        }
    }
}
