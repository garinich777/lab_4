﻿using DevExpress.Mvvm;
using lab_4.VM;
using System.Windows.Controls;

namespace lab_4.View
{
    /// <summary>
    /// Логика взаимодействия для AddGradesPage.xaml
    /// </summary>
    public partial class AddGradesPage : Page
    {
        public AddGradesPage(ViewModelBase VM, bool ModMod)
        {
            InitializeComponent();
            if (ModMod)
            {
                DataContext = (ModGradesVM)VM;
                bt_addmod.Content = "Изменить";
            }
            else
            {
                DataContext = (AddGradesVM)VM;
                bt_addmod.Content = "Добавить";
            }
        }
    }
}
