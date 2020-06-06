using System;
using System.Data.Entity;
using System.Data.SqlClient;

namespace lab_4.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(string nameOrConnectionString = "DbConnectionString") : base(nameOrConnectionString)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.CurrentDirectory);
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\StudentList.mdf");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grades> Grades { get; set; }
    }
}
