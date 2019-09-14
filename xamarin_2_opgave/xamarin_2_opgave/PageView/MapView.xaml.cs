using Android.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_2_opgave
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapView : ContentPage
    {
        public MapView()
        {
            InitializeComponent();

            Find_vej.Text = "Find vej nu!";
        }

        private async void Find_vej_Clicked(object sender, EventArgs e)
        {
            var Placemark = new Placemark
            {
                Thoroughfare = PlacemarkText.Text
            };
            NavigationMode NavMode = GetNavmode();

            var options = new MapLaunchOptions { NavigationMode = NavMode };

            await Map.OpenAsync(Placemark, options);
        }

        private NavigationMode GetNavmode()
        {
            string typeText = TypeText.Text.ToLower();
            var NavMode = NavigationMode.None;
            switch (typeText)
            {
                case "gå":
                    NavMode = NavigationMode.Walking;
                    break;
                case "bil":
                    NavMode = NavigationMode.Driving;
                    break;
            }

            return NavMode;
        }
    }
}