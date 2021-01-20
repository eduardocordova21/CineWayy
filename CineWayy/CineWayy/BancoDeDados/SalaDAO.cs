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
            GetConexao().Update(obj);
        }

        public void Cadastrar(SalaVO obj)
        {
            GetConexao().Insert(obj);
        }

        public List<SalaVO> Consultar()
        {
            return GetConexao().Table<SalaVO>().ToList();
        }

        public void Excluir(SalaVO obj)
        {
            GetConexao().Delete(obj);
        }

        public List<SalaVO> Pesquisar(string palavra)
        {
            return GetConexao().Table<SalaVO>().Where(s => s.Nome.Contains(palavra)).ToList();
        }

        public SalaVO PesquisarPorID(int ID)
        {
            return GetConexao().Table<SalaVO>().Where(s => s.ID == ID).FirstOrDefault();
        }
    }
}
