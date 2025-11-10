
using HubCollege.model;
using Microsoft.EntityFrameworkCore;

namespace HubCollege.Data
{
    public class AppDbContext : DbContext
    {
        // contructor of DbContext
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<FormsActivity> FormsActivities { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<Teachers> Teachers { get; set; }

    }
}