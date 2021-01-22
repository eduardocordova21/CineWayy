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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private LoginViewModel GetViewModel() => (LoginViewModel)BindingContext;

        private void BotarCadastrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastrar());
        }

        private void BotaoEntrar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntradaDeLogin.Text) == false && string.IsNullOrWhiteSpace(EntradaDeSenha.Text) == false && GetViewModel().ValidarDadosDeLoginDoUsuario(EntradaDeLogin.Text, EntradaDeSenha.Text))
                Navigation.PushAsync(new Flyout(), true);
            else
                DisplayAlert("AVISO", "Credenciais incorretas, por favor, tente novamente.", "Fechar");
        }
    }
}