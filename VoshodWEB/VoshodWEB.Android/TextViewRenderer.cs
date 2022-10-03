using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using widget = Android.Widget;
using VoshodWEB;
using System.ComponentModel;

namespace VoshodWEB.Droid
{
    public sealed class TextViewRenderer : ViewRenderer<TextView, widget.TextView>
    {
        public TextViewRenderer(Context ctx) : base(ctx)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<TextView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                widget.TextView view = new widget.TextView(Context);
                SetNativeControl(view);
                if (e.NewElement != null)
                {
                    view.Text = e.NewElement.Text;
                    view.Touch += (sender, args) => e.NewElement.OnTouched<EventArgs>(this, args);
                }
            }
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == TextView.TextProperty.PropertyName)
            {
                Control.Text = Element.Text;
            }
        }
    }
}