using DevExpress.Mvvm;
using lab_3.Model;
using lab_3.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace lab_3.VM
{
    public class MainVM : ViewModelBase
    {
        private Page ViewTablePage = new ViewTablePage();
        private Page AddStudentPage = new AddStudentPage();
        private Page AddGradesPage = new AddGradesPage();

        public Page CorentPage
        {
            get { return GetValue<Page>("CorentPage"); }
            set { SetValue(value, "CorentPage"); }
        }

        public MainVM()
        {
            CorentPage = ViewTablePage;
            Grades a  = (Grades)((ViewTablePage)ViewTablePage).dg_grades.SelectedItem;
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
                            CorentPage = AddStudentPage;
                            break;
                        case 1:
                            CorentPage = AddGradesPage;
                            break;
                        default:
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
    }
}
