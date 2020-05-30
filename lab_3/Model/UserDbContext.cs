using System.Data.Entity;

namespace lab_3.Model
{
    class UserDbContext : DbContext
    {
        public UserDbContext() : base("DbConnectionString"){}

        public DbSet<Student> Students { get; set; }
        public DbSet<Grades> Grades { get; set; }
    }
}
