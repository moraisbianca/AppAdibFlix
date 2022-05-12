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
    public partial class Fantasia : ContentPage
    {
        public Fantasia()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppAdibFlix.Posters.logonetflix.png");
        }
    }
}