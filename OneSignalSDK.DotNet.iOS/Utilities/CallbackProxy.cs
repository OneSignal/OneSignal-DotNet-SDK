using System;
using OneSignalSDK.DotNet.Core.Utilities;

namespace OneSignalSDK.DotNet.iOS.Utilities;

public interface ICallbackProxy<in TReturn>
{
    void OnResponse(TReturn response);
}

public abstract class CallbackProxy<TReturn> : BaseLater<TReturn>, ICallbackProxy<TReturn>
{
    public abstract void OnResponse(TReturn response);
}

public sealed class BooleanCallbackProxy : CallbackProxy<bool>
{
    public override void OnResponse(bool response) => _complete(response);
}
