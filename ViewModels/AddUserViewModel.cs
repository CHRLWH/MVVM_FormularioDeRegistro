using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpfMVVM_Prueba.Comandos;
using wpfMVVM_Prueba.Model;

namespace wpfMVVM_Prueba.ViewModels
{
    public class AddUserViewModel
    {
        public ICommand AddUserCommand { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }

        public AddUserViewModel()
        {
            AddUserCommand = new ConectorComando(AddUser, CanAddUser);

        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {
            UserManager.AddUsers(new User() { Nombre = Nombre, Email = Email });
        }
    }
}
