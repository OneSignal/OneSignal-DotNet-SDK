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
}