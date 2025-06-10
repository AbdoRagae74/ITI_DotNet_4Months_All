using ITIMVC.Repository;
using Microsoft.EntityFrameworkCore;

namespace ITIMVC.Models
{
    public class InstructorBL
    {
        ITIContext con;
        public InstructorBL()
        {
            
        }
        public InstructorBL(ITIContext _con)
        {
                con = _con;
        }
        public Instructor getByID(int id)
        {
            
            return con.Instructors.Include(x => x.Dept).Include(x => x.Course).SingleOrDefault(i => i.Id == id);
        }
    }
}
