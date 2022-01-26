using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserNotifications;
using Foundation;
using UIKit;

namespace LinphoneXamarin
{
    public class NotificationService : UNNotificationServiceExtension
    {
        protected NotificationService(NSObjectFlag t) : base(t)
        {
        }


        #region Override Methods
        public override void DidReceiveNotificationRequest(UNNotificationRequest request, Action<UNNotificationContent> contentHandler)
        {
            Console.WriteLine("omer50:DidReceiveNotificationRequest");
        }

        public override void TimeWillExpire()
        {
            // Handle service timing out
        }
        #endregion
    }
}