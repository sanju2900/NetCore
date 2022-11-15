
using Entity_Framework.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework
{
    public class MyAppDataContext : DbContext
    {
        public MyAppDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Club> Clubs { get; set; }

    }
}
