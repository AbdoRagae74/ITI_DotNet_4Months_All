using ITIMVC.Models;
using ITIMVC.Repository;
using ITIMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace ITIMVC.Controllers
{

    public class CourseController : Controller
    {

        
        ICourseRepository CourseRepo;
        IInstructorRepository InsRepo;
        IDepartmentRepository DepartmentRepo;
        //IserviceRepo     Injecting service layer in controller
        public CourseController(ICourseRepository courseRep, IDepartmentRepository deptRepo,IInstructorRepository insRepo)
        {
            InsRepo = insRepo;
            CourseRepo = courseRep;
            DepartmentRepo = deptRepo;
            
        }
        public IActionResult Index()
        {

            List<Course> allCourses = CourseRepo.GetAll();
            return View(allCourses);
        }

        public IActionResult AddCourse()
        {


            CourseDataandallDept model = new CourseDataandallDept()
            {
                Departments = DepartmentRepo.GetAll()

            };
                ViewBag.depts = model.Departments;
            return View(model);
        }
       
        public IActionResult SaveAdd(CourseDataandallDept dataFromReq)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    //serviceLayer.Add(ViewModel returned from view) 
                    //Apply mapping in service not in controller
                    Course newCoures = new Course() { 
                
                        Name = dataFromReq.Name,
                        Degree = dataFromReq.Degree,
                        MinDegree = dataFromReq.MinDegree,
                        Hours = dataFromReq.Hours,
                        DeptID = dataFromReq.deptID
                    };
                    CourseRepo.Add(newCoures);
                    CourseRepo.Save(); 
                    return RedirectToAction("Index");
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("erro1", ex.InnerException.Message);
                    dataFromReq.Departments = DepartmentRepo.GetAll();
                }
                
            }
            dataFromReq.Departments = DepartmentRepo.GetAll();
            return View("AddCourse", dataFromReq);
        }

        public IActionResult DeleteCourse(int id) {
            CourseRepo.Delete(id);
            CourseRepo.Save();
            return RedirectToAction("Index");
        }

        public IActionResult SearchResult(string searchValue)
        {

            List<Course> result = CourseRepo.Search(searchValue);
            return PartialView(result);
        }

        public IActionResult MinDegreeVal(int MinDegree, int Degree)
        {
            if (MinDegree <= Degree)
            {
                return Json(true);
            }
            return Json(false);
        }

        public IActionResult HoursChecker(int Hours)
        {

            return Hours % 3 == 0 ? Json(true) : Json(false);
        }
    }
}
