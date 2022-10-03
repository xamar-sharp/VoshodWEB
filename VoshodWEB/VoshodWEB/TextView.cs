using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace VoshodWEB
{
    public sealed class TextView : View
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(TextView), "none");
        public string Text
        {
            get
            {
                return GetValue(TextProperty) as string;
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }
        public event EventHandler Touched;
        public void OnTouched<T>(object sender, T args) where T : EventArgs
        {
            Touched?.Invoke(sender, args);
        }
    }
}
