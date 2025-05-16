namespace DotNETMNFCSD04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Pass Value Type By Values [read only]
            //int x = 3;
            //int y = 5;
            //Console.WriteLine("Before Swap");
            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"y={y}");
            //Utility obj = new Utility();
            //obj.SwapV(x, y);  //Pass Value Type By Values [Swap(3,5)]
            //Console.WriteLine("After Swap");
            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"y={y}");
            #endregion

            #region Pass Value Type By Reference[alias name for another variable in memory]  [Read&Write]
            //int x = 3;
            //int y = 5;
            //Console.WriteLine("Before Swap");
            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"y={y}");
            //Utility obj = new Utility();
            //obj.SwapR(ref x,ref y);  //Pass Value Type By References 
            //Console.WriteLine("After Swap");
            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"y={y}");
            #endregion

            #region Pass Reference Type By Values ===[pass reference type by reference]
            //int[] arr = [1, 2, 3, 4, 5];
            //Console.WriteLine($"main arr identity {arr.GetHashCode()}");
            //Utility obj = new Utility();
            //obj.PrintArrayV(arr); //pass Reference Type By Values
            //Console.WriteLine("in main print at index 0");
            //Console.WriteLine(arr[0]);
            #endregion


            #region Pass Reference Type By Reference[alias name for another variable in memory]
            //int[] arr = [1, 2, 3, 4, 5];
            //Console.WriteLine($"main arr identity {arr.GetHashCode()}");
            //Utility obj = new Utility();
            //obj.PrintArrayR(ref arr); //pass Reference Type By Reference
            //Console.WriteLine("in main print at index 0");
            //Console.WriteLine(arr[0]);
            #endregion

            #region Question?
            //is there any difference between pass Reference Type By Values and pass Reference Type By Reference?
            //Yes ,one different ??? search
            #endregion

            #region this keyword   [discuss previous example without any change]
            //Complex c1 = new Complex();
            //Complex c2 = new Complex();
            //c1.SetReal(3);  //compiler =>Complex.SetReal(c1,3)
            //c2.SetReal(5);  //compiler =>Complex.SetReal(c2,3)
            ////inside any member function [method]
            ////there is a hidden parameter called  className this
            #endregion

            #region Overloading
            ///fn overloading:
            ///functions in same scope with same name but different input
            ///parameters type or number or order
            ///Return type is not part of overloading
            ///

            //Math obj = new Math();
            //obj.Add(11, 22);
            //obj.Add(11, 22, 33);
            //obj.Add("Hello", "World");
            #endregion


            #region Create Object with Initialization V1
            //Complex c1= new Complex();
            //Complex c2= new Complex();
            //Complex c3 = new Complex();

            //c1.SetReal(3);
            //c1.SetImg(4);
            //c2.SetReal(3);
            //c2.SetImg(4);
            //c3.SetReal(3);
            //c3.SetImg(4);

            //Console.WriteLine(c1.Print());
            //Console.WriteLine(c2.Print());
            //Console.WriteLine(c3.Print());

            #endregion

            #region Create Object with Initialization V2
            //Complex c1 = new Complex();
            //Complex c2 = new Complex();
            //Complex c3 = new Complex();

            //c1.Initialize();
            //c2.Initialize(5,6);
            //c3.Initialize(7);

            //Console.WriteLine(c1.Print());
            //Console.WriteLine(c2.Print());
            //Console.WriteLine(c3.Print());
            #endregion

            #region Constructor
            //inside any class/struct , there is hidden
            //function called constructor

            //Constructor:
            ///>method inside class/struct
            ///called automatically -WE CANNOT CALL CTOR-
            ///when u create object from that class/struct

            ///>we can use ctor to initialize data of that object created

            ///>how to write ctor explicitly?
            ///1-ctor method name is same as class/struct name
            ///2-has no return type even void
            ///3-ctor can be overloaded
            ///4-ctor can have access modifier [public]
            #endregion

            #region Create Object with Initialization V3
            //Complex c1 = new Complex();
            //Complex c2 = new Complex(5,6);
            //Complex c3 = new Complex(7);

            //Complex c4; //NOOO ctor called  //reference   //ZERO BYTES

            //Console.WriteLine(c1.Print());
            //Console.WriteLine(c2.Print());
            //Console.WriteLine(c3.Print());
            #endregion

            #region NOT Important
            ///destructor:
            ///method inside class calling automatically -we cannot call it-
            ///>when o.s remove object from memory
            ///>when object reach end of its scope

            //>how to write dest explicitly?
            //1-method name is ~class/struct name
            //2-has no return type even void
            //3-dest cannot have parameters [only one parameterless copy]
            //4-dest cannot have access modifier [public]


            ///c++ -> manual memory allocation
            ///c#  -> automatic memory allocation  [GC]
            #endregion

            #region ctor with struct [.net 7 and above]
            ////new +struct =>initialize ONLY
            //Point p1= new Point();
            //Point p2 = new Point(5,6);
            //Point p3 = new Point(7);

            #endregion

            #region create object with ctor initialization [less used]
            //Employee e1= new Employee();
            //Console.WriteLine(e1.Print());

            //Employee e2 = new Employee(2,"Ahmed",22,9000);
            //Console.WriteLine(e2.Print());

            ////Employee e2 = new Employee(2, "Ahmed", 22, 9000,33,44,55,'A',false,444);

            ////call function with named parameters
            //Employee e3 = new Employee(_age:1,_name:"Sara",_id:11,_salary:5000);

            #endregion

            #region C# use property instead of setters and getters
            //Employee e1 = new Employee();
            //Console.WriteLine("Enter id");
            //e1.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter name");
            //e1.Name = Console.ReadLine();
            //Console.WriteLine("Enter age");
            //e1.Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter salary");
            //e1.Salary = double.Parse(Console.ReadLine());

            ////e1.SetId(int.Parse(Console.ReadLine()));
            ////e1.id=int.Parse(Console.ReadLine());

            ////Console.WriteLine(e1.GetId());
            ////Console.WriteLine(e1.Id);

            //Console.WriteLine(e1.Print());
            #endregion

            #region Create object via property initialization [Most used]
            //Employee e1 = new Employee();
            //Employee e2 = new Employee(1, "Ali", 22, 1234);
            //Employee e3 = new Employee(_name:"Ali",_id:1,_age:22,_salary:1234);

            //Employee e4 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Ali",
            //    Age = 22,
            //    Salary = 1234
            //};
            #endregion

            //automatic property

            ///when to use class,when to use struct?


            #region Lab Assignments 
            //1- try lecture regions   search on difference of pass Ref Type
            //2- class Complex
            /////ctor
            /////ctor overloading
            /////try this 
            /////property
            #endregion

        }
    }
}
