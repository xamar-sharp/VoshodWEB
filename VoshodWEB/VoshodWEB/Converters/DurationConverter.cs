using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Globalization;
using Octane.Xamarin.Forms.VideoPlayer;
namespace VoshodWEB.Converters
{
    public sealed class DurationConverter : IValueConverter
    {
        public object Convert(object path, Type type, object param, CultureInfo info)
        {
            return path is null ? 0 : ((TimeSpan)path).Seconds;
        }
        public object ConvertBack(object path, Type type, object param, CultureInfo info)
        {
            var delta = (param as VideoPlayer).CurrentTime - TimeSpan.FromSeconds((int)path);
            (param as VideoPlayer).Seek(System.Convert.ToInt32(Math.Floor(delta.TotalSeconds)));
            return (int)path;
        }
    }
}
