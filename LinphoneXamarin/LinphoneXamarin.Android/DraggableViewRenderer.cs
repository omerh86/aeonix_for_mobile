using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using LinphoneXamarin.Android;
using LinphoneXamarin.components.userControllers;
using LinphoneXamarin.Entities;
using LinphoneXamarin.styles;
using LinphoneXamarin.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(speedDialView), typeof(DraggableViewRenderer))]
namespace LinphoneXamarin.Android
{

    public class DraggableViewRenderer : VisualElementRenderer<Xamarin.Forms.View>
    {
        float originalX;
        float originalY;
        float dX;
        float dY;
        bool firstTime = true;
        bool touchedDown = false;
        int counter = 0;
        public DraggableViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                LongClick -= HandleLongClick;
                Click -= HandleClick;
            }
            if (e.NewElement != null)
            {
                LongClick += HandleLongClick;
                Click += HandleClick;
                var dragView = Element as speedDialView;
                if (dragView.DragMode == DragMode.None)

                    dragView.RestorePositionCommand = new Command(() =>
                  {
                      if (!firstTime)
                      {
                          SetX(originalX);
                          SetY(originalY);
                      }

                  });

            }

        }

        private void HandleLongClick(object sender, LongClickEventArgs e)
        {
            var dragView = Element as speedDialView;
            if (firstTime)
            {
                originalX = GetX();
                originalY = GetY();
                firstTime = false;
            }
            dragView.DragStarted();
            touchedDown = true;
        }

        private void HandleClick(object sender, EventArgs e)
        {
            var dragView = Element as speedDialView;
            dragView.clicked();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var dragView = Element as speedDialView;
            base.OnElementPropertyChanged(sender, e);
        }

        public override bool OnTouchEvent(MotionEvent e)
        {
            float x = e.RawX;
            float y = e.RawY;

            var dragView = Element as speedDialView;
            switch (e.Action)
            {
                case MotionEventActions.Down:
                    if (dragView.DragMode == DragMode.Touch)
                    {
                        if (!touchedDown)
                        {
                            if (firstTime)
                            {
                                originalX = GetX();
                                originalY = GetY();
                                firstTime = false;
                            }
                            dragView.DragStarted();
                        }
                    }
                    dX = x - this.GetX();
                    dY = y - this.GetY();
                    break;
                case MotionEventActions.Move:
                    if (dragView.DragMode == DragMode.None)
                    {
                        break;
                    }
                    if (touchedDown)
                    {

                        if (dragView.DragDirection == DragDirectionType.All || dragView.DragDirection == DragDirectionType.Horizontal)
                        {
                            SetX(x - dX);
                        }

                        if (dragView.DragDirection == DragDirectionType.All || dragView.DragDirection == DragDirectionType.Vertical)
                        {
                            SetY(y - dY);
                        }
                        if (counter % 10 == 0)
                            dragView.DragInProgress(GetX(), GetY());

                        counter++;
                    }
                    break;
                case MotionEventActions.Up:
                    if (touchedDown)
                    {
                        touchedDown = false;
                        dragView.DragEnded(GetX(), GetY());
                    }
                    break;
                case MotionEventActions.Cancel:
                    touchedDown = false;
                    break;
            }
            return base.OnTouchEvent(e);
        }

        public override bool OnInterceptTouchEvent(MotionEvent e)
        {

            BringToFront();
            return true;
        }

        private void addLog(string s)
        {
            Console.WriteLine($"omer56: {s}");
            MyFileSystem.Instance.writeDebug(s, "speedDialEditorPage");
        }

    }
}