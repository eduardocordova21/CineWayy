using CineWayy.Enums;
using CineWayy.Modelos;
using CineWayy.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CineWayy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastrar : ContentPage
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private CadastrarViewModel GetViewModel() => (CadastrarViewModel)BindingContext;

        private void LimparCampos()
        {
            EntradaDeLogin.Text = string.Empty;
            EntradaDeSenha.Text = string.Empty;
            EntradaDeTipoDeUsuario.SelectedIndex = -1;
        }

        private void ListarUsuarios_Clicked(object sender, EventArgs e)
        {
            List<UsuarioVO> listaDeUsuariosCadastrados = GetViewModel().ConsultarUsuarios();

            foreach (var usuario in listaDeUsuariosCadastrados)
            {
                DisplayAlert("Usuários Cadastrados", usuario.Login + " | " + usuario.Senha, "OK"); 
            }
        }

        private void SalvarCadastro_Clicked(object sender, EventArgs e)
        {
            try
            {
                GetViewModel().SalvarUsuario(EntradaDeLogin.Text, EntradaDeSenha.Text, (TiposDeUsuarios)EntradaDeTipoDeUsuario.SelectedIndex);
                LimparCampos();
            }
            catch
            {
                DisplayAlert("ERRO", "Problema ao salvar o usuário, por favor, tente novamente.", "Fechar");
            }
        }
    }
}