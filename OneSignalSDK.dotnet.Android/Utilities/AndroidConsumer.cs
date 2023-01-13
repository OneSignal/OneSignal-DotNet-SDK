using System.Runtime.CompilerServices;
using Com.OneSignal.Android;
using Java.Util.Functions;

namespace OneSignalSDK.DotNet.Android;

public class AndroidConsumer<TResult> : Java.Lang.Object
{
    protected TaskCompletionSource<TResult> _completionSource = new TaskCompletionSource<TResult>();

    public TaskAwaiter<TResult> GetAwaiter()
    {
        return _completionSource.Task.GetAwaiter();
    }
}

public class AndroidVoidConsumer : AndroidConsumer<object?>, IConsumer
{
    public void Accept(Java.Lang.Object? t)
    {
        var result = t as ContinueResult;
        if (result?.IsSuccess ?? false)
        {
            _completionSource.TrySetResult(null);
        }
        else
        {
            _completionSource.TrySetException(result?.Throwable ?? new Exception("Error with async method"));
        }
    }
}

public class AndroidBoolConsumer : AndroidConsumer<bool>, IConsumer
{
    public void Accept(Java.Lang.Object? t)
    {
        var result = t as ContinueResult;
        if (result?.IsSuccess ?? false && result.Data != null && (result.Data is Java.Lang.Boolean))
        {
            var boolValue = ((Java.Lang.Boolean)result!.Data!).BooleanValue();
            _completionSource.TrySetResult(boolValue);
        }
        else
        {
            _completionSource.TrySetException(result?.Throwable ?? new Exception("Error with async method"));
        }
    }
}
