using CineWayy.Modelos;
using CineWayy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineWayy.BancoDeDados
{
    class UsuarioDAO : AcessoAoBanco, IUsarBancoDeDados<UsuarioVO>
    {
        public void Atualizar(UsuarioVO obj)
        {
            AbrirConexao().Update(obj);
        }

        public void Cadastrar(UsuarioVO obj)
        {
            AbrirConexao().Insert(obj);
        }

        internal bool ValidarDadosDeLoginDoUsuario(string login, string senha)
        {
            var usuario = AbrirConexao().Table<UsuarioVO>().Where(u => u.Login == login).Where(u => u.Senha == senha).FirstOrDefault();

            if (usuario != null)
                return true;

            return false;
        }

        internal bool ValidarSenhaDoUsuario(string senha)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioVO> Consultar()
        {
            return AbrirConexao().Table<UsuarioVO>().ToList();
        }

        public void Excluir(UsuarioVO obj)
        {
            AbrirConexao().Delete(obj);
        }

        public List<UsuarioVO> Pesquisar(string palavra)
        {
            return AbrirConexao().Table<UsuarioVO>().Where(u => u.Login.Contains(palavra)).ToList();
        }

        public UsuarioVO PesquisarPorID(int ID)
        {
            return AbrirConexao().Table<UsuarioVO>().Where(u => u.ID == ID).FirstOrDefault();
        }
    }
}
