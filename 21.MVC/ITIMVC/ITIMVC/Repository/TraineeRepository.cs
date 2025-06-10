using ITIMVC.Models;

namespace ITIMVC.Repository
{
    public class TraineeRepository : ITraineeRepository
    {
        ITIContext con;
        public TraineeRepository(ITIContext _con)
        {
            con = _con;
        }
        public void Add(Trainee obj)
        {
            con.Trainees.Add(obj);
        }

        public void Delete(int id)
        {
            Trainee toDelete = GetById(id);
            if (toDelete != null)
            {
                con.Trainees.Remove(toDelete);
            }
        }

        public List<Trainee> GetAll()
        {
            return con.Trainees.ToList();
        }

        public Trainee GetById(int id)
        {
            return con.Trainees.FirstOrDefault(x => x.Id == id);
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public void Update(Trainee obj)
        {
            Trainee toUpdate = GetById(obj.Id);
            if (toUpdate != null)
            {
                toUpdate.Name = obj.Name;
                toUpdate.Image= obj.Image;
                toUpdate.Address = obj.Address;


            }
        }
    }
}
