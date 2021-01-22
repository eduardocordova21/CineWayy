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
        }

        public MenuLateralViewModel GetViewModel() => (MenuLateralViewModel)BindingContext;

        private void SetUsuarioLogado(string login)
        {
            GetViewModel().UsuarioLogado = login;
        }
    }
}