using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSEmailSubscriptionState']"
	[global::Android.Runtime.Register ("com/onesignal/OSEmailSubscriptionState", DoNotGenerateAcw=true)]
	public partial class OSEmailSubscriptionState : global::Java.Lang.Object, global::Java.Lang.ICloneable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSEmailSubscriptionState", typeof (OSEmailSubscriptionState));

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

		protected OSEmailSubscriptionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSEmailSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.EmailAddress);
		}
#pragma warning restore 0169

		public virtual unsafe string? EmailAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSEmailSubscriptionState']/method[@name='getEmailAddress' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSEmailSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.EmailUserId);
		}
#pragma warning restore 0169

		public virtual unsafe string? EmailUserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSEmailSubscriptionState']/method[@name='getEmailUserId' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSEmailSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsSubscribed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSubscribed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSEmailSubscriptionState']/method[@name='isSubscribed' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSEmailSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Observable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object? Observable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSEmailSubscriptionState']/method[@name='getObservable' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSEmailSubscriptionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSEmailSubscriptionState']/method[@name='toJSONObject' and count(parameter)=0]"
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
