using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalHmsEventBridge']"
	[global::Android.Runtime.Register ("com/onesignal/OneSignalHmsEventBridge", DoNotGenerateAcw=true)]
	public partial class OneSignalHmsEventBridge : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalHmsEventBridge']/field[@name='HMS_SENT_TIME_KEY']"
		[Register ("HMS_SENT_TIME_KEY")]
		public const string HmsSentTimeKey = (string) "hms.sent_time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalHmsEventBridge']/field[@name='HMS_TTL_KEY']"
		[Register ("HMS_TTL_KEY")]
		public const string HmsTtlKey = (string) "hms.ttl";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignalHmsEventBridge", typeof (OneSignalHmsEventBridge));

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

		protected OneSignalHmsEventBridge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalHmsEventBridge']/constructor[@name='OneSignalHmsEventBridge' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OneSignalHmsEventBridge () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalHmsEventBridge']/method[@name='onNewToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("onNewToken", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void OnNewToken (global::Android.Content.Context context, string token)
		{
			const string __id = "onNewToken.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_token = JNIEnv.NewString ((string?)token);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_token);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_token);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalHmsEventBridge']/method[@name='onNewToken' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onNewToken", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public static unsafe void OnNewToken (global::Android.Content.Context context, string token, global::Android.OS.Bundle? bundle)
		{
			const string __id = "onNewToken.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_token = JNIEnv.NewString ((string?)token);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_token);
				__args [2] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_token);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (bundle);
			}
		}

	}
}
