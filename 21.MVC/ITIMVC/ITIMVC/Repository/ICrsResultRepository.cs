using ITIMVC.Models;

namespace ITIMVC.Repository
{
    public interface ICrsResultRepository:IRepository<CrsResult>
    {
        CrsResult getByTraineeIdWithCrsId(int tid, int cid);
        List<CrsResult> getByTraineeId(int tid);
    }
}
