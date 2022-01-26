using System;
using System.Threading;
using System.Threading.Tasks;
using LinphoneXamarin.Android;
using LinphoneXamarin.components.userControllers;
using LinphoneXamarin.Util;
using Windows.UI.Xaml.Input;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ResolutionGroupName("MyApp")]
[assembly: ExportEffect(typeof(UwpLongPressedEffect), "LongPressedEffect")]

namespace LinphoneXamarin.Android
{
    public class UwpLongPressedEffect : PlatformEffect
    {
        private bool _attached;
        private bool isPressed;
        PointerEventHandler pressed;
        PointerEventHandler released;

        public static void Initialize() { }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Yukon.Application.AndroidComponents.Effects.AndroidLongPressedEffect"/> class.
        /// Empty constructor required for the odd Xamarin.Forms reflection constructor search
        /// </summary>
        public UwpLongPressedEffect()
        {

        }

        private void addLog(string message)
        {
            MyFileSystem.Instance.writeDebug(message, "UwpLongPressedEffect");
            Console.WriteLine($"omer56: {message}");
        }

        protected override void OnAttached()
        {

            pressed = new PointerEventHandler(onPointerPressed);
            released = new PointerEventHandler(onPointerReleased);
            //because an effect can be detached immediately after attached (happens in listview), only attach the handler one time.
            if (!_attached)
            {
                if (Control != null)
                {

                    Control.AddHandler(Windows.UI.Xaml.UIElement.PointerPressedEvent, pressed, true);
                    Control.AddHandler(Windows.UI.Xaml.UIElement.PointerReleasedEvent, released, true);
                }

                _attached = true;
            }
        }

        private void onPointerPressed(object sender, PointerRoutedEventArgs e)
        {

            isPressed = true;

            new Task(() =>
            {
                Thread.Sleep(800);
                if (isPressed)
                {
                    var command = LongPressedEffect.GetCommand(Element);
                    command?.Execute("long");
                    isPressed = false;
                }
            }).Start();
        }

        private void onPointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (isPressed)
            {
                isPressed = false;
                var command = LongPressedEffect.GetCommand(Element);
                command?.Execute("short");
            }
        }

        /// <summary>
        /// Clean the event handler on detach
        /// </summary>
        protected override void OnDetached()
        {
            if (_attached)
            {
                if (Control != null)
                {
                    Control.RemoveHandler(Windows.UI.Xaml.UIElement.PointerPressedEvent, pressed);
                    Control.RemoveHandler(Windows.UI.Xaml.UIElement.PointerReleasedEvent, released);
                }

                _attached = false;
            }
        }
    }
}