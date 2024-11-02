using Microsoft.EntityFrameworkCore;
using SchoolApp.Models.Entities;

namespace SchoolApp.Models.Context
{
    public class ApplicationDbContext : DbContext // DbContext is a class from EFCore.
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // setting up domain classes or entities

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; } 
    }
}
