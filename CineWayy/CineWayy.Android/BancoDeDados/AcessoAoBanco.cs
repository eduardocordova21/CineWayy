using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CineWayy.Droid.BancoDeDados;
using CineWayy.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly:Dependency(typeof(AcessoAoBanco))]
namespace CineWayy.Droid.BancoDeDados
{
    public class AcessoAoBanco : IAcessoAoBanco
    {
        public string ObterCaminhoDoBancoDeDados(string NomeDoArquivoDoBancoDeDados)
        {
            string caminhoDaPastaDoBancoDeDados = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoDoBancoDeDados = Path.Combine(caminhoDaPastaDoBancoDeDados, NomeDoArquivoDoBancoDeDados);
            return caminhoDoBancoDeDados;
        }
    }
}