using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace VoshodWEB.Droid
{
    [Activity(Label = "Voshod",Icon ="@drawable/icon",MainLauncher =true,NoHistory=true,Theme ="@style/SplashTheme",ScreenOrientation =Android.Content.PM.ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(typeof(MainActivity));
            // Create your application here
        }
    }
}