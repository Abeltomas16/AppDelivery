using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF.Material.Forms.UI.Dialogs;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms.UI;

namespace AppDelivery.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDois : ContentPage
    {
        public PageDois()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await MaterialDialog.Instance.AlertAsync(message: "Vou cadastrar-se",
                                                    title: "cadastro",
                                                    acknowledgementText: "Aceito");
        }

        private async void btnSObre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageAbout());
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new PageHome();
        }
    }
}