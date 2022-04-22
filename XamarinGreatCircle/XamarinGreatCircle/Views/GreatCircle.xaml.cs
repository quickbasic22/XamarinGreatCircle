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
    }
}