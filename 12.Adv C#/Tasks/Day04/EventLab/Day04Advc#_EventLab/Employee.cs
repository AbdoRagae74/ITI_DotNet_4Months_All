using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day04Advc__EventLab.Program;

namespace Day04Advc__EventLab
{
    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        DateTime birthDate;
        int vStock;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
                if ((DateTime.Now.Year - value.Year) >= 60)
                {
                    EmployeeLayOffEventArgs employeeFired = new EmployeeLayOffEventArgs();
                    employeeFired.Cause = LayOffCause.Age;
                    OnEmployeeLayOff(employeeFired);

                }
            }
        }
        public int VacationStock
        {
            get { return VacationStock; }
            set
            {

                vStock = value;
                if (vStock <= 0)
                {
                    EmployeeLayOffEventArgs employeeFired = new EmployeeLayOffEventArgs();
                    employeeFired.Cause = LayOffCause.VacationStock;
                    OnEmployeeLayOff(employeeFired);

                }
            }
        }
        public string Name { get; set; }
        public Employee(string name,int employeeID, DateTime birthDate, int vacationStock)
        {
            Name = name;
            EmployeeID = employeeID;
            BirthDate = birthDate;
            VacationStock = vacationStock;
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }
        public void EndOfYearOperation()
        {
            throw new NotImplementedException();
        }
    }
}
