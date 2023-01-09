using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionStateChanges']"
	[global::Android.Runtime.Register ("com/onesignal/OSSMSSubscriptionStateChanges", DoNotGenerateAcw=true)]
	public partial class OSSMSSubscriptionStateChanges : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSSMSSubscriptionStateChanges", typeof (OSSMSSubscriptionStateChanges));

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

		protected OSSMSSubscriptionStateChanges (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionStateChanges']/constructor[@name='OSSMSSubscriptionStateChanges' and count(parameter)=2 and parameter[1][@type='com.onesignal.OSSMSSubscriptionState'] and parameter[2][@type='com.onesignal.OSSMSSubscriptionState']]"
		[Register (".ctor", "(Lcom/onesignal/OSSMSSubscriptionState;Lcom/onesignal/OSSMSSubscriptionState;)V", "")]
		public unsafe OSSMSSubscriptionStateChanges (global::Com.OneSignal.Android.OSSMSSubscriptionState? from, global::Com.OneSignal.Android.OSSMSSubscriptionState? to) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/OSSMSSubscriptionState;Lcom/onesignal/OSSMSSubscriptionState;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((from == null) ? IntPtr.Zero : ((global::Java.Lang.Object) from).Handle);
				__args [1] = new JniArgumentValue ((to == null) ? IntPtr.Zero : ((global::Java.Lang.Object) to).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (from);
				global::System.GC.KeepAlive (to);
			}
		}

		static Delegate? cb_getFrom;
#pragma warning disable 0169
		static Delegate GetGetFromHandler ()
		{
			if (cb_getFrom == null)
				cb_getFrom = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFrom);
			return cb_getFrom;
		}

		static IntPtr n_GetFrom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionStateChanges> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.From);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSSMSSubscriptionState? From {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionStateChanges']/method[@name='getFrom' and count(parameter)=0]"
			[Register ("getFrom", "()Lcom/onesignal/OSSMSSubscriptionState;", "GetGetFromHandler")]
			get {
				const string __id = "getFrom.()Lcom/onesignal/OSSMSSubscriptionState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getTo;
#pragma warning disable 0169
		static Delegate GetGetToHandler ()
		{
			if (cb_getTo == null)
				cb_getTo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTo);
			return cb_getTo;
		}

		static IntPtr n_GetTo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionStateChanges> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.To);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSSMSSubscriptionState? To {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionStateChanges']/method[@name='getTo' and count(parameter)=0]"
			[Register ("getTo", "()Lcom/onesignal/OSSMSSubscriptionState;", "GetGetToHandler")]
			get {
				const string __id = "getTo.()Lcom/onesignal/OSSMSSubscriptionState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionStateChanges> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSSMSSubscriptionStateChanges']/method[@name='toJSONObject' and count(parameter)=0]"
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
