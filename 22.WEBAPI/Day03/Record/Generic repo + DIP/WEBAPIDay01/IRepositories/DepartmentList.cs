using WEBAPIDay01.Models;

namespace WEBAPIDay01.IRepositories
{
    public class DepartmentList : IDepartmentRepository
    {
        static List<Department> depts = new List<Department>()
        {

            new Department(){DeptId = 10,DeptName="SD",DeptDesc="Dept10",DeptLocation="Lec1",DeptManager=1},
            new Department(){DeptId = 20,DeptName="EL",DeptDesc="Dept20",DeptLocation="Lec2",DeptManager=2},
            new Department(){DeptId = 30,DeptName="AB",DeptDesc="Dept30",DeptLocation="Lec3",DeptManager=6},
            new Department(){DeptId = 40,DeptName=".NET",DeptDesc="Dept40",DeptLocation="Section4",DeptManager=5},
            new Department(){DeptId = 50,DeptName="BI",DeptDesc="Dept50",DeptLocation="Lec5",DeptManager=4},
            new Department(){DeptId = 60,DeptName="MERN",DeptDesc="Dept60",DeptLocation="Hall 6",DeptManager=3},
            new Department(){DeptId = 70,DeptName="PP",DeptDesc="Dept70",DeptLocation="Lec7",DeptManager=2},

        };

        public void Add(Department d)
        {
           depts.Add(d);
        }

        public void Delete(int id)
        {
            Department d = depts.FirstOrDefault(x=>x.DeptId == id);
            depts.Remove(d);
        }

        public List<Department> getAll()
        {
            return depts;
        }

        public Department getByID(int id)
        {
            return depts.FirstOrDefault(x => x.DeptId == id);
        }

        public List<Department> getByName(string name)
        {
            return depts.Where(x => x.DeptName.ToLower().Contains(name)).ToList();
        }

        public void Save()
        {
           
        }

        public void Update(Department s)
        {
            Department d = getByID(s.DeptId);
            d.DeptDesc = s.DeptDesc;
            d.DeptLocation = s.DeptDesc;
            d.DeptManager = s.DeptManager;
            d.DeptName = s.DeptName;

        }
    }
}
