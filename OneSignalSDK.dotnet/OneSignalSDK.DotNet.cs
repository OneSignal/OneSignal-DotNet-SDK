using System;
using System.Diagnostics;
using OneSignalSDK.DotNet.Core;

namespace OneSignalSDK.DotNet
{
   public class OneSignal
   {
      static readonly Lazy<OneSignalSDKInternal> Implementation = new Lazy<OneSignalSDKInternal>(CreateOneSignal);

      public static OneSignalSDKInternal Default
      {
         get
         {
            if (Implementation.Value == null)
               throw NotImplementedInReferenceAssembly();

            return Implementation.Value;
         }
      }

      static OneSignalSDKInternal CreateOneSignal()
      {
#if __IOS__
            return new OneSignalSDK.DotNet.iOS.OneSignalImplementation();
#elif __ANDROID__
            return new OneSignalSDK.DotNet.Android.OneSignalImplementation();
#else
            Debug.WriteLine("PORTABLE Reached");
            return null;
#endif

      }

      internal static Exception NotImplementedInReferenceAssembly()
      {
         return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
      }
   }
}
