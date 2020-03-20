using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoinWallet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            BotaoPerfil.Clicked += BotaoPerfilClicked;
            BotaoSaldo.Clicked += BotaoSaldoClicked;
            BotaoSair.Clicked += BotaoSairClicked;
        }

        public async void BotaoPerfilClicked(object o, EventArgs e)
        {
            await Navigation.PushAsync(new PerfilPage());
        }

        public async void BotaoSaldoClicked(object o, EventArgs e)
        {
            await Navigation.PushAsync(new SaldoPage());
        }

        public async void BotaoSairClicked(object o, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}