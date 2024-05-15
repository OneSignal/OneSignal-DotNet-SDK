using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneSignalSDK.DotNet.Core.LiveActivities
{
	public interface ILiveActivitiesManager
	{
        /// <summary>
        /// Register this device with OneSignal indicating that the device has entered a live activity.
        /// </summary>
        /// <param name="activityId">The (app-provided) ID of the activity that is being entered.</param>
        /// <param name="token">The (OS-provided) token that will be used to update the content-state of the live activity on this device.</param>
        /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
        Task<bool> Enter(string activityId, string token);

        /// <summary>
        /// Unregister this device with OneSignal indicating that the device has exited a live activity.
        /// </summary>
        /// <param name="activityId">The (app-provided) ID of the activity that is being exited.</param>
        /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
        Task<bool> Exit(string activityId);

        /// <summary>
        /// Enable the OneSignalSDK to setup the default`DefaultLiveActivityAttributes` structure,
        /// which conforms to the `OneSignalLiveActivityAttributes`. When using this function, the
        /// widget attributes are owned by the OneSignal SDK, which will allow the SDK to handle the
        /// entire lifecycle of the live activity.  All that is needed from an app-perspective is to
        /// create a Live Activity widget in a widget extension, with a `ActivityConfiguration` for
        /// `DefaultLiveActivityAttributes`. This is most useful for users that (1) only have one Live
        /// Activity widget and (2) are using a cross-platform framework and do not want to create the
        /// cross-platform <-> iOS native bindings to manage ActivityKit.
        /// 
        /// Only applies to iOS.
        /// </summary>
        /// <param name="options">An optional structure to provide for more granular setup options.</param>
        void SetupDefault(LiveActivitySetupOptions options = null);

        /// <summary>
        /// Start a new LiveActivity that is modelled by the default`DefaultLiveActivityAttributes`
        /// structure. The `DefaultLiveActivityAttributes` is initialized with the dynamic `attributes`
        /// and `content` passed in.
        /// 
        /// Only applies to iOS.
        /// </summary>
        /// <param name="activityId">The activity identifier the live activity on this device will be started
        /// and eligible to receive updates for.</param>
        /// <param name="attributes">A dynamic type containing the static attributes passed into `DefaultLiveActivityAttributes`.</param>
        /// <param name="content">A dynamic type containing the content attributes passed into `DefaultLiveActivityAttributes`.</param>
        void StartDefault(string activityId, IDictionary<string, object> attributes, IDictionary<string, object> content);

        /// <summary>
        /// Indicate this device is capable of receiving pushToStart live activities for the `activityType`.
        /// The `activityType` **must** be the name of the struct conforming to `ActivityAttributes` that will be used
        /// to start the live activity.
        /// 
        /// Only applies to iOS.
        /// </summary>
        /// <param name="activityType">The name of the specific `ActivityAttributes` structure tied to the live activity.</param>
        void SetPushToStartToken(string activityType, string token);

        /// <summary>
        /// Indicate this device is no longer capable of receiving pushToStart live activities for the `activityType`.
        /// The `activityType` **must** be the name of the struct conforming to `ActivityAttributes` that will be used
        /// to start the live activity.
        /// 
        /// Only applies to iOS.
        /// </summary>
        /// <param name="activityType">The name of the specific `ActivityAttributes` structure tied to the live activity.</param>
        void RemovePushToStartToken(string activityType);
	}

        /// <summary>
        /// The setup options for <see cref="ILiveActivitiesManager.SetupDefault"/>.
        /// </summary>
        public class LiveActivitySetupOptions
        {
                /// <summary>
                /// When true, OneSignal will listen for pushToStart tokens for the `OneSignalLiveActivityAttributes` structure.
                /// </summary>
                public bool EnablePushToStart { get; set; }

                /// <summary>
                /// When true, OneSignal will listen for pushToUpdate  tokens for each start live activity that uses the
                /// `OneSignalLiveActivityAttributes` structure.
                /// </summary>
                public bool EnablePushToUpdate { get; set; }
        }
}

