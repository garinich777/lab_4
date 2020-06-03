using lab_4.VM;
using System.Windows;

namespace lab_4.View
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
            DataContext = VM;
        }
    }
}
