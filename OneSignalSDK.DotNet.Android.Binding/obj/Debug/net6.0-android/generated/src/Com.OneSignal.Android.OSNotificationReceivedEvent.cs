using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationReceivedEvent']"
	[global::Android.Runtime.Register ("com/onesignal/OSNotificationReceivedEvent", DoNotGenerateAcw=true)]
	public partial class OSNotificationReceivedEvent : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotificationReceivedEvent", typeof (OSNotificationReceivedEvent));

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

		protected OSNotificationReceivedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getNotification;
#pragma warning disable 0169
		static Delegate GetGetNotificationHandler ()
		{
			if (cb_getNotification == null)
				cb_getNotification = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNotification);
			return cb_getNotification;
		}

		static IntPtr n_GetNotification (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationReceivedEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Notification);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSNotification? Notification {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationReceivedEvent']/method[@name='getNotification' and count(parameter)=0]"
			[Register ("getNotification", "()Lcom/onesignal/OSNotification;", "GetGetNotificationHandler")]
			get {
				const string __id = "getNotification.()Lcom/onesignal/OSNotification;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_complete_Lcom_onesignal_OSNotification_;
#pragma warning disable 0169
		static Delegate GetComplete_Lcom_onesignal_OSNotification_Handler ()
		{
			if (cb_complete_Lcom_onesignal_OSNotification_ == null)
				cb_complete_Lcom_onesignal_OSNotification_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Complete_Lcom_onesignal_OSNotification_);
			return cb_complete_Lcom_onesignal_OSNotification_;
		}

		static void n_Complete_Lcom_onesignal_OSNotification_ (IntPtr jnienv, IntPtr native__this, IntPtr native_notification)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationReceivedEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var notification = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (native_notification, JniHandleOwnership.DoNotTransfer);
			__this.Complete (notification);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationReceivedEvent']/method[@name='complete' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSNotification']]"
		[Register ("complete", "(Lcom/onesignal/OSNotification;)V", "GetComplete_Lcom_onesignal_OSNotification_Handler")]
		public virtual unsafe void Complete (global::Com.OneSignal.Android.OSNotification? notification)
		{
			const string __id = "complete.(Lcom/onesignal/OSNotification;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((notification == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notification).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (notification);
			}
		}

		static Delegate? cb_toJSONObject;
#pragma warning disable 0169
		static Delegate GetToJSONObjectHandler ()
		{
			if (cb_toJSONObject == null)
				cb_toJSONObject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToJSONObject);
			return cb_toJSONObject;
		}

		static IntPtr n_ToJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationReceivedEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationReceivedEvent']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "GetToJSONObjectHandler")]
		public virtual unsafe global::Org.Json.JSONObject? ToJSONObject ()
		{
			const string __id = "toJSONObject.()Lorg/json/JSONObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
