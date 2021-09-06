using AppDelivery.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms.Dialogs;
using XF.Material.Forms.Models;
using XF.Material.Forms.UI;
using XF.Material.Forms.UI.Dialogs;

namespace AppDelivery.View.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageUsuarioHome : ContentPage
    {

        public PageUsuarioHome()
        {
            InitializeComponent();
            Produt produt = new Produt();
            collectionProdutos.BindingContext = produt;
            collectionProdutoss.BindingContext = produt;

            List<string> nomes = new List<string>()
            {
                "Abel",
                "Joao"
            };
            mm.Choices = nomes;
          

        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            //await  DisplayAlert("teste",(sender as MaterialButton).Parent.GetType().Name,"ok");
            //(sender as MaterialButton).IsVisible = false;
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await MaterialDialog.Instance.SnackbarAsync("Produto adicionado ao carrinho",
                                                                 msDuration: MaterialSnackbar.DurationShort,
                                                                 actionButtonText: "Ok");
        }
    }
}