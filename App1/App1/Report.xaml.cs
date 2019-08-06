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
	public partial class Report : ContentPage
	{
		public Report ()
		{
			InitializeComponent ();
		}

        public async void voltar(object sender, EventArgs args)
        {
           await Navigation.PopModalAsync();
        }

        public async void enviar(object sender, EventArgs args)
        {
            entrada.Text = "";
            await DisplayAlert("Mensagem Enviada", "Sua mensagem foi recebida com sucesso. Muito obrigado pela sua ajuda =).", "Ok");
        }

	}
}