//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using WEBAPIDay01.Models;


//namespace WEBAPIDay01.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CoursesController : ControllerBase
//    {
//        public ITIDbContext con;
//        public CoursesController(ITIDbContext c)
//        {
//            con = c;
//        }
//        [HttpGet]
//        public IActionResult allCourses()
//        {
//            List<Course> courses = con.Courses.ToList();

//            if (courses == null)
//            {
//                return NotFound();
//            }
//            return Ok(courses);
//        }
//        [HttpGet("/api/get/{id}")]
//        public IActionResult getById(int id)
//        {
//            Course c = con.Courses.FirstOrDefault(x => x.CrsId == id);

//            if (c == null)
//            {
//                return NotFound();
//            }
//            return Ok(c);
//        }

//        [HttpPost]
//        public IActionResult AddCourse(Course c)
//        {
//            if (c == null) return BadRequest();

//            con.Courses.Add(c);
//            con.SaveChanges();
//            return CreatedAtAction("getById", new { id = c.CrsId }, c);

//        }

//        [HttpDelete("{id}")]
//        public IActionResult deleteCourse(int id)
//        {
//            Course toDelete = con.Courses.SingleOrDefault(c => c.CrsId == id);

//            if (toDelete == null)
//            {
//                return NotFound();
//            }
//            con.Courses.Remove(toDelete);
//            con.SaveChanges();
//            return Ok(allCourses());

//        }
//        [HttpPut("{id}")]
//        public IActionResult update(Course c, int id)
//        {
//            if (c == null) return BadRequest();
//            if (c.CrsId != id) return BadRequest();
//            if (ModelState.IsValid)
//            {
//                con.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
//                con.SaveChanges();
//                return Ok();
//                return NoContent();
//            }
//            else return BadRequest(ModelState);

//        }

//        [HttpGet("/api/crs/{name}")]
//        public IActionResult getByName(string name)
//        {
//            Course c = con.Courses.FirstOrDefault(x => x.CrsName == name);

//            if (c == null)
//            {
//                return NotFound();
//            }
//            return Ok(c);
//        }


//    }
//}


