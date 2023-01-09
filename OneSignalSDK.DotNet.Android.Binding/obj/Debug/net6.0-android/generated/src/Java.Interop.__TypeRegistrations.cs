using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/onesignal",
					},
					new Converter<string, Type?>[]{
						lookup_com_onesignal_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type? Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[]? package_com_onesignal_mappings;
		static Type? lookup_com_onesignal_package (string klass)
		{
			if (package_com_onesignal_mappings == null) {
				package_com_onesignal_mappings = new string[]{
					"com/onesignal/AlertDialogPrepromptForAndroidSettings:Com.OneSignal.Android.AlertDialogPrepromptForAndroidSettings",
					"com/onesignal/BootUpReceiver:Com.OneSignal.Android.BootUpReceiver",
					"com/onesignal/BuildConfig:Com.OneSignal.Android.BuildConfig",
					"com/onesignal/FCMIntentJobService:Com.OneSignal.Android.FCMIntentJobService",
					"com/onesignal/GenerateNotificationOpenIntent:Com.OneSignal.Android.GenerateNotificationOpenIntent",
					"com/onesignal/GenerateNotificationOpenIntentFromPushPayload:Com.OneSignal.Android.GenerateNotificationOpenIntentFromPushPayload",
					"com/onesignal/IntentGeneratorForAttachingToNotifications:Com.OneSignal.Android.IntentGeneratorForAttachingToNotifications",
					"com/onesignal/LocationPermissionController:Com.OneSignal.Android.LocationPermissionController",
					"com/onesignal/NavigateToAndroidSettingsForLocation:Com.OneSignal.Android.NavigateToAndroidSettingsForLocation",
					"com/onesignal/NavigateToAndroidSettingsForNotifications:Com.OneSignal.Android.NavigateToAndroidSettingsForNotifications",
					"com/onesignal/NotificationDismissReceiver:Com.OneSignal.Android.NotificationDismissReceiver",
					"com/onesignal/NotificationOpenedActivityHMS:Com.OneSignal.Android.NotificationOpenedActivityHMS",
					"com/onesignal/NotificationOpenedReceiver:Com.OneSignal.Android.NotificationOpenedReceiver",
					"com/onesignal/NotificationOpenedReceiverAndroid22AndOlder:Com.OneSignal.Android.NotificationOpenedReceiverAndroid22AndOlder",
					"com/onesignal/NotificationOpenedReceiverBase:Com.OneSignal.Android.NotificationOpenedReceiverBase",
					"com/onesignal/NotificationPermissionController:Com.OneSignal.Android.NotificationPermissionController",
					"com/onesignal/OSBackgroundManager:Com.OneSignal.Android.OSBackgroundManager",
					"com/onesignal/OSDeviceState:Com.OneSignal.Android.OSDeviceState",
					"com/onesignal/OSEmailSubscriptionState:Com.OneSignal.Android.OSEmailSubscriptionState",
					"com/onesignal/OSEmailSubscriptionStateChanges:Com.OneSignal.Android.OSEmailSubscriptionStateChanges",
					"com/onesignal/OSFocusHandler:Com.OneSignal.Android.OSFocusHandler",
					"com/onesignal/OSFocusHandler$Companion:Com.OneSignal.Android.OSFocusHandler/Companion",
					"com/onesignal/OSInAppMessage:Com.OneSignal.Android.OSInAppMessage",
					"com/onesignal/OSInAppMessageAction:Com.OneSignal.Android.OSInAppMessageAction",
					"com/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType:Com.OneSignal.Android.OSInAppMessageAction/OSInAppMessageActionUrlType",
					"com/onesignal/OSInAppMessageContentKt:Com.OneSignal.Android.OSInAppMessageContentKt",
					"com/onesignal/OSInAppMessageLifecycleHandler:Com.OneSignal.Android.OSInAppMessageLifecycleHandler",
					"com/onesignal/OSInAppMessageOutcome:Com.OneSignal.Android.OSInAppMessageOutcome",
					"com/onesignal/OSInAppMessagePageKt:Com.OneSignal.Android.OSInAppMessagePageKt",
					"com/onesignal/OSInAppMessagePrompt:Com.OneSignal.Android.OSInAppMessagePrompt",
					"com/onesignal/OSInAppMessagePushPrompt:Com.OneSignal.Android.OSInAppMessagePushPrompt",
					"com/onesignal/OSInAppMessageTag:Com.OneSignal.Android.OSInAppMessageTag",
					"com/onesignal/OSMutableNotification:Com.OneSignal.Android.OSMutableNotification",
					"com/onesignal/OSNotification:Com.OneSignal.Android.OSNotification",
					"com/onesignal/OSNotification$ActionButton:Com.OneSignal.Android.OSNotification/ActionButton",
					"com/onesignal/OSNotification$BackgroundImageLayout:Com.OneSignal.Android.OSNotification/BackgroundImageLayout",
					"com/onesignal/OSNotification$OSNotificationBuilder:Com.OneSignal.Android.OSNotification/OSNotificationBuilder",
					"com/onesignal/OSNotificationAction:Com.OneSignal.Android.OSNotificationAction",
					"com/onesignal/OSNotificationAction$ActionType:Com.OneSignal.Android.OSNotificationAction/ActionType",
					"com/onesignal/OSNotificationController:Com.OneSignal.Android.OSNotificationController",
					"com/onesignal/OSNotificationGenerationJob:Com.OneSignal.Android.OSNotificationGenerationJob",
					"com/onesignal/OSNotificationIntentExtras:Com.OneSignal.Android.OSNotificationIntentExtras",
					"com/onesignal/OSNotificationOpenAppSettings:Com.OneSignal.Android.OSNotificationOpenAppSettings",
					"com/onesignal/OSNotificationOpenBehaviorFromPushPayload:Com.OneSignal.Android.OSNotificationOpenBehaviorFromPushPayload",
					"com/onesignal/OSNotificationOpenedResult:Com.OneSignal.Android.OSNotificationOpenedResult",
					"com/onesignal/OSNotificationReceivedEvent:Com.OneSignal.Android.OSNotificationReceivedEvent",
					"com/onesignal/OSOutcomeEvent:Com.OneSignal.Android.OSOutcomeEvent",
					"com/onesignal/OSPermissionState:Com.OneSignal.Android.OSPermissionState",
					"com/onesignal/OSPermissionStateChanges:Com.OneSignal.Android.OSPermissionStateChanges",
					"com/onesignal/OSSMSSubscriptionState:Com.OneSignal.Android.OSSMSSubscriptionState",
					"com/onesignal/OSSMSSubscriptionStateChanges:Com.OneSignal.Android.OSSMSSubscriptionStateChanges",
					"com/onesignal/OSSessionManager:Com.OneSignal.Android.OSSessionManager",
					"com/onesignal/OSSubscriptionState:Com.OneSignal.Android.OSSubscriptionState",
					"com/onesignal/OSSubscriptionStateChanges:Com.OneSignal.Android.OSSubscriptionStateChanges",
					"com/onesignal/OSTimeImpl:Com.OneSignal.Android.OSTimeImpl",
					"com/onesignal/OSWebView:Com.OneSignal.Android.OSWebView",
					"com/onesignal/OneSignal:Com.OneSignal.Android.OneSignal",
					"com/onesignal/OneSignal$AppEntryAction:Com.OneSignal.Android.OneSignal/AppEntryAction",
					"com/onesignal/OneSignal$EmailErrorType:Com.OneSignal.Android.OneSignal/EmailErrorType",
					"com/onesignal/OneSignal$EmailUpdateError:Com.OneSignal.Android.OneSignal/EmailUpdateError",
					"com/onesignal/OneSignal$ExternalIdError:Com.OneSignal.Android.OneSignal/ExternalIdError",
					"com/onesignal/OneSignal$ExternalIdErrorType:Com.OneSignal.Android.OneSignal/ExternalIdErrorType",
					"com/onesignal/OneSignal$LOG_LEVEL:Com.OneSignal.Android.OneSignal/LOG_LEVEL",
					"com/onesignal/OneSignal$OSLanguageError:Com.OneSignal.Android.OneSignal/OSLanguageError",
					"com/onesignal/OneSignal$OSSMSUpdateError:Com.OneSignal.Android.OneSignal/OSSMSUpdateError",
					"com/onesignal/OneSignal$SMSErrorType:Com.OneSignal.Android.OneSignal/SMSErrorType",
					"com/onesignal/OneSignal$SendTagsError:Com.OneSignal.Android.OneSignal/SendTagsError",
					"com/onesignal/OneSignalHmsEventBridge:Com.OneSignal.Android.OneSignalHmsEventBridge",
					"com/onesignal/OneSignalNotificationManager:Com.OneSignal.Android.OneSignalNotificationManager",
					"com/onesignal/OneSignalRemoteParams:Com.OneSignal.Android.OneSignalRemoteParams",
					"com/onesignal/OneSignalRemoteParams$InfluenceParams:Com.OneSignal.Android.OneSignalRemoteParams/InfluenceParams",
					"com/onesignal/PermissionsActivity:Com.OneSignal.Android.PermissionsActivity",
					"com/onesignal/PushRegistratorADM:Com.OneSignal.Android.PushRegistratorADM",
					"com/onesignal/SyncJobService:Com.OneSignal.Android.SyncJobService",
					"com/onesignal/SyncService:Com.OneSignal.Android.SyncService",
					"com/onesignal/TLS12SocketFactory:Com.OneSignal.Android.TLS12SocketFactory",
					"com/onesignal/UpgradeReceiver:Com.OneSignal.Android.UpgradeReceiver",
				};
			}

			return Lookup (package_com_onesignal_mappings, klass);
		}
	}
}
