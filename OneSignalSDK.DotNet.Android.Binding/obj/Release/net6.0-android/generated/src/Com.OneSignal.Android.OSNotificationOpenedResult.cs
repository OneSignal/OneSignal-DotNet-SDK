using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenedResult']"
	[global::Android.Runtime.Register ("com/onesignal/OSNotificationOpenedResult", DoNotGenerateAcw=true)]
	public partial class OSNotificationOpenedResult : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotificationOpenedResult", typeof (OSNotificationOpenedResult));

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

		protected OSNotificationOpenedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenedResult']/constructor[@name='OSNotificationOpenedResult' and count(parameter)=2 and parameter[1][@type='com.onesignal.OSNotification'] and parameter[2][@type='com.onesignal.OSNotificationAction']]"
		[Register (".ctor", "(Lcom/onesignal/OSNotification;Lcom/onesignal/OSNotificationAction;)V", "")]
		public unsafe OSNotificationOpenedResult (global::Com.OneSignal.Android.OSNotification? notification, global::Com.OneSignal.Android.OSNotificationAction? action) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/OSNotification;Lcom/onesignal/OSNotificationAction;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((notification == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notification).Handle);
				__args [1] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (notification);
				global::System.GC.KeepAlive (action);
			}
		}

		static Delegate? cb_getAction;
#pragma warning disable 0169
		static Delegate GetGetActionHandler ()
		{
			if (cb_getAction == null)
				cb_getAction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAction);
			return cb_getAction;
		}

		static IntPtr n_GetAction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationOpenedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Action);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSNotificationAction? Action {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenedResult']/method[@name='getAction' and count(parameter)=0]"
			[Register ("getAction", "()Lcom/onesignal/OSNotificationAction;", "GetGetActionHandler")]
			get {
				const string __id = "getAction.()Lcom/onesignal/OSNotificationAction;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationOpenedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Notification);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSNotification? Notification {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenedResult']/method[@name='getNotification' and count(parameter)=0]"
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

		static Delegate? cb_onEntryStateChange_Lcom_onesignal_OneSignal_AppEntryAction_;
#pragma warning disable 0169
		static Delegate GetOnEntryStateChange_Lcom_onesignal_OneSignal_AppEntryAction_Handler ()
		{
			if (cb_onEntryStateChange_Lcom_onesignal_OneSignal_AppEntryAction_ == null)
				cb_onEntryStateChange_Lcom_onesignal_OneSignal_AppEntryAction_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnEntryStateChange_Lcom_onesignal_OneSignal_AppEntryAction_);
			return cb_onEntryStateChange_Lcom_onesignal_OneSignal_AppEntryAction_;
		}

		static void n_OnEntryStateChange_Lcom_onesignal_OneSignal_AppEntryAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appEntryState)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationOpenedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var appEntryState = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.AppEntryAction> (native_appEntryState, JniHandleOwnership.DoNotTransfer);
			__this.OnEntryStateChange (appEntryState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenedResult']/method[@name='onEntryStateChange' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.AppEntryAction']]"
		[Register ("onEntryStateChange", "(Lcom/onesignal/OneSignal$AppEntryAction;)V", "GetOnEntryStateChange_Lcom_onesignal_OneSignal_AppEntryAction_Handler")]
		public virtual unsafe void OnEntryStateChange (global::Com.OneSignal.Android.OneSignal.AppEntryAction? appEntryState)
		{
			const string __id = "onEntryStateChange.(Lcom/onesignal/OneSignal$AppEntryAction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((appEntryState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) appEntryState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (appEntryState);
			}
		}

		static Delegate? cb_stringify;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetStringifyHandler ()
		{
			if (cb_stringify == null)
				cb_stringify = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Stringify);
			return cb_stringify;
		}

		[Obsolete]
		static IntPtr n_Stringify (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationOpenedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Stringify ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenedResult']/method[@name='stringify' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("stringify", "()Ljava/lang/String;", "GetStringifyHandler")]
		public virtual unsafe string? Stringify ()
		{
			const string __id = "stringify.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationOpenedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationOpenedResult']/method[@name='toJSONObject' and count(parameter)=0]"
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
