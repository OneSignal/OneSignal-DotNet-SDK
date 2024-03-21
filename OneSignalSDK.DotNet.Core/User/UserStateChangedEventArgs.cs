using System;

namespace OneSignalSDK.DotNet.Core.User
{
    /// <summary>
    /// Several states associated with the SDK can be changed in and outside of the application.
    /// </summary>
    public class UserStateChangedEventArgs : EventArgs
    {
        public UserChangedState State { get; }

        public UserStateChangedEventArgs(UserChangedState state) {
            State = state;
        }
    }

    public sealed class UserChangedState {
        public IUserState Current { get; }

        public UserChangedState(IUserState state) {
            Current = state;
        }
    }
}
