using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']"
	[global::Android.Runtime.Register ("com/onesignal/OSDeviceState", DoNotGenerateAcw=true)]
	public partial class OSDeviceState : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSDeviceState", typeof (OSDeviceState));

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

		protected OSDeviceState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getEmailAddress;
#pragma warning disable 0169
		static Delegate GetGetEmailAddressHandler ()
		{
			if (cb_getEmailAddress == null)
				cb_getEmailAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEmailAddress);
			return cb_getEmailAddress;
		}

		static IntPtr n_GetEmailAddress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.EmailAddress);
		}
#pragma warning restore 0169

		public virtual unsafe string? EmailAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='getEmailAddress' and count(parameter)=0]"
			[Register ("getEmailAddress", "()Ljava/lang/String;", "GetGetEmailAddressHandler")]
			get {
				const string __id = "getEmailAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getEmailUserId;
#pragma warning disable 0169
		static Delegate GetGetEmailUserIdHandler ()
		{
			if (cb_getEmailUserId == null)
				cb_getEmailUserId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEmailUserId);
			return cb_getEmailUserId;
		}

		static IntPtr n_GetEmailUserId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.EmailUserId);
		}
#pragma warning restore 0169

		public virtual unsafe string? EmailUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='getEmailUserId' and count(parameter)=0]"
			[Register ("getEmailUserId", "()Ljava/lang/String;", "GetGetEmailUserIdHandler")]
			get {
				const string __id = "getEmailUserId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_isEmailSubscribed;
#pragma warning disable 0169
		static Delegate GetIsEmailSubscribedHandler ()
		{
			if (cb_isEmailSubscribed == null)
				cb_isEmailSubscribed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmailSubscribed);
			return cb_isEmailSubscribed;
		}

		static bool n_IsEmailSubscribed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsEmailSubscribed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEmailSubscribed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='isEmailSubscribed' and count(parameter)=0]"
			[Register ("isEmailSubscribed", "()Z", "GetIsEmailSubscribedHandler")]
			get {
				const string __id = "isEmailSubscribed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsPushDisabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPushDisabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='isPushDisabled' and count(parameter)=0]"
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

		static Delegate? cb_isSMSSubscribed;
#pragma warning disable 0169
		static Delegate GetIsSMSSubscribedHandler ()
		{
			if (cb_isSMSSubscribed == null)
				cb_isSMSSubscribed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSMSSubscribed);
			return cb_isSMSSubscribed;
		}

		static bool n_IsSMSSubscribed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsSMSSubscribed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSMSSubscribed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='isSMSSubscribed' and count(parameter)=0]"
			[Register ("isSMSSubscribed", "()Z", "GetIsSMSSubscribedHandler")]
			get {
				const string __id = "isSMSSubscribed.()Z";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsSubscribed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSubscribed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='isSubscribed' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PushToken);
		}
#pragma warning restore 0169

		public virtual unsafe string? PushToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='getPushToken' and count(parameter)=0]"
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

		static Delegate? cb_getSMSNumber;
#pragma warning disable 0169
		static Delegate GetGetSMSNumberHandler ()
		{
			if (cb_getSMSNumber == null)
				cb_getSMSNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSMSNumber);
			return cb_getSMSNumber;
		}

		static IntPtr n_GetSMSNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SMSNumber);
		}
#pragma warning restore 0169

		public virtual unsafe string? SMSNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='getSMSNumber' and count(parameter)=0]"
			[Register ("getSMSNumber", "()Ljava/lang/String;", "GetGetSMSNumberHandler")]
			get {
				const string __id = "getSMSNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getSMSUserId;
#pragma warning disable 0169
		static Delegate GetGetSMSUserIdHandler ()
		{
			if (cb_getSMSUserId == null)
				cb_getSMSUserId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSMSUserId);
			return cb_getSMSUserId;
		}

		static IntPtr n_GetSMSUserId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SMSUserId);
		}
#pragma warning restore 0169

		public virtual unsafe string? SMSUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='getSMSUserId' and count(parameter)=0]"
			[Register ("getSMSUserId", "()Ljava/lang/String;", "GetGetSMSUserIdHandler")]
			get {
				const string __id = "getSMSUserId.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		public virtual unsafe string? UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='getUserId' and count(parameter)=0]"
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

		static Delegate? cb_areNotificationsEnabled;
#pragma warning disable 0169
		static Delegate GetAreNotificationsEnabledHandler ()
		{
			if (cb_areNotificationsEnabled == null)
				cb_areNotificationsEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_AreNotificationsEnabled);
			return cb_areNotificationsEnabled;
		}

		static bool n_AreNotificationsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.AreNotificationsEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='areNotificationsEnabled' and count(parameter)=0]"
		[Register ("areNotificationsEnabled", "()Z", "GetAreNotificationsEnabledHandler")]
		public virtual unsafe bool AreNotificationsEnabled ()
		{
			const string __id = "areNotificationsEnabled.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSDeviceState']/method[@name='toJSONObject' and count(parameter)=0]"
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
