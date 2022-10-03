using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
namespace VoshodWEB.MarkupExtensions
{
    [ContentProperty("Key")]
    public sealed class Localizer : IMarkupExtension
    {
        public string Key { get; set; }
        public object ProvideValue(IServiceProvider provider)
        {
            return Resource.ResourceManager.GetString(Key);
        }
    }
}
