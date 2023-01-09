using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='NavigateToAndroidSettingsForLocation']"
	[global::Android.Runtime.Register ("com/onesignal/NavigateToAndroidSettingsForLocation", DoNotGenerateAcw=true)]
	public sealed partial class NavigateToAndroidSettingsForLocation : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='NavigateToAndroidSettingsForLocation']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.OneSignal.Android.NavigateToAndroidSettingsForLocation Instance {
			get {
				const string __id = "INSTANCE.Lcom/onesignal/NavigateToAndroidSettingsForLocation;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.NavigateToAndroidSettingsForLocation> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/NavigateToAndroidSettingsForLocation", typeof (NavigateToAndroidSettingsForLocation));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal NavigateToAndroidSettingsForLocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NavigateToAndroidSettingsForLocation']/method[@name='show' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("show", "(Landroid/content/Context;)V", "")]
		public unsafe void Show (global::Android.Content.Context context)
		{
			const string __id = "show.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
