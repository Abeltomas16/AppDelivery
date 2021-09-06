using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppDelivery.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(AppDelivery.CustomLabel), typeof(CustomLabelRedner))]
namespace AppDelivery.iOS
{
    class CustomLabelRedner : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.TextAlignment = UITextAlignment.Justified;
            }
        }
    }
}