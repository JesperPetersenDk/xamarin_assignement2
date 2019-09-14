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
    public partial class Tracking : ContentPage
    {
        public Tracking()
        {
            InitializeComponent();

            Current.Text = $"CurrentBuild: {VersionTracking.CurrentBuild} - CurrentVersion: ({VersionTracking.CurrentVersion})";
            Previous.Text = (VersionTracking.PreviousBuild != null && VersionTracking.PreviousVersion != null) ? $"PreviousBuild: {VersionTracking.PreviousBuild} - PreviousVersion: ({VersionTracking.PreviousVersion})" : "Ingen Previous";
            firstVersion.Text = $"FirstInstalledBuild: {VersionTracking.FirstInstalledBuild} - FirstInstalledVersion: {VersionTracking.FirstInstalledVersion}";
        }
    }
}