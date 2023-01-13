using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Session;

using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidSessionManager : ISessionManager
{
    public void AddOutcome(string name) => OneSignalNative.Session.AddOutcome(name);
    public void AddUniqueOutcome(string name) => OneSignalNative.Session.AddUniqueOutcome(name);
    public void AddOutcomeWithValue(string name, float value) => OneSignalNative.Session.AddOutcomeWithValue(name, value);
}
