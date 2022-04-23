using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinGreatCircle.Views;

namespace XamarinGreatCircle
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GreatCircle), typeof(GreatCircle));
            Routing.RegisterRoute(nameof(DegreesToRadians), typeof(DegreesToRadians));
            Routing.RegisterRoute(nameof(AntiPodalLocation), typeof(AntiPodalLocation));
            Routing.RegisterRoute(nameof(Map), typeof(Map));

        }

    }
}
