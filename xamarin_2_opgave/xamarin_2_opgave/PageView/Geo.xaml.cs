using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Essentials;

namespace xamarin_2_opgave
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Geo : ContentPage
    {
        public Geo()
        {
            InitializeComponent();

            GeoText.Text = "Giv Geolocation";
            GeoTextOther.Text = "Giv Geo på Nansensgade 19";
        }

        private async void GeoText_Clicked(object sender, EventArgs e)
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            GeoTitle.Text = (location != null) ? $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}" : "Hov hov hov";
        }

        private async void GeoTextOther_Clicked(object sender, EventArgs e)
        {
            var address = "Nansensgade 19, 1366 København";
            var locations = await Geocoding.GetLocationsAsync(address);

            var location = locations?.FirstOrDefault();
            if (location != null)
            {
                GeoTitle.Text = $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}";
            }
        }
    }
}