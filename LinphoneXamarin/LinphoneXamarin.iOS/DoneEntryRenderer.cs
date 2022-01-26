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

[assembly: ExportRenderer(typeof(Entry), typeof(DoneEntryRenderer))]
namespace LinphoneXamarin.iOS
{
  
        public class DoneEntryRenderer : EntryRenderer
        {
            protected override void OnModelSet(VisualElement model)
            {
                base.OnModelSet(model);
                var textField = (UITextField)this.Control;
                textField.ReturnKeyType = UIReturnKeyType.Done;
            }
        }

}
