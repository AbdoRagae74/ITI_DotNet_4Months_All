using ITIMVC.Models;

namespace ITIMVC.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
        public List<Course> Search(string term);
    }
}
