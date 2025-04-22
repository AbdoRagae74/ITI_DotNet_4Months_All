namespace Day04Advc__EventLab
{
    class Program
    {
        public enum LayOffCause
        {
            VacationStock, Age

        }

        public class EmployeeLayOffEventArgs : EventArgs
        {
            public LayOffCause Cause { get; set; }
        }


        static void Main(string[] args)
        {
            Employee emp = new Employee("ahmed", 1, new DateTime(2002, 4, 25), 17);
            Employee emp2 = new Employee("Kamal", 19, new DateTime(1998, 3, 24), 8);
            Employee emp3 = new Employee("Saleh", 3, new DateTime(1993, 5, 28), 23);
            Club club = new Club(1, "clubOne");
            Department dept = new Department(1, "CS");

            /* Operations */
            dept.AddStaff(emp);
            dept.AddStaff(emp2);
            dept.AddStaff(emp3);

            club.AddMember(emp);
            club.AddMember(emp2);
            club.AddMember(emp3);

            emp2.BirthDate = new DateTime(1955, 1, 1);
            emp3.VacationStock = 0;
            Console.WriteLine();
            Console.WriteLine($"Department => {dept.DeptName} staff after operations :");

            foreach (Employee e in dept.Staff)
                Console.WriteLine(e.Name);
           
            Console.WriteLine();
            Console.WriteLine($"Club => {club.ClubName} members after oprations : ");
            Console.WriteLine();

            foreach (Employee member in club.Members)
                Console.WriteLine(member.Name);

        }
    }
}
