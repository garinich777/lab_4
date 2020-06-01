using lab_3.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_3.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainVM VM = new MainVM();
        public MainWindow()
        {
            InitializeComponent();
            dg_grades.ItemsSource = VM.Grades;
            dg_student.ItemsSource = VM.Student;
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
