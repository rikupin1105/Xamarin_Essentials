using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Essentials.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationPage : ContentPage
    {
        public LocationPage()
        {
            InitializeComponent();
        }
        private double Latitude;
        private double Longitude;

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);
                if (location != null)
                {
                    Latitude = location.Latitude;
                    Longitude = location.Longitude;

                    labelLatitude.Text = $"緯度:{Latitude}";
                    labelLongitude.Text = $"経度:{Longitude}";
                    buttonOpenMap.IsVisible = true;
                }

            }
            catch (Exception)
            {

            }
        }
        private async void buttonOpenMap_Clicked(object sender, EventArgs e)
        {
            var location = new Location(Latitude, Longitude);
            await Map.OpenAsync(location);
        }
    }
}