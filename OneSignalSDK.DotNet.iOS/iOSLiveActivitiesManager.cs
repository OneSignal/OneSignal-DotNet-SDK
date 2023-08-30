using System;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.LiveActivities;
using OneSignalSDK.DotNet.iOS.Utilities;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;
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
    }
}
