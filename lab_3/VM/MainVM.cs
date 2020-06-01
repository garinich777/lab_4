using DevExpress.Mvvm;
using lab_3.Model;
using lab_3.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
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
            get { return new DelegateCommand(() => CorentPage = AddStudentPage); }
        }

        public ICommand ViewPageClick
        {
            get { return new DelegateCommand(() => CorentPage = ViewTablePage); }
        }
    }
}
