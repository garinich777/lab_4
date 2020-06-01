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
    /// Логика взаимодействия для AddGradesPage.xaml
    /// </summary>
    public partial class AddGradesPage : Page
    {
        AddGradesVM AddGradesVM = new AddGradesVM();
        public AddGradesPage()
        {
            InitializeComponent();
            DataContext = AddGradesVM;
        }
    }
}
