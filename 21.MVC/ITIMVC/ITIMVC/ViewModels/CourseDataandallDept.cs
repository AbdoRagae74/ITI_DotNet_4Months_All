using ITIMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITIMVC.ViewModels
{
    public class CourseDataandallDept
    {
       
        public int Id { get; set; }

        [Required]
        [Unique]
        [MaxLength(25, ErrorMessage = "Max Length is 25 characters")]
        [Display(Name = "Course name")]
        public string Name { get; set; }
        [Range(50, 100)]
        public int Degree { get; set; }
        [Display(Name = "Minimum Degree")]
        [Remote("MinDegreeVal", "Course", AdditionalFields = "Degree", ErrorMessage = "Min degree must be less than degree")]
        public int MinDegree { get; set; }
        [Display(Name = "Course hours")]

        [Remote("HoursChecker","Course",ErrorMessage ="Hours Must be divided by 3")]
        public int Hours { get; set; }
        [Display(Name = "Department ID")]
        public int deptID { get; set; }
        public List<Departments>? Departments { get; set; }
    }
}
