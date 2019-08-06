using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void MudarTelaLoginApp(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Login());
        }

        public async void MudarTelaCadastro(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Cadastro());
        }
    }
}
