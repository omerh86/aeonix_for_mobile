using Android.InputMethodServices;
using Android.Views.InputMethods;
using Android.Widget;
using LinphoneXamarin.Android;
using LinphoneXamarin.components.userControllers;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(MyListView), typeof(MyListRenderer))]
namespace LinphoneXamarin.Android
{
    public class MyListRenderer : ListViewRenderer
    {
        private int _prevFirstVisibleElement;
        private bool isScrolledBefore;

        public MyListRenderer() { }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement is MyListView)
                Control.Scroll += Control_Scroll;

            isScrolledBefore = false;
        }

        private void Control_Scroll(object sender, AbsListView.ScrollEventArgs e)
        {
            if (e.FirstVisibleItem != _prevFirstVisibleElement && Element is MyListView)
            {
                if (!isScrolledBefore)
                {
                    try
                    {

                        InputMethodManager inputManager = (InputMethodManager)Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity.GetSystemService(InputMethodService.InputMethodService);
                        inputManager.HideSoftInputFromWindow(Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity.CurrentFocus.WindowToken, HideSoftInputFlags.None);
                    }
                    catch (Exception err)
                    {

                    }
                    isScrolledBefore = true;
                }
                var direction = e.FirstVisibleItem > _prevFirstVisibleElement
                                        ? "Going down!" : "Going up!";
                var myList = Element as MyListView;
                myList.LastScrollDirection = direction;
                myList.AtStartOfList = (e.FirstVisibleItem == 0);
                _prevFirstVisibleElement = e.FirstVisibleItem;
            }
        }
    }
}