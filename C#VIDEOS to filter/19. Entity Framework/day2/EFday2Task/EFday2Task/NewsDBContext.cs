using EFday2Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EFday2Task
{
    public class NewsDBContext : DbContext
    {
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=NewsDB_EFD2Task;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Ali Ashraf", Email = "ali@gmial.com" },
                new Author { Id = 2, Name = "Omar Ahmed", Email = "omar@yahoo.com" },
                new Author { Id = 3, Name = "Mona Ali", Email = "mona@outlook.com" });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Politics", Description = "Government, elections, policies" },
                new Category { Id = 2, Name = "Crime", Description = "Law, police, investigations" },
                new Category { Id = 3, Name = "Sports", Description = "Games, athletes, competitions" },
                new Category { Id = 4, Name = "Technology", Description = "Innovations, gadgets, AI" },
                new Category { Id = 5, Name = "Economy", Description = "Markets, money, companies" });

            modelBuilder.Entity<News>().HasData(
                new News { Id = 1, Title = "title1", AuthorId = 2, CategoryId = 5 },
                new News { Id = 2, Title = "title2", AuthorId = 2, CategoryId = 3 },
                new News { Id = 3, Title = "title3", AuthorId = 1, CategoryId = 4 },
                new News { Id = 4, Title = "title4", AuthorId = 2, CategoryId = 1 },
                new News { Id = 5, Title = "title5", AuthorId = 3, CategoryId = 4 });
        }
    }
}
