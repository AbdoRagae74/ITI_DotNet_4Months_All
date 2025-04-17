using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02Adv_C_
{
    class Employee : IComparable
    {

        int id, salary;
        string securityLevel, gender;
        HiringDate comingDate;
        public int Id { get { return id; } set { id = value; } }
        public int Salary { get { return salary; } set { salary = value; } }
        public string SLevel { get { return securityLevel; } set { securityLevel = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public HiringDate ComingDate { get { return comingDate; } set { comingDate = value; } }
        public Employee(int id = 0, int salary = 0, int m = 1, int d = 1, int y = 2000, string securityLevel = "", string gender = "")
        {
            this.id = id;
            this.salary = salary;
            this.securityLevel = securityLevel;
            comingDate = new HiringDate(day: d, month: m, year: y);
            this.gender = gender;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Employee e)
                return comingDate.CompareTo(e.comingDate);
            throw new("Passed parameter isn't Employee");

        }

        public override string ToString()
        {
            return $"id : {id}\nSecurity Level : {securityLevel}\nGender : {gender}\nSalary : {salary}\ncoming date : {comingDate}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Employee e)
                return id == e.id;
            return false;
        }

    }
}
