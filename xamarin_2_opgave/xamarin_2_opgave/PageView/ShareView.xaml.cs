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
    public partial class ShareView : ContentPage
    {
        public ShareView()
        {
            InitializeComponent();



            ShareText.Text = "Share mig";
        }

        private async void ShareText_Clicked(object sender, EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = Text.Text,
                Title = "Share Text"
            });
        }
    }
}