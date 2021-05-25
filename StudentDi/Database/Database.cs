using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace StudentDi.Database
{
    public class Databasecontext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=student_di;User Id=postgres;Password=1234;");
        }
    }
    public class Student
    {
        public int Id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Updated { get; set; }
    }
}
