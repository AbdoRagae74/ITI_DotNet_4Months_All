using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace LINQD02
{
    internal class Part01
    {


        public static void loop(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }

        static void Main01(string[] args)
        {

            #region Q1
            //1.First 4 Employees in the List Using Method Syntax[fluent syntax].
            var emps = Repo.GetEmployees();
            var depts = Repo.GetDepartments();
            var q1 = emps.Take(4);
            //loop(q1);
            #endregion

            #region Q2
            // First 3 Employees in the List with Salary more than 5000 Using Method Syntax [fluent syntax].
            var q2 = emps.Where(e => e.Salary > 5000);
            //loop(q2);
            #endregion

            #region Q3
            //3.	Last 4 Employees in the List Using Method Syntax [fluent syntax].
            var q3 = emps.TakeLast(4);
            //loop(q3);

            #endregion


            #region Q4
            //4.Second 2 Employees in the List Using Method Syntax[fluent syntax].
            var q4 = emps.Skip(2).Take(2);
            //loop(q4);
            #endregion

            #region Q5
            //5.All Employees While Name length< 5 Using Method Syntax[fluent syntax].
            var q5 = emps.TakeWhile(e => e.FirstName.Length < 5);
            //loop(q5);
            #endregion

            #region Q6
            //6.	Distinct Employees. Hint: (Using IEqualityComparer) Using Method Syntax [fluent syntax].
            var compObj = new EmpComp();
            var q6 = emps.Distinct(compObj);
            //q6.loop();
            #endregion


            #region Q7
            //7.Name and Id of All Employees Using Method Syntax[fluent syntax].

            var q7 = emps.Select(e => new { EmpID = e.Id, Name = $"{e.FirstName} {e.LastName}" });
            //q7.loop();
            #endregion


            #region Q8

            //8.Name and Id of All Employees Using Query Syntax.

            var q8 = from s in emps
                     select new { EmpId = s.Id, Name = $"{s.FirstName} {s.LastName}" };
            //q8.loop();
            #endregion


            #region Q9
            //9.Name and DeptName of All Employees Using Query Syntax.

            var q9 = from e in emps
                     join d in depts
                     on e.DepartmentID equals d.DepartmentID
                     select new { Name = e.FirstName, department = d.DepartmentName };
            //q9.loop();
            #endregion


            #region Q10
            //10.Name and DeptName of All Employees Using Method Syntax[fluent syntax].

            var q10 = emps.Join(depts, e => e.DepartmentID, d => d.DepartmentID, (e, d) => new { Name = e.FirstName, department = d.DepartmentName });
            //q10.loop();

            #endregion

            #region Q11
            //       11.	 All Employees Group by DeptName Using Method Syntax [fluent syntax].

            var q11 = emps.Join(depts,
                e => e.DepartmentID,
                d => d.DepartmentID,
                (e, d) => new { e.FirstName, d.DepartmentName }
                ).GroupBy(d => d.DepartmentName);
            //q11.loopObject();
            #endregion

            #region Q12
            //12.	 All Employees Group by DeptName Using Query Syntax.

            var q12 = from e in emps
                      join d in depts
                      on e.DepartmentID equals d.DepartmentID
                      group e by d.DepartmentName;
            //q12.loopObject();
            #endregion

            #region Q13
            //13.	 Min Salary, Max Salary, Avg Salary.
            var q13 = emps.Select(e => e.Salary);

            //q13.loop();
            //Console.WriteLine(q13.Min());
            //Console.WriteLine(q13.Max());
            //Console.WriteLine(q13.Average());

            #endregion

            #region Q14

            //          14.	 Employee Where Salary < Avg Salary.

            var q14 = emps.Where(e => e.Salary < emps.Average(e => e.Salary));
            //q14.loop();
            #endregion

            #region Q15
            //15.Create two lists of int and try Expect, Concat, Union, Intersect.
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> ints2 = new List<int>() { 7, 2, 9, 10, 11, 12 };
            //var q15_1 = ints.Except(ints2);
            //var q15_2 = ints.Concat(ints2);
            //var q15_3 = ints.Union(ints2);
            //var q15_4 = ints.Intersect(ints2);

            //q15_1.loop();
            //q15_2.loop();
            //q15_3.loop();
            //q15_4.loop();
            #endregion

            #region Q16
            //16.	 Create list of Phone Number and Names and try Zip Operator.
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<string> Names = new List<string>() { "Ahmed", "Ali", "Mohamed", "Ramy", "Salah", "Mahmoud" };
            //Numbers.Zip(Names, (nu, nn) => new { Number = nu , Name = nn }).loop();
            #endregion



        }
    }
}
