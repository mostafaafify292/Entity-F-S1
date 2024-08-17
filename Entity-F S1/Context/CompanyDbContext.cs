using Entity_F_S1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S1.Context
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = Iti_EF ; Trusted_Connection = True ; Encrypt = False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>().HasKey(p => new {p.Course_Id , p.Inst_Id });
            modelBuilder.Entity<Stud_Course>().HasKey(p => new { p.Course_Id, p.Stud_Id });
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Courses_Inst { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Stud_Course> stud_Courses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Topic> topics { get; set; }


    }
}
