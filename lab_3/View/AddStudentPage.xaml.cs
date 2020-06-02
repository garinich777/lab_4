using DevExpress.Mvvm;
using lab_3.VM;
using System.Windows.Controls;

namespace lab_3.View
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        public AddStudentPage(ViewModelBase VM, bool ModMod)
        {
            InitializeComponent();
            if (ModMod)
            {
                DataContext = (ModStudentVM)VM;
                bt_addmod.Content = "Изменить";                           
            }
            else
            {
                DataContext = (AddStudentVM)VM;
                bt_addmod.Content = "Добавить";
            }
        }
    }
}
