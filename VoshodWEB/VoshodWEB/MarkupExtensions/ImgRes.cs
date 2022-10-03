using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
namespace VoshodWEB.MarkupExtensions
{
    [ContentProperty("Name")]
    public sealed class ImgRes:IMarkupExtension
    {
        public string Name { get; set; }
        public object ProvideValue(IServiceProvider provider)
        {
            return ImageSource.FromResource($"VoshodWEB.Images.{Name}");
        }
    }
}
