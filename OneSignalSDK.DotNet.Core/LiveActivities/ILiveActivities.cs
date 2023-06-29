using System;
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
	}
}

