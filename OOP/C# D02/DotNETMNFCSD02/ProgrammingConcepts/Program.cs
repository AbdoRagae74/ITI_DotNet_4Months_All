using System.Diagnostics.Metrics;

namespace ProgrammingConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if
            ///if(condition)
            ///{
            //////code here if condition is true
            ///}

            ///if(condition)
            ///{
            //////code here if condition is true
            ///}
            ///else
            ///{
            //////code here if condition is false
            ///}

            ///if(condition)
            ///{
            //////code here if condition is true
            ///}
            ///else if(condition)
            ///{
            //////code here if condition is true
            ///}
            ///else if(condition)
            ///{
            //////code here if condition is true
            ///}
            ///else
            ///{
            //////code here if all conditions are false
            ///}

            ///if(condition)
            ///{
            //////if(condition)
            //////{
            //////////code here if condition is true
            //////}
            ///}

            ///if(condition)
            ///{
            /////code here if condition is true
            ///}
            ///if(condition)
            ///{
            /////code here if condition is true
            ///}
            ///if(condition)
            ///{
            /////code here if condition is true
            ///}

            //int grade;
            //Console.WriteLine("Enter your grade");
            //grade = int.Parse(Console.ReadLine()); //-45454

            //if (grade>=85) 
            //{
            //    Console.WriteLine("A");
            //}
            //else if(grade>=75 && grade<85)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (grade >= 65 && grade < 75)
            //{
            //    Console.WriteLine("C");
            //}
            //else
            //{
            //    Console.WriteLine("Not Valid !!!");
            //}

            //int month;
            //Console.WriteLine("Enter month #");
            //month=int.Parse(Console.ReadLine());//13

            //if (month==1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //else if (month == 3)
            //{
            //    Console.WriteLine("Mar");
            //}
            //else if (month == 4)
            //{
            //    Console.WriteLine("Apr");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid !!!!");
            //}
            #endregion

            #region Switch
            //switch is valid with int, char, string

            ///switch syntax
            ///switch(variable)
            ///{
            /////case value1:
            ///////code here;
            /////break;
            /////case value2:
            ///////code here;
            /////break;
            /////case value3:
            ///////code here;
            /////break;
            /////default:
            ///////code here;
            /////break;
            ///}
            ///

            //int month;
            //Console.WriteLine("Enter month #");
            //month = int.Parse(Console.ReadLine()); //2

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;  //fall through
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    case 4:
            //        Console.WriteLine("Apr");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid !!!!");
            //        break;
            //}


            //char grade;
            //Console.WriteLine("Enter your grade");
            //grade = char.Parse(Console.ReadLine()); //a
            //switch (grade)
            //{
            //    case 'A':
            //    case 'a':
            //        Console.WriteLine("Excellent");
            //        break;
            //    case 'B':
            //    case 'b':
            //        Console.WriteLine("Very Good");
            //        break;
            //    case 'C':
            //    case 'c':
            //        Console.WriteLine("Good");
            //        break;
            //    default:
            //        Console.WriteLine("Not Valid !!!");
            //        break;
            //}
            #endregion

            #region goto [bridge] [search]
            ///goto [forbidden keyword]
            ///DON'T USE IT Never ever
            #endregion

            #region for
            ///console.writeline("Hello.NET MNF R3");
            ///console.writeline("Hello.NET MNF R3");
            ///console.writeline("Hello.NET MNF R3");
            ///console.writeline("Hello.NET MNF R3");
            ///console.writeline("Hello.NET MNF R3");
            ///
            ///Copy And Paste [BAD PRACTICE] [bad programming]
            ///1-cost of declaration
            ///2-cost of modification
            ///
            ///soln: think of write code once and Execute it many times
            ///for loop
            /////iterator for repeat code specific number of times

            ///for syntax
            ///for(initialization;condition[true];increment/decrement)
            ///{
            /////code here if condition is true
            ///}
            //     #1        #2#5  #4
            //for (int i = 1; i < 6; i++)
            //{
            //    //#3
            //    Console.WriteLine("Hello .NET MNF");
            //}
            //memory i 1 2 3 4 5 6
            //o/p
            ///Hello .NET MNF
            ///Hello .NET MNF
            ///Hello .NET MNF
            ///Hello .NET MNF
            ///Hello .NET MNF

            //for (int i=10; i>0 ;i--) { }

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine($"{i},{j}");
            //    }
            //}
            ////memory i 0 1   j 0 1 2 3 4 0
            /////o/p
            /////0,0
            /////0,1
            /////0,2
            /////0,3
            /////1,0
            #endregion

            #region do-while
            ///syntax
            ///do
            ///{
            /////code here
            ///}while(condition[true]);

            //int container = 0;
            //int num;

            //do
            //{
            //    Console.WriteLine("Enter #");
            //    num = int.Parse(Console.ReadLine());
            //    container += num;
            //    //Console.WriteLine($"indicator->{container}");
            //} 
            //while (container<100);
            /////do code while condition is true

            //Console.WriteLine($"outside loop container={container}");


            //int ssn;
            //string name;
            //int age;

            ////
            //

            //do
            //{
            //    Console.WriteLine("Enter age between 18 and 60");
            //    age = int.Parse(Console.ReadLine()); //22
            //}
            //while (age < 18 || age > 60);

            //Console.WriteLine($"your age is {age}"); //22

            //int evenNum;
            //do
            //{
            //    Console.WriteLine("Enter even number");
            //    evenNum = int.Parse(Console.ReadLine());
            //}while(evenNum%2 != 0);

            //Console.WriteLine($"even # is {evenNum}");

            #endregion

            #region while
            /////syntax
            /////while(condition[true])
            /////{
            ///////code here if condition is true
            /////}
            /////
            //int container = 0;
            //int num;
            //while (container < 100)
            //{
            //    Console.WriteLine("Enter #");
            //    num = int.Parse(Console.ReadLine());
            //    container += num;
            //    Console.WriteLine($"indicator->{container}");
            //}
            //Console.WriteLine($"outside loop container={container}");


            //int evenNum;
            //
            //while(evenNum%2!=0)
            //{
            /////
            ///}

            #endregion

            #region 1D Array
            ///////25 stds
            ///////5 subjects
            ///////float std1Sub1;
            ///////float std1Sub2;
            ///////float std1Sub3;
            ///////float std1Sub4;
            ///////float std1Sub5;
            ///////float std2Sub1;
            ///////25 * 5 Variables
            ///////think of way to to make variable carries 5 subjects
            ///////125 variables ===> 25 variables
            ///////later 25 variables ===> 1 variable
            ///////
            ////////Array:
            ////////fixed-size collection of data with same DT
            ////////stored sequentiallly in memory

            /////array declaration
            /////DT[] variableName=new DT[size];
            /////int[] arr=new int[5];
            ///////store 5 integers sequientially in memory
            ///////size of arr=5*sizeof(int) =20B
            /////char[] carr=new char[5];
            ///////size of carr=5*sizeof(char)=5B

            /////int[] arr; //ZERO B   //NULL  //Reference of array of integers
            /////arr=new int[5];  ///arr|0|0|0|0|0|
            /////new +array=> array allocation in memory +initialization by ZERO
            //int size = 5;
            //Console.WriteLine("Enter size");
            //size = int.Parse(Console.ReadLine()); //5
            //int[] arr;  //Zero Bytes have been allocated   //null
            //arr = new int[size];  //20B
            /////new +array=> array allocation in memory[heap] +initialization by ZERO
            ////////////arr|0|0|0|0|0| 
            /////index      0 1 2 3 4


            //for (int i=0;i<arr.Length ;i++) 
            //{
            //    Console.WriteLine($"Enter # at index {i}");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"# at index {i} is {arr[i]}");
            //}


            //////set or get value of array
            ////arr[0] = 10;
            ////arr[1] = 20;
            ////arr[2] = 30;
            ////arr[3] = 40;
            ////arr[4] = 50;

            ////Console.WriteLine(arr[0]);
            ////Console.WriteLine(arr[1]);
            ////Console.WriteLine(arr[2]);
            ////Console.WriteLine(arr[3]);
            ////Console.WriteLine(arr[4]);
            //////Console.WriteLine(arr[5]);


            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /////fixed size collection of data with same DT
            /////stored sequientially in memory
            /////

            /////declare array of 5 integers
            /////DT[] variableName=new DT[5]
            ////int[] arr; //ZERO B   //NULL   //Reference 
            //int[] arr = new int[5];
            ////new + array=> array allocation in memory +initialization by ZERO
            //////////////arr   |0|0|0|0|0|
            //////////////index  0 1 2 3 4

            #endregion

            #region 2D Array
            ////int[,] arr=new int[RowSize,ColSize];
            //int[,] arr; //Zero Bytes have been allocated   //null  //Reference
            //arr = new int[3, 4];
            ////new +array=> array allocation in memory[heap] +initialization by ZERO
            /////arr size? 3*4*sizeof(int)=12*4=48B
            /////
            /////to access each place
            /////arr[rowIndex,colIndex]=value;
            //arr[0, 0] = 1;
            //arr[0, 1] = 2;
            //arr[0, 2] = 3;
            //arr[0, 3] = 4;
            //arr[1, 0] = 5;
            //arr[1, 1] = 6;
            //arr[1, 2] = 7;
            //arr[1, 3] = 8;
            ////...

            //for (int i = 0; i <arr.GetLength(0); i++)
            //{
            //    for (int j=0;j<arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter # at index {i},{j}");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            ////
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        //Console.WriteLine($"# at index {i},{j}={arr[i,j]}");
            //        Console.Write($"{arr[i,j]} \t");
            //    }
            //    Console.WriteLine();
            //}
            ///////////////////////////////////////////////////////
            /////Calculate sum of each row
            //int[] sumOfrows= new int[arr.GetLength(0)];
            ////new +array=> array allocation in memory[heap] +initialization by ZERO

            //for(int i = 0; i < arr.GetLength(0); i++) 
            //{
            //    for(int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        sumOfrows[i] += arr[i, j];
            //    }
            //}
            /////memory i 0 1    j 0 1 2 3 4 0
            ////
            //Console.WriteLine("===================");
            //for (int i=0;i<sumOfrows.Length;i++)
            //{
            //    Console.WriteLine(sumOfrows[i]);
            //}
            #endregion

            #region Arrays declaration with default values
            ///int[] arr=new int[5];  //0 0 0 0 0 
            ///int[] arr=new int[5]{1,2,3,4,5};  //1 2 3 4 5 
            ///int[] arr=new int[10]{1,2,3,4,5,6,7,8,9,10};
            ///int[] arr=new int[10]{1,2,3,4,5}; //Compile Error
            ///int[]arr=new int[5]{1,2,3,4,5,6,7,8,9,10};//Compile Error
            ///int[] arr=new int[]; //Compile Error
            ///int[] arr=new int[]{1,2,3,4,5}; 
            ///syntax sugar
            ///int[] arr={1,2,3,4,5};
            ///int[] arr=[1,2,3,4,5];
            ///string[] strarr=/*new string[]*/{"A","B","A","D","A"};

            //2D array
            ///int[,] arr=new int[3,4]{{1,1,1,1},{2,2,2,2},{3,3,3,3}};
            ///int[,] arr=new int[,]{{1,1,1,1},{2,2,2,2},{3,3,3,3}};
            //int[,] arr={{1,1},{2,2},{3,3},{4,4}};

            ////jagged Array [less used]
            //int[][] arr = new int[3][];
            //arr[0] = new int[4];
            //arr[1] = new int[1];
            //arr[2] = new int[7];
            #endregion

            #region struct
            /////25 stds   -> 5 subjs  -> 125V
            /////1D array   -> 25 V
            /////2D array   ->1V
            /////if i wanna store another data about student
            /////int ssn
            /////string name
            /////int age
            /////string address
            /////float GPA
            ///
            ///can we store this data in array? NOOOOO
            ////Array store data with same DT
            ///
            ////struct
            ////Data type with my own definitions
            ////Data type can carry several unrelated data types

            ///struct syntax
            ///struct DTName
            ///{
            /////Data id,name,age,salary,GPA
            ///}
            /////DTName => Fst ltr upper case + singularize
            /////XXX struct Employees,employee,EMPLOYEE,Departments,People
            ////T   struct Employee,Department,Person

            ///data inside struct
            /////fst ltr must be lower case or _
            /// XXXX   Id,Name,FirstName
            /// T       id,name,_name,firstName
            /// 




            #endregion

            #region One Employee [struct]
            //Employee e1;      ///e1 id|| name|| age|| salary||
            //Employee e2;      ///e2 id|| name|| age|| salary||
            ////Varaible from Employee
            /////Size 16 Bytes  [total # of data inside it]


            /////we can access data by variable name
            //e1.id = 10;
            //e1.name = "Ali";
            //e1.age = 22;
            //e1.salary = 1234.56;

            //Console.WriteLine(e1);
            //Console.WriteLine(e1.id);
            //Console.WriteLine(e1.name);
            //Console.WriteLine(e1.age);
            //Console.WriteLine(e1.salary);

            //Console.WriteLine("Enter id");
            //e2.id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter name");
            //e2.name = Console.ReadLine();
            //Console.WriteLine("Enter age");
            //e2.age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter salary");
            //e2.salary = double.Parse(Console.ReadLine());
            //Console.WriteLine(e2.id);
            //Console.WriteLine(e2.name);
            //Console.WriteLine(e2.age);
            //Console.WriteLine(e2.salary);


            ////
            //Employee e3; //16B  //e3 id|ua| name|ua| age|ua| salary|ua|
            //e3 = new Employee();
            ////e3 id|0| name|null| age|0| salary|0|
            ////new +struct=>Data fields initialization ONLYYYYYYY
            //e3.id = int.Parse(Console.ReadLine());e3.name = "Ali"; e3.age = 22; e3.salary = 1234.56;

            //Console.WriteLine(e3.id);
            //Console.WriteLine(e3.name);
            //Console.WriteLine(e3.age);
            //Console.WriteLine(e3.salary);

            #endregion

            #region Array of 3 employees [struct]
            //Employee[] employees; //Zero Bytes have been allocated   //null  //Reference
            //employees = new Employee[3]; //3 * sizeof(Employee) =48B
            ////new +array => allocation in memory + data initialization
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine("Enter id");
            //    employees[i].id = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter name");
            //    employees[i].name = Console.ReadLine();
            //    Console.WriteLine("Enter age");
            //    employees[i].age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter salary");
            //    employees[i].salary = double.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[i].id);
            //    Console.WriteLine(employees[i].name);
            //    Console.WriteLine(employees[i].age);
            //    Console.WriteLine(employees[i].salary);
            //    Console.WriteLine("===================");
            //}
            #endregion
            //////////////////////////////////////////////////////
            #region Lab Assignments
            ////revise [Function]   Retyrntype function (input params){}
            ///lab assignments
            ///READ ALL DATA FROM USER AT RUNTIME
            ///

            ///1D array [without any built in function]
            ///1- array of 10 intergers and get min and max value   |5|4|2|-1|-33|55|66|77|88|100|
            ///2- array of 10 integers and sort it ascending without any built in function
            ///3- array of 10 integers and search number and get index
            ////////|4|5|6|7|8|9|2|3|66|77|88|99|100|
            ////////enter number to search
            ////////888
            ////////not found
            ////////88
            ////////found at index 10


            ///4-(BONUS)matrix  3*2   *  2*1   =3*1
            ///

            ///2D
            ///5- array of 3 rows,4 cols read and write   int[,]arr=new int[3,4];
            ///add get Sum of rows

            ///5- calculate your birth date
            ////////////////////
            ///1,3,5,7,8,10,12     31days
            ///4,6,9,11           30 days
            ///2      28,29 leap year    2000,2004,2008,2020


            ///while ->   do while

            /////plz enter your year from 1980->2023
            //2000
            /////plz enter your month
            //2
            /////plz enter your day
            //32
            /////plz enter your day
            //31
            /////plz enter your day
            //30
            /////plz enter your day
            //29


            /////you're 22y  3 months and 5 days

            //int currentday = DateTime.Now.day;
            //int currentmonth = DateTime.Now.Month;
            //int currentyear = DateTime.Now.Year;

            //int day, month, year;

            //6-simple calculator
            ///enter #1
            ///5
            ///enter #2
            ///6
            ///enter operator
            ///+
            ///5+6=11
            ///continue y or n?
            ///y
            //////enter #1
            ///11
            ///enter #2
            ///22
            ///enter operator
            ///+
            ///11+22=33

            ///REVISE
            ////Try Again struct employee id ,name,age,salary   
            ///> one employee
            ///>array of 3 employees
            #endregion



            #region Assignment1

            #endregion

        }
    }
}
