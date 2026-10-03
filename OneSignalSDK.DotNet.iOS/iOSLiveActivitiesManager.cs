using System;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.LiveActivities;
using OneSignalSDK.DotNet.iOS.Utilities;
using LiveActivitySetupOptionsNative = Com.OneSignal.iOS.LiveActivitySetupOptions;
using OneSignalLiveActivityNative = Com.OneSignal.iOS.OneSignalLiveActivitiesManagerImpl;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.DotNet.iOS
{
    public class iOSLiveActivitiesManager : ILiveActivitiesManager
    {
        public async Task<bool> Enter(string activityId, string token)
        {
            if (
                InputGuard.IsMissing(activityId, "enter: activityId")
                || InputGuard.IsMissing(token, "enter: token")
            )
                return false;
            BooleanCallbackProxy proxy = new BooleanCallbackProxy();
            OneSignalNative.LiveActivities.Enter(
                activityId,
                token,
                response => proxy.OnResponse(true),
                response => proxy.OnResponse(false)
            );
            return await proxy;
        }

        [Obsolete("Currently unsupported, avoid using this method.")]
        public async Task<bool> Exit(string activityId)
        {
            if (InputGuard.IsMissing(activityId, "exit: activityId"))
                return false;
            BooleanCallbackProxy proxy = new BooleanCallbackProxy();
            OneSignalNative.LiveActivities.Exit(
                activityId,
                response => proxy.OnResponse(true),
                response => proxy.OnResponse(false)
            );
            return await proxy;
        }

        public void RemovePushToStartToken(string activityType)
        {
            if (!UIDevice.CurrentDevice.CheckSystemVersion(17, 2))
            {
                Console.WriteLine(
                    "RemovePushToStartToken is only available on iOS 17.2 and later."
                );
                return;
            }
            if (InputGuard.IsMissing(activityType, "removePushToStartToken: activityType"))
                return;

            NSError? error;
            OneSignalLiveActivityNative.RemovePushToStartToken(activityType, out error);

            if (error != null)
            {
                throw new Exception(error.LocalizedDescription);
            }
        }

        public void SetPushToStartToken(string activityType, string token)
        {
            if (!UIDevice.CurrentDevice.CheckSystemVersion(17, 2))
            {
                Console.WriteLine("SetPushToStartToken is only available on iOS 17.2 and later.");
                return;
            }
            if (
                InputGuard.IsMissing(activityType, "setPushToStartToken: activityType")
                || InputGuard.IsMissing(token, "setPushToStartToken: token")
            )
                return;

            NSError? error;
            OneSignalLiveActivityNative.SetPushToStartToken(activityType, token, out error);

            if (error != null)
            {
                throw new Exception(error.LocalizedDescription);
            }
        }

        public void SetupDefault(LiveActivitySetupOptions? options = null)
        {
            if (!UIDevice.CurrentDevice.CheckSystemVersion(16, 1))
            {
                Console.WriteLine("SetupDefault is only available on iOS 16.1 and later.");
                return;
            }

            LiveActivitySetupOptionsNative? nativeOptions = null;

            if (options != null)
            {
                nativeOptions = new LiveActivitySetupOptionsNative(
                    options.EnablePushToStart,
                    options.EnablePushToUpdate
                );
            }

            OneSignalLiveActivityNative.SetupDefaultWithOptions(nativeOptions);
        }

        public void StartDefault(
            string activityId,
            IDictionary<string, object> attributes,
            IDictionary<string, object> content
        )
        {
            if (!UIDevice.CurrentDevice.CheckSystemVersion(16, 1))
            {
                Console.WriteLine("StartDefault is only available on iOS 16.1 and later.");
                return;
            }
            if (
                InputGuard.IsMissing(activityId, "startDefault: activityId")
                || InputGuard.IsMissing(attributes, "startDefault: attributes")
                || InputGuard.IsMissing(content, "startDefault: content")
            )
                return;

            OneSignalLiveActivityNative.StartDefault(
                activityId,
                NativeConversion.DictToNSDict(attributes)!,
                NativeConversion.DictToNSDict(content)!
            );
        }
    }
}
