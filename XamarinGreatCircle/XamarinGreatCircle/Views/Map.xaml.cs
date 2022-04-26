using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.ComponentModel;

namespace XamarinGreatCircle.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class Map : ContentPage
    {
        
        public Map()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MapViewModel();
        }

        private async void ButtonOpenCoords_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(EntryLatitude.Text, out double lat))
                return;
            if (!double.TryParse(EntryLongitude.Text, out double lng))
                return;

           double MilesinMeters = Xamarin.Essentials.UnitConverters.MilesToMeters(2000.0);

            Location Eustis = new Location(lat, lng, MilesinMeters);
            
            await Xamarin.Essentials.Map.OpenAsync(Eustis, new MapLaunchOptions
            {
                Name = EntryName.Text,
                NavigationMode = NavigationMode.None
            });
        }
    }
}