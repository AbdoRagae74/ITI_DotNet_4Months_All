using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPIDay01.DTOs.DepartmentDTO;
using WEBAPIDay01.DTOs.StudentDTO;
using WEBAPIDay01.Models;
using WEBAPIDay01.Repository;
using WEBAPIDay01.UnitOfWorks;


namespace WEBAPIDay01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {

        IMapper map;
        //public ITIDbContext con;


        UnitOfWork unit;
        public DepartmentsController(UnitOfWork u,IMapper mapper)
        {
            unit = u;
            map = mapper;
        }
        [HttpGet]
        [EndpointSummary("Returns Data of all Departments")]
        public IActionResult getAll()
        {
            List<Department> allDepts = unit.DeptRep.getAll();
            if (allDepts.Count == 0)
                return NotFound();            
            return Ok(map.Map<List<DepartmentUpdateDTO>>(allDepts));
            
        }


        [HttpGet("{id}")]
        [EndpointSummary("Returns Data of Department by its ID")]
        public IActionResult getById(int id)
        {

            Department s = unit.DeptRep.getByID(id);
            if (s == null) return NotFound();

            return Ok(map.Map<DeptDataDTO>(s));
        }

        //[HttpGet("/api/dept/{name}")]
        //[EndpointSummary("Returns Department data ")]
        //[EndpointDescription("Returns Department data if found otherwise returns Not found ")]
        //[ProducesResponseType(200,Type=typeof(GetDeptDataDTO))]
        //[ProducesResponseType(404)]
        //[ProducesErrorResponseType(typeof(void))]
        //public IActionResult getByName(string name)
        //{
        //    List<Department> s = repo.getByName(name);
        //    if (s == null) return NotFound();

        //    return Ok(map.Map<List<GetDeptDataDTO>>(s));
        //}

        [HttpPut("{id}")]
        [EndpointSummary("Update department data")]
        public IActionResult Update(DepartmentUpdateDTO s, int id)
        {
            if (s == null) return NotFound();
            if (s.DeptId != id) return BadRequest();
            Department stoSave = map.Map<Department>(s);
            unit.DeptRep.Update(stoSave);
            unit.Save();
            return Ok();

        }

        [HttpPost]
        [EndpointSummary("Adds new department")]
        public IActionResult add(DepartmentUpdateDTO s)
        {
            if (s == null) return NotFound();
            Department stoSave = map.Map<Department>(s);
            unit.DeptRep.Add(stoSave);
            unit.DeptRep.Save();
            return Ok();

        }
        [HttpDelete("{id}")]
        [EndpointSummary("Deletes Department by its id")]
        public IActionResult delete(int id)
        {
            Department s = unit.DeptRep.getByID(id);
            if (s == null) return NotFound();
            unit.DeptRep.Delete (id);
            unit.Save();
            return Ok();
        }

    }
}
