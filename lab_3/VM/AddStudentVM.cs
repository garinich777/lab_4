using DevExpress.Mvvm;
using lab_3.Model;
using System.Windows;
using System.Windows.Input;

namespace lab_3.VM
{
    public class AddStudentVM : ViewModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupNum { get; set; }
        public string TrainingFormat { get; set; }
        public int Grant { get; set; }
        public int CostEducation { get; set; }

        public ICommand AddStudent
        {
            get
            {
                return new DelegateCommand(() =>
                {                    
                    Student new_student = new Student()
                    {
                        FirstName = FirstName,
                        LastName = LastName, 
                        GroupNum = GroupNum, 
                        TrainingFormat = TrainingFormat,
                        Grant = Grant, 
                        CostEducation = CostEducation
                    };

                    using (var context = new UserDbContext())
                    {                        
                        context.Students.Add(new_student);
                        context.SaveChanges();
                        MessageBox.Show("Добавлено");
                    }
                });
            }               
        }
    }
}
