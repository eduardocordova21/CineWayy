using CineWayy.BancoDeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CineWayy.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        MenuLateralViewModel menuLateralViewModel;

        internal bool ValidarDadosDeLoginDoUsuario(string login, string senha)
        {
            if(usuarioDAO.ValidarDadosDeLoginDoUsuario(login, senha))
                return true;

            return false;
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
