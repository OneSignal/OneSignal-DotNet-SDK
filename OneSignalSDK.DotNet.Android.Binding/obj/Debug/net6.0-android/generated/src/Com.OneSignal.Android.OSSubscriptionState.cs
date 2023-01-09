using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSSubscriptionState']"
	[global::Android.Runtime.Register ("com/onesignal/OSSubscriptionState", DoNotGenerateAcw=true)]
	public partial class OSSubscriptionState : global::Java.Lang.Object, global::Java.Lang.ICloneable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSSubscriptionState", typeof (OSSubscriptionState));

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

		protected OSSubscriptionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_isPushDisabled;
#pragma warning disable 0169
		static Delegate GetIsPushDisabledHandler ()
		{
			if (cb_isPushDisabled == null)
				cb_isPushDisabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPushDisabled);
			return cb_isPushDisabled;
		}

		static bool n_IsPushDisabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsPushDisabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPushDisabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSubscriptionState']/method[@name='isPushDisabled' and count(parameter)=0]"
			[Register ("isPushDisabled", "()Z", "GetIsPushDisabledHandler")]
			get {
				const string __id = "isPushDisabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_isSubscribed;
#pragma warning disable 0169
		static Delegate GetIsSubscribedHandler ()
		{
			if (cb_isSubscribed == null)
				cb_isSubscribed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSubscribed);
			return cb_isSubscribed;
		}

		static bool n_IsSubscribed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsSubscribed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSubscribed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSubscriptionState']/method[@name='isSubscribed' and count(parameter)=0]"
			[Register ("isSubscribed", "()Z", "GetIsSubscribedHandler")]
			get {
				const string __id = "isSubscribed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getObservable;
#pragma warning disable 0169
		static Delegate GetGetObservableHandler ()
		{
			if (cb_getObservable == null)
				cb_getObservable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObservable);
			return cb_getObservable;
		}

		static IntPtr n_GetObservable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Observable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object? Observable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSubscriptionState']/method[@name='getObservable' and count(parameter)=0]"
			[Register ("getObservable", "()Ljava/lang/Object;", "GetGetObservableHandler")]
			get {
				const string __id = "getObservable.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getPushToken;
#pragma warning disable 0169
		static Delegate GetGetPushTokenHandler ()
		{
			if (cb_getPushToken == null)
				cb_getPushToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPushToken);
			return cb_getPushToken;
		}

		static IntPtr n_GetPushToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PushToken);
		}
#pragma warning restore 0169

		public virtual unsafe string? PushToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSubscriptionState']/method[@name='getPushToken' and count(parameter)=0]"
			[Register ("getPushToken", "()Ljava/lang/String;", "GetGetPushTokenHandler")]
			get {
				const string __id = "getPushToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		public virtual unsafe string? UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSubscriptionState']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				const string __id = "getUserId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSubscriptionState']/method[@name='toJSONObject' and count(parameter)=0]"
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
