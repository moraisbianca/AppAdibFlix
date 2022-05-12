using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAdibFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Acao : ContentPage
    {
        public Acao()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppAdibFlix.Posters.logonetflix.png");

            Batman.Source = ImageSource.FromResource("AppAdibFlix.Img.thebatman.jpg");
            DrEstranho.Source = ImageSource.FromResource("AppAdibFlix.Img.doutorestranho.jpg");
            AnimaisFantasticos.Source = ImageSource.FromResource("AppAdibFlix.Img.animaisfantasticos.jpg");
            Duna.Source = ImageSource.FromResource("AppAdibFlix.Img.dunaaventura.jpg");
            Eternos.Source = ImageSource.FromResource("AppAdibFlix.Img.eternosaventura.jpg");
            Uncharted.Source = ImageSource.FromResource("AppAdibFlix.Img.unchartedaventura.jpg");
        }

        private async void Batman_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.TheBatman());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }

        private async void DrEstranho_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.DoutorEstranho());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }

        private async void AnimaisFantasticos_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.AnimaisFantasticos());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }

        private async void Duna_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Duna());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }

        private async void Eternos_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Eternos());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }

        private async void Uncharted_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Uncharted());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }
    }
}