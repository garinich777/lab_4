using System.Data.Entity;

namespace lab_4.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(string nameOrConnectionString = "DbConnectionString") : base(nameOrConnectionString) {}

        public DbSet<Student> Students { get; set; }
        public DbSet<Grades> Grades { get; set; }
    }
}
