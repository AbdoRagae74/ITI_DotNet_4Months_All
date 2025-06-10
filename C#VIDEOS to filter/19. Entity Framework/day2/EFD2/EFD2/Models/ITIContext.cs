using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2.Models
{
    internal class ITIContext:DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<empProj> EmpProjs { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=DESKTOP-JP4B1RU;Database=EFd2;Trusted_Connection=True; TrustServerCertificate=True;");
           // optionsBuilder.LogTo(Console.Write);
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<empProj>().HasKey("empid", "projid");
            //modelBuilder.Entity<Employee>().Property<string>("name").IsRequired();
            //modelBuilder.Entity<Employee>().HasKey("id");

            modelBuilder.Entity<Department>().HasData(
                new Department() { deptid = 1, name = "dotnet", location = "lec1" },
                new Department() { deptid = 2, name = "php", location = "lec2" },
                new Department() { deptid = 3, name = "front", location = "lec3" });
        }
    }
}
