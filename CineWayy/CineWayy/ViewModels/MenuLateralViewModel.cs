using CineWayy.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CineWayy.ViewModels
{
    public class MenuLateralViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MenuLateralVO> ListaIconesDosMenus { get; set; } = new ObservableCollection<MenuLateralVO>
        {
            new MenuLateralVO
            {
                NomeDoMenu = "Gerenciar Filmes",
                CaminhoCompletoDoIcone = "CineWayy.Icones.iconeGerenciarFilmes.png"
            },

            new MenuLateralVO
            {
                NomeDoMenu = "Gerenciar Sessões",
                CaminhoCompletoDoIcone = "CineWayy.Icones.iconeGerenciarSessoes.png"
            },

            new MenuLateralVO
            {
                NomeDoMenu = "Lista de Salas",
                CaminhoCompletoDoIcone = "CineWayy.Icones.iconeListaDeSalas.png"
            },
        };


        private string usuarioLogado;

        public string UsuarioLogado
        {
            get { return usuarioLogado; }
            set { usuarioLogado = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
