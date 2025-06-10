using WEBAPIDay01.Models;

namespace WEBAPIDay01.IRepositories
{
    public interface IRepository<T>
    {

        public List<T> getAll();
        public T getByID(int id);
        public List<T> getByName(string name);
        public void Add(T d);
        public void Update(T s);
        public void Delete(int id);
        public void Save();
    }
}
