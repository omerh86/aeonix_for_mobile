using LinphoneXamarin.components.userControllers;
using UWP;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

//[assembly: ExportRenderer(typeof(MYVideo), typeof(MyVideoRenderer))]
namespace UWP
{
    public class MyVideoRenderer : ViewRenderer<MYVideo, SwapChainPanel>
    {

        protected override void OnElementChanged(ElementChangedEventArgs<MYVideo> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
              
               
            }

        }



    }
}
