using lab_4.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace lab_4.Test
{
    [TestClass]
    public class DB_Test
    {
        [TestMethod]
        public void Test_Add_Data()
        {
            Student new_student = new Student();
            int count = 0;
            int add_count = 0;
            using (var context = new UserDbContext("DbConnectionTest"))
            {
                count = context.Students.Count();
                context.Students.Add(new_student);
                context.SaveChanges();
                add_count = context.Students.Count();
            }

            Assert.AreEqual(count + 1, add_count);
        }
    }
}
