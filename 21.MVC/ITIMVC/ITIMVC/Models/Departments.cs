namespace ITIMVC.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }

        public virtual List <Course> Courses { get; set; } = new List<Course>();
        public virtual List <Trainee> Trainees { get; set; } = new List<Trainee>();
        public virtual List <Instructor> Instructors { get; set; } = new List<Instructor>();

        public override string ToString()
        {
            return Name;
        }

    }
}
