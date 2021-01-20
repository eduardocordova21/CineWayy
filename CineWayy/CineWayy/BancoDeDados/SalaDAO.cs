using CineWayy.Interfaces;
using CineWayy.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineWayy.BancoDeDados
{
    class SalaDAO : AcessoAoBanco, IUsarBancoDeDados<SalaVO>
    {
        public void Atualizar(SalaVO obj)
        {
            AbrirConexao().Update(obj);
        }

        public void Cadastrar(SalaVO obj)
        {
            AbrirConexao().Insert(obj);
        }

        public List<SalaVO> Consultar()
        {
            return AbrirConexao().Table<SalaVO>().ToList();
        }

        public void Excluir(SalaVO obj)
        {
            AbrirConexao().Delete(obj);
        }

        public List<SalaVO> Pesquisar(string palavra)
        {
            return AbrirConexao().Table<SalaVO>().Where(s => s.Nome.Contains(palavra)).ToList();
        }

        public SalaVO PesquisarPorID(int ID)
        {
            return AbrirConexao().Table<SalaVO>().Where(s => s.ID == ID).FirstOrDefault();
        }
    }
}
