using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : TabbedPage
    {
        public PaginaPrincipal ()
        {
            InitializeComponent();
        }

        public async void MudarTelaNovoItem(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AdicionarItem()));
        }

        public void novaDica(object sender, EventArgs args)
        {
            campoDica.Text = "Você compra jogos muito caros, tente encontrar uma loja com jogos mais baratos.";
        }
        public async void MudarTelaNovoConfig(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Config()));
        }
    }
}