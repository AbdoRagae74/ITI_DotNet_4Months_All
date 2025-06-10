using WEBAPIDay01.Models;

namespace WEBAPIDay01.IRepositories
{
    public class DepartmentDb : IDepartmentRepository
    {
        ITIDbContext con;
        public DepartmentDb(ITIDbContext db)
        {
            con = db;
        }

        public List<Department> getAll()
        {
            return con.Departments.ToList();
        }



        public Department getByID(int id)
        {
            return con.Departments.Find(id);
        }

        public List<Department> getByName(string name)
        {
            return con.Departments.Where(x => x.DeptName == name).ToList();
        }

        public void Add(Department d)
        {

            con.Departments.Add(d);
        }
        public void Update(Department s)
        {
            con.Entry(s).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(int id)
        {
            con.Remove(con.Departments.Find(id));
        }
        public void Save()
        {
            con.SaveChanges();
        }

       
    }
}
