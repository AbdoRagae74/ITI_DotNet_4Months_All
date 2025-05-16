//using static System.Console;

namespace DotNETMNFCSD05
{
    struct EntryPoint
    {
        static void Main()
        {
            #region Stack Example V01
            //MyStack s1 = new MyStack();  // s1 tos||   arr||||||
            //s1.Push(10);
            //s1.Push(20);
            //s1.Push(30);
            //s1.Push(40);
            //s1.Push(50);
            //s1.Push(60);
            //s1.Push(70);
            //Console.WriteLine(s1.Pop());
            //Console.WriteLine(s1.Pop());
            //Console.WriteLine(s1.Pop());
            //Console.WriteLine(s1.Pop());
            //Console.WriteLine(s1.Pop());
            //Console.WriteLine(s1.Pop());
            //Console.WriteLine(s1.Pop());
            #endregion

            #region Stack Example V02
            ////DynamicStack s1 = new DynamicStack(10);
            ////s1.Push(1);
            ////s1.Push(2);
            ////s1.Push(3);
            ////s1.Push(4);
            ////s1.Push(5);
            ////s1.Push(6);
            ////s1.Push(7);
            ////Console.WriteLine(s1.Pop());
            ////Console.WriteLine(s1.Pop());
            ////Console.WriteLine(s1.Pop());
            ////Console.WriteLine(s1.Pop());
            ////Console.WriteLine(s1.Pop());
            ////Console.WriteLine(s1.Pop());
            ////Console.WriteLine(s1.Pop());
            ////Console.WriteLine(s1.Pop());


            //StackStr s2 = new StackStr();
            //s2.Push("Eman");
            //StackChar s3 = new StackChar();
            //s3.Push('A');
            #endregion

            #region Template[c++] -> generic[C#]
            ////you can create container DT once
            ////and can be applicable with any DT

            ////GenericStack s1 = new GenericStack();
            //GenericStack<int> s1 = new GenericStack<int>();
            //GenericStack<string> s2 = new GenericStack<string>();
            //GenericStack<char> s3 = new GenericStack<char>();
            //s1.Push(2);
            //s2.Push("");
            //s3.Push('A');
            #endregion

            #region static


            ///////static variable / class variable / shared variable
            ///////>member variable with keyword static
            ///////>member variable that O.S will create
            ///////only one copy of it in memory[heap]
            ///////regardless # of objects created from that class
            ///////>static variable is Alive till program ends
            ///////>static variable is accessed by class name NOT object name 

            ////DynamicStack s1 = new DynamicStack(5);
            ////DynamicStack s2 = new DynamicStack(10);
            ////DynamicStack s3 = new DynamicStack();


            ////////Console.WriteLine(s1.counter); //T c++,java
            //////Console.WriteLine(DynamicStack.counter);
            //////DynamicStack.counter = 33;
            //////Console.WriteLine(DynamicStack.counter);


            //////Console.WriteLine(s1.GetCounter()); //3  //Runs sccessfully  ///not make sense

            ////Console.WriteLine(DynamicStack.GetCounter()); //3
            ////Console.WriteLine(DynamicStack.Counter);


            //Console.WriteLine(Math.Add(11,22));

            //Console.WriteLine("Hello .Net");

            ////WriteLine("Hello Again");
            #endregion

            #region operators overloading
            //int x = 3, y = 4, z;
            //double a = 5, b = 6, c;

            //z = x + y;  
            ////->  int operator+(int left,int right){}
            //c = a + b;
            ////->  double operator+(double left,double right){}


            ///operators in C# can be overloaded
            ///operator to be declared must be public and static
            ///+,-,*,/,% can be overloaded
            ///++,-- can be overloaded
            ///casting operator can be overloaded + implicit cast or explicit cast
            ///>,<,>=,<=,==,!= can be overloaded

            ///= cannot be overloaded
            ///+=,.. cannot
            ///&&,|| cannot

            Complex c1 = new Complex();
            Complex c2 = new Complex { Real = 5, Img = 6 };
            Complex c3 = new Complex();

            //c3 = c1.Add(c2);
            //c3 = c1 + c2;
            //->  Complex operator+(Complex left,Complex right){}
            //->  double operator+(double left,double right){}
            //->  int operator+(int left,int right){}


            //c3 = c1 + c2;

            //c3 = c1 + 10;

            //c3 = 10 + c1;

            //c3 = ++c1;

            ////implicit Casting
            //int real = c1;

            ////explicit Casting
            //int real =(int) c1;
            //Console.WriteLine(real);//3

            //Console.WriteLine(c1.Print());  //4+5i
            //Console.WriteLine(c3.Print());  //4+5i

            //if (c1 > c2)
            //{

            //}

            //string str = (string)c1;
            //Console.WriteLine(str);
            #endregion

            #region Casting [Convert state NOT variable]
            //int x = 3, y = 4;
            //float z;
            //z = (float)x / y;
            //Console.WriteLine(z);
            #endregion

            #region Lab Assignments
            //1- Implement dynamic Stack with static counter
            //2- Implement Generic Stack
            //3- class Complex
            ///c1+c2
            ///c1++
            ///++c1
            ///c1+10
            ///10+c1
            ///c1>c2
            ///(int) c1
            ///
            
            //4- (Bonus) Implement Queue [shift or circular]
            #endregion
        }
    }
}
