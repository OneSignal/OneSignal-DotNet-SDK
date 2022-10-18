using System;
namespace OneSignalSDK.DotNet.Core {
   [Serializable]
   public sealed class NotificationOpenedResult {
      public NotificationAction action;
      public Notification notification;
   }
}
