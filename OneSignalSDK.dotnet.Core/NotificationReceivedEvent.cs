using System;
namespace OneSignalSDK.DotNet.Core {
   public class NotificationReceivedEvent {
        public Notification notificationReceived;

      public NotificationReceivedEvent(Notification notificationReceived) {
            this.notificationReceived = notificationReceived;
      }
   }
}
