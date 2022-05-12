using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppAdibFlix.Categorias;

namespace AppAdibFlix
{
    //categorias: aventura, acao, drama, comedia, fantasia, ficcao, terror, suspense
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppAdibFlix.Posters.logonetflix.png");
        }

        private async void btnAventura_Clicked(object sender, EventArgs e)
        {
            try // "Vai tentar rodar o código abaixo" 
            {
                await Navigation.PushAsync(new Categorias.Aventura()); // navegar para a página da categoria aventura

            } catch(Exception ex) // "Caso haja alguma excessão (erro)"
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK"); // "ex.Message" mostra a mensagem de erro
            }
        }

        private async void btnAcao_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Acao());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }

        private async void btnDrama_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Drama());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }

        private async void btnComedia_Clicked(object sender, EventArgs e)
        {
            try 
            {
                await Navigation.PushAsync(new Categorias.Comedia());
            } catch(Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }

        private async void btnFantasia_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Fantasia());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }

        private async void btnFiccao_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Ficcao());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }
        private async void btnTerror_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Terror());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }

        private async void btnSuspense_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Suspense());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, algo deu errado :(", ex.Message, "OK");
            }
        }
    }
}
