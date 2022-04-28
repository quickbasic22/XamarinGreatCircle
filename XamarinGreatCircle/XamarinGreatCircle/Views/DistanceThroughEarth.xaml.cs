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
    public partial class DistanceThroughEarth : ContentPage
    {
        XamarinGreatCircle.GreatCircle gc;
        public DistanceThroughEarth()
        {
            InitializeComponent();
            gc = new XamarinGreatCircle.GreatCircle();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            ResultDistance.Text = gc.GetDistantThroughEarth(double.Parse(LatDegrees1.Text), double.Parse(LongDegrees1.Text), double.Parse(LatDegrees2.Text), double.Parse(LongDegrees2.Text)).ToString();

        }
    }
}