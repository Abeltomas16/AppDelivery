using AppDelivery.View;
using AppDelivery.View.Testes;
using Plugin.LocalNotification;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms;
using XF.Material.Forms.UI;

using Newtonsoft.Json;

namespace AppDelivery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
             Material.Init(this);
             MainPage = new MaterialNavigationPage(new MainPage());
            //MainPage = new NavigationPage(new Graficos())
            //{
            //    BarBackgroundColor = Color.FromHex("#7dbbe6"),
            //    BarTextColor = Color.White
            //};
        }



        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
