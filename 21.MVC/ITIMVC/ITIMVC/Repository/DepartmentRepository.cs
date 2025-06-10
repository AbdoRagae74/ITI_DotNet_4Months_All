using ITIMVC.Models;

namespace ITIMVC.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        ITIContext con;
        public DepartmentRepository(ITIContext _con )
        {
            con = _con;
        }
        public void Add(Departments repository)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Departments> GetAll()
        {
            return con.Departments.ToList();
        }

        public Departments GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Departments obj)
        {
            throw new NotImplementedException();
        }
    }
}
