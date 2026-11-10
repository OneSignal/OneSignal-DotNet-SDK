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
        NativeCall.Run("addOutcome", () => OneSignalNative.Session.AddOutcome(name));
    }

    public void AddUniqueOutcome(string name)
    {
        if (InputGuard.IsMissing(name, "addUniqueOutcome: name"))
            return;
        NativeCall.Run("addUniqueOutcome", () => OneSignalNative.Session.AddUniqueOutcome(name));
    }

    public void AddOutcomeWithValue(string name, float value)
    {
        if (
            InputGuard.IsMissing(name, "addOutcomeWithValue: name")
            || InputGuard.IsNotFinite(value, "addOutcomeWithValue: value")
        )
            return;
        NativeCall.Run(
            "addOutcomeWithValue",
            () => OneSignalNative.Session.AddOutcomeWithValue(name, value)
        );
    }
}
