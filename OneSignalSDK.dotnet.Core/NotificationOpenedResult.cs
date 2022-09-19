using System;
namespace OneSignalSDK.dotnet.Core {
   [Serializable]
   public sealed class NotificationOpenedResult {
      public NotificationAction action;
      public Notification notification;
   }
}
