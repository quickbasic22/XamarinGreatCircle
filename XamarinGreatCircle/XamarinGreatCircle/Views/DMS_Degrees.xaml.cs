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
    public partial class DMS_Degrees : ContentPage
    {
        XamarinGreatCircle.GreatCircle gc;
        public DMS_Degrees()
        {
            InitializeComponent();
            gc = new XamarinGreatCircle.GreatCircle();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            double latDeg1 = double.Parse(LatDeg1.Text);
            double latMin1 = double.Parse(LatMin1.Text);
            double latSec1 = double.Parse(LatSec1.Text);
            double longDeg1 = double.Parse(LongDeg1.Text);
            double longMin1 = double.Parse(LongMin1.Text);
            double longSec1 = double.Parse(LongSec1.Text);
            double lat1result = gc.DMS_Degrees(latDeg1, latMin1, latSec1);
            double long1result = gc.DMS_Degrees(longDeg1, longMin1, longSec1);
            EntryLat.Text = $"latitude is {lat1result.ToString()}";
            EntryLong.Text = $"longitude is {long1result.ToString()}";

            Xamarin.Essentials.Clipboard.SetTextAsync(EntryLat.Text + " " + EntryLong.Text);
        }
    }
}