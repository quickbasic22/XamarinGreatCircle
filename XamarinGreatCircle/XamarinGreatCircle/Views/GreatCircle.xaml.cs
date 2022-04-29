using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinGreatCircle.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreatCircle : ContentPage
    {
        XamarinGreatCircle.GreatCircle gc;
        public GreatCircle()
        {
            InitializeComponent();
            BindingContext = new ViewModels.GreatCircleViewModel();
            gc = new XamarinGreatCircle.GreatCircle();
            
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            double lat = double.Parse(Latitude1.Text);
            double lon = double.Parse(Longitude1.Text);
            double lat2 = double.Parse(Latitude2.Text);
            double lon2 = double.Parse(Longitude2.Text);
            double result = gc.GreatCircle_Calculation(lat, lon, lat2, lon2);
            Result.Text = result.ToString();
        }

        private void LocationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var picker = (Picker)sender;
            var location = (Model.LocationInfo)picker.SelectedItem;
            if (Latitude1.Text == "")
            {
                Latitude1.Text = location.Latitude.ToString();
                Longitude1.Text = location.Longitude.ToString();
                Location1.Text = location.Name;
            }
            else
            {
                Latitude2.Text = location.Latitude.ToString();
                Longitude2.Text = location.Longitude.ToString();
                Location2.Text = location.Name;
            } 
        }

        private void ClearTextButton_Clicked(object sender, EventArgs e)
        {
            Latitude1.Text = "";
            Longitude1.Text = "";
            Latitude2.Text = "";
            Longitude2.Text = "";
            Location1.Text = "";
            Location2.Text = "";
        }
    }
}