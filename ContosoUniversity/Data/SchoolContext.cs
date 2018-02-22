using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        // In this class , specify the entities that included in the data model.
        // So you can access Databases by using Entity Framework.
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        // Actually, we can omit(省略) DbSet<Enrollment> and DbSet<Course> Courses
        // Because the Student entity has references to Enrollment and Course
        // Entity Framework will to the job for us.

        // When Database is create, EntityFramework create tables whose name is the same as DbSet<> name
        // But if we don't want the pluralized (複數) table name, we can override by the following codes :
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
