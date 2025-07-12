using WEBAPIDay01.Models;
using WEBAPIDay01.Repository;

namespace WEBAPIDay01.UnitOfWorks
{
    public class UnitOfWork
    {
        ITIDbContext db;
        GenericRep<Student> studRep;
        GenericRep<Department> deptRep;
        public UnitOfWork(ITIDbContext db)
        {
            this.db=db;
            //DeptRep = new GenericRep<Department>(this.db);
            //StudRep = new GenericRep<Student>(this.db);
        }
        public GenericRep<Student> StudRep
        { get
            {
                if(studRep==null)
                    studRep =  new GenericRep<Student>(db);
               return studRep;
            } 
        }
        public GenericRep<Department> DeptRep
        { get
            {
                if(deptRep==null)
                    deptRep =  new GenericRep<Department>(db);
               return deptRep;
            } 
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
