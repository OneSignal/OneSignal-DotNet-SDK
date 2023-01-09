using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Influence.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']"
	[global::Android.Runtime.Register ("com/onesignal/influence/data/OSInfluenceDataRepository", DoNotGenerateAcw=true)]
	public sealed partial class OSInfluenceDataRepository : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/influence/data/OSInfluenceDataRepository", typeof (OSInfluenceDataRepository));

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

		internal OSInfluenceDataRepository (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/constructor[@name='OSInfluenceDataRepository' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSSharedPreferences']]"
		[Register (".ctor", "(Lcom/onesignal/OSSharedPreferences;)V", "")]
		public unsafe OSInfluenceDataRepository (global::Com.OneSignal.Android.IOSSharedPreferences preferences) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/OSSharedPreferences;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((preferences == null) ? IntPtr.Zero : ((global::Java.Lang.Object) preferences).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (preferences);
			}
		}

		public unsafe string? CachedNotificationOpenId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='getCachedNotificationOpenId' and count(parameter)=0]"
			[Register ("getCachedNotificationOpenId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCachedNotificationOpenId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceType IamCachedInfluenceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='getIamCachedInfluenceType' and count(parameter)=0]"
			[Register ("getIamCachedInfluenceType", "()Lcom/onesignal/influence/domain/OSInfluenceType;", "")]
			get {
				const string __id = "getIamCachedInfluenceType.()Lcom/onesignal/influence/domain/OSInfluenceType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe int IamIndirectAttributionWindow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='getIamIndirectAttributionWindow' and count(parameter)=0]"
			[Register ("getIamIndirectAttributionWindow", "()I", "")]
			get {
				const string __id = "getIamIndirectAttributionWindow.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int IamLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='getIamLimit' and count(parameter)=0]"
			[Register ("getIamLimit", "()I", "")]
			get {
				const string __id = "getIamLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsDirectInfluenceEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='isDirectInfluenceEnabled' and count(parameter)=0]"
			[Register ("isDirectInfluenceEnabled", "()Z", "")]
			get {
				const string __id = "isDirectInfluenceEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsIndirectInfluenceEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='isIndirectInfluenceEnabled' and count(parameter)=0]"
			[Register ("isIndirectInfluenceEnabled", "()Z", "")]
			get {
				const string __id = "isIndirectInfluenceEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsUnattributedInfluenceEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='isUnattributedInfluenceEnabled' and count(parameter)=0]"
			[Register ("isUnattributedInfluenceEnabled", "()Z", "")]
			get {
				const string __id = "isUnattributedInfluenceEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Org.Json.JSONArray LastIAMsReceivedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='getLastIAMsReceivedData' and count(parameter)=0]"
			[Register ("getLastIAMsReceivedData", "()Lorg/json/JSONArray;", "")]
			get {
				const string __id = "getLastIAMsReceivedData.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Org.Json.JSONArray LastNotificationsReceivedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='getLastNotificationsReceivedData' and count(parameter)=0]"
			[Register ("getLastNotificationsReceivedData", "()Lorg/json/JSONArray;", "")]
			get {
				const string __id = "getLastNotificationsReceivedData.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceType NotificationCachedInfluenceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='getNotificationCachedInfluenceType' and count(parameter)=0]"
			[Register ("getNotificationCachedInfluenceType", "()Lcom/onesignal/influence/domain/OSInfluenceType;", "")]
			get {
				const string __id = "getNotificationCachedInfluenceType.()Lcom/onesignal/influence/domain/OSInfluenceType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe int NotificationIndirectAttributionWindow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='getNotificationIndirectAttributionWindow' and count(parameter)=0]"
			[Register ("getNotificationIndirectAttributionWindow", "()I", "")]
			get {
				const string __id = "getNotificationIndirectAttributionWindow.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int NotificationLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='getNotificationLimit' and count(parameter)=0]"
			[Register ("getNotificationLimit", "()I", "")]
			get {
				const string __id = "getNotificationLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='cacheIAMInfluenceType' and count(parameter)=1 and parameter[1][@type='com.onesignal.influence.domain.OSInfluenceType']]"
		[Register ("cacheIAMInfluenceType", "(Lcom/onesignal/influence/domain/OSInfluenceType;)V", "")]
		public unsafe void CacheIAMInfluenceType (global::Com.Onesignal.Influence.Domain.OSInfluenceType influenceType)
		{
			const string __id = "cacheIAMInfluenceType.(Lcom/onesignal/influence/domain/OSInfluenceType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((influenceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) influenceType).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (influenceType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='cacheNotificationInfluenceType' and count(parameter)=1 and parameter[1][@type='com.onesignal.influence.domain.OSInfluenceType']]"
		[Register ("cacheNotificationInfluenceType", "(Lcom/onesignal/influence/domain/OSInfluenceType;)V", "")]
		public unsafe void CacheNotificationInfluenceType (global::Com.Onesignal.Influence.Domain.OSInfluenceType influenceType)
		{
			const string __id = "cacheNotificationInfluenceType.(Lcom/onesignal/influence/domain/OSInfluenceType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((influenceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) influenceType).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (influenceType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='cacheNotificationOpenId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("cacheNotificationOpenId", "(Ljava/lang/String;)V", "")]
		public unsafe void CacheNotificationOpenId (string? id)
		{
			const string __id = "cacheNotificationOpenId.(Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='saveIAMs' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("saveIAMs", "(Lorg/json/JSONArray;)V", "")]
		public unsafe void SaveIAMs (global::Org.Json.JSONArray iams)
		{
			const string __id = "saveIAMs.(Lorg/json/JSONArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iams).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (iams);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='saveInfluenceParams' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignalRemoteParams.InfluenceParams']]"
		[Register ("saveInfluenceParams", "(Lcom/onesignal/OneSignalRemoteParams$InfluenceParams;)V", "")]
		public unsafe void SaveInfluenceParams (global::Com.OneSignal.Android.OneSignalRemoteParams.InfluenceParams influenceParams)
		{
			const string __id = "saveInfluenceParams.(Lcom/onesignal/OneSignalRemoteParams$InfluenceParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((influenceParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) influenceParams).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (influenceParams);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSInfluenceDataRepository']/method[@name='saveNotifications' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("saveNotifications", "(Lorg/json/JSONArray;)V", "")]
		public unsafe void SaveNotifications (global::Org.Json.JSONArray notifications)
		{
			const string __id = "saveNotifications.(Lorg/json/JSONArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((notifications == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notifications).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (notifications);
			}
		}

	}
}
