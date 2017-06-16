using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Graphics;
using System.ComponentModel;
using DroneLander2;
using DroneLander2.Droid;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(DroneLander2.Droid.DigitalFontEffect), "FontEffect")]
namespace DroneLander2.Droid
{
	public class DigitalFontEffect : PlatformEffect
	{
		TextView control;
		protected override void OnAttached()
		{
			try
			{
				control = Control as TextView;
				Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, DroneLander2.DigitalFontEffect.GetFontFileName(Element) + ".ttf");
				control.Typeface = font;
			}
			catch (Exception ex)
			{
			}
		}

		protected override void OnDetached()
		{
		}

		protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
		{
			if (args.PropertyName == DroneLander2.DigitalFontEffect.FontFileNameProperty.PropertyName)
			{
				Typeface font = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, DroneLander2.DigitalFontEffect.GetFontFileName(Element) + ".ttf");
				control.Typeface = font;
			}
		}
	}
}