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
            Routing .RegisterRoute(nameof(DMS_Degrees), typeof(DMS_Degrees));
            Routing.RegisterRoute(nameof(Deg_DMS), typeof(Deg_DMS));
            Routing.RegisterRoute(nameof(Radians_DD), typeof(Radians_DD));
            Routing.RegisterRoute(nameof(ViewableMileage_AtHeight), typeof(ViewableMileage_AtHeight));
            Routing.RegisterRoute(nameof(DistanceThroughEarth), typeof(DistanceThroughEarth));

        }

    }
}
