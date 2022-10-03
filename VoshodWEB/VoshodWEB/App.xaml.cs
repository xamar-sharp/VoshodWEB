using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VoshodWEB.Dependencies;
namespace VoshodWEB
{
    public partial class App : Application
    {
        public App()
        {
            Resource.Culture = DependencyService.Get<IPlatformInfo>().PlatformCulture;
            InitializeComponent();
            MainPage = new NavigationPage(new TracksPage()) { BarBackgroundColor = Color.Purple };
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
