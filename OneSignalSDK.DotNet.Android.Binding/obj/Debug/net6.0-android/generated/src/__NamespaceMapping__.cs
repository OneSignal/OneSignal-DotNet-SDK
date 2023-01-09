using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onesignal", Managed="Com.OneSignal.Android")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onesignal.influence.data", Managed="Com.Onesignal.Influence.Data")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onesignal.influence.domain", Managed="Com.Onesignal.Influence.Domain")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onesignal.language", Managed="Com.Onesignal.Language")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onesignal.outcomes.data", Managed="Com.Onesignal.Outcomes.Data")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onesignal.outcomes.domain", Managed="Com.Onesignal.Outcomes.Domain")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onesignal.shortcutbadger", Managed="Com.Onesignal.Shortcutbadger")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onesignal.shortcutbadger.impl", Managed="Com.Onesignal.Shortcutbadger.Impl")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onesignal.shortcutbadger.util", Managed="Com.Onesignal.Shortcutbadger.Util")]

delegate float _JniMarshal_PP_F (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPF_V (IntPtr jnienv, IntPtr klass, float p0);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPIIIIIIIIZ_Z (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, bool p8);
delegate void _JniMarshal_PPILL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPJ_L (IntPtr jnienv, IntPtr klass, long p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate int _JniMarshal_PPLII_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate IntPtr _JniMarshal_PPLILI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, int p3);
delegate void _JniMarshal_PPLILL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate int _JniMarshal_PPLLI_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate void _JniMarshal_PPLLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate IntPtr _JniMarshal_PPLLIZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, bool p3);
delegate long _JniMarshal_PPLLJ_J (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, long p2);
delegate void _JniMarshal_PPLLJ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, long p2);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate int _JniMarshal_PPLLLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLLLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6);
delegate IntPtr _JniMarshal_PPLLLLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6, IntPtr p7);
delegate void _JniMarshal_PPLLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2);
delegate bool _JniMarshal_PPLLZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2);
delegate bool _JniMarshal_PPLZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

