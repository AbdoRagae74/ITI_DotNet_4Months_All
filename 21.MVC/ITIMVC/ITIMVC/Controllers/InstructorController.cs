using ITIMVC.Models;
using ITIMVC.Repository;
using ITIMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITIMVC.Controllers
{
    [Authorize(Roles ="Admin")]

    public class InstructorController : Controller
    {

        ICourseRepository CourseRepo;
        IInstructorRepository InsRepo;
        IDepartmentRepository DepartmentRepo;
        public InstructorController(ICourseRepository courseRep, IDepartmentRepository deptRepo, IInstructorRepository insRepo)
        {
            InsRepo = insRepo;
            CourseRepo = courseRep;
            DepartmentRepo = deptRepo;

        }
        public IActionResult Index()
        {
            
            List<Instructor> instructors = InsRepo.GetAll();
            return View(instructors);
        }
        
        public IActionResult Details(int id)
        {
            Instructor current = InsRepo.GetById(id);
            if(current!=null)
                return View(current);
            else 
                return NotFound();
        }

        public IActionResult AddInstructor()
        {
            InstructorWithCoursesViewModel insCourse = new InstructorWithCoursesViewModel()
            {
                Departments = DepartmentRepo.GetAll(),
                Courses = CourseRepo.GetAll(),
            };

            return View(insCourse);
        }

        public async void saveFile(IFormFile img)
        {
            //Injecting service to get path to wwwroot 
            string path = $"C:\\Users\\AbdoRagae\\source\\repos\\ITIMVC\\ITIMVC\\wwwroot\\images\\{img.FileName}";

            //Copying the content of the Image from the InsFormReq to the file in the wwwroot
            using (var stream = System.IO.File.Create(path))
            {

                await img.CopyToAsync(stream);

            }
        }
        [HttpPost]
        public IActionResult SaveAdd(InstructorWithCoursesViewModel InsFromReq)
        {
           
            saveFile(InsFromReq.Image);


            if (InsFromReq.InsName != null)
            {
                Instructor newIns = new Instructor() {
                    
                    Name = InsFromReq.InsName,
                    Address = InsFromReq.Address,
                    Image = InsFromReq.Image.FileName,
                    Salary = InsFromReq.Salary,
                    DeptID = InsFromReq.DeptId,
                    CourseID = InsFromReq.CrsId,

                };

                InsRepo.Add(newIns);
                InsRepo.Save();
                return RedirectToAction("Index");

            }

            InsFromReq.Courses = CourseRepo.GetAll();
            InsFromReq.Departments = DepartmentRepo.GetAll();
            return View("AddInstructor", InsFromReq);

        }
        public IActionResult SearchResult(string searchValue)
        {

            List<Instructor> res =  InsRepo.Search(searchValue);
            return PartialView(res);
        }

        public IActionResult DeleteIns(int id)
        {
            //Instructor insToRemove = InsRepo.GetById(id);
            InsRepo.Delete(id);
            InsRepo.Save();
            return RedirectToAction("Index");
        }
    }
}
