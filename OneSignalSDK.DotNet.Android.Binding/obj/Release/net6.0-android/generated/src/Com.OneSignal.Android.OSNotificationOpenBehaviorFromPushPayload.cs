using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenBehaviorFromPushPayload']"
	[global::Android.Runtime.Register ("com/onesignal/OSNotificationOpenBehaviorFromPushPayload", DoNotGenerateAcw=true)]
	public sealed partial class OSNotificationOpenBehaviorFromPushPayload : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotificationOpenBehaviorFromPushPayload", typeof (OSNotificationOpenBehaviorFromPushPayload));

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

		internal OSNotificationOpenBehaviorFromPushPayload (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenBehaviorFromPushPayload']/constructor[@name='OSNotificationOpenBehaviorFromPushPayload' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/json/JSONObject;)V", "")]
		public unsafe OSNotificationOpenBehaviorFromPushPayload (global::Android.Content.Context context, global::Org.Json.JSONObject fcmPayload) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lorg/json/JSONObject;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((fcmPayload == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fcmPayload).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (fcmPayload);
			}
		}

		public unsafe bool ShouldOpenApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenBehaviorFromPushPayload']/method[@name='getShouldOpenApp' and count(parameter)=0]"
			[Register ("getShouldOpenApp", "()Z", "")]
			get {
				const string __id = "getShouldOpenApp.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Net.Uri? Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenBehaviorFromPushPayload']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Landroid/net/Uri;", "")]
			get {
				const string __id = "getUri.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
