using DevExpress.Mvvm;
using lab_4.Model;
using System.Windows;
using System.Windows.Input;

namespace lab_4.VM
{
    public class ModGradesVM : ViewModelBase
    {
        Grades grades;
        public int StudentId { get; set; }
        public string SubjectName { get; set; }
        public int Score { get; set; }

        public ModGradesVM(Grades grades)
        {
            this.grades = grades;
            StudentId = grades.StudentId;
            SubjectName = grades.SubjectName;
            Score = grades.Score;
        }

        public ICommand AddGrades
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    using (var context = new UserDbContext())
                    {
                        grades = context.Grades.Find(grades.Id);

                        grades.StudentId = StudentId;
                        grades.SubjectName = SubjectName;
                        grades.Score = Score;

                        context.SaveChanges();
                        MessageBox.Show("Запись изменена");
                    }
                });
            }
        }
    }
}
