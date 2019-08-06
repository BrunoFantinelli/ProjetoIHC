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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        public async void MudarPaginaInicial(object sender, EventArgs args)
        {
            if (CampoLogin.Text == "Rafael" && CampoSenha.Text == "1234")
            {
                await Navigation.PushModalAsync(new PaginaPrincipal());
            }
            else if (CampoLogin.Text == "Bruno" && CampoSenha.Text == "1234")
            {
                await Navigation.PushModalAsync(new PaginaPrincipal());
            }
            else if (CampoLogin.Text == "Vitor" && CampoSenha.Text == "1234")
            {
                await Navigation.PushModalAsync(new PaginaPrincipal());
            }
            else
            {
                await DisplayAlert("Erro", "Usuário ou Senha incorretos", "OK");
            }
        }

        
	}
}