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
            AbrirConexao().Update(obj);
        }

        public void Cadastrar(SessaoVO obj)
        {
            AbrirConexao().Insert(obj);
        }

        public List<SessaoVO> Consultar()
        {
            return AbrirConexao().Table<SessaoVO>().ToList();
        }

        public void Excluir(SessaoVO obj)
        {
            AbrirConexao().Delete(obj);
        }

        public List<SessaoVO> Pesquisar(string palavra)
        {
            return AbrirConexao().Table<SessaoVO>().Where(s => s.Date.ToShortDateString().Contains(palavra)).ToList();
        }

        public SessaoVO PesquisarPorID(int ID)
        {
            return AbrirConexao().Table<SessaoVO>().Where(s => s.ID == ID).FirstOrDefault();
        }
    }
}
