using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ConsoleApp2
{
    class Employee : IComparable<Employee>
    {
        int id;
        string name;
        string securityLvl;
        int salary;
        Date hireDate;
        string gender;

        public Employee(int id, string name, string securityLvl, int salary, Date hireDate, string gender)
        {
            this.salary = salary;
            this.id = id;
            this.name = name;
            this.securityLvl = securityLvl;
            this.hireDate = hireDate;
            this.gender = gender;
        }
        public override string ToString()
        {
            return $"id: {id},name: {name}, security level: {securityLvl}, salary: {salary}, hiring date: {hireDate}, gender: {gender}";
        }
        public int CompareTo(Employee e)
        {
            return hireDate.CompareTo(e.hireDate);
        }

    }
    class Date:IComparable<Date>
    {
        int day;
        int month;
        int year;
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
        public void ShowDate()
        {
            Console.WriteLine($"day: {day}, month: {month}, year: {year}");
        }
        public int CompareTo(Date d)
        {
            //if (year < d.year) return 1;
            //else if(year > d.year) return -1;
            //else
            //{
            //    if (month < d.month) return 1;
            //    else if (month > d.month) return -1;
            //    else
            //    {
            //        if(day < d.day) return 1;
            //        else if (day > d.day) return -1;
            //        else return 0;
            //    }
            //}
            //if (year.CompareTo(d.year) == 1) return -1;
            //else if (year.CompareTo(d.year) == -1) return 1;
            //else
            //{
            //    if (month.CompareTo(d.month) == 1) return -1;
            //    else if (month.CompareTo(d.month) == -1) return 1;
            //    else
            //    {
            //        if (day.CompareTo(d.day) == 1) return -1;
            //        else if (day.CompareTo(d.day) == -1) return 1;
            //        else
            //        {
            //            return 0;
            //        }
            //    }
            //}
            if (year.CompareTo(d.year) != 0) 
                return year.CompareTo(d.year);
            else if (year.CompareTo(d.month) != 0) 
                return year.CompareTo(d.month);
            else return day.CompareTo(d.day);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("inter first employee ID: ");
            int ID;
            int.TryParse(Console.ReadLine(),out ID);
            Date date = new Date(1, 5, 2024);
            Employee dba = new Employee(ID, "omar", "lvl4", 10000, date, "male");

            //Console.WriteLine(date);
            //Console.WriteLine(dba);

            Date geustDate = new Date(15, 5, 2024);
            Employee guest = new Employee(6, "mona", "lvl1", 6000, geustDate, "female");

            Date dateOfficer = new Date(29, 5, 2024);
            Employee securityOfficer = new Employee(1, "khlaed", "lvl10", 9000, dateOfficer, "male");

            Employee[] emps = new Employee[3];
            emps = [dba, guest, securityOfficer];
                
            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("---------------------------------- after sorting: --------------------------------------");

            Array.Sort(emps);

            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
