using OneSignalSDK.DotNet.Core;
using OneSignalSDK.DotNet.Core.Session;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.DotNet.Android;

public class AndroidSessionManager : ISessionManager
{
    public void AddOutcome(string name)
    {
        if (InputGuard.IsMissing(name, "addOutcome: name"))
            return;
        if (AndroidInit.Reject("addOutcome"))
            return;
        OneSignalNative.Session.AddOutcome(name);
    }

    public void AddUniqueOutcome(string name)
    {
        if (InputGuard.IsMissing(name, "addUniqueOutcome: name"))
            return;
        if (AndroidInit.Reject("addUniqueOutcome"))
            return;
        OneSignalNative.Session.AddUniqueOutcome(name);
    }

    public void AddOutcomeWithValue(string name, float value)
    {
        if (
            InputGuard.IsMissing(name, "addOutcomeWithValue: name")
            || InputGuard.IsNotFinite(value, "addOutcomeWithValue: value")
        )
            return;
        if (AndroidInit.Reject("addOutcomeWithValue"))
            return;
        OneSignalNative.Session.AddOutcomeWithValue(name, value);
    }
}
