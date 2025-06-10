using ITIMVC.Models;

namespace ITIMVC.ViewModels
{
    public class InstructorWithCoursesViewModel
    {

        public int Id { get; set; }
        public string InsName { get; set; }

        public IFormFile? Image { get; set; }
        public int? Salary { get; set; }
        public string? Address { get; set; }
        public int DeptId { get; set; }
        public int CrsId { get; set; }
        public List<Course> Courses { get; set; }
        public List<Departments> Departments { get; set; }

    }
}
