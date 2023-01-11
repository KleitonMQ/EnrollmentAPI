using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnrollmentAPI.src.entities;

namespace EnrollmentAPI.src.context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>(studentTable =>
            {
                studentTable.HasKey(entityStudant => entityStudant.ID);
                studentTable.HasMany(courses => courses.course).WithOne().HasForeignKey(course => course.ID);
            });
        }
    }
}