using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinGreatCircle.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Deg_DMS : ContentPage
    {
        XamarinGreatCircle.GreatCircle GreatCircle { get; set; }
        public Deg_DMS()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Deg_DMS_ViewModel();
            GreatCircle = new XamarinGreatCircle.GreatCircle();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            double latdegrees = double.Parse(EntryLatDegrees.Text);
            string resultlat = GreatCircle.Deg_DMS(latdegrees);
            double longdegrees = double.Parse(EntryLongDegrees.Text);
            string resultlong = GreatCircle.Deg_DMS(longdegrees);
            EntryLat.Text = resultlat.ToString();
            EntryLong.Text = resultlong.ToString();

            Xamarin.Essentials.Clipboard.SetTextAsync(EntryLat.Text + " " + EntryLong.Text);
        }
        
        private void LocationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender as Picker;
            var location = (Model.LocationInfo)picker.SelectedItem;

            
            EntryLatDegrees.Text = location.Latitude.ToString();
            EntryLongDegrees.Text = location.Longitude.ToString();

            Calculate_Clicked(this, null);
        }

    }
}