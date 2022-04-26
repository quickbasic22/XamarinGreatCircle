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
    public partial class Radians_DD : ContentPage
    {
        XamarinGreatCircle.GreatCircle GreatCircle { get; set; }
        public Radians_DD()
        {
            InitializeComponent();
            GreatCircle = new XamarinGreatCircle.GreatCircle();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            double latdegrees = double.Parse(EntryLatRadians.Text);
            double resultlat = GreatCircle.Radians_Deg(latdegrees);
            double longdegrees = double.Parse(EntryLongRadians.Text);
            double resultlong = GreatCircle.Radians_Deg(longdegrees);
            EntryDegLat.Text = resultlat.ToString();
            EntryDegLong.Text = resultlong.ToString();
        }
    }
}