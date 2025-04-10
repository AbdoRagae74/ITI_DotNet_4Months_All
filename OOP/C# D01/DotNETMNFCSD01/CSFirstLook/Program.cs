using System;
namespace CSFirstLook
{
    internal class Program
    {
        //Entry point
        static void Main(string[] args)
        {
            #region write in console
            //Console.WriteLine("Hello .NET MNF");
            //int age = 22;
            //string name = "Fatma";

            /////WORST CASE EVER FOR STRING [Concat]  =>[Memeory overhead]
            //Console.WriteLine("Your name is " + name);
            //Console.WriteLine("Your age is " + age);

            ////best for string
            ////1-
            //Console.WriteLine("Your name is {0}",name);
            //Console.WriteLine("Your age is {0}",age);
            //Console.WriteLine("Your name is {0},Your age is {1}", name,age);
            ////2-[RECOMMENDED] string interpolation
            //Console.WriteLine($"your name is {name}");
            //Console.WriteLine($"your age is {age}");
            //Console.WriteLine($"Your name is {name},Your age is {age}");
            #endregion

            #region read from console
            //int id;  //unassigned local variable
            //string name;
            //int age;
            //float salary;

            //Console.WriteLine("Enter Id");
            //id = int.Parse(Console.ReadLine()); 
            ////id=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Name");
            //name= Console.ReadLine();
            //Console.WriteLine("Enter Age");
            //age=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Salary");
            //salary=float.Parse(Console.ReadLine());

            //Console.WriteLine($"id={id},name={name},age={age},salary={salary}");

            #endregion

            #region Operators
            #region Binary arithmatic operators +,-,*,/,%
            //int x = 3, y = 4, z;

            //z = x + y;
            //z = x - y;
            //z = x / y;
            //z = x % y;
            //Console.WriteLine($"x={x}"); //3
            //Console.WriteLine($"y={y}"); //4
            //Console.WriteLine($"z={z}"); //3
            #endregion

            #region Unary operator ++,--

            //int x = 3, y = 4, z;

            ////x++;
            ////++x;
            ////z = x++;  //execution x=z then x++

            //z = ++x;

            //Console.WriteLine($"x={x}");  //4 
            //Console.WriteLine($"z={z}");  //4
            //Console.WriteLine($"y={++y}");  //5
            //Console.WriteLine($"y={y}");  //5


            /////REMEMBER
            /////z=x+1;
            /////z=++x;
            #endregion

            #region Compound operator +=,-=,*=,/=,%=    ==XXXX
            //int x = 3, y = 4, z = 5;

            //x += y;   //x=x+y;

            #endregion

            #region Comparison operators >,<,>=,<=,==,!=  return bool [true][false]
            //int x = 3, y = 4, z = 5, a = 3;
            //Console.WriteLine(x != y);

            #endregion
            #region Logical operator &&,||
            //int x = 3, y = 4, z = 5, a = 3;
            //Console.WriteLine(x>y &&  y>z &&  z>x);
            ////&& returns true if ALL Branches are true
            ////&& returns false if Any Branch is false

            ////|| returns false if ALL Branches are false
            ////|| returns true if Any Branch is true
            #endregion

            //Search turnary operator ()?value1:value2
            #endregion

            #region Lab Assignments -> No Delivery
            //1-VS community 2022 Setup
            //2-try All In Lecture
            #endregion

        }
    }
}
