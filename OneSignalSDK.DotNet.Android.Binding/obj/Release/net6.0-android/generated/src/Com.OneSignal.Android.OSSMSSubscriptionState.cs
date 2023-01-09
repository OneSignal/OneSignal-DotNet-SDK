using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionState']"
	[global::Android.Runtime.Register ("com/onesignal/OSSMSSubscriptionState", DoNotGenerateAcw=true)]
	public partial class OSSMSSubscriptionState : global::Java.Lang.Object, global::Java.Lang.ICloneable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSSMSSubscriptionState", typeof (OSSMSSubscriptionState));

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

		protected OSSMSSubscriptionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsSubscribed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSubscribed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionState']/method[@name='isSubscribed' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Observable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object? Observable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionState']/method[@name='getObservable' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SMSNumber);
		}
#pragma warning restore 0169

		public virtual unsafe string? SMSNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionState']/method[@name='getSMSNumber' and count(parameter)=0]"
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

		static Delegate? cb_getSmsUserId;
#pragma warning disable 0169
		static Delegate GetGetSmsUserIdHandler ()
		{
			if (cb_getSmsUserId == null)
				cb_getSmsUserId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSmsUserId);
			return cb_getSmsUserId;
		}

		static IntPtr n_GetSmsUserId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SmsUserId);
		}
#pragma warning restore 0169

		public virtual unsafe string? SmsUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionState']/method[@name='getSmsUserId' and count(parameter)=0]"
			[Register ("getSmsUserId", "()Ljava/lang/String;", "GetGetSmsUserIdHandler")]
			get {
				const string __id = "getSmsUserId.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionState']/method[@name='toJSONObject' and count(parameter)=0]"
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
