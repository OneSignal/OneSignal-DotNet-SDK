﻿using System;
namespace OneSignalSDK.DotNet.Core {
   public enum NotificationActionType {
      /// <summary>Notification was tapped on.</summary>
      Opened,

      /// <summary>User tapped on an action from the notification.</summary>
      ActionTaken
   }

   [Serializable]
   public sealed class NotificationAction {
      public string actionID;
      public NotificationActionType type;
   }
}
