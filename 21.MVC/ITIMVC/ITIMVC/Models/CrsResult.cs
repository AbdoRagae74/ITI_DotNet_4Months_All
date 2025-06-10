using System.ComponentModel.DataAnnotations.Schema;

namespace ITIMVC.Models
{
    public class CrsResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        [ForeignKey("Trainee")]
        public int TraineeID { get; set; }

        public virtual Trainee? Trainee { get; set; }
        public virtual Course? Course { get; set; }
    }
}
