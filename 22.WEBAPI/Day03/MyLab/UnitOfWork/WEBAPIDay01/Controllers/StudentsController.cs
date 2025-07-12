using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPIDay01.DTOs.StudentDTO;
using WEBAPIDay01.Models;
using WEBAPIDay01.Repository;
using WEBAPIDay01.UnitOfWorks;

namespace WEBAPIDay01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //ITIDbContext con;
        UnitOfWork unit;
        IMapper map;


        public StudentsController(UnitOfWork u, IMapper mapper)
        {
            unit = u;
            map = mapper;
        }

        [EndpointSummary("Get All ")]
        [HttpGet()]
        public IActionResult getAll()
        {

            List<Student> sts = unit.StudRep.getAll();
            if (sts == null) return NotFound();
            return (Ok(map.Map<List<StudentsDataDTO>>(sts)));
        }

        [EndpointSummary("Get By ID")]

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {

            Student s = unit.StudRep.getByID(id);
            if (s == null) return NotFound();

            return Ok(map.Map<StudentsDataDTO>(s));
        }
        //Search
        //[EndpointSummary("Search")]
        //[HttpGet("/api/stname/{name}")]
        //public IActionResult getByName(string name)
        //{
        //    List<Student> s = repo.getByName(name);
        //    if (s == null) return NotFound();

        //    return Ok(map.Map<List<StudentsDataDTO>>(s));
        //}

        [HttpPut("{id}")]
        [EndpointSummary("Update")]

        public IActionResult Update(StudentUpdateDTO s , int id) 
        {
            if(s == null) return NotFound();
            if (s.StId != id) return BadRequest();
            Student stoSave = map.Map<Student>(s);
            unit.StudRep.Update(stoSave);
            unit.Save();
            return Ok();
            
        }
        [HttpPost]
        [EndpointSummary("Add")]

        public IActionResult add(StudentUpdateDTO s )
        {
            if(s == null) return NotFound();
            Student stoSave = map.Map<Student>(s);
            unit.StudRep.Add(stoSave);
            unit.Save();
            return Ok();
            
        }
        [HttpDelete("{id}")]
        [EndpointSummary("Delete")]

        public IActionResult delete(int id) {
            Student s = unit.StudRep.getByID(id);
            if (s == null) return NotFound();
            unit.StudRep.Delete(id);
            unit.Save();
            return Ok();
        }


        //[HttpGet]


        //[HttpGet]

    }
}
