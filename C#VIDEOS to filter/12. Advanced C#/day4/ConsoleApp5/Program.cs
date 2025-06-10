namespace ConsoleApp5
{
    internal class Program
    {
        public enum LayOffCause
        { 
            MaxAgeReached,
            NegativeVacations
        }
        public class EmployeeLayOffEventArgs: EventArgs
        {
            public LayOffCause cause;
        }
        public class Employee
        {
            public int id;
            public DateTime birthDate;
            public int vacationStock;
            public Employee(int id, DateTime bd, int vacStock = 12)
            {
                this.id = id;
                this.birthDate = bd;    
                this.vacationStock = vacStock;
            }
            public int GetAge()
            {
                return DateTime.Now.Year - birthDate.Year;
            }
            public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
            protected void OnEmployeeLayOff (EmployeeLayOffEventArgs e)
            {
                EmployeeLayOff?.Invoke(this, e);
            }
            public bool RequestVacation(DateTime From, DateTime To)
            {
                if (vacationStock - (To.Day - From.Day) >= 0)
                {
                    vacationStock -= (To.Day-From.Day);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void EndOfYearOperation()
            {
                if (vacationStock < 0)
                {
                    EmployeeLayOffEventArgs args = new EmployeeLayOffEventArgs();
                    args.cause = LayOffCause.NegativeVacations;
                    OnEmployeeLayOff(args);
                }
                else if (GetAge() > 60)
                {
                    EmployeeLayOffEventArgs args = new EmployeeLayOffEventArgs();
                    args.cause = LayOffCause.MaxAgeReached;
                    OnEmployeeLayOff(args);
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        public class Department
        {
            public int deptID;
            public string deptName;
            private List<Employee> staff = new List<Employee>();
            public int StaffCount()
            {
                return staff.Count;
            }
            public Department(int _DeptID = 4, string _DeptName = "quality")
            {
                this.deptID = _DeptID;
                this.deptName = _DeptName;
            }
            public void AddStaff(Employee E)
            {
                staff.Add(E);
                E.EmployeeLayOff += RemoveStaff;
            }
            public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
            {
                if (sender is Employee) // equal to Employee emp = sender as Employee
                {
                    Employee emp = (Employee)sender;
                    staff.Remove(emp);
                    Console.WriteLine($"Employee {emp.id} removed from {deptName}. Reason: {e.cause}");
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        class Club
        {
            public int id;
            public String name;
            public Club(int id, String name)
            {
                this.id = id;
                this.name = name;
            }
            private List<Employee> members = new List<Employee>();
            public int? MembersCount()
            {
                return members?.Count;
            }
            public void AddMember(Employee E)
            {
                members.Add(E);
                E.EmployeeLayOff += RemoveMember;
            }
            public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
            {
                Employee employee = (Employee)sender;
                if (employee.vacationStock < 0)
                {
                    members.Remove(employee);
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        static void Main()
        {
            Employee e1 = new Employee(11, new DateTime(2000, 10, 26), 8);
            Employee e2 = new Employee(14, new DateTime(1960, 8, 3), 7);
            Employee e3 = new Employee(14, new DateTime(1990, 3, 15), -1);

            Department dep1 = new Department();
            dep1.AddStaff(e1);
            dep1.AddStaff(e2);
            dep1.AddStaff(e3);

            Club club1 = new Club(43, "City club");
            club1.AddMember(e1);
            club1.AddMember(e2);
            club1.AddMember(e3);

            e1.EndOfYearOperation();
            e2.EndOfYearOperation();
            e3.EndOfYearOperation();

            Console.WriteLine("Remaining staff in dep1: " + dep1.StaffCount());
            Console.WriteLine("Remaining members in club1: " + club1.MembersCount());
        }
    }
}
