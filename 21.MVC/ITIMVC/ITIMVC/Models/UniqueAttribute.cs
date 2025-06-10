using ITIMVC.ViewModels;
using System.CodeDom;
using System.ComponentModel.DataAnnotations;

namespace ITIMVC.Models
{
    public class UniqueAttribute:ValidationAttribute
    {
       

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //ITIContext con = new ITIContext();
            ITIContext   con = (ITIContext)validationContext.GetService(typeof(ITIContext));
            string? name = value?.ToString();
            CourseDataandallDept courseObj = (CourseDataandallDept)validationContext.ObjectInstance;
            Course DBCourse = con.Courses.Where(x => x.DeptID == courseObj.deptID).FirstOrDefault(x=>x.Name==name);
            if (DBCourse == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Name already exists in that department");


        }

    }
}
