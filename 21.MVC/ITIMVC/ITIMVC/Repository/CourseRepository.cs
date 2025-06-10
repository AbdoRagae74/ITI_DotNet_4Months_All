using ITIMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Buffers;

namespace ITIMVC.Repository
{
    public class CourseRepository : ICourseRepository
    {
        ITIContext con;
        public CourseRepository(ITIContext _con)
        {
            con = _con;
        }
        public void Add(Course course)
        {

          con.Courses.Add(course);
        }

        public void Delete(int id)
        {
            Course toDelete = con.Courses.FirstOrDefault(c => c.Id == id);
            if(toDelete!=null) con.Remove(toDelete);
        }

        public List<Course> GetAll()
        {
            return con.Courses.Include(x=>x.Dept).AsNoTracking().ToList();
        }

        public void Update(Course obj)
        {
            Course toEdit = GetById(obj.Id);
            toEdit.DeptID = obj.DeptID;
            toEdit.Degree = obj.Degree;
            toEdit.MinDegree = obj.MinDegree;
            toEdit.Name = obj.Name;
            toEdit.Hours = obj.Hours;
        }
        public Course GetById(int id)
        {
            return con.Courses.FirstOrDefault(c => c.Id == id);
        }

        public List<Course> Search(string term)
        {
            var data = con.Courses.Include(x => x.Dept);
            List<Course> result;
            if (!string.IsNullOrWhiteSpace(term))
                result = data.Where(x => x.Name.ToLower().Contains(term)).ToList();
            else
                result = data.ToList();
            return result;

        }

        public void Save()
        {
            con.SaveChanges();
        }


    }
}
