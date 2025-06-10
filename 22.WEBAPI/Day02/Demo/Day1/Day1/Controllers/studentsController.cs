using AutoMapper;
using Day1.DTOs.StudentDTO;
using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class studentsController : ControllerBase
    {
        ITIContext db;
        IMapper _map;
        public studentsController(ITIContext db ,IMapper _map)
        {
            this.db = db;
            this._map = _map;
        }

        [HttpGet]
        public ActionResult Getall()
        {
            List<Student> sts= db.Students.ToList();

            //List<ReadStudentDTO> stsDTO = new List<ReadStudentDTO>();

            //foreach (var s in sts)
            //{
            //    ReadStudentDTO sDTO = new ReadStudentDTO()
            //    {
            //        id = s.ID,
            //        name = s.name,
            //        age = s.age,
            //        address = s.adddress,
            //        departmentName = s.dept.name
            //    };
            //    stsDTO.Add(sDTO);
            //}
            List<ReadStudentDTO> stsDTO = _map.Map<List<ReadStudentDTO>>(sts);
            return Ok(stsDTO);
        }
        
        [HttpGet("{id:int}")]
        [Produces("application/json")]

        public ActionResult getbyid(int id)
        {
           Student s= db.Students.Where(n => n.ID == id).FirstOrDefault();
            if (s == null) return NotFound();
            //ReadStudentDTO stDTO = new ReadStudentDTO()
            //{
            //    id = s.ID,
            //    name = s.name,
            //    age = s.age,
            //    address = s.adddress,
            //    departmentName = s.dept.name
            //};
          ReadStudentDTO stDTO =  _map.Map<ReadStudentDTO>(s);
             return Ok(stDTO);
        }
      //  [HttpGet("/api/sts/{name}")]
        [HttpGet("{name:alpha}")]

        public ActionResult getbyname(string name)
        {
            Student s = db.Students.Where(n => n.name==name).FirstOrDefault();
            if (s == null) return NotFound();
            ReadStudentDTO stDTO = new ReadStudentDTO()
            {
                id = s.ID,
                name = s.name,
                age = s.age,
                address = s.adddress,
                departmentName = s.dept.name
            };

            return Ok(stDTO);
        }

        [HttpPost]
        [Consumes("application/json")]
        public ActionResult add(AddStudentDTO sdto)
        {
            if (sdto == null) return BadRequest();
            if(!ModelState.IsValid) return BadRequest(ModelState);
            Student s = new Student()
            {
                name = sdto.name,
                age = sdto.age,
                adddress = sdto.address,
                deptid = sdto.deptid
            };

            db.Students.Add(s);
            db.SaveChanges();
            // return Created("ay7aga", s);
            return CreatedAtAction("getbyid", new { id = s.ID },sdto);
        }
        [HttpPut("{id}")]
        public ActionResult update(int id ,Student s) { 
        
        if(s == null) return BadRequest();
        if(id!=s.ID) return BadRequest();

            if (ModelState.IsValid)
            {
                db.Entry(s).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

                return NoContent();
            }
            else return BadRequest(ModelState);
        
        }


        [HttpDelete("{id}")]
        public ActionResult delete(int id)
        {
            Student s=db.Students.FirstOrDefault(n=>n.ID == id);
            if (s == null) return NotFound();
            db.Students.Remove(s);
            db.SaveChanges();
            return Ok(s);
        }


        [HttpPost("{id}")]
        public ActionResult test([FromQuery]int id ,[FromBody] string name )
        {
            return Ok();
        }

    }
}
