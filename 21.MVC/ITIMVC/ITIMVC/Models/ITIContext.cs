using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace ITIMVC.Models
{
    public class ITIContext  : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public ITIContext(DbContextOptions<ITIContext>options):base(options)
        {
            
        }
        public ITIContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ABDELRAHMAN\\MSSQLSERVER01;Initial Catalog=M3M;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

    }

}
