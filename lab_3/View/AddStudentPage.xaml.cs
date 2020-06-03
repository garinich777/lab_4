using DevExpress.Mvvm;
using lab_4.VM;
using System.Windows.Controls;

namespace lab_4.View
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
