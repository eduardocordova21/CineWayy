using Xamarin.Forms;

namespace CineWayy.Modelos
{
    public class MenuLateralVO : FlyoutPage
    {
        public string NomeDoMenu { get; set; }

        public string CaminhoCompletoDoIcone { get; set; }

        public string DescricaoDoMenu { get; set; }

        public Page NavegarPara { get; set; }
    }
}