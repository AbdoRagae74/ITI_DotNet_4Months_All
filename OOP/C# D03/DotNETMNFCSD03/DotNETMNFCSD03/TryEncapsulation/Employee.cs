using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryEncapsulation
{
    class Employee
    {
        #region Notes  [Rules]
        ///>each data inside class/struct is member variable/function
        ///>member is called by instance/object of class/struct
        ///>private:member can be accessed only inside the class/struct
        ///>public:member can be accessed inside and outside the class/struct
        #endregion
        #region Data
        private int id;
        private string name;
        private double salary; 
        private int age;
        //password   [set only]
        #endregion

        #region [public] Setters and Getters 
        //caller e1
        public void SetId(int _id)
        {
            /*caller e1*/id = _id;
        }
        //caller e2
        public int GetId()
        {
            return /*caller e2*/id;
        }
        public void SetName(string _name)
        {
            /*e1 caller*/name = _name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAge(int _age)
        {
            age = _age;
        }
        public int GetAge()
        {
            return /*e1 caller*/age;
        }
        public void SetSalary(double _salary)
        {
            if (_salary >= 5000 && _salary <= 10000)
            { salary = _salary; }
            else
            {
                salary = 5000;
            }
        }
        public double GetSalary()
        {
            return salary;
        }
        #endregion

        #region Print Object
        public void Print()
        {
            Console.WriteLine(/*caller*/id);
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(salary);
        }
        //RECOMMENDED
        public string PrintV2()
        {
            return $"{id}:{name}:{age}:{salary}";
        }
        #endregion
    }
}
