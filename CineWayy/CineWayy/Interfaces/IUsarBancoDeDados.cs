using System.Collections.Generic;

namespace CineWayy.Interfaces
{
    public interface IUsarBancoDeDados<T>
    {
        void Atualizar(T obj);

        void Cadastrar(T obj);

        List<T> Consultar();

        void Excluir(T obj);

        List<T> Pesquisar(string palavra);

        T PesquisarPorID(int ID);
    }
}