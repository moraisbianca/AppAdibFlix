using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAdibFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TheBatman : ContentPage
    {
        private object sinopse;

        public TheBatman()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppAdibFlix.Posters.logonetflix.png");
            poster.Source = ImageSource.FromResource("AppAdibFlix.Img.thebatman.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width = '560' height = '315' 
                                        src = 'https://www.youtube.com/embed/rsQEor4y2hg' 
                                        title = 'YouTube video player'
                                        frameborder = '0' 
                                        allow = 'accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; ' +
                                               'picture-in-picture' 
                                       allowfullscreen>
                                </iframe>";

            visualizador.Source = htmlSource;

            sinopse = "Após dois anos espreitando as ruas como Batman, Bruce Wayne se encontra nas profundezas mais sombrias de Gotham City. Com poucos aliados confiáveis, o vigilante solitário se estabelece como apersonificação da vingança para a população";
        }
    }
}