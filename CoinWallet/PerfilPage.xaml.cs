using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoinWallet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerfilPage : ContentPage
    {
        public PerfilPage()
        {
            InitializeComponent();
            BotaoVoltar.Clicked += BotaoVoltarClicked;
            BotaoSair.Clicked += BotaoSairClicked;
        }

        public async void BotaoVoltarClicked(object o, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        public async void BotaoSairClicked(object o, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}