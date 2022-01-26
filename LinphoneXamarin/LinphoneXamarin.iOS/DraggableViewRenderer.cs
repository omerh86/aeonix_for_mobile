using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using LinphoneXamarin.iOS;
using LinphoneXamarin.components.userControllers;
using LinphoneXamarin.Entities;
using CoreGraphics;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(speedDialView), typeof(DraggableViewRenderer))]

namespace LinphoneXamarin.iOS
{

    public class DraggableViewRenderer : VisualElementRenderer<View>
    {
       
        bool firstTime = true;
        int counter = 0;
        double lastTimeStamp = 0f;
        UIPanGestureRecognizer panGesture;
        CGPoint lastLocation;
        CGPoint originalPosition;
        UIGestureRecognizer.Token panGestureToken;
        void DetectPan()
        {
            var dragView = Element as speedDialView;

            if (dragView.DragMode == DragMode.LongPress)
            {
                if (panGesture.State == UIGestureRecognizerState.Began)
                {
                    dragView.DragStarted();
                    if (firstTime)
                    {
                        originalPosition = Center;
                        firstTime = false;
                   
                    }
                }

                CGPoint translation = panGesture.TranslationInView(Superview);
                var currentCenterX = Center.X;
                var currentCenterY = Center.Y;
                if (dragView.DragDirection == DragDirectionType.All || dragView.DragDirection == DragDirectionType.Horizontal)
                {
                    currentCenterX = lastLocation.X + translation.X;
                    counter++;
                    if (counter % 15 == 0)
                        dragView.DragInProgress((float)currentCenterX, (float)currentCenterY);
                }

                if (dragView.DragDirection == DragDirectionType.All || dragView.DragDirection == DragDirectionType.Vertical)
                {
                    currentCenterY = lastLocation.Y + translation.Y;
                    counter++;
                    if (counter % 15 == 0)
                        dragView.DragInProgress((float)currentCenterX, (float)currentCenterY);

                }

                Center = new CGPoint(currentCenterX, currentCenterY);

                if (panGesture.State == UIGestureRecognizerState.Ended)
                {
                    dragView.DragEnded((float)currentCenterX, (float)currentCenterY);
                    
                }
            }
        }

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                RemoveGestureRecognizer(panGesture);
                panGesture.RemoveTarget(panGestureToken);
            }
            if (e.NewElement != null)
            {
                var dragView = Element as speedDialView;
                panGesture = new UIPanGestureRecognizer();
                panGestureToken = panGesture.AddTarget(DetectPan);
                AddGestureRecognizer(panGesture);


                dragView.RestorePositionCommand = new Command(() =>
                {
                    if (!firstTime)
                    {

                        Center = originalPosition;
                    }
                });

            }

        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var dragView = Element as speedDialView;
            base.OnElementPropertyChanged(sender, e);

        }

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            Console.WriteLine($"omer56: TouchesBegan: ");
            base.TouchesBegan(touches, evt);
            lastTimeStamp = evt.Timestamp;
            Superview.BringSubviewToFront(this);
            lastLocation = Center;

        }
        public override void TouchesMoved(NSSet touches, UIEvent evt)
        {
            Console.WriteLine($"omer56: TouchesMoved: ");
           
            base.TouchesMoved(touches, evt);
        }

        public override void TouchesEnded(Foundation.NSSet touches, UIEvent evt)
        {
            Console.WriteLine($"omer56: TouchesEnded: ");
            var dragView = Element as speedDialView;
            if (evt.Timestamp - lastTimeStamp >= 1)
                dragView.DragStarted();
            else
                dragView.clicked();
            
            base.TouchesEnded(touches, evt);
        }

        public override void TouchesCancelled(Foundation.NSSet touches, UIEvent evt)
        {
            Console.WriteLine($"omer56: TouchesCancelled: ");
            var dragView = Element as speedDialView;
            if (evt.Timestamp - lastTimeStamp >= 1)
                dragView.DragStarted();
           

            base.TouchesCancelled(touches, evt);
        }

       
    }
}