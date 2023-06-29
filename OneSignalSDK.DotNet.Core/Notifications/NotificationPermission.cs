using System;
namespace OneSignalSDK.DotNet.Core.Notifications
{
	public enum NotificationPermission
	{
        NotDetermined = 0,
        Denied,
        Authorized,
        Provisional, // only available in iOS 12
        Ephemeral // only available in iOS 14 
	}
}

