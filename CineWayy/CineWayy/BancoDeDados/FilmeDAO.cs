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
            AbrirConexao().Update(obj);
        }

        public void Cadastrar(FilmeVO obj)
        {
            AbrirConexao().Insert(obj);
        }

        public List<FilmeVO> Consultar()
        {
            return AbrirConexao().Table<FilmeVO>().ToList();
        }

        public void Excluir(FilmeVO obj)
        {
            AbrirConexao().Delete(obj);
        }

        public List<FilmeVO> Pesquisar(string palavra)
        {
            return AbrirConexao().Table<FilmeVO>().Where(f => f.Titulo.Contains(palavra)).ToList();
        }

        public FilmeVO PesquisarPorID(int ID)
        {
            return AbrirConexao().Table<FilmeVO>().Where(f => f.ID == ID).FirstOrDefault();
        }
    }
}