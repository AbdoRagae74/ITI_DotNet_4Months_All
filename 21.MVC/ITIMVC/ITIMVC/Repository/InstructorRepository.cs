using ITIMVC.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using System.Buffers;
using System.Net;

namespace ITIMVC.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        ITIContext con;
        public InstructorRepository(ITIContext _con)
        {
            con = _con;
        }
        public void Add(Instructor instructor)
        {
            con.Instructors.Add (instructor);
        }

        public void Delete(int id)
        {
            Instructor toDelete = con.Instructors.FirstOrDefault(x => x.Id == id);
            if (toDelete != null)
            {
                con.Remove(toDelete);
            }
        }

        public List<Instructor> GetAll()
        {
            return con.Instructors.Include(x=>x.Dept).Include(x=>x.Course).ToList();
        }

        public Instructor GetById(int id)
        {
            return con.Instructors.FirstOrDefault(i => i.Id == id);
        }
        public void Update(Instructor obj)
        {
            Instructor toEdit = GetById(obj.Id);
            toEdit.Name = obj.Name;
            toEdit.Address = obj.Address;
            toEdit.Image = toEdit.Image;
            toEdit.Salary = obj.Salary;
            toEdit.DeptID = obj.DeptID;
            toEdit.CourseID = obj.CourseID;
        }
        public void Save()
        {
            con.SaveChanges();
        }

        public List<Instructor> Search(string term)
        {
            var data = GetAll();
            List<Instructor> result;
            if (!string.IsNullOrWhiteSpace(term))
                result = data.Where(x => x.Name.ToLower().Contains(term)).ToList();
            else
                result = data.ToList();

            return result;
        }
    }
}
