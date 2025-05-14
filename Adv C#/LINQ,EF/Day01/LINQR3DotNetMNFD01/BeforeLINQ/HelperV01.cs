namespace BeforeLINQ
{
    public class HelperV01
    {
        /*-------------------------------------------------------------------------*/
        //public static List<Employee> GetEmployeesWithNameStartWith(string val)
        public static IEnumerable<Employee> GetEmployeesWithNameStartWith(string val)
        {
            //List<Employee> emps = Repository.GetEmployees();
            var emps = Repository.GetEmployees(); // DS
            var res = new List<Employee>();
            foreach (var emp in emps)
            {
                if (emp.Name.ToLower().StartsWith(val.ToLower()))
                {
                    res.Add(emp);
                }
            }
            return res;
        }
        /*-------------------------------------------------------------------------*/
        public static IEnumerable<Employee> GetEmployeesWithNameEndWith(string val)
        {
            //List<Employee> emps = Repository.GetEmployees();
            var emps = Repository.GetEmployees();
            var res = new List<Employee>();
            foreach (var emp in emps)
            {
                if (emp.Name.ToLower().EndsWith(val.ToLower()))
                {
                    res.Add(emp);
                }
            }
            return res;
        }
        /*-------------------------------------------------------------------------*/
    }
}
