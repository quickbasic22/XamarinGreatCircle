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
    public partial class AntiPodalLocation : ContentPage
    {
        XamarinGreatCircle.GreatCircle GreatCircle { get; set; }
        public AntiPodalLocation()
        {
            InitializeComponent();
            GreatCircle = new XamarinGreatCircle.GreatCircle();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            double latdeg1 = double.Parse(LatDeg1.Text);
            double latmin1 = double.Parse(LatMin1.Text);
            double latsec1 = double.Parse(LatSec1.Text);
            double longdeg2 = double.Parse(LongDeg2.Text);
            double longmin2 = double.Parse(LongMin2.Text);
            double longsec2 = double.Parse(LongSec2.Text);

            double[] result = GreatCircle.Get_AntiPodal(latdeg1, latmin1, latsec1, longdeg2, longmin2, longsec2);
            AntipodalLat.Text = String.Format("Latitude {0}", result[0].ToString());
            AntipodalLong.Text = String.Format("Longitude {0}", result[1].ToString());
            double resultlat = result[0];
            double resultlong = result[1];


            Shell.Current.GoToAsync($"{nameof(Map)}?{nameof(ViewModels.MapViewModel.CoorLat)}={resultlat}&{nameof(ViewModels.MapViewModel.CoorLong)}={resultlong}");
            


        }
    }
}