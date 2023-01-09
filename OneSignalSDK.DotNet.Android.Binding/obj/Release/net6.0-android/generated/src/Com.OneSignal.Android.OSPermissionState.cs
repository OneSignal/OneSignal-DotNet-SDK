using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSPermissionState']"
	[global::Android.Runtime.Register ("com/onesignal/OSPermissionState", DoNotGenerateAcw=true)]
	public partial class OSPermissionState : global::Java.Lang.Object, global::Java.Lang.ICloneable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSPermissionState", typeof (OSPermissionState));

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

		protected OSPermissionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSPermissionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Observable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object? Observable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSPermissionState']/method[@name='getObservable' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSPermissionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.AreNotificationsEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSPermissionState']/method[@name='areNotificationsEnabled' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSPermissionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSPermissionState']/method[@name='toJSONObject' and count(parameter)=0]"
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
