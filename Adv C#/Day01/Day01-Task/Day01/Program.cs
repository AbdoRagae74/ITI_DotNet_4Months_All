namespace Day01
{
    internal class Program
    {
        class Student
        {
            public int id, age;
            public string name;
            public Student(int id, string name, int age)
            {
                this.id = id;
                this.name = name;
                this.age = age;
            }
            public override string ToString()
            {
                return  $"{id}\t {name} \t {age}";
            }
        }
        struct Complex
        {
            public int real;
            public int img;
            public Complex(int real , int img)
            {
                this.real = real;
                this.img = img;

            }

            public override string ToString()
            {
                return $"{real}{img}i";
            }

        }
        static void Main(string[] args)
        {

            Student s1 = new Student(12, "Ahmed", 23);
            Console.WriteLine(s1.ToString());
            Complex c1 = new Complex(12, 5);
            c1.ToString();

            object[] o1 = new object[] { 1,"ali",2.3f,false };

            int x = (int)o1[0]; // Unboxing
            x++;
            o1[0] = x; // Boxing

        }
    }
}
