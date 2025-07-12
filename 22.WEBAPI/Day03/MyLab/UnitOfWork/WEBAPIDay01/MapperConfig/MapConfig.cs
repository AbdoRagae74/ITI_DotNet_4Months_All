using AutoMapper;
using WEBAPIDay01.DTOs.DepartmentDTO;
using WEBAPIDay01.DTOs.StudentDTO;
using WEBAPIDay01.Models;

namespace WEBAPIDay01.MapperConfig
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<Student, StudentsDataDTO>().AfterMap((src, dest) =>
            {
                dest.firstName = src.StFname;
                dest.lastName = src.StLname;
                dest.address = src.StAddress;
                dest.age = src.StAge;
                dest.departmentName = src.Dept?.DeptName;
                //if (src.StSuperNavigation == null) dest.supervisorName = "NULL";
                //else
                    dest.supervisorName = $"{src.StSuperNavigation?.StFname} {src.StSuperNavigation?.StLname}";
            });

            CreateMap<Department, DeptDataDTO>().AfterMap((src, dest) =>
            {
                dest.cnt = src.Students.Count;
            });

            CreateMap<Student, StudentUpdateDTO>().ReverseMap();
            CreateMap<Department, GetDeptDataDTO>().ReverseMap();
            CreateMap<Department, DepartmentUpdateDTO>().ReverseMap();


        }
    }
}
