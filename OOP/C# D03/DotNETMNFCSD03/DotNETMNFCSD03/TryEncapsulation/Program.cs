namespace TryEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region C# Data Types
            /////1-struct
            /////2-class
            /////3-enum
            /////
            //Int32 x = 10;
            //float y = 20;
            //double z = 30;
            //bool flag =true;

            ////keyword
            /////Int32 ===> int
            //int a = 11;
            #endregion

            int x = 33;
            #region Value type   [struct][enum]
            //int x,y; //4B 
            //x = 2;
            //y = 10;
            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"y={y}");
            //x = y; //assign state
            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"y={y}");
            //y = -1000;
            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"y={y}");

            #endregion

            #region Reference type  [class]
            ////string str1="Eman";
            ////string str2="Eman";

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 6, 7, 8, 9, 10 };

            /////HashCode [identical # for any object in memory]
            //Console.WriteLine($"arr1 identity {arr1.GetHashCode()}");
            //Console.WriteLine($"arr2 identity {arr2.GetHashCode()}");

            //arr1 = arr2; //assign reference

            //Console.WriteLine($"arr1 identity {arr1.GetHashCode()}");
            //Console.WriteLine($"arr2 identity {arr2.GetHashCode()}");

            //arr1[0] = 1000;
            //Console.WriteLine(arr2[0]);
            #endregion

            #region class Example
            //Employee e1; //ZERO Bytes  //null //reference
            //e1 = new Employee(); //4+0+8+4 = 16 Bytes
            ////new + class= allocation in heap + data initialization
            ////e1=> object/instance of Employee [new]
            #endregion

            #region OOP Violation [Encapsulation]
            //Employee e1 = new Employee();
            //Employee e2 = new Employee();
            ////new + class= allocation in heap + data initialization

            //e1.id = 1;
            //e1.name = Console.ReadLine();
            //e1.salary = 1000;
            //e1.age = 20;

            //Console.WriteLine(e1); //ns.DTName
            //Console.WriteLine(e1.id); 
            //Console.WriteLine(e1.name); 
            //Console.WriteLine(e1.age);
            //Console.WriteLine(e1.salary);

            ////after private
            ////compile Error
            #endregion

            #region Encapsulation Example
            //Employee e1 = new Employee();
            ////e1 id|1| name|nl| salary|0| age|0|   +GC variables overhead
            //Employee e2 = new Employee();
            ////e2 id|2| name|nl| salary|0| age|0| 
            ////new +class=allocation in heap + data initialization

            ////e1.Eman(1);
            ////e2.Eman(2);


            ////Console.WriteLine(e1.HatId()); //1
            ////Console.WriteLine(e2.HatId());//2


            //e1.SetId(1);
            //e1.SetName("Eman");
            //e1.SetSalary(80000);
            //e1.SetAge(20);
            //Console.WriteLine(e1.GetId());
            //Console.WriteLine(e1.GetName());
            //Console.WriteLine(e1.GetAge());
            //Console.WriteLine(e1.GetSalary());

            //Console.WriteLine("========================");
            //Console.WriteLine("Enter id");
            //e2.SetId(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Enter name");
            //e2.SetName(Console.ReadLine());
            //Console.WriteLine("Enter age");
            //e2.SetAge(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Enter salary");
            //e2.SetSalary(double.Parse(Console.ReadLine()));

            //Console.WriteLine(e2.GetId());
            //Console.WriteLine(e2.GetName());
            //Console.WriteLine(e2.GetAge());
            //Console.WriteLine(e2.GetSalary());
            //Console.WriteLine("OR");
            //e2.Print();
            //Console.WriteLine("OR");
            //Console.WriteLine(e2.PrintV2());
            #endregion

            #region Array of 3 Employees [class]

            /////Famous Runtime Error
            /////Object reference not set to an instance of an object.


            //Employee[] employees;  //ZERO Bytes //null //reference
            //employees = new Employee[3];
            ////new + array= allocation in heap + data initialization

            //////REmember [with class]
            //////each element in array is reference
            //////u must allocate it in heap
            ////employees[0] = new Employee();
            ////employees[1] = new Employee();
            ////employees[2] = new Employee();
            //////

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    //
            //    employees[i] = new Employee();
            //    //
            //    Console.WriteLine("Enter id");
            //    employees[i].SetId(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("Enter name");
            //    employees[i].SetName(Console.ReadLine());
            //    Console.WriteLine("Enter age");
            //    employees[i].SetAge(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("Enter salary");
            //    employees[i].SetSalary(double.Parse(Console.ReadLine()));
            //}
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    //employees[i].Print();
            //    Console.WriteLine(employees[i].PrintV2());
            //}

            #endregion

            #region Struct Example Recap
            //Employee e2; //16Bytes //in Stack
            //e2 = new Employee();
            ////new +struct= data initialization
            ///

            //Employee[] employees;  //ZERO Bytes //null //reference
            //employees = new Employee[3]; //16*3=48Bytes
            #endregion

            #region Complex Example
            //Complex c1 = new Complex();
            //Complex c2 = new Complex();
            //Complex c3 = new Complex();
            ////new +class=allocation in heap + data initialization
            //c1.SetReal(3);
            //c1.SetImg(4);

            //Console.WriteLine("Enter real");
            //c2.SetReal(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Enter img");
            //c2.SetImg(int.Parse(Console.ReadLine()));
            ////c3 = c1.Add(c1, c2);
            //c3 = c1.AddV2(c2);

            //Console.WriteLine($"c1={c1.Print()}");
            //Console.WriteLine($"c2={c2.Print()}");
            //Console.WriteLine($"c3={c3.Print()}");
            #endregion

            #region LAb Assignments
            //class Employee [id,name,salary,age] [setters&getters][print]

            //1-one employee read and write

            //2-array of 3 employees read and write [new array] != [new object]

            //class Complex [real,img] [setters&getters][???print][add 2 complex numbers]
            //3-one complex number read and write

            ///real img  print
            ///3    4    3+4i
            ///3    -4   3-4i
            ///3    1    3+i
            ///3    -1   3-i
            ///0     1    i
            ///0     -1   -i
            ///0     0    0
            ///0     3    3i
            ///0     -3   -3i
            ///3     0    3
            
            //Complex c1= new Complex();

            //while (true)
            //{
            //    Console.WriteLine("Enter real");
            //    c1.SetReal(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("Enter img");
            //    c1.SetImg(int.Parse(Console.ReadLine()));
            //    Console.WriteLine(c1.Print());
            //}


            #endregion
        }
    }
}
