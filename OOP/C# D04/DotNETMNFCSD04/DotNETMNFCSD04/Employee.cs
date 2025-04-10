using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD04
{
    class Employee
    {
        #region Data fields
        int id;
        string name;
        int age;
        double salary;
        #endregion

        #region Property [New Way for Setters and Getters] [fst ltr uppercase]
        public int Id
        {
            set   //public void set(int value)
            {
                //private field on left side
                id = value;
            }
            get    //public int get()
            {
                return id;
            }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public double Salary
        {
            set
            {
                if (value > 5000 && value < 10000)
                {
                    salary = value;
                }
                else
                {
                    salary = 5000;
                }
            }
            get
            {
                return salary;
            }
        }
        #endregion

        #region Traditional Setters & Getters
        public void SetId(int _id)
        {
            id = _id;
        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public void SetAge(int _age)
        {
            age = _age;
        }
        public void SetSalary(double _salary)
        {
            salary = _salary;
        }
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public double GetSalary()
        {
            return salary;
        }
        #endregion

        #region ctors
        public Employee()
        {
            id = 1;
            name = "Eman";
            age = 22;
            salary = 10000;
        }
        public Employee(int _id,string _name,int _age,double _salary)
        {
            id = _id;
            name = _name;
            age = _age;
            salary = _salary;
        }
        #endregion

        #region Print
        public string Print()
        {
            return $"Id:{id},Name:{name},Age:{age},Salary:{salary}";
        }
        #endregion
    }
}
