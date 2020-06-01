using lab_3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.VM
{
    public class MainVM
    {
        public List<Grades> Grades {
            get
            {
                List<Grades> grades = null;
                using (var context = new UserDbContext())
                {
                    grades = context.Grades.Local.ToList();
                }
                return grades;

                //return new List<Grades>()
                //{ 
                //    new Grades() { Id = 1, Score = 1, StudentId = 1, SubjectName = "МатАн" },
                //    new Grades() { Id = 2, Score = 3, StudentId = 2, SubjectName = "ВычМт" }
                //};
            }
            set
            {
            }
        }

        public List<Student> Student
        {
            get
            {
                List<Student> student = null;
                using (var context = new UserDbContext())
                {
                    student = context.Students.Local.ToList();
                }
                return student;
            }
            set
            {
            }
        }

    }
}
