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
    public partial class DegreesToRadians : ContentPage
    {
        XamarinGreatCircle.GreatCircle gc;
        public DegreesToRadians()
        {
            InitializeComponent();
            gc = new XamarinGreatCircle.GreatCircle();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            double lat1 = double.Parse(LatRadians1.Text);
            double lon1 = double.Parse(LongRadians1.Text);
            double lat2 = double.Parse(LatRadians2.Text);
            double long2 = double.Parse(LongRadians2.Text);
            double lat1result = gc.Deg_Radians(lat1);
            double lon1result = gc.Deg_Radians(lon1);
            double lat2result = gc.Deg_Radians(lat2);
            double long2result = gc.Deg_Radians(long2);
            LatRadians1.Text = lat1result.ToString();
            LongRadians1.Text = long2result.ToString();
            LatRadians2.Text = lat2result.ToString();
            LongRadians2.Text = long2result.ToString();
        }

    }
}