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
    }
}