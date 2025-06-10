using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITIMVC.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name{ get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public int Hours { get; set; }
        [ForeignKey("Dept")]
        public int DeptID { get; set; }

        public virtual Departments? Dept { get; set; }
        public virtual List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public virtual List<CrsResult> Results { get; set; } = new List<CrsResult>();

        public override string ToString()
        {
            return Name;
        }

    }
}
