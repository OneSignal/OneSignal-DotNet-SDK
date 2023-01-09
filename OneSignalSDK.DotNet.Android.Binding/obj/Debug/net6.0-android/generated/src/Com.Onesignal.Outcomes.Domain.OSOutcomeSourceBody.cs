using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Outcomes.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSourceBody']"
	[global::Android.Runtime.Register ("com/onesignal/outcomes/domain/OSOutcomeSourceBody", DoNotGenerateAcw=true)]
	public sealed partial class OSOutcomeSourceBody : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/outcomes/domain/OSOutcomeSourceBody", typeof (OSOutcomeSourceBody));

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

		internal OSOutcomeSourceBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSourceBody']/constructor[@name='OSOutcomeSourceBody' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSOutcomeSourceBody () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSourceBody']/constructor[@name='OSOutcomeSourceBody' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register (".ctor", "(Lorg/json/JSONArray;)V", "")]
		public unsafe OSOutcomeSourceBody (global::Org.Json.JSONArray? notificationIds) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/json/JSONArray;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((notificationIds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notificationIds).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (notificationIds);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSourceBody']/constructor[@name='OSOutcomeSourceBody' and count(parameter)=2 and parameter[1][@type='org.json.JSONArray'] and parameter[2][@type='org.json.JSONArray']]"
		[Register (".ctor", "(Lorg/json/JSONArray;Lorg/json/JSONArray;)V", "")]
		public unsafe OSOutcomeSourceBody (global::Org.Json.JSONArray? notificationIds, global::Org.Json.JSONArray? inAppMessagesIds) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/json/JSONArray;Lorg/json/JSONArray;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((notificationIds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notificationIds).Handle);
				__args [1] = new JniArgumentValue ((inAppMessagesIds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppMessagesIds).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (notificationIds);
				global::System.GC.KeepAlive (inAppMessagesIds);
			}
		}

		public unsafe global::Org.Json.JSONArray? InAppMessagesIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSourceBody']/method[@name='getInAppMessagesIds' and count(parameter)=0]"
			[Register ("getInAppMessagesIds", "()Lorg/json/JSONArray;", "")]
			get {
				const string __id = "getInAppMessagesIds.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSourceBody']/method[@name='setInAppMessagesIds' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
			[Register ("setInAppMessagesIds", "(Lorg/json/JSONArray;)V", "")]
			set {
				const string __id = "setInAppMessagesIds.(Lorg/json/JSONArray;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Org.Json.JSONArray? NotificationIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSourceBody']/method[@name='getNotificationIds' and count(parameter)=0]"
			[Register ("getNotificationIds", "()Lorg/json/JSONArray;", "")]
			get {
				const string __id = "getNotificationIds.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSourceBody']/method[@name='setNotificationIds' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
			[Register ("setNotificationIds", "(Lorg/json/JSONArray;)V", "")]
			set {
				const string __id = "setNotificationIds.(Lorg/json/JSONArray;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSourceBody']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject ToJSONObject ()
		{
			const string __id = "toJSONObject.()Lorg/json/JSONObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}
}
