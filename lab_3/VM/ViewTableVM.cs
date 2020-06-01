using DevExpress.Mvvm;
using lab_3.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.VM
{
    public class ViewTableVM
    {
        public List<Grades> Grades
        {
            get
            {
                List<Grades> grades = null;
                using (var context = new UserDbContext())
                {
                    context.Grades.Load();
                    grades = context.Grades.Local.ToList();
                }
                return grades;
            }            
        }

        public List<Student> Student
        {
            get
            {
                List<Student> student = null;
                using (var context = new UserDbContext())
                {
                    context.Students.Load();
                    student = context.Students.Local.ToList();
                }
                return student;
            }
        }
    }
}
