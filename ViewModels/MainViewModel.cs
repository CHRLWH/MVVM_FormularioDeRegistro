using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using wpfMVVM_Prueba.Comandos;
using wpfMVVM_Prueba.Model;
using wpfMVVM_Prueba.Views;

namespace wpfMVVM_Prueba.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsuarios();
            ShowWindowCommand = new ConectorComando(ShowWindow, CanSowWindow);

        }

        private bool CanSowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;

            AddUser addUserWin = new AddUser();
            addUserWin.Owner = mainWindow;
            addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWin.Show();
        }
    }
}
