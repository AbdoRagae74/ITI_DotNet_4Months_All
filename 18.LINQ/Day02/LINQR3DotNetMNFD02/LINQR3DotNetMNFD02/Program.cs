namespace LINQR3DotNetMNFD02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-------------------------------------------------------------------------*/
            #region Repository
            var employees = Repository.GetEmployees();
            var departments = Repository.GetDepartments();
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Immediate Ececution vs Deferred Execution
            // All LINQ Methods are Deferred Execution expect (First, Last, Single)

            //IEnumerable<Employee> q1 = employees.Where(e => e.DeptId == 1);
            //List<Employee> q2 = employees.Where(e => e.DeptId == 1).ToList();

            //var e1 = new Employee { Id = 11, Name = "New", Salary = 2000, Age = 30, DeptId = 1, };
            //employees.Add(e1);

            //foreach (var item in q1) // Ex Happen here
            //{
            //    Console.WriteLine(item);
            //}

            //var q1 = employees.Where(e => e.DeptId == 1).ToList(); // Ex Happen here

            //var e1 = new Employee { Id = 11, Name = "New", Salary = 2000, Age = 30, DeptId = 1, };
            //employees.Add(e1);

            //foreach (var item in q1) 
            //{
            //    Console.WriteLine(item);
            //}

            //var q3 = employees.LastOrDefault(); // Ex Happen here 
            //var e1 = new Employee { Id = 11, Name = "New", Salary = 2000, Age = 30, DeptId = 1, };
            //employees.Add(e1);
            //Console.WriteLine(q3); // Not here
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Select Top 3
            //var q1 = employees.Take(1);
            //var q2 = employees.Take(3);
            //var q3 = employees.Take(30);

            //var q4 = employees.TakeLast(3);
            //var q5 = employees.TakeLast(50);

            //var q6 = employees.Skip(1);
            //var q7 = employees.Skip(1).Take(1);
            //var q8 = employees.Skip(1).Skip(1).Take(1);

            //var q9 = employees.SkipLast(3);

            //// Take Last 
            //// return unitl condition = true
            //var q10 = employees.TakeWhile(e => e.DeptId == 1);
            //// Loop over All List
            //var q10_1 = employees.Where(e => e.DeptId == 1);


            //var q11 = employees.SkipWhile(e => e.DeptId == 1);

            //foreach (var item in q11)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------");
            //foreach (var item in q10_1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Any, All
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var res1 = ints.Any(x => x % 2 == 0);
            //var res2 = ints.All(x => x % 2 == 0);

            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Distinict
            //List<int> ints = new List<int>() { 1, 1, 1, 1, 5, 6, 7, 7, 7, 10, 11, 12, 13, 14, 15 };

            //var q1 = ints.Distinct();
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Distinict Employee
            //var emps = new List<Employee>()
            //{
            //    new Employee { Id = 1, Name = "Ahmed", Age = 26 , Salary = 1234, DeptId = 1},
            //    new Employee { Id = 2, Name = "Mohamed", Age = 36 , Salary = 2234, DeptId = 2},
            //    new Employee { Id = 3, Name = "Sara", Age = 46 , Salary = 4234, DeptId = 3},
            //    new Employee { Id = 4, Name = "Omar", Age = 25 , Salary = 5234, DeptId = 4},
            //    new Employee { Id = 5, Name = "Ali", Age = 23 , Salary = 6234, DeptId = 1},
            //    new Employee { Id = 6, Name = "Mai", Age = 36 , Salary = 7234, DeptId = 2},
            //    new Employee { Id = 7, Name = "Ramy", Age = 49 , Salary = 8234, DeptId = 3},
            //    new Employee { Id = 8, Name = "Hamada", Age = 18 , Salary = 9234, DeptId = 4},
            //    new Employee { Id = 9, Name = "Hatem", Age = 26 , Salary = 10234, DeptId = 1},
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2},
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2},
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2},
            //};

            ////var q1 = emps.Distinct(); // XXXXXX
            //var obj = new EmpComp();
            //var q1 = emps.Distinct(obj);
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}

            //var q2 = emps.DistinctBy(e => e.Age);
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Projection => Select Colums
            //// Filter rows but not filter col.

            //var q1 = employees // 10
            //    .Where(e => e.DeptId == 1); // 4

            //var q2 = employees // 10
            //  .Where(e => e.DeptId == 1)
            //  .Select(e => e.Name);



            //var q2_1 = employees // 10
            //      .Where(e => e.DeptId == 1)
            //      .Select(e => e.Name + "Age:" + e.Age); // Limitation

            //var q3 = from e in employees
            //         where e.DeptId == 2
            //         select e.Name;

            ////var q4 = from e in employees
            ////         where e.DeptId == 2
            ////         select e.Name && e.Id; // XXXXXXXXXX


            //var q5 = from e in employees
            //         where e.DeptId == 2
            //         select new Employee { Id = e.Id, Name = e.Name };


            //var q6 = from e in employees
            //         where e.DeptId == 2
            //         select new { SSN = e.Id, FullName = e.Name };

            //var q7 = employees // 10
            //      .Where(e => e.DeptId == 1)
            //      .Select(e => new { SSN = e.Id, Name = e.Name });


            //var q8 = employees // 10
            //      .Where(e => e.DeptId == 1)
            //      .Select(e => new { SSN = e.Id, FullName = e.Name })
            //      .OrderBy(e => e.FullName);


            //foreach (var item in q8)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Join [Query Syntax]
            //var q1 = from emp in employees
            //         join dept in departments
            //         on emp.DeptId equals dept.DeptId
            //         select new { SSN = emp.Id, Name = emp.Name, DeptName = dept.DeptName };

            //var q1_1 = from emp in employees
            //         join dept in departments
            //         on emp.DeptId equals dept.DeptId
            //         select new { Employee = emp, DeptName = dept.DeptName };

            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Join [Fluent Syntax]
            //var q1 = employees // outer
            //    .Join(departments, // inner
            //    e => e.DeptId, // outer key
            //    d => d.DeptId, // inner key
            //    (emp, dept) => new { Name = emp.Name, DepartmentName = dept.DeptName });

            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Min, Max, Count, Avg, Sum
            //decimal q0 = employees.Min(e => e.Salary);
            //var q1 = employees.Min(e => e.Salary);
            //var q2 = employees.Max(e => e.Salary);
            //var q3 = employees.Count(e => e.DeptId == 1);
            //var q4 = employees.Average(e => e.Salary);
            //var q5 = employees.Sum(e => e.Salary);

            //var q7 = employees.Where(e => e.Salary > /*7134*/ employees.Average(e => e.Salary));
            //var q8 = employees.Where(e => e.Salary > q4);

            //Console.WriteLine(q4);
            #endregion
            /*-------------------------------------------------------------------------*/
            #region OfType
            //List<User> users = new List<User>()
            //{
            //    new Female {Id = 1, Name = "Sara"},
            //    new Female {Id = 1, Name = "Sara"},
            //    new Male {Id = 1, Name = "Ahmed"},
            //    new Male {Id = 1, Name = "Ali"},
            //};

            //var q1 = users.OfType<Male>();
            //var q2 = users.OfType<Female>();

            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region GroupBy
            //IEnumerable<Employee> q1 = employees.Where(e => e.Salary > 1000);
            //List<Employee> q1_1 = employees.Where(e => e.Salary > 1000).ToList();
            // q2 = IEnumerable<IGrouping<TKey, TSource>> GroupBy
            //var q2 = employees.GroupBy(e => e.DeptId);

            //// q2 = [G,G,G,G]
            //// G1 = {Key:int 1, Emp1}
            //// G1 = {Key:int 1, Emp2}
            //// G1 = {Key:int 1, Emp3}
            //// G2 = {Key:int 2, Emp4}
            //// G = {Key:int, Value: List<Employee>}
            //// G = {Key:int, Value: List<Employee>}

            //var q3 = from emp in employees
            //         group emp by emp.DeptId;

            //var q4 = from emp in employees
            //         join dept in departments
            //         on emp.DeptId equals dept.DeptId
            //         group emp by dept.DeptName;

            //var q5 = employees.Join(
            //    departments,
            //    e => e.DeptId,
            //    d => d.DeptId,
            //    (e, d) => new { EmpName = e.Name, deptName = d.DeptName })
            //    .GroupBy(h => h.deptName);

            //foreach (var item in q5)
            //{
            //    Console.WriteLine($"Dept Name: =>>>>>>>>>{item.Key}");
            //    foreach (var emp in item)
            //    {
            //        Console.WriteLine(emp);
            //    }
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Insert, Update, Delete
            //// Insert 
            //var e1 = new Employee { Id = 11, Name = "New", Salary = 2000, Age = 30, DeptId = 1, };
            //employees.Add(e1);


            //// Update
            //// 1- Catch To Update
            //// Ref. to Object
            //var empToUpdate = employees.SingleOrDefault(e => e.Id == 1);
            //if (empToUpdate != null)
            //{
            //    empToUpdate.Name = "New Name";
            //}

            //// Delete
            //// 1- Catch To Delete
            //// Ref. to Object
            //var empToDelete = employees.SingleOrDefault(e => e.Id == 1);
            //if (empToDelete != null)
            //{
            //    employees.Remove(empToDelete);
            //}
            //// Linq to obj
            //employees.RemoveAll(e => e.DeptId == 1);

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Expect, Concat, Union, Intersect
            //List<int> ints1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> ints2 = new List<int>() { 8, 9, 10, 11 };

            //var q1 = ints1.Concat(ints2);
            //var q2 = ints1.Union(ints2);
            //var q2 = ints1.Union(ints2);
            //var q3 = ints1.Except(ints2);
            //var q4 = ints1.Intersect(ints2);

            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Zip Oprator
            //List<int> numbers = new List<int>() { 1, 2, 3 };
            //List<string> names = new List<string>() { "Mohamed", "Ali", "Ramy" };

            //var newList = numbers.Zip(names);
            //var newList2 = numbers.Zip(names, (i, n) => new { Number = i, Name = n });
            //var newList3 = Enumerable.Zip(numbers, names, (i, n) => new { Number = i, Name = n });

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region Indexed Where & Indexed Select
            ////var indexedSelect = employees.Select((e, index) => new { Emp = e, Index = index });
            ////foreach (var item in indexedSelect)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //var q1 = employees.Where(e => e.DeptId == 1);
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------");
            //var indexedWhere = employees.Where((e, index) => e.DeptId == 1 && index < 5);
            //foreach (var item in indexedWhere)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region GroupBy and Agg FN
            //var q1 = from emp in employees
            //         join dept in departments
            //         on emp.DeptId equals dept.DeptId
            //         group emp by dept.DeptName into groups
            //         select new
            //         {
            //             DepartmentName = groups.Key,
            //             TotalSalary = groups.Sum(e => e.Salary),
            //             AvgSalary = groups.Average(e => e.Salary),
            //             MinSalary = groups.Min(e => e.Salary),
            //             MaxSalary = groups.Max(e => e.Salary),
            //         };

            //var q2 = employees.Join(
            //    departments,
            //    e => e.DeptId,
            //    d => d.DeptId,
            //    (e, d) => new { Salary = e.Salary, DepartmentName = d.DeptName })
            //    .GroupBy(a => a.DepartmentName)
            //    .Select(g => new
            //    {
            //        DepartmentName = g.Key,
            //        TotalSalary = g.Sum(e => e.Salary),
            //        AvgSalary = g.Average(e => e.Salary),
            //        MinSalary = g.Min(e => e.Salary),
            //        MaxSalary = g.Max(e => e.Salary),
            //    });

            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
            #region IntersectBy
            //var emps1 = new List<Employee>()
            //{
            //    new Employee { Id = 1, Name = "Ahmed", Age = 26 , Salary = 1234, DeptId = 1},
            //    new Employee { Id = 2, Name = "Mohamed", Age = 36 , Salary = 2234, DeptId = 2},
            //    new Employee { Id = 3, Name = "Sara", Age = 46 , Salary = 4234, DeptId = 3},
            //    new Employee { Id = 4, Name = "Omar", Age = 25 , Salary = 5234, DeptId = 4},
            //    new Employee { Id = 5, Name = "Ali", Age = 23 , Salary = 6234, DeptId = 1},
            //    new Employee { Id = 6, Name = "Mai", Age = 36 , Salary = 7234, DeptId = 2},
            //    new Employee { Id = 7, Name = "Ramy", Age = 49 , Salary = 8234, DeptId = 3},
            //    new Employee { Id = 8, Name = "Hamada", Age = 18 , Salary = 9234, DeptId = 4},
            //    new Employee { Id = 9, Name = "Hatem", Age = 26 , Salary = 10234, DeptId = 1},
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2},
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2},
            //    new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2},
            //};

            //var emps2 = new List<Employee>()
            //{
            //    new Employee { Id = 1, Name = "Ahmed", Age = 26 , Salary = 1234, DeptId = 1},
            //    new Employee { Id = 2, Name = "Mohamed", Age = 36 , Salary = 2234, DeptId = 2},
            //    new Employee { Id = 3, Name = "Sara", Age = 46 , Salary = 4234, DeptId = 3},
            //    new Employee { Id = 4, Name = "Omar", Age = 25 , Salary = 5234, DeptId = 4},
            //    new Employee { Id = 5, Name = "Ali", Age = 23 , Salary = 6234, DeptId = 1},
            //    new Employee { Id = 6, Name = "Mai", Age = 36 , Salary = 7234, DeptId = 2},
            //    new Employee { Id = 7, Name = "Ramy", Age = 49 , Salary = 8234, DeptId = 3},
            //    new Employee { Id = 8, Name = "Hamada", Age = 18 , Salary = 9234, DeptId = 4},
            //    new Employee { Id = 9, Name = "Hatem", Age = 26 , Salary = 10234, DeptId = 1},
            //    new Employee { Id = 11, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2},
            //    new Employee { Id = 12, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2},
            //    new Employee { Id = 13, Name = "Osama", Age = 25 , Salary = 17234, DeptId = 2},
            //};

            //var q1 = emps1.IntersectBy(emps2.Select(left => left.Id), right => right.Id);

            ////var q2 = emps1.Intersect(emps2); XXXXXX
            //var q2 = emps1.Intersect(emps2, new EmpComp());
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*-------------------------------------------------------------------------*/
        }
    }
}
