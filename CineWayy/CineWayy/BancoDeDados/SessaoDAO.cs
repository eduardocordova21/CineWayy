using CineWayy.Interfaces;
using CineWayy.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineWayy.BancoDeDados
{
    class SessaoDAO : AcessoAoBanco, IUsarBancoDeDados<SessaoVO>
    {
        public void Atualizar(SessaoVO obj)
        {
            GetConexao().Update(obj);
        }

        public void Cadastrar(SessaoVO obj)
        {
            GetConexao().Insert(obj);
        }

        public List<SessaoVO> Consultar()
        {
            return GetConexao().Table<SessaoVO>().ToList();
        }

        public void Excluir(SessaoVO obj)
        {
            GetConexao().Delete(obj);
        }

        public List<SessaoVO> Pesquisar(string palavra)
        {
            return GetConexao().Table<SessaoVO>().Where(s => s.Date.ToShortDateString().Contains(palavra)).ToList();
        }

        public SessaoVO PesquisarPorID(int ID)
        {
            return GetConexao().Table<SessaoVO>().Where(s => s.ID == ID).FirstOrDefault();
        }
    }
}
