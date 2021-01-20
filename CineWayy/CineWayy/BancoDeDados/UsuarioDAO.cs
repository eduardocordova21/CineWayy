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
            GetConexao().Update(obj);
        }

        public void Cadastrar(UsuarioVO obj)
        {
            GetConexao().Insert(obj);
        }

        public List<UsuarioVO> Consultar()
        {
            return GetConexao().Table<UsuarioVO>().ToList();
        }

        public void Excluir(UsuarioVO obj)
        {
            GetConexao().Delete(obj);
        }

        public List<UsuarioVO> Pesquisar(string palavra)
        {
            return GetConexao().Table<UsuarioVO>().Where(u => u.Login.Contains(palavra)).ToList();
        }

        public UsuarioVO PesquisarPorID(int ID)
        {
            return GetConexao().Table<UsuarioVO>().Where(u => u.ID == ID).FirstOrDefault();
        }
    }
}
