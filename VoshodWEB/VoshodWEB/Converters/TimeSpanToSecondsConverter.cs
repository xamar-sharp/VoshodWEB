using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;
namespace VoshodWEB.Converters
{
    public sealed class TimeSpanToSecondsConverter:IValueConverter
    {
        public object Convert(object path, Type type, object param, CultureInfo info)
        {
            return ((TimeSpan)path).TotalSeconds;
        }
        public object ConvertBack(object path, Type type, object param, CultureInfo info)
        {
            throw new NotImplementedException();
        }
    }
}
