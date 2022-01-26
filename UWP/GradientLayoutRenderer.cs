using LinphoneXamarin.styles;
using System;
using UWP;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Point = Windows.Foundation.Point;

//[assembly: ExportRenderer(typeof(GradientView), typeof(GradientLayoutRenderer))]

namespace UWP
{
    public class GradientLayoutRenderer : VisualElementRenderer<ContentPage, Panel>
    {
        private Color StartColor { get; set; }
        private Color EndColor { get; set; }
        
        protected override void UpdateBackgroundColor()
        {
            base.UpdateBackgroundColor();

            LinearGradientBrush gradient;

            GradientStopCollection stopCollection = new GradientStopCollection();
            stopCollection.Add(new GradientStop
            {
                Color = Windows.UI.Color.FromArgb((byte)(StartColor.A * byte.MaxValue), (byte)(StartColor.R * byte.MaxValue), (byte)(StartColor.G * byte.MaxValue), (byte)(StartColor.B * byte.MaxValue)),
                Offset = 0
            });
            stopCollection.Add(new GradientStop
            {
                Color = Windows.UI.Color.FromArgb((byte)(EndColor.A * byte.MaxValue), (byte)(EndColor.R * byte.MaxValue), (byte)(EndColor.G * byte.MaxValue), (byte)(EndColor.B * byte.MaxValue)),
                Offset = 1
            });

            gradient = new LinearGradientBrush
            {
                GradientStops = stopCollection,
                StartPoint = new Point(0.5, 0),
                EndPoint = new Point(0.5, 1)
            };

            Background = gradient;


        }

        protected override void OnElementChanged(ElementChangedEventArgs<ContentPage> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
                return;

            try
            {
                var stack = e.NewElement as GradientView;
                this.StartColor = stack.StartColor;
                this.EndColor = stack.EndColor;

                UpdateBackgroundColor();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@"ERROR:", ex.Message);
            }
        }
    }
}
