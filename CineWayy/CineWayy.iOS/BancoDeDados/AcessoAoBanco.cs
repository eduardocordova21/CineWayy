using CineWayy.Interfaces;
using CineWayy.iOS.BancoDeDados;
using Foundation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(AcessoAoBanco))]
namespace CineWayy.iOS.BancoDeDados
{
    public class AcessoAoBanco : IAcessoAoBanco
    {
        public string ObterCaminhoDoBancoDeDados(string NomeDoArquivoDoBancoDeDados)
        {
            string caminhoDaPastaDoBancoDeDados = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoDaBiblioteca = Path.Combine(caminhoDaPastaDoBancoDeDados, "..", "Library");
            string caminhoDoBancoDeDados = Path.Combine(caminhoDaBiblioteca, NomeDoArquivoDoBancoDeDados);
            return caminhoDoBancoDeDados;
        }
    }
}