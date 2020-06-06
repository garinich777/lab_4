using lab_4.VM;
using System.Windows;

namespace lab_4.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainVM VM;
        public MainWindow()
        {
            try
            {
                VM = new MainVM();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                Close();
            }
            InitializeComponent();
            DataContext = VM;
        }
    }
}
