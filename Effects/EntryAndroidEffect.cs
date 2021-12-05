using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("PlateformEffect")]
[assembly: ExportEffect(typeof(PlateformEffect.Droid.Effects.EntryAndroidEffect), nameof(PlateformEffect.Effects.EntryEffect))]
namespace PlateformEffect.Droid.Effects
{
    public class EntryAndroidEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (this.Control != null)
            {
                this.Control.Background = new ColorDrawable(Android.Graphics.Color.LightGray);
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}