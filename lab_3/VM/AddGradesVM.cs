using DevExpress.Mvvm;
using lab_3.Model;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace lab_3.VM
{
    class AddGradesVM : ViewModelBase
    {
        public int StudentId { get; set; }
        public string SubjectName { get; set; }
        public int Score { get; set; }

        public ICommand AddGrades
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    using (var context = new UserDbContext())
                    {
                        Grades new_grades = new Grades()
                        {
                            StudentId = StudentId,
                            SubjectName = SubjectName,
                            Score = Score,
                            
                        };

                        if (context.Students.Find(StudentId) != null)
                        {
                            context.Grades.Add(new_grades);
                            context.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Такого студента нет!");
                        }

                    }
                });
            }
        }
    }
}
