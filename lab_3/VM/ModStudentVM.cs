using DevExpress.Mvvm;
using lab_4.Model;
using System.Windows;
using System.Windows.Input;

namespace lab_4.VM
{
    public class ModStudentVM : ViewModelBase
    {
        Student student;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupNum { get; set; }
        public string TrainingFormat { get; set; }
        public int Grant { get; set; }
        public int CostEducation { get; set; }

        public ModStudentVM(Student student)
        {
            this.student = student;
            FirstName = student.FirstName;
            LastName = student.LastName;
            GroupNum = student.GroupNum;
            TrainingFormat = student.TrainingFormat;
            Grant = student.Grant;
            CostEducation = student.CostEducation;
        }

        public ICommand AddStudent
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    using (var context = new UserDbContext())
                    {
                        student = context.Students.Find(student.Id);

                        student.FirstName = FirstName;
                        student.LastName = LastName;
                        student.GroupNum = GroupNum;
                        student.TrainingFormat = TrainingFormat;
                        student.Grant = Grant;
                        student.CostEducation = CostEducation;

                        context.SaveChanges();
                        MessageBox.Show("Запись изменена");
                    }
                });
            }
        }
    }
}
