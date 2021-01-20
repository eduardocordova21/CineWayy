using CineWayy.BancoDeDados;
using CineWayy.Enums;
using CineWayy.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CineWayy.ViewModels
{
    class CadastrarViewModel : INotifyPropertyChanged
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();

        private string[] tiposDeUsuarios;

        public string[] TiposDeUsuarios
        {
            get { return Enum.GetNames(typeof(TiposDeUsuarios)); }
            set { tiposDeUsuarios = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        internal List<UsuarioVO> ConsultarUsuarios()
        {
            return usuarioDAO.Consultar();
        }

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        internal void SalvarUsuario(UsuarioVO novoUsuario)
        {
            usuarioDAO.Cadastrar(novoUsuario);
        }

        internal void SalvarUsuario(string login, string senha, TiposDeUsuarios tipoDeUsuario)
        {
            UsuarioVO novoUsuario = new UsuarioVO
            {
                Login = login,
                Senha = senha,
                TipoDeUsuario = tipoDeUsuario
            };

            usuarioDAO.Cadastrar(novoUsuario);
        }
    }
}
