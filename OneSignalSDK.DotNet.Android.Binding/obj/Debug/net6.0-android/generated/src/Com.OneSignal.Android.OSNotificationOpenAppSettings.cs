using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenAppSettings']"
	[global::Android.Runtime.Register ("com/onesignal/OSNotificationOpenAppSettings", DoNotGenerateAcw=true)]
	public sealed partial class OSNotificationOpenAppSettings : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenAppSettings']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.OneSignal.Android.OSNotificationOpenAppSettings Instance {
			get {
				const string __id = "INSTANCE.Lcom/onesignal/OSNotificationOpenAppSettings;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationOpenAppSettings> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotificationOpenAppSettings", typeof (OSNotificationOpenAppSettings));

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

		internal OSNotificationOpenAppSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenAppSettings']/method[@name='getShouldOpenActivity' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getShouldOpenActivity", "(Landroid/content/Context;)Z", "")]
		public unsafe bool GetShouldOpenActivity (global::Android.Content.Context context)
		{
			const string __id = "getShouldOpenActivity.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenAppSettings']/method[@name='getSuppressLaunchURL' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSuppressLaunchURL", "(Landroid/content/Context;)Z", "")]
		public unsafe bool GetSuppressLaunchURL (global::Android.Content.Context context)
		{
			const string __id = "getSuppressLaunchURL.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
