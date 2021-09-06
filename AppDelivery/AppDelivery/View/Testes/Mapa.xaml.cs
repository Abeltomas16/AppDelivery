using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.ExternalMaps;
using Plugin.Geolocator;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace AppDelivery.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mae : ContentPage
    {
        public Mae()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;
            var posicao = await locator.GetPositionAsync(timeout: TimeSpan.FromMilliseconds(10000));
            double latitude = posicao.Latitude;
            double longitude = posicao.Longitude;
            Pin pin = new Pin()
            {
                Type = PinType.Place,
                Label = "Cliente",
                Position = new Position(latitude, longitude),
            };
            meuMapa.Pins.Add(pin);
            meuMapa.MoveToRegion(MapSpan.FromCenterAndRadius(pin.Position, Distance.FromMeters(5000)));
        }

        private async void btnMostrarPosicaoNoMapa_Clicked(object sender, EventArgs e)
        {
           // lblGeolocalizacao.Text = "Obtendo a geolocalização....\n";
            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;
                TimeSpan time = TimeSpan.FromMilliseconds(10000);
             //   var position = await locator.GetPositionAsync(timeout: time);

               // lblGeolocalizacao.Text += "Status: " + position.Timestamp + "\n";
              // lblGeolocalizacao.Text += "Latitude: " + position.Latitude + "\n";
                //lblGeolocalizacao.Text += "Longitude: " + position.Longitude;
              //  latitude = position.Latitude;
               // longitude = position.Longitude;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro : ", ex.Message, "OK");
            }
        }

        private void btnGeolocalizacao_Clicked(object sender, EventArgs e)
        {
            try
            {
                // CrossExternalMaps.Current.NavigateTo("Abel", latitude, longitude);
                Pin pinPaulista = new Pin()
                {
                    Type = PinType.Place,
                    Label = "Paulista",
                    Address = "Malanje",
                 //   Position = new Position(latitude, longitude),
                    Tag = "id_malanje",
                };

                meuMapa.Pins.Add(pinPaulista);

                meuMapa.MoveToRegion(MapSpan.FromCenterAndRadius(pinPaulista.Position,
                    Distance.FromMeters(5000)));
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro : ", ex.Message, "OK");
            }
        }
    }
}