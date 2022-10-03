using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using VoshodWEB.Dependencies;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Util;
namespace VoshodWEB.Droid
{
    public sealed class AndroidPlatformInfo:IPlatformInfo
    {
        public CultureInfo PlatformCulture
        {
            get
            {
                string value = Locale.Default.ToString().Replace("_", "-");
                return new CultureInfo(value);
            }
        }
        public string GetData()
        {
            return AndroidX.Print.PrintHelper.SystemSupportsPrint().ToString();
        }
    }
}