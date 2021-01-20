using System;
using System.Collections.Generic;
using System.Text;
using CineWayy.Interfaces;
using CineWayy.Modelos;
using SQLite;
using Xamarin.Forms;

namespace CineWayy.BancoDeDados
{
    public class AcessoAoBanco
    {
        private SQLiteConnection _conexao;

        public AcessoAoBanco()
        {
            var dependencyService = DependencyService.Get<IAcessoAoBanco>();
            string caminhoParaOBancoDeDados = dependencyService.ObterCaminhoDoBancoDeDados("CineWayyDatabase.sqlite");
            _conexao = new SQLiteConnection(caminhoParaOBancoDeDados);
            _conexao.CreateTable<UsuarioVO>();
            _conexao.CreateTable<FilmeVO>();
            _conexao.CreateTable<SalaVO>();
            _conexao.CreateTable<SessaoVO>();
        }

        public SQLiteConnection AbrirConexao()
        {
            return _conexao;
        }

        public void FecharConexao()
        {
            _conexao.Close();
        }
    }
}
