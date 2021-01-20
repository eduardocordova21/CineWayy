using CineWayy.Interfaces;
using CineWayy.Modelos;
using System;
using System.Collections.Generic;

namespace CineWayy.BancoDeDados
{
    public class FilmeDAO : AcessoAoBanco, IUsarBancoDeDados<FilmeVO>
    {
        public void Atualizar(FilmeVO obj)
        {
            GetConexao().Update(obj);
        }

        public void Cadastrar(FilmeVO obj)
        {
            GetConexao().Insert(obj);
        }

        public List<FilmeVO> Consultar()
        {
            return GetConexao().Table<FilmeVO>().ToList();
        }

        public void Excluir(FilmeVO obj)
        {
            GetConexao().Delete(obj);
        }

        public List<FilmeVO> Pesquisar(string palavra)
        {
            return GetConexao().Table<FilmeVO>().Where(f => f.Titulo.Contains(palavra)).ToList();
        }

        public FilmeVO PesquisarPorID(int ID)
        {
            return GetConexao().Table<FilmeVO>().Where(f => f.ID == ID).FirstOrDefault();
        }
    }
}