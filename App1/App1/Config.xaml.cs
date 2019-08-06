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
	public partial class Config : ContentPage
	{
		public Config ()
		{
			InitializeComponent ();
		}

        public async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Aviso", "Deseja realmente sair da conta?", "Não", "Sim");
            if(answer == false)
            {
                await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
            }
        }

        public async void irReport(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Report()));
        }

        public async void voltarTela(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}