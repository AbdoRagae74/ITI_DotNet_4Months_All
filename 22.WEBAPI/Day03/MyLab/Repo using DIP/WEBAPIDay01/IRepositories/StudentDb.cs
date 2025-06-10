using WEBAPIDay01.Models;

namespace WEBAPIDay01.IRepositories
{
    public class StudentDb:IStudentRepository
    {
        ITIDbContext con;
        public StudentDb(ITIDbContext db)
        {
            con = db;
        }

        public List<Student> getAll()
        {
            return con.Students.ToList();
        }


        public List<Student> Pagination(int page, int size)
        {
            List<Student> sts = con.Students.Skip((page - 1) * size).Take(size).ToList();
            return sts;
        }

        public Student getByID(int id)
        {
            return con.Students.Find(id);
        }

        public List<Student> getByName(string name)
        {
            return con.Students.Where(x => x.StFname.ToLower().Contains(name)).ToList();
        }

        public void Add(Student s)
        {

            con.Students.Add(s);
        }
        public void Update(Student s)
        {
            con.Entry(s).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(int id)
        {
            con.Remove(con.Students.Find(id));
        }
        public void Save()
        {
            con.SaveChanges();
        }
    }
}
