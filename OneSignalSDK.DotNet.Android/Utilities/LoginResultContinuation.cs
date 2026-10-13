using Android.Runtime;
using OneSignalSDK.DotNet.Core.Internal.Utilities;
using OneSignalSDK.DotNet.Core.User;

namespace OneSignalSDK.DotNet.Android;

/// <summary>
/// Bridges the suspending native <c>OneSignal.login(externalId, profile, jwt)</c> to a
/// <see cref="Task"/>. Pass to the native call, then hand its return value to <see cref="OnReturned"/>.
/// </summary>
internal sealed class LoginResultContinuation : Java.Lang.Object, Kotlin.Coroutines.IContinuation
{
    private readonly TaskCompletionSource<LoginResult> _completionSource = new(
        TaskCreationOptions.RunContinuationsAsynchronously
    );

    public Task<LoginResult> Task => _completionSource.Task;

    public Kotlin.Coroutines.ICoroutineContext Context =>
        Kotlin.Coroutines.EmptyCoroutineContext.Instance;

    // Kotlin may call this on any thread and must never see an exception from it.
    public void ResumeWith(Java.Lang.Object result)
    {
        Complete(result);
    }

    // A suspend call that finishes without suspending returns its result and never calls ResumeWith.
    public void OnReturned(Java.Lang.Object? returned)
    {
        var suspended = Kotlin.Coroutines.Intrinsics.IntrinsicsKt.COROUTINE_SUSPENDED;
        if (returned != null && JNIEnv.IsSameObject(returned.Handle, suspended.Handle))
            return;
        Complete(returned);
    }

    public void Fail(string message)
    {
        _completionSource.TrySetResult(LoginResult.Failure("UNKNOWN", message));
    }

    private void Complete(Java.Lang.Object? result)
    {
        try
        {
            _completionSource.TrySetResult(ToLoginResult(result));
        }
        catch (Exception e)
        {
            Fail("loginWithProfile failed: " + e.Message);
        }
    }

    private static LoginResult ToLoginResult(Java.Lang.Object? result)
    {
        if (result == null)
            return LoginResult.Failure("UNKNOWN", "loginWithProfile returned no result");
        if (result.Class.Name == "kotlin.Result$Failure")
            return LoginResult.Failure("UNKNOWN", "loginWithProfile failed: " + result);

        var nativeResult = result.JavaCast<Com.OneSignal.Android.OneSignalResult>();
        var json = new Org.Json.JSONObject((System.Collections.IDictionary)nativeResult.ToMap());
        return LoginResult.FromMap(Json.Deserialize(json.ToString()));
    }
}
