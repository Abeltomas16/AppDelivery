using AppDelivery.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.Material.Forms.UI;
using XF.Material.Forms.UI.Dialogs;

namespace AppDelivery
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(1500);
            var loading = await MaterialDialog.Instance.LoadingDialogAsync(message: "Carregando");
            await Task.Delay(2000); // Represents a task that is running.
            await loading.DismissAsync();
            await Navigation.PushAsync(new PageDois());
        }
    }
}
