using DevExpress.Mvvm;
using lab_3.Model;
using lab_3.View;
using System.Windows.Controls;
using System.Windows.Input;

namespace lab_3.VM
{
    public class MainVM : ViewModelBase
    {
        private Page ViewTablePage = new ViewTablePage();
        private Page AddStudentPage;
        private Page AddGradesPage;

        public Page CorentPage
        {
            get { return GetValue<Page>("CorentPage"); }
            set { SetValue(value, "CorentPage"); }
        }

        public MainVM()
        {
            CorentPage = ViewTablePage;            
        }

        public ICommand AddPageClick
        {
            get 
            {
                return new DelegateCommand(() =>
                {
                    int selected_index = ((ViewTablePage)ViewTablePage).tc_tabs.SelectedIndex;
                    switch (selected_index)
                    {
                        case 0:
                            AddStudentPage = new AddStudentPage(new AddStudentVM(), false);
                            CorentPage = AddStudentPage;
                            break;
                        case 1:
                            AddGradesPage = new AddGradesPage(new AddGradesVM(), false);
                            CorentPage = AddGradesPage;
                            break;
                        default:
                            break;
                    }
                });
            }
        }

        public ICommand ModPageClick
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    int selected_index = ((ViewTablePage)ViewTablePage).tc_tabs.SelectedIndex;
                    switch (selected_index)
                    {
                        case 0:
                            Student student = (Student)((ViewTablePage)ViewTablePage).dg_student.SelectedItem;
                            AddStudentPage = new AddStudentPage(new ModStudentVM(student), true);
                            CorentPage = AddStudentPage;
                            break;
                        case 1:
                            Grades grades = (Grades)((ViewTablePage)ViewTablePage).dg_grades.SelectedItem;
                            AddGradesPage = new AddGradesPage(new ModGradesVM(grades), true);
                            CorentPage = AddGradesPage;
                            break;
                    }
                });
            }
        }

        public ICommand ViewPageClick
        {
            get { return new DelegateCommand(() =>
            {
                ViewTablePage = new ViewTablePage();
                CorentPage = ViewTablePage;
            }); }
        }

        public ICommand DeleatClick
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (CorentPage != ViewTablePage)
                        return;
                    int selected_index = ((ViewTablePage)ViewTablePage).tc_tabs.SelectedIndex;
                    switch (selected_index)
                    {
                        case 0:
                            using (var context = new UserDbContext())
                            {
                                if (((ViewTablePage)ViewTablePage).dg_student.SelectedItem == null)
                                    return;
                                Student student = context.Students.Find(((Student)((ViewTablePage)ViewTablePage).dg_student.SelectedItem).Id);
                                context.Students.Remove(student);
                                context.SaveChanges();
                            }
                            break;
                        case 1:
                            using (var context = new UserDbContext())
                            {
                                if (((ViewTablePage)ViewTablePage).dg_grades.SelectedItem == null)
                                    return;
                                Grades grades = context.Grades.Find(((Grades)((ViewTablePage)ViewTablePage).dg_grades.SelectedItem).Id);
                                context.Grades.Remove(grades);
                                context.SaveChanges();
                            }
                            break;
                    }
                    ViewTablePage = new ViewTablePage();
                    CorentPage = ViewTablePage;
                    ((ViewTablePage)CorentPage).tc_tabs.SelectedIndex = selected_index;

                });
            }
        }
    }
}
