using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;
using XamarinGreatCircle.Views;
using Xamarin.Essentials;

namespace XamarinGreatCircle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Xamarin.Essentials.VersionTracking.Track();
            MainPage = new AppShell();
            AppActions.OnAppAction += AppActions_OnAppAction;
           
        }

        private void AppActions_OnAppAction(object sender, AppActionEventArgs e)
        {
           if (Application.Current != this && Application.Current is App app)
            {
                AppActions.OnAppAction -= app.AppActions_OnAppAction;
                return;
            }
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                if (e.AppAction.Id == "GreatCircle_info")
                    await Shell.Current.GoToAsync("//" + nameof(GreatCircle));
                else if (e.AppAction.Id == "Degrees_ToRadians")
                    await Shell.Current.GoToAsync("//" + nameof(DegreesToRadians));
                else if (e.AppAction.Id == "Antipodal")
                    await Shell.Current.GoToAsync("//" + nameof(AntiPodalLocation));
            });
        }

        protected async override void OnStart()
        {
            try
            {
                await AppActions.SetAsync(
                    new AppAction("GreatCircle_info", "Great Circle Info", icon: "icon_about"),
                new AppAction("Degrees_ToRadians", "Degrees To Radians", icon: "icon_about"),
                    new AppAction("Antipodal", "Antipodal Location", icon: "icon_feed")
                    );
            }
            catch (Exception ex)
            {
                
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

    }
}
