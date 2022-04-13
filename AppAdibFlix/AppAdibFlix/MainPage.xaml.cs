using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAdibFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAventura_Clicked(object sender, EventArgs e)
        {
            try // "Vai tentar rodar o código abaixo" 
            {
                await Navigation.PushAsync(new Categorias.Aventura()); // navegar para a página da categoria aventura

            } catch(Exception ex) // "Caso haja alguma excessão (erro)"
            {
                await DisplayAlert("Ops", ex.Message, "OK"); // "ex.Message" mostra a mensagem de erro
            }
        }

        private async void btnComedia_Clicked(object sender, EventArgs e)
        {
            try 
            {
                await Navigation.PushAsync(new Categorias.Comedia());
            } catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
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
                await DisplayAlert("Ops", ex.Message, "OK");
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
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
