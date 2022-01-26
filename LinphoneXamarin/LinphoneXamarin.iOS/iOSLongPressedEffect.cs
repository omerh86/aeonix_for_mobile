using System;
using Foundation;
using LinphoneXamarin.iOS;
using LinphoneXamarin.components;
using LinphoneXamarin.styles;
using UIKit;
using Xamarin.Forms;
using LinphoneXamarin.components.userControllers;
using Xamarin.Forms.Platform.iOS;
[assembly: ResolutionGroupName("MyApp")]
[assembly: ExportEffect(typeof(iOSLongPressedEffect), "LongPressedEffect")]


namespace LinphoneXamarin.iOS
{
   public class iOSLongPressedEffect : PlatformEffect
    {
        private bool _attached;
        private int counter;
        private readonly UILongPressGestureRecognizer _longPressRecognizer;
       
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Yukon.Application.iOSComponents.Effects.iOSLongPressedEffect"/> class.
        /// </summary>
        public iOSLongPressedEffect()
        {
            counter = 0;
            _longPressRecognizer = new UILongPressGestureRecognizer(HandleLongClick);

        }

        /// <summary>
        /// Apply the handler
        /// </summary>
        protected override void OnAttached()
        {
            //because an effect can be detached immediately after attached (happens in listview), only attach the handler one time
            if (!_attached)
            {
                Container.AddGestureRecognizer(_longPressRecognizer);
                _attached = true;
            }
        }

        /// <summary>
        /// Invoke the command if there is one
        /// </summary>
        private void HandleLongClick()
        {
            var command = LongPressedEffect.GetCommand(Element);
            counter++;
            if (counter % 100 == 1)
            {
                command?.Execute(null);
            }
            Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
            {
                counter = 0;
                return false;
            });
        }

        /// <summary>
        /// Clean the event handler on detach
        /// </summary>
        protected override void OnDetached()
        {
            if (_attached)
            {
                Container.RemoveGestureRecognizer(_longPressRecognizer);
                _attached = false;
            }
        }

    }
}
