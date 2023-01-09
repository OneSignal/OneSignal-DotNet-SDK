using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationIntentExtras']"
	[global::Android.Runtime.Register ("com/onesignal/OSNotificationIntentExtras", DoNotGenerateAcw=true)]
	public sealed partial class OSNotificationIntentExtras : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotificationIntentExtras", typeof (OSNotificationIntentExtras));

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

		internal OSNotificationIntentExtras (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationIntentExtras']/constructor[@name='OSNotificationIntentExtras' and count(parameter)=2 and parameter[1][@type='org.json.JSONArray'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONArray;Lorg/json/JSONObject;)V", "")]
		public unsafe OSNotificationIntentExtras (global::Org.Json.JSONArray? dataArray, global::Org.Json.JSONObject? jsonData) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/json/JSONArray;Lorg/json/JSONObject;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dataArray == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataArray).Handle);
				__args [1] = new JniArgumentValue ((jsonData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonData).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dataArray);
				global::System.GC.KeepAlive (jsonData);
			}
		}

		public unsafe global::Org.Json.JSONArray? DataArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationIntentExtras']/method[@name='getDataArray' and count(parameter)=0]"
			[Register ("getDataArray", "()Lorg/json/JSONArray;", "")]
			get {
				const string __id = "getDataArray.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationIntentExtras']/method[@name='setDataArray' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
			[Register ("setDataArray", "(Lorg/json/JSONArray;)V", "")]
			set {
				const string __id = "setDataArray.(Lorg/json/JSONArray;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Org.Json.JSONObject? JsonData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationIntentExtras']/method[@name='getJsonData' and count(parameter)=0]"
			[Register ("getJsonData", "()Lorg/json/JSONObject;", "")]
			get {
				const string __id = "getJsonData.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationIntentExtras']/method[@name='setJsonData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setJsonData", "(Lorg/json/JSONObject;)V", "")]
			set {
				const string __id = "setJsonData.(Lorg/json/JSONObject;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationIntentExtras']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Lorg/json/JSONArray;", "")]
		public unsafe global::Org.Json.JSONArray? Component1 ()
		{
			const string __id = "component1.()Lorg/json/JSONArray;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationIntentExtras']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject? Component2 ()
		{
			const string __id = "component2.()Lorg/json/JSONObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationIntentExtras']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='org.json.JSONArray'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("copy", "(Lorg/json/JSONArray;Lorg/json/JSONObject;)Lcom/onesignal/OSNotificationIntentExtras;", "")]
		public unsafe global::Com.OneSignal.Android.OSNotificationIntentExtras Copy (global::Org.Json.JSONArray? dataArray, global::Org.Json.JSONObject? jsonData)
		{
			const string __id = "copy.(Lorg/json/JSONArray;Lorg/json/JSONObject;)Lcom/onesignal/OSNotificationIntentExtras;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dataArray == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataArray).Handle);
				__args [1] = new JniArgumentValue ((jsonData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonData).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationIntentExtras> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (dataArray);
				global::System.GC.KeepAlive (jsonData);
			}
		}

	}
}
