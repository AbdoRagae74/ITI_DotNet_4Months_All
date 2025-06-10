using ITIMVC.Models;
using ITIMVC.Repository;
using ITIMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace ITIMVC.Controllers
{
    
    public class TraineeController : Controller
    {
        ICourseRepository CourseRepo;
        ICrsResultRepository CrsResultRepo;
        ITraineeRepository TraineeRepo;
        public TraineeController(ICourseRepository courseRep, ITraineeRepository traineeRepo, ICrsResultRepository crsResultRepo)
        {
            CourseRepo = courseRep;
            TraineeRepo = traineeRepo;
            CrsResultRepo = crsResultRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Result(int tid , int cid)
        {
            Trainee? t = TraineeRepo.GetById(tid);
            Course? c = CourseRepo.GetById(cid);
            CrsResult? crs = CrsResultRepo.getByTraineeIdWithCrsId(tid, cid);

            if (t == null || crs == null || c == null) return NotFound();

            TraineeCrsDegreeViewModel crsData = new()
            {
                TraineeName = t.Name,
                CrsDegree = crs.Degree,
                CrsName = c.Name,
                status = "Pass",
                Color = "green",

        };
            if (c.MinDegree > crs.Degree)
            {
                crsData.status = "Fail";
                crsData.Color = "red";
            }
            

            return View(crsData);
        }
        public IActionResult TraineeResults(int id)
        {

            List<CrsResult> res = CrsResultRepo.getByTraineeId(id);
            List<TraineeCrsDegreeViewModel> Data = new List<TraineeCrsDegreeViewModel>();
            if (res.Count == 0) return NotFound();
            foreach (var c in res) {

                TraineeCrsDegreeViewModel courseData = new()
                {
                    TraineeName = c.Trainee.Name,
                    CrsDegree = c.Degree,
                    CrsName = c.Course.Name,
                    status="Pass",
                    Color = "green"

                };
                if(c.Course.MinDegree > c.Degree)
                {
                    courseData.status = "Fail";
                    courseData.Color = "red";
                }
                Data.Add(courseData);
            }

            
            

            return View(Data);

        }



    }
}
