using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSOutcomeEvent']"
	[global::Android.Runtime.Register ("com/onesignal/OSOutcomeEvent", DoNotGenerateAcw=true)]
	public partial class OSOutcomeEvent : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSOutcomeEvent", typeof (OSOutcomeEvent));

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

		protected OSOutcomeEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSOutcomeEvent']/constructor[@name='OSOutcomeEvent' and count(parameter)=5 and parameter[1][@type='com.onesignal.influence.domain.OSInfluenceType'] and parameter[2][@type='org.json.JSONArray'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='float']]"
		[Register (".ctor", "(Lcom/onesignal/influence/domain/OSInfluenceType;Lorg/json/JSONArray;Ljava/lang/String;JF)V", "")]
		public unsafe OSOutcomeEvent (global::Com.Onesignal.Influence.Domain.OSInfluenceType session, global::Org.Json.JSONArray? notificationIds, string name, long timestamp, float weight) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/influence/domain/OSInfluenceType;Lorg/json/JSONArray;Ljava/lang/String;JF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				__args [1] = new JniArgumentValue ((notificationIds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notificationIds).Handle);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (timestamp);
				__args [4] = new JniArgumentValue (weight);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (session);
				global::System.GC.KeepAlive (notificationIds);
			}
		}

		static Delegate? cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSOutcomeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string? Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSOutcomeEvent']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getNotificationIds;
#pragma warning disable 0169
		static Delegate GetGetNotificationIdsHandler ()
		{
			if (cb_getNotificationIds == null)
				cb_getNotificationIds = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNotificationIds);
			return cb_getNotificationIds;
		}

		static IntPtr n_GetNotificationIds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSOutcomeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.NotificationIds);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONArray? NotificationIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSOutcomeEvent']/method[@name='getNotificationIds' and count(parameter)=0]"
			[Register ("getNotificationIds", "()Lorg/json/JSONArray;", "GetGetNotificationIdsHandler")]
			get {
				const string __id = "getNotificationIds.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getSession;
#pragma warning disable 0169
		static Delegate GetGetSessionHandler ()
		{
			if (cb_getSession == null)
				cb_getSession = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSession);
			return cb_getSession;
		}

		static IntPtr n_GetSession (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSOutcomeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Session);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceType? Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSOutcomeEvent']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lcom/onesignal/influence/domain/OSInfluenceType;", "GetGetSessionHandler")]
			get {
				const string __id = "getSession.()Lcom/onesignal/influence/domain/OSInfluenceType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSOutcomeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Timestamp;
		}
#pragma warning restore 0169

		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSOutcomeEvent']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				const string __id = "getTimestamp.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getWeight;
#pragma warning disable 0169
		static Delegate GetGetWeightHandler ()
		{
			if (cb_getWeight == null)
				cb_getWeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetWeight);
			return cb_getWeight;
		}

		static float n_GetWeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSOutcomeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Weight;
		}
#pragma warning restore 0169

		public virtual unsafe float Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSOutcomeEvent']/method[@name='getWeight' and count(parameter)=0]"
			[Register ("getWeight", "()F", "GetGetWeightHandler")]
			get {
				const string __id = "getWeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSOutcomeEvent']/method[@name='fromOutcomeEventParamsV2toOutcomeEventV1' and count(parameter)=1 and parameter[1][@type='com.onesignal.outcomes.domain.OSOutcomeEventParams']]"
		[Register ("fromOutcomeEventParamsV2toOutcomeEventV1", "(Lcom/onesignal/outcomes/domain/OSOutcomeEventParams;)Lcom/onesignal/OSOutcomeEvent;", "")]
		public static unsafe global::Com.OneSignal.Android.OSOutcomeEvent? FromOutcomeEventParamsV2toOutcomeEventV1 (global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams? outcomeEventParams)
		{
			const string __id = "fromOutcomeEventParamsV2toOutcomeEventV1.(Lcom/onesignal/outcomes/domain/OSOutcomeEventParams;)Lcom/onesignal/OSOutcomeEvent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((outcomeEventParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outcomeEventParams).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSOutcomeEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (outcomeEventParams);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSOutcomeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSOutcomeEvent']/method[@name='toJSONObject' and count(parameter)=0]"
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

		static Delegate? cb_toJSONObjectForMeasure;
#pragma warning disable 0169
		static Delegate GetToJSONObjectForMeasureHandler ()
		{
			if (cb_toJSONObjectForMeasure == null)
				cb_toJSONObjectForMeasure = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToJSONObjectForMeasure);
			return cb_toJSONObjectForMeasure;
		}

		static IntPtr n_ToJSONObjectForMeasure (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSOutcomeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObjectForMeasure ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSOutcomeEvent']/method[@name='toJSONObjectForMeasure' and count(parameter)=0]"
		[Register ("toJSONObjectForMeasure", "()Lorg/json/JSONObject;", "GetToJSONObjectForMeasureHandler")]
		public virtual unsafe global::Org.Json.JSONObject? ToJSONObjectForMeasure ()
		{
			const string __id = "toJSONObjectForMeasure.()Lorg/json/JSONObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
