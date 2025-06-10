using WEBAPIDay01.Models;

namespace WEBAPIDay01.IRepositories
{
    public class StudentList : IStudentRepository
    {
        static List<Student> studentss = new List<Student>()
        {
            new Student(){StId=1 , StFname="Ali",StLname = "List",StAddress="Alex",DeptId=10,StSuper=5},
            new Student(){StId=2 , StFname="Mahmoud",StLname = "List",StAddress="Ciro",DeptId=20,StSuper=5},
            new Student(){StId=3 , StFname="Mohamed",StLname = "List",StAddress="Mnf",DeptId=30,StSuper=5},
            new Student(){StId=4 , StFname="Alaa",StLname = "List",StAddress="Mansoura",DeptId=40,StSuper=5},
            new Student(){StId=5 , StFname="Saly",StLname = "List",StAddress="Banha",DeptId=20,StSuper=6},
            new Student(){StId=6 , StFname="Amr",StLname = "List",StAddress="Aswan",DeptId=30,StSuper=4},
            new Student(){StId=7 , StFname="Noha",StLname = "List",StAddress="Luxor",DeptId=30,StSuper=3},
            new Student(){StId=8 , StFname="Mona",StLname = "List",StAddress="Alex",DeptId=20,StSuper=2},
        };
        public void Add(Student d)
        {
            studentss.Add(d);
        }

        public void Delete(int id)
        {
            Student s = studentss.FirstOrDefault(x => x.StId == id);
            studentss.Remove(s);  
        }

        public List<Student> getAll()
        {
            return studentss;
        }

        public Student getByID(int id)
        {
            return studentss.FirstOrDefault(x => x.StId == id);
        }

        public List<Student> getByName(string name)
        {
            return studentss.Where(x => x.StFname.ToLower().Contains(name)).ToList();
        }

        public List<Student> Pagination(int page, int size)
        {
            List<Student> sts = studentss.Skip((page - 1) * size).Take(size).ToList();
            return sts;
        }

        public void Save()
        {
        }

        public void Update(Student s)
        {
            Student stoSave = studentss.FirstOrDefault(x=>x.StId==s.StId);
            stoSave.StFname = s.StFname;
            stoSave.StLname = s.StLname;
            stoSave.StAge= s.StAge;
            stoSave.StAddress = s.StAddress;
            stoSave.DeptId = s.DeptId;
        }

      
    }
}
