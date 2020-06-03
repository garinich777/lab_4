using lab_4.VM;
using System.Windows.Controls;

namespace lab_4.View
{
    /// <summary>
    /// Логика взаимодействия для ViewTablePage.xaml
    /// </summary>
    public partial class ViewTablePage : Page
    {
        public ViewTableVM VM = new ViewTableVM();
        public ViewTablePage()
        {
            InitializeComponent();
            DataContext = VM;
        }
    }
}
