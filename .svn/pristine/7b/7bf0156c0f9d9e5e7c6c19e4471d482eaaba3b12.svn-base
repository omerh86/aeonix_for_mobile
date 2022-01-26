using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;

using LinphoneXamarin.Android;
using LinphoneXamarin.components.userControllers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ResolutionGroupName("MyApp")]
[assembly: ExportEffect(typeof(AndroidLongPressedEffect), "LongPressedEffect")]

namespace LinphoneXamarin.Android
{
    public class AndroidLongPressedEffect : PlatformEffect
    {
        private bool _attached;

        /// <summary>
        /// Initializer to avoid linking out
        /// </summary>
        public static void Initialize() { }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Yukon.Application.AndroidComponents.Effects.AndroidLongPressedEffect"/> class.
        /// Empty constructor required for the odd Xamarin.Forms reflection constructor search
        /// </summary>
        public AndroidLongPressedEffect()
        {
        }

        /// <summary>
        /// Apply the handler
        /// </summary>
        protected override void OnAttached()
        {

            //because an effect can be detached immediately after attached (happens in listview), only attach the handler one time.
            if (!_attached)
            {
                if (Control != null)
                {
                    Control.LongClickable = true;
                    Control.LongClick += Control_LongClick;
                }
                else
                {
                    Container.LongClickable = true;
                    Container.LongClick += Control_LongClick;
                }
                _attached = true;
            }
        }

        /// <summary>
        /// Invoke the command if there is one
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void Control_LongClick(object sender, global::Android.Views.View.LongClickEventArgs e)
        {

            var command = LongPressedEffect.GetCommand(Element);
            command?.Execute(null);
        }

        /// <summary>
        /// Clean the event handler on detach
        /// </summary>
        protected override void OnDetached()
        {
            try
            {
                if (_attached)
                {
                    if (Control != null)
                    {
                        Control.LongClickable = true;
                        Control.LongClick -= Control_LongClick;
                    }
                    else
                    {
                        Container.LongClickable = true;
                        Container.LongClick -= Control_LongClick;
                    }
                    _attached = false;
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}