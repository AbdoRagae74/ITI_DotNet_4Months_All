namespace BeforeLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-------------------------------------------------------------------------*/
            #region V01
            //Console.WriteLine("Employees with name start with mo");
            //var emp1 = HelperV01.GetEmployeesWithNameStartWith("Mo");
            //foreach (var item in emp1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region V02
            //var emps = Repository.GetEmployees();
            //Console.WriteLine("Employees with name start with mo");
            //Predicate<Employee> predicate = e => e.Name.ToLower().StartsWith("mo");
            //var emps1_1 = HelperV02.FilterEmployees(emps, predicate);
            //var emps1 = HelperV02.FilterEmployees(emps, e => e.Name.ToLower().StartsWith("mo"));
            //var emps2 = HelperV02.FilterEmployees(emps, e => e.Name.ToLower().EndsWith("mo"));
            //var emps3 = HelperV02.FilterEmployees(emps, e => e.Name.ToLower().Contains("mo"));
            //var emps4 = HelperV02.FilterEmployees(emps, e => e.DeptId == 1);
            //var emps5 = HelperV02.FilterEmployees(emps, e => e.Age > 25);
            //foreach (var item in emps1_1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region V03 Extention Method
            var emps = Repository.GetEmployees();
            var depts = Repository.GetDepartments();
            Console.WriteLine("Employees with name start with mo");

            var empsEx = HelperV03.FilterEmployees(emps, e => e.DeptId == 1);
            var empsEx2 = emps.FilterEmployees(e => e.DeptId == 1);
            #endregion
            /*-------------------------------------------------------------------------*/
        }
    }
}
