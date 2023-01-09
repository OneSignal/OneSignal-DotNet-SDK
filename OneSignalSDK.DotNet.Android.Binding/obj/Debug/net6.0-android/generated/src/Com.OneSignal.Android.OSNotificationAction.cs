using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationAction']"
	[global::Android.Runtime.Register ("com/onesignal/OSNotificationAction", DoNotGenerateAcw=true)]
	public partial class OSNotificationAction : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationAction.ActionType']"
		[global::Android.Runtime.Register ("com/onesignal/OSNotificationAction$ActionType", DoNotGenerateAcw=true)]
		public sealed partial class ActionType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationAction.ActionType']/field[@name='ActionTaken']"
			[Register ("ActionTaken")]
			public static global::Com.OneSignal.Android.OSNotificationAction.ActionType? ActionTaken {
				get {
					const string __id = "ActionTaken.Lcom/onesignal/OSNotificationAction$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationAction.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationAction.ActionType']/field[@name='Opened']"
			[Register ("Opened")]
			public static global::Com.OneSignal.Android.OSNotificationAction.ActionType? Opened {
				get {
					const string __id = "Opened.Lcom/onesignal/OSNotificationAction$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationAction.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotificationAction$ActionType", typeof (ActionType));

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

			internal ActionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationAction.ActionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/onesignal/OSNotificationAction$ActionType;", "")]
			public static unsafe global::Com.OneSignal.Android.OSNotificationAction.ActionType? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/onesignal/OSNotificationAction$ActionType;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationAction.ActionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationAction.ActionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/onesignal/OSNotificationAction$ActionType;", "")]
			public static unsafe global::Com.OneSignal.Android.OSNotificationAction.ActionType[]? Values ()
			{
				const string __id = "values.()[Lcom/onesignal/OSNotificationAction$ActionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.OneSignal.Android.OSNotificationAction.ActionType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.OneSignal.Android.OSNotificationAction.ActionType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotificationAction", typeof (OSNotificationAction));

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

		protected OSNotificationAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationAction']/constructor[@name='OSNotificationAction' and count(parameter)=2 and parameter[1][@type='com.onesignal.OSNotificationAction.ActionType'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/onesignal/OSNotificationAction$ActionType;Ljava/lang/String;)V", "")]
		public unsafe OSNotificationAction (global::Com.OneSignal.Android.OSNotificationAction.ActionType? type, string? actionId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/OSNotificationAction$ActionType;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_actionId = JNIEnv.NewString ((string?)actionId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (native_actionId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_actionId);
				global::System.GC.KeepAlive (type);
			}
		}

		static Delegate? cb_getActionId;
#pragma warning disable 0169
		static Delegate GetGetActionIdHandler ()
		{
			if (cb_getActionId == null)
				cb_getActionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetActionId);
			return cb_getActionId;
		}

		static IntPtr n_GetActionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ActionId);
		}
#pragma warning restore 0169

		public virtual unsafe string? ActionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationAction']/method[@name='getActionId' and count(parameter)=0]"
			[Register ("getActionId", "()Ljava/lang/String;", "GetGetActionIdHandler")]
			get {
				const string __id = "getActionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSNotificationAction.ActionType? Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationAction']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/onesignal/OSNotificationAction$ActionType;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Lcom/onesignal/OSNotificationAction$ActionType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationAction.ActionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationAction']/method[@name='toJSONObject' and count(parameter)=0]"
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
