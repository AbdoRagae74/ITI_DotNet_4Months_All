using System.ComponentModel.DataAnnotations.Schema;

namespace ITIMVC.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        [ForeignKey("Dept")]
        public int DeptID { get; set; }
       
        public virtual Departments? Dept { get; set; }
        public virtual List<CrsResult>Results { get; set; } = new List<CrsResult>();
    }
}
