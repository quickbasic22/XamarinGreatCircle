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
    public partial class Deg_DMS : ContentPage
    {
        XamarinGreatCircle.GreatCircle GreatCircle { get; set; }
        public Deg_DMS()
        {
            InitializeComponent();
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
        }
    }
}