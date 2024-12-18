using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-BBPSTK82\\SQLEXPRESS;database=CoreProjeDB;integrated security=true;TrustServerCertificate=True");     
         }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<CourseSelection> CourseSelections { get; set; }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }
      
    }
}
