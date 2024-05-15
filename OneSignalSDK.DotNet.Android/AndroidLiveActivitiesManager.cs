using System;
namespace OneSignalSDK.DotNet.Android;

using System.Threading.Tasks;
using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.LiveActivities;

public class AndroidLiveActivitiesManager: ILiveActivitiesManager
{
    public Task<bool> Enter(string activityId, string token)
    {
        Console.WriteLine("OneSignal: EnterLiveActivity is available on iOS only");
        return Task.FromResult(false);
    }

    public Task<bool> Exit(string activityId)
    {
        Console.WriteLine("OneSignal: ExitLiveActivity is available on iOS only");
        return Task.FromResult(false);
    }

    public void RemovePushToStartToken(string activityType)
    {
        Console.WriteLine("OneSignal: RemovePushToStartToken is available on iOS only");
    }

    public void SetPushToStartToken(string activityType, string token)
    {
        Console.WriteLine("OneSignal: SetPushToStartToken is available on iOS only");
    }

    public void SetupDefault(LiveActivitySetupOptions options = null)
    {
        Console.WriteLine("OneSignal: SetupDefault is available on iOS only");
    }

    public void StartDefault(string activityId, IDictionary<string, object> attributes, IDictionary<string, object> content)
    {
        Console.WriteLine("OneSignal: StartDefault is available on iOS only");
    }
}