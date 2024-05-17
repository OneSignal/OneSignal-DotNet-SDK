using System;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.LiveActivities;
using OneSignalSDK.DotNet.iOS.Utilities;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;
using OneSignalLiveActivityNative = Com.OneSignal.iOS.OneSignalLiveActivitiesManagerImpl;
using LiveActivitySetupOptionsNative = Com.OneSignal.iOS.LiveActivitySetupOptions;

namespace OneSignalSDK.DotNet.iOS
{
	public class iOSLiveActivitiesManager: ILiveActivitiesManager
	{
        public async Task<bool> Enter(string activityId, string token)
        {
            BooleanCallbackProxy proxy = new BooleanCallbackProxy();
            OneSignalNative.LiveActivities.Enter(activityId, token, response => proxy.OnResponse(true), response => proxy.OnResponse(false));
            return await proxy;
        }

        public async Task<bool> Exit(string activityId)
        {
            BooleanCallbackProxy proxy = new BooleanCallbackProxy();
            OneSignalNative.LiveActivities.Exit(activityId, response => proxy.OnResponse(true), response => proxy.OnResponse(false));
            return await proxy;
        }

        public void RemovePushToStartToken(string activityType)
        {
            if (!UIDevice.CurrentDevice.CheckSystemVersion(17,2))
            {
                Console.WriteLine("RemovePushToStartToken is only available on iOS 17.2 and later.");
                return;
            }

            NSError error;
            OneSignalLiveActivityNative.RemovePushToStartToken(activityType, out error);

            if (error != null)
            {
                throw new Exception(error.LocalizedDescription);
            }
        }

        public void SetPushToStartToken(string activityType, string token)
        {
            if (!UIDevice.CurrentDevice.CheckSystemVersion(17,2))
            {
                Console.WriteLine("SetPushToStartToken is only available on iOS 17.2 and later.");
                return;
            }

            NSError error;
            OneSignalLiveActivityNative.SetPushToStartToken(activityType, token, out error);

            if (error != null)
            {
                throw new Exception(error.LocalizedDescription);
            }
        }

        public void SetupDefault(LiveActivitySetupOptions options = null)
        {
            if (!UIDevice.CurrentDevice.CheckSystemVersion(16,1))
            {
                Console.WriteLine("SetupDefault is only available on iOS 16.1 and later.");
                return;
            }

            LiveActivitySetupOptionsNative nativeOptions = null;

            if(options != null)
            {
                nativeOptions = new LiveActivitySetupOptionsNative(options.EnablePushToStart, options.EnablePushToUpdate);
            }

            OneSignalLiveActivityNative.SetupDefaultWithOptions(nativeOptions);
        }

        public void StartDefault(string activityId, IDictionary<string, object> attributes, IDictionary<string, object> content)
        {
            if (!UIDevice.CurrentDevice.CheckSystemVersion(16,1))
            {
                Console.WriteLine("StartDefault is only available on iOS 16.1 and later.");
                return;
            }


            OneSignalLiveActivityNative.StartDefault(activityId, NativeConversion.DictToNSDict(attributes), NativeConversion.DictToNSDict(content));
        }
    }
}
