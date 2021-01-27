using CineWayy.Modelos;
using CineWayy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CineWayy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : ContentPage
    {
        public MenuLateral()
        {
            InitializeComponent();
            listaDeMenus.ItemSelected += NavegarParaOMenuSelecionado;
        }

        private void NavegarParaOMenuSelecionado(object sender, SelectedItemChangedEventArgs e)
        {
            var menuLateral = e.SelectedItem as MenuLateralVO;

            if (menuLateral != null)
            {
                menuLateral.Detail = new NavigationPage((Page)Activator.CreateInstance(menuLateral.NavegarPara.GetType()));
                listaDeMenus.SelectedItem = null;
                menuLateral.IsPresented = false;
            }

            Navigation.PushAsync(menuLateral.NavegarPara, true);
        }

        public MenuLateralViewModel GetViewModel() => (MenuLateralViewModel)BindingContext;
    }
}