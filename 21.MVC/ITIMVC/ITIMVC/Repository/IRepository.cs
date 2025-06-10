namespace ITIMVC.Repository
{
    public interface IRepository<T>
    {

        void Add(T repository);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
        void Update(T obj);
        void Save();

    }
}
