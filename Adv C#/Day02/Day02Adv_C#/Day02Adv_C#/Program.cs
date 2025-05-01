using System.Runtime.InteropServices;

namespace Day02Adv_C_
{
    internal class Program
    {



        static void Main(string[] args)
        {

            Employee [] employees = new Employee[3];
            string [] arr = {"DBA","Guest","Security officer"};
            string [] genders = {"Male","Female"};
        for(int i = 0 ; i<employees.Length;i++){
            employees[i] = new Employee(i+1,10000*(i+1),5+i,13+i,2024-i,arr[i], genders[i%2] );
        }
            System.Console.WriteLine("Before sort");
            foreach (Employee e in employees)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("After sort");
            
            Array.Sort(employees);
            
            foreach (Employee e in employees)
            {
                System.Console.WriteLine(e);
            }

        Employee emp = new Employee();
        System.Console.WriteLine("Enter id");
        int input;
        string inputStr="";
        bool status=false;
        while(!status){
             System.Console.WriteLine("Enter valid Employee id");
            status = int.TryParse(Console.ReadLine(),out input);
            if(status) emp.Id= input;
        }
        System.Console.WriteLine("Enter salary");
        input = int.Parse(Console.ReadLine());
        emp.Salary = input;
        
        System.Console.WriteLine("Enter coming day in numbers");
        input = int.Parse(Console.ReadLine());
        emp.ComingDate.Day = input;

        System.Console.WriteLine("Enter coming month in numbers");
        input = int.Parse(Console.ReadLine());
        emp.ComingDate.Month = input;

        System.Console.WriteLine("Enter coming year");
        input = int.Parse(Console.ReadLine());
        emp.ComingDate.Year = input;

        System.Console.WriteLine("Enter Gender");
        inputStr = Console.ReadLine();
        emp.Gender = inputStr;

        System.Console.WriteLine("Enter Security Level");
        inputStr = Console.ReadLine();
        emp.SLevel = inputStr;
        System.Console.WriteLine(emp);





        }
    }
}
