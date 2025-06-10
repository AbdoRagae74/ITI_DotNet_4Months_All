using System.ComponentModel.DataAnnotations.Schema;

namespace ITIMVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public int? Salary { get; set; }
        public string? Address { get; set; }
        [ForeignKey("Dept")]
        public int DeptID { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }

        public virtual Departments? Dept { get; set; }
        public virtual Course? Course { get; set; }
    }
}
