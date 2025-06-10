using AutoMapper;
using Day1.DTOs.DepartmentDTO;
using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public DepartmentController(ITIContext db ,IMapper _map)
        {
            Db = db;
            Map = _map;
        }

        public ITIContext Db { get; }
        public IMapper Map { get; }

        [HttpGet]
        public ActionResult getall()
        {
            return Ok( Db.Departments.ToList());
        }
        [HttpGet("{id}")]
        public ActionResult getbyid(int id)
        {
            Department d= Db.Departments.Find(id);
            //ReadDepartmentDTO dDTO = new ReadDepartmentDTO()
            //{
            //    id = d.ID,
            //    name = d.name,
            //    location = d.Loc,
            //    studentNames=d.Students.Select(n=>n.name).ToList()
            //};
            ReadDepartmentDTO dDTO = Map.Map<ReadDepartmentDTO>(d);
            return Ok(dDTO);
        }
    }
}
