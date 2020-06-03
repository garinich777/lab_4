using DevExpress.Mvvm;
using lab_4.Model;
using System.Windows;
using System.Windows.Input;

namespace lab_4.VM
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
                            MessageBox.Show("Добавлено");
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
