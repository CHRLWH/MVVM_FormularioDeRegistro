using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfMVVM_Prueba.Model
{
    class UserManager
    {
        public static ObservableCollection<User> _UsuarioDeLaBaseDeDatos { get; set; } = new ObservableCollection<User>() { new User() { Email = "prueba@mail.com", Nombre = "Nombre" }, new User() { Email = "prueba2@mail.com", Nombre = "Nombre" } };

        public static ObservableCollection<User> GetUsuarios()
        {
            return _UsuarioDeLaBaseDeDatos;

        }

        public static void AddUsers(User usuario)
        {
            _UsuarioDeLaBaseDeDatos.Add(usuario);

        }

    }
}
