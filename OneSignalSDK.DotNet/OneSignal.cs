﻿using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Dynamic;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.LiveActivities;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalSDK.DotNet.Core.InAppMessages;
using OneSignalSDK.DotNet.Core.Location;
using OneSignalSDK.DotNet.Core.Notifications;
using OneSignalSDK.DotNet.Core.Session;
using OneSignalSDK.DotNet.Core.User;

namespace OneSignalSDK.DotNet
{
    /// <summary>
    /// This class is the entry point to the OneSignal SDK. It
    /// is designed to make OneSignal easy to use.  SDK functionality can
    /// be accessed via the static functionality on the class <see cref="OneSignal"/>.
    /// </summary>
    public class OneSignal
    {
        private static readonly Lazy<IOneSignal> Implementation = new Lazy<IOneSignal>(CreateOneSignal);

        /// <summary>
        /// The user manager for accessing user-scoped management.
        /// </summary>
        public static IUserManager User { get; } = OneSignal.Default.User;

        /// <summary>
        /// The session manager for accessing session-scoped management.
        /// </summary>
        public static ISessionManager Session { get; } = OneSignal.Default.Session;

        /// <summary>
        /// The notification manager for accessing device-scoped notification management.
        /// </summary>
        public static INotificationsManager Notifications { get; } = OneSignal.Default.Notifications;

        /// <summary>
        /// The location manager for accessing device-scoped location management.
        /// </summary>
        public static ILocationManager Location { get; } = OneSignal.Default.Location;

        /// <summary>
        /// The In App Messaging manager for accessing device-scoped IAP management.
        /// </summary>
        public static IInAppMessagesManager InAppMessages { get; } = OneSignal.Default.InAppMessages;

        /// <summary>
        /// Access to debug the SDK in the event additional information is required to diagnose any
        /// SDK-related issues.
        /// </summary>
        /// <remarks>
        /// This should not be used in a production setting.
        /// </remarks>
        public static IDebugManager Debug { get; } = OneSignal.Default.Debug;

        /// <summary>
        /// The LiveActivities manager for accessing iOS Live Activity management.
        /// </summary>
        public static ILiveActivitiesManager LiveActivities { get; } = OneSignal.Default.LiveActivities;

        /// <summary>
        /// Determines whether a user must consent to privacy prior to their user data being sent
        /// up to OneSignal.This should be set to <code>true</code> prior to the invocation of
        /// <see cref="Initialize(string)"/>to ensure compliance.
        /// </summary>
        public static bool ConsentRequired { set => OneSignal.Default.ConsentRequired = value; }

        /// <summary>
        /// Indicates whether privacy consent has been granted. This field is only relevant when
        /// the application has opted into data privacy protections. <see cref="ConsentRequired"/>.
        /// </summary>
        public static bool ConsentGiven { set => OneSignal.Default.ConsentGiven = value; }

        /// <summary>
        /// Initialze the OneSignal SDK.  This should be called during startup of the application.
        /// </summary>
        /// <param name="appId">The application ID the OneSignal SDK is bound to.</param>
        public static void Initialize(String appId)
        {
            OneSignal.Default.Initialize(appId);
        }

        /// <summary>
        /// Login to OneSignal under the user identified by the[externalId] provided.The act of
        /// logging a user into the OneSignal SDK will switch the[User] context to that specific user.
        ///
        /// <list type="bullet">
        /// <item><description>
        /// If the <paramref name="externalId"/> exists the user will be retrieved
        /// and the context set from that user information. If operations have already been performed
        /// under a guest user, they <b>will not</b> be applied to the now logged in user (they will
        /// be lost).
        /// </description></item>
        /// <item><description>
        /// If the <paramref name="externalId"/> does not exist the user will be created and the
        /// context set from the current local state. If operations have already been performed
        /// under a guest user those operations <b>will</b> be applied to the newly created user.
        /// </description></item>
        /// </list>
        ///
        /// <b>Push Notifications and In App Messaging</b>
        /// Logging in a new user will automatically transfer push notification and in app messaging
        /// subscriptions from the current user(if there is one) to the newly logged in user.This is
        /// because both Push and IAM are owned by the device.
        /// </summary>
        /// <param name="externalId">The external ID of the user that is to be logged in.</param>
        /// <param name="jwtBearerToken">
        /// The optional JWT bearer token generated by your backend to establish trust for the
        /// login operation.Required when identity verification has been enabled.  See
        /// <a href="https://documentation.onesignal.com/docs/identity-verification">Identity Verification | OneSignal</a>
        /// </param>
        public static void Login(String externalId, String jwtBearerToken = null)
        {
            OneSignal.Default.Login(externalId, jwtBearerToken);
        }

        /// <summary>
        /// Logout the user previously logged in via <see cref="Login(string, string?)"/>. The
        /// <see cref="User"/> property now references a new device-scoped user.A device-scoped
        /// user has no user identity that can later be retrieved, except through this device as
        /// long as the app remains installed and the app data is not cleared.
        /// </summary>
        public static void Logout()
        {
            OneSignal.Default.Logout();
        }

        /// <summary>
        /// Access to the OneSignal SDK.
        /// </summary>
        private static IOneSignal Default
        {
            get
            {
                if (Implementation.Value == null)
                    throw NotImplementedInReferenceAssembly();

                return Implementation.Value;
            }
        }

        private static IOneSignal CreateOneSignal()
        {
#if __IOS__
        return new OneSignalSDK.DotNet.iOS.iOSOneSignal();
#elif __ANDROID__
        return new OneSignalSDK.DotNet.Android.AndroidOneSignal();
#else
            System.Diagnostics.Debug.WriteLine("PORTABLE Reached");
            return null;
#endif

        }

        private static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}