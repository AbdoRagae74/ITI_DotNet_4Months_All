using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD02.Models
{
    public class NewsContext :DbContext
    {
        public virtual DbSet<News> News { get; set; }   
        public virtual DbSet<Category> Categories { get; set; }   
        public virtual DbSet<Author> Authors  { get; set; }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABDELRAHMAN\\MSSQLSERVER01;Database=News;Trusted_Connection=True;TrustServerCertificate = True;");
        }

    }
}
