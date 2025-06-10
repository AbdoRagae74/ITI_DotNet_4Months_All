using ITIMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ITIMVC.Repository
{
    public class CrsResultRepository : ICrsResultRepository
    {
        ITIContext con;
        public CrsResultRepository(ITIContext _con)
        {
            con = _con;
        }
        public void Add(CrsResult obj)
        {
            
            con.CrsResults.Add(obj);
        }

        public void Delete(int id)
        {
            CrsResult toDelete = GetById(id);
            if (toDelete!=null)
            {
                con.CrsResults.Remove(toDelete);
            }
        }

        public List<CrsResult> GetAll()
        {
            return con.CrsResults.ToList();
        }

        public CrsResult GetById(int id)
        {
            return con.CrsResults.FirstOrDefault(x => x.Id == id);
        }

        public List<CrsResult> getByTraineeId(int tid)
        {
            return con.CrsResults.Where(t => t.TraineeID == tid).Include(x=>x.Trainee).Include(x=>x.Course).ToList();
        }

        public CrsResult getByTraineeIdWithCrsId(int tid, int cid)
        {
            return con.CrsResults.FirstOrDefault(x => x.TraineeID== tid && x.CourseID==cid );
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public void Update(CrsResult obj)
        {
            CrsResult toUpdate = GetById(obj.Id);
            if (toUpdate!=null)
            {
                toUpdate.Degree = obj.Degree;
                toUpdate.TraineeID = obj.TraineeID;
                toUpdate.CourseID = obj.CourseID;
            }
        }
    }
}
