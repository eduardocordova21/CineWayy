using CineWayy.Modelos;
using CineWayy.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CineWayy.ViewModels
{
    public class MenuLateralViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MenuLateralVO> ListaDeMenuLateral { get; set; } = new ObservableCollection<MenuLateralVO>
        {
            new MenuLateralVO
            {
                NomeDoMenu = "Gerenciar Filmes",
                CaminhoCompletoDoIcone = "CineWayy.Icones.iconeGerenciarFilmes.png",
                DescricaoDoMenu = "Cadastrar, Editar e Remover",
                NavegarPara = new GerenciarFilmes()
            },

            new MenuLateralVO
            {
                NomeDoMenu = "Gerenciar Sessões",
                CaminhoCompletoDoIcone = "CineWayy.Icones.iconeGerenciarSessoes.png",
                DescricaoDoMenu = "Visualizar",
                NavegarPara = new GerenciarSessoes()
            },

            new MenuLateralVO
            {
                NomeDoMenu = "Lista de Salas",
                CaminhoCompletoDoIcone = "CineWayy.Icones.iconeListaDeSalas.png",
                DescricaoDoMenu = "Cadastrar e Remover",
                NavegarPara = new ListaDeSalas()
            },
        };

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
