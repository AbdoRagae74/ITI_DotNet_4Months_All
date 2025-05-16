using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD01
{
    public class Utils
    {

        public static IEnumerable<Student> FindStudentsSorted( IEnumerable<Student> DataSource,int method , int way)
        {
            if (method == 1) // Name
            {
                if (way == 1) // ASC
                    return DataSource.OrderBy(s => s.FirstName);
                else
                    return DataSource.OrderByDescending(s => s.FirstName);
            }  
            
            if (method == 2) // Age
            {
                if (way == 1) // ASC
                    return DataSource.OrderBy(s => s.Age);
                else
                    return DataSource.OrderByDescending(s => s.Age);
            }  

            if (method == 3) // Salary
            {
                if (way == 1) // ASC
                    return DataSource.OrderBy(s => s.Salary);
                else
                    return DataSource.OrderByDescending(s => s.Salary);
            }   
            
            if (method == 4) // Track
            {
                if (way == 1) // ASC
                    return DataSource.OrderBy(s => s.TrackId);
                else
                    return DataSource.OrderByDescending(s => s.TrackId);
            }
            return DataSource.OrderBy(s => s.Id);
        }
    }
}
