using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='GenerateNotificationOpenIntentFromPushPayload']"
	[global::Android.Runtime.Register ("com/onesignal/GenerateNotificationOpenIntentFromPushPayload", DoNotGenerateAcw=true)]
	public sealed partial class GenerateNotificationOpenIntentFromPushPayload : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='GenerateNotificationOpenIntentFromPushPayload']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.OneSignal.Android.GenerateNotificationOpenIntentFromPushPayload Instance {
			get {
				const string __id = "INSTANCE.Lcom/onesignal/GenerateNotificationOpenIntentFromPushPayload;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.GenerateNotificationOpenIntentFromPushPayload> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/GenerateNotificationOpenIntentFromPushPayload", typeof (GenerateNotificationOpenIntentFromPushPayload));

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

		internal GenerateNotificationOpenIntentFromPushPayload (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='GenerateNotificationOpenIntentFromPushPayload']/method[@name='create' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("create", "(Landroid/content/Context;Lorg/json/JSONObject;)Lcom/onesignal/GenerateNotificationOpenIntent;", "")]
		public unsafe global::Com.OneSignal.Android.GenerateNotificationOpenIntent Create (global::Android.Content.Context context, global::Org.Json.JSONObject fcmPayload)
		{
			const string __id = "create.(Landroid/content/Context;Lorg/json/JSONObject;)Lcom/onesignal/GenerateNotificationOpenIntent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((fcmPayload == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fcmPayload).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.GenerateNotificationOpenIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (fcmPayload);
			}
		}

	}
}
