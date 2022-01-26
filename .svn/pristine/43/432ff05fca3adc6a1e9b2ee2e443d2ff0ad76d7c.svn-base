using LinphoneXamarin.components.userControllers;
using LinphoneXamarin.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UWP;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(speedDialView), typeof(DragableRenderer))]

namespace UWP
{
    class DragableRenderer : ViewRenderer<speedDialView, Windows.UI.Xaml.FrameworkElement>
    {

        int counter = 0;
        bool doubleTapped = false;
        protected override void OnElementChanged(ElementChangedEventArgs<speedDialView> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {

                this.CanDrag = true;
                this.AllowDrop = true;
                this.Tapped += OnTapped;
                this.DoubleTapped += OnDoubleTapped;
                this.RightTapped += OnRightTapped;
                this.DragOver += OnDragOver;
                this.DragStarting += OnDragStarting;
                this.Drop += OnDragEnded;
                this.DragLeave += OnDragLeave;

            }

            if (e.NewElement == null)
            {

                this.CanDrag = false;
                this.AllowDrop = false;
                this.Tapped -= OnTapped;
                this.DoubleTapped -= OnDoubleTapped;
                this.DragOver -= OnDragOver;
                this.DragStarting -= OnDragStarting;
                this.Drop -= OnDragEnded;
                this.DragLeave -= OnDragLeave;
            }

        }

        private void OnTapped(object sender, TappedRoutedEventArgs args)
        {
            addLog("OnTapped");
            doubleTapped = false;
            this.Opacity = 0.7;
            new Task(() =>
            {
                Thread.Sleep(300);
                if (!doubleTapped)
                {
                    addLog("DoOnTapped");
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
                    {
                        this.Opacity = 1;
                        var viewRenderer = sender as DragableRenderer;
                        var element = viewRenderer?.Element as speedDialView;
                        element.clicked();
                    });
                }
                else
                {
                    doubleTapped = false;
                }
            }).Start();

        }

        private void OnDoubleTapped(object sender, DoubleTappedRoutedEventArgs args)
        {
            doubleTapped = true;
            this.Opacity = 1;
            addLog("OnDoubleTapped");
            var viewRenderer = sender as DragableRenderer;
            var element = viewRenderer?.Element as speedDialView;
            element.Edit = true;
            element.clicked();
        }

        private void OnRightTapped(object sender, RightTappedRoutedEventArgs args)
        {

            addLog("OnRightTapped");
            var viewRenderer = sender as DragableRenderer;
            var element = viewRenderer?.Element as speedDialView;
            element.Edit = true;
            element.clicked();
        }


        private void OnDragStarting(object sender, DragStartingEventArgs args)
        {
            var viewRenderer = sender as DragableRenderer;
            var element = viewRenderer?.Element as speedDialView;
            args.Cancel = false;
            var pos = args.GetPosition(viewRenderer);
            // dragView.DragStarted((float)pos.X, (float)pos.Y);
            args.Data.Properties.Add("customView", (element));

            element.DragStarted();
        }

        private void OnDragOver(object sender, DragEventArgs e)
        {

            var viewRenderer = sender as DragableRenderer;
            var pos = e.GetPosition(viewRenderer);
            e.AcceptedOperation = DataPackageOperation.Move;
            //dragView.DragInProgress((float)pos.X, (float)pos.Y);

            counter++;



        }

        private void OnDragLeave(object sender, DragEventArgs e)
        {
            var viewRenderer = sender as DragableRenderer;
            var element = viewRenderer?.Element;
            var dragView = viewRenderer?.Element as speedDialView;

            var pos = e.GetPosition(viewRenderer);
            //dragView.DragEnded((float)pos.X, (float)pos.Y);


        }

        private void OnDragEnded(object sender, DragEventArgs e)
        {
            var viewRenderer = sender as DragableRenderer;
            var element = viewRenderer?.Element as speedDialView;
            var result = e.DataView?.Properties?.
                        SingleOrDefault(p => p.Key == "customView" && p.Value.GetType() == typeof(speedDialView));
            var positionCustomView = result?.Value as speedDialView;

            positionCustomView.DragEnded((float)positionCustomView.position, (float)element.position);
        }

        private void addLog(string s)
        {
            Console.WriteLine($"omer56: {s}");
            MyFileSystem.Instance.writeDebug(s, "DragableRenderer");
        }

    }
}
