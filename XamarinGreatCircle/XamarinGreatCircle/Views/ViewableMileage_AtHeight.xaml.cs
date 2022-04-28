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
    public partial class ViewableMileage_AtHeight : ContentPage
    {
        XamarinGreatCircle.GreatCircle gc;
        public ViewableMileage_AtHeight()
        {
            InitializeComponent();
            gc = new XamarinGreatCircle.GreatCircle();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            ResultsLabel.Text = gc.ViewableMileage_AtHeight(double.Parse(HeightInFeet.Text));
        }
    }
}