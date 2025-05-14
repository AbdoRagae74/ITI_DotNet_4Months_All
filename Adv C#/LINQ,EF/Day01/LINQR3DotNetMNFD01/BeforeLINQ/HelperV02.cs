namespace BeforeLINQ
{
    public class HelperV02
    {
        /*-------------------------------------------------------------------------*/
        public static IEnumerable<Employee> FilterEmployees
            (IEnumerable<Employee> emps, Predicate<Employee> pre)
        {
            // Ex Dep
            //var emps = Repository.GetEmployees();
            var res = new List<Employee>();
            foreach (var emp in emps)
            {
                if (pre(emp) == true)
                {
                    res.Add(emp);
                }
            }
            return res;
        }
        /*-------------------------------------------------------------------------*/
    }
}
