using WEBAPIDay01.Models;

namespace WEBAPIDay01.IRepositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        public List<Student> Pagination(int page, int size);

    }
}
