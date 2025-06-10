using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPIDay01.DTOs.StudentDTO;
using WEBAPIDay01.IRepositories;
using WEBAPIDay01.Models;
using WEBAPIDay01.Repository;

namespace WEBAPIDay01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //ITIDbContext con;
        IStudentRepository repo;
        IMapper map;

        // GET ALL , get by id , get by name update , delete , add
        public StudentsController(IStudentRepository r, IMapper mapper)
        {
            repo = r;
            map = mapper;
        }

        [EndpointSummary("Pagination ")]
        [HttpGet("/api/spage/{page}/{size}")]
        public IActionResult getAll(int page,int size)
        {

            List<Student> sts = repo.Pagination(page, size);
            if (sts == null) return NotFound();
            return (Ok(map.Map<List<StudentsDataDTO>>(sts)));
        }

        [EndpointSummary("Get By ID")]

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {

            Student s = repo.getByID(id);
            if (s == null) return NotFound();

            return Ok(map.Map<StudentsDataDTO>(s));
        }
        //Search
        [EndpointSummary("Search")]
        [HttpGet("/api/stname/{name}")]
        public IActionResult getByName(string name)
        {
            List<Student> s = repo.getByName(name);
            if (s == null) return NotFound();

            return Ok(map.Map<List<StudentsDataDTO>>(s));
        }

        [HttpPut("{id}")]
        [EndpointSummary("Update")]

        public IActionResult Update(StudentUpdateDTO s , int id)
        {
            if(s == null) return NotFound();
            if (s.StId != id) return BadRequest();
            Student stoSave = map.Map<Student>(s);
            repo.Update(stoSave);
            repo.Save();
            return Ok();
            
        }
        [HttpPost]
        [EndpointSummary("Add")]

        public IActionResult add(StudentUpdateDTO s )
        {
            if(s == null) return NotFound();
            Student stoSave = map.Map<Student>(s);
            repo.Add(stoSave);
            repo.Save();
            return Ok();
            
        }
        [HttpDelete("{id}")]
        [EndpointSummary("Delete")]

        public IActionResult delete(int id) {
            Student s = repo.getByID(id);
            if (s == null) return NotFound();
            repo.Delete(id);
            repo.Save();
            return Ok();
        }


        //[HttpGet]


        //[HttpGet]

    }
}
