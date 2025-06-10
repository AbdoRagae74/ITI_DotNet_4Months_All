using ITIMVC.Models;

namespace ITIMVC.Repository
{
    public interface IInstructorRepository:IRepository<Instructor>
    {
        public List<Instructor> Search(string term);
    }
}
