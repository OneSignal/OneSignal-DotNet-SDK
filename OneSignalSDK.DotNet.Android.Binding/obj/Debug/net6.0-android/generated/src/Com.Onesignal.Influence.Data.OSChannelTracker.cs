using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Influence.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']"
	[global::Android.Runtime.Register ("com/onesignal/influence/data/OSChannelTracker", DoNotGenerateAcw=true)]
	public abstract partial class OSChannelTracker : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/influence/data/OSChannelTracker", typeof (OSChannelTracker));

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

		protected OSChannelTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getChannelLimit;
#pragma warning disable 0169
		static Delegate GetGetChannelLimitHandler ()
		{
			if (cb_getChannelLimit == null)
				cb_getChannelLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetChannelLimit);
			return cb_getChannelLimit;
		}

		static int n_GetChannelLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ChannelLimit;
		}
#pragma warning restore 0169

		public abstract int ChannelLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getChannelLimit' and count(parameter)=0]"
			[Register ("getChannelLimit", "()I", "GetGetChannelLimitHandler")]
			get; 
		}

		static Delegate? cb_getChannelType;
#pragma warning disable 0169
		static Delegate GetGetChannelTypeHandler ()
		{
			if (cb_getChannelType == null)
				cb_getChannelType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChannelType);
			return cb_getChannelType;
		}

		static IntPtr n_GetChannelType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ChannelType);
		}
#pragma warning restore 0169

		public abstract global::Com.Onesignal.Influence.Domain.OSInfluenceChannel ChannelType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getChannelType' and count(parameter)=0]"
			[Register ("getChannelType", "()Lcom/onesignal/influence/domain/OSInfluenceChannel;", "GetGetChannelTypeHandler")]
			get; 
		}

		public unsafe global::Com.Onesignal.Influence.Domain.OSInfluence CurrentSessionInfluence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getCurrentSessionInfluence' and count(parameter)=0]"
			[Register ("getCurrentSessionInfluence", "()Lcom/onesignal/influence/domain/OSInfluence;", "")]
			get {
				const string __id = "getCurrentSessionInfluence.()Lcom/onesignal/influence/domain/OSInfluence;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluence> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		protected unsafe global::Com.Onesignal.Influence.Data.OSInfluenceDataRepository DataRepository {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getDataRepository' and count(parameter)=0]"
			[Register ("getDataRepository", "()Lcom/onesignal/influence/data/OSInfluenceDataRepository;", "")]
			get {
				const string __id = "getDataRepository.()Lcom/onesignal/influence/data/OSInfluenceDataRepository;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSInfluenceDataRepository> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='setDataRepository' and count(parameter)=1 and parameter[1][@type='com.onesignal.influence.data.OSInfluenceDataRepository']]"
			[Register ("setDataRepository", "(Lcom/onesignal/influence/data/OSInfluenceDataRepository;)V", "")]
			set {
				const string __id = "setDataRepository.(Lcom/onesignal/influence/data/OSInfluenceDataRepository;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe string? DirectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getDirectId' and count(parameter)=0]"
			[Register ("getDirectId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDirectId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='setDirectId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDirectId", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setDirectId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_getIdTag;
#pragma warning disable 0169
		static Delegate GetGetIdTagHandler ()
		{
			if (cb_getIdTag == null)
				cb_getIdTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdTag);
			return cb_getIdTag;
		}

		static IntPtr n_GetIdTag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.IdTag);
		}
#pragma warning restore 0169

		public abstract string IdTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getIdTag' and count(parameter)=0]"
			[Register ("getIdTag", "()Ljava/lang/String;", "GetGetIdTagHandler")]
			get; 
		}

		static Delegate? cb_getIndirectAttributionWindow;
#pragma warning disable 0169
		static Delegate GetGetIndirectAttributionWindowHandler ()
		{
			if (cb_getIndirectAttributionWindow == null)
				cb_getIndirectAttributionWindow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIndirectAttributionWindow);
			return cb_getIndirectAttributionWindow;
		}

		static int n_GetIndirectAttributionWindow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IndirectAttributionWindow;
		}
#pragma warning restore 0169

		public abstract int IndirectAttributionWindow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getIndirectAttributionWindow' and count(parameter)=0]"
			[Register ("getIndirectAttributionWindow", "()I", "GetGetIndirectAttributionWindowHandler")]
			get; 
		}

		public unsafe global::Org.Json.JSONArray? IndirectIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getIndirectIds' and count(parameter)=0]"
			[Register ("getIndirectIds", "()Lorg/json/JSONArray;", "")]
			get {
				const string __id = "getIndirectIds.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='setIndirectIds' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
			[Register ("setIndirectIds", "(Lorg/json/JSONArray;)V", "")]
			set {
				const string __id = "setIndirectIds.(Lorg/json/JSONArray;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceType? InfluenceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getInfluenceType' and count(parameter)=0]"
			[Register ("getInfluenceType", "()Lcom/onesignal/influence/domain/OSInfluenceType;", "")]
			get {
				const string __id = "getInfluenceType.()Lcom/onesignal/influence/domain/OSInfluenceType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='setInfluenceType' and count(parameter)=1 and parameter[1][@type='com.onesignal.influence.domain.OSInfluenceType']]"
			[Register ("setInfluenceType", "(Lcom/onesignal/influence/domain/OSInfluenceType;)V", "")]
			set {
				const string __id = "setInfluenceType.(Lcom/onesignal/influence/domain/OSInfluenceType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getLastChannelObjects;
#pragma warning disable 0169
		static Delegate GetGetLastChannelObjectsHandler ()
		{
			if (cb_getLastChannelObjects == null)
				cb_getLastChannelObjects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLastChannelObjects);
			return cb_getLastChannelObjects;
		}

		static IntPtr n_GetLastChannelObjects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LastChannelObjects);
		}
#pragma warning restore 0169

		public abstract global::Org.Json.JSONArray LastChannelObjects {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getLastChannelObjects' and count(parameter)=0]"
			[Register ("getLastChannelObjects", "()Lorg/json/JSONArray;", "GetGetLastChannelObjectsHandler")]
			get; 
		}

		public unsafe global::Org.Json.JSONArray LastReceivedIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getLastReceivedIds' and count(parameter)=0]"
			[Register ("getLastReceivedIds", "()Lorg/json/JSONArray;", "")]
			get {
				const string __id = "getLastReceivedIds.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.OneSignal.Android.IOSLogger Logger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getLogger' and count(parameter)=0]"
			[Register ("getLogger", "()Lcom/onesignal/OSLogger;", "")]
			get {
				const string __id = "getLogger.()Lcom/onesignal/OSLogger;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSLogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSLogger']]"
			[Register ("setLogger", "(Lcom/onesignal/OSLogger;)V", "")]
			set {
				const string __id = "setLogger.(Lcom/onesignal/OSLogger;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_addSessionData_Lorg_json_JSONObject_Lcom_onesignal_influence_domain_OSInfluence_;
#pragma warning disable 0169
		static Delegate GetAddSessionData_Lorg_json_JSONObject_Lcom_onesignal_influence_domain_OSInfluence_Handler ()
		{
			if (cb_addSessionData_Lorg_json_JSONObject_Lcom_onesignal_influence_domain_OSInfluence_ == null)
				cb_addSessionData_Lorg_json_JSONObject_Lcom_onesignal_influence_domain_OSInfluence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AddSessionData_Lorg_json_JSONObject_Lcom_onesignal_influence_domain_OSInfluence_);
			return cb_addSessionData_Lorg_json_JSONObject_Lcom_onesignal_influence_domain_OSInfluence_;
		}

		static void n_AddSessionData_Lorg_json_JSONObject_Lcom_onesignal_influence_domain_OSInfluence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject, IntPtr native_influence)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			var influence = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluence> (native_influence, JniHandleOwnership.DoNotTransfer);
			__this.AddSessionData (jsonObject!, influence!);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='addSessionData' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.onesignal.influence.domain.OSInfluence']]"
		[Register ("addSessionData", "(Lorg/json/JSONObject;Lcom/onesignal/influence/domain/OSInfluence;)V", "GetAddSessionData_Lorg_json_JSONObject_Lcom_onesignal_influence_domain_OSInfluence_Handler")]
		public abstract void AddSessionData (global::Org.Json.JSONObject jsonObject, global::Com.Onesignal.Influence.Domain.OSInfluence influence);

		static Delegate? cb_cacheState;
#pragma warning disable 0169
		static Delegate GetCacheStateHandler ()
		{
			if (cb_cacheState == null)
				cb_cacheState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CacheState);
			return cb_cacheState;
		}

		static void n_CacheState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.CacheState ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='cacheState' and count(parameter)=0]"
		[Register ("cacheState", "()V", "GetCacheStateHandler")]
		public abstract void CacheState ();

		static Delegate? cb_getLastChannelObjectsReceivedByNewId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLastChannelObjectsReceivedByNewId_Ljava_lang_String_Handler ()
		{
			if (cb_getLastChannelObjectsReceivedByNewId_Ljava_lang_String_ == null)
				cb_getLastChannelObjectsReceivedByNewId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetLastChannelObjectsReceivedByNewId_Ljava_lang_String_);
			return cb_getLastChannelObjectsReceivedByNewId_Ljava_lang_String_;
		}

		static IntPtr n_GetLastChannelObjectsReceivedByNewId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLastChannelObjectsReceivedByNewId (id));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getLastChannelObjectsReceivedByNewId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLastChannelObjectsReceivedByNewId", "(Ljava/lang/String;)Lorg/json/JSONArray;", "GetGetLastChannelObjectsReceivedByNewId_Ljava_lang_String_Handler")]
		public abstract global::Org.Json.JSONArray GetLastChannelObjectsReceivedByNewId (string? id);

		static Delegate? cb_initInfluencedTypeFromCache;
#pragma warning disable 0169
		static Delegate GetInitInfluencedTypeFromCacheHandler ()
		{
			if (cb_initInfluencedTypeFromCache == null)
				cb_initInfluencedTypeFromCache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_InitInfluencedTypeFromCache);
			return cb_initInfluencedTypeFromCache;
		}

		static void n_InitInfluencedTypeFromCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.InitInfluencedTypeFromCache ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='initInfluencedTypeFromCache' and count(parameter)=0]"
		[Register ("initInfluencedTypeFromCache", "()V", "GetInitInfluencedTypeFromCacheHandler")]
		public abstract void InitInfluencedTypeFromCache ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='resetAndInitInfluence' and count(parameter)=0]"
		[Register ("resetAndInitInfluence", "()V", "")]
		public unsafe void ResetAndInitInfluence ()
		{
			const string __id = "resetAndInitInfluence.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_saveChannelObjects_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetSaveChannelObjects_Lorg_json_JSONArray_Handler ()
		{
			if (cb_saveChannelObjects_Lorg_json_JSONArray_ == null)
				cb_saveChannelObjects_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveChannelObjects_Lorg_json_JSONArray_);
			return cb_saveChannelObjects_Lorg_json_JSONArray_;
		}

		static void n_SaveChannelObjects_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channelObjects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var channelObjects = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_channelObjects, JniHandleOwnership.DoNotTransfer);
			__this.SaveChannelObjects (channelObjects!);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='saveChannelObjects' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("saveChannelObjects", "(Lorg/json/JSONArray;)V", "GetSaveChannelObjects_Lorg_json_JSONArray_Handler")]
		public abstract void SaveChannelObjects (global::Org.Json.JSONArray channelObjects);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='saveLastId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveLastId", "(Ljava/lang/String;)V", "")]
		public unsafe void SaveLastId (string? id)
		{
			const string __id = "saveLastId.(Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

	}

	[global::Android.Runtime.Register ("com/onesignal/influence/data/OSChannelTracker", DoNotGenerateAcw=true)]
	internal partial class OSChannelTrackerInvoker : OSChannelTracker {
		public OSChannelTrackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/influence/data/OSChannelTracker", typeof (OSChannelTrackerInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int ChannelLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getChannelLimit' and count(parameter)=0]"
			[Register ("getChannelLimit", "()I", "GetGetChannelLimitHandler")]
			get {
				const string __id = "getChannelLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceChannel ChannelType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getChannelType' and count(parameter)=0]"
			[Register ("getChannelType", "()Lcom/onesignal/influence/domain/OSInfluenceChannel;", "GetGetChannelTypeHandler")]
			get {
				const string __id = "getChannelType.()Lcom/onesignal/influence/domain/OSInfluenceChannel;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public override unsafe string IdTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getIdTag' and count(parameter)=0]"
			[Register ("getIdTag", "()Ljava/lang/String;", "GetGetIdTagHandler")]
			get {
				const string __id = "getIdTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public override unsafe int IndirectAttributionWindow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getIndirectAttributionWindow' and count(parameter)=0]"
			[Register ("getIndirectAttributionWindow", "()I", "GetGetIndirectAttributionWindowHandler")]
			get {
				const string __id = "getIndirectAttributionWindow.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::Org.Json.JSONArray LastChannelObjects {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getLastChannelObjects' and count(parameter)=0]"
			[Register ("getLastChannelObjects", "()Lorg/json/JSONArray;", "GetGetLastChannelObjectsHandler")]
			get {
				const string __id = "getLastChannelObjects.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='addSessionData' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.onesignal.influence.domain.OSInfluence']]"
		[Register ("addSessionData", "(Lorg/json/JSONObject;Lcom/onesignal/influence/domain/OSInfluence;)V", "GetAddSessionData_Lorg_json_JSONObject_Lcom_onesignal_influence_domain_OSInfluence_Handler")]
		public override unsafe void AddSessionData (global::Org.Json.JSONObject jsonObject, global::Com.Onesignal.Influence.Domain.OSInfluence influence)
		{
			const string __id = "addSessionData.(Lorg/json/JSONObject;Lcom/onesignal/influence/domain/OSInfluence;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				__args [1] = new JniArgumentValue ((influence == null) ? IntPtr.Zero : ((global::Java.Lang.Object) influence).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (jsonObject);
				global::System.GC.KeepAlive (influence);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='cacheState' and count(parameter)=0]"
		[Register ("cacheState", "()V", "GetCacheStateHandler")]
		public override unsafe void CacheState ()
		{
			const string __id = "cacheState.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='getLastChannelObjectsReceivedByNewId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLastChannelObjectsReceivedByNewId", "(Ljava/lang/String;)Lorg/json/JSONArray;", "GetGetLastChannelObjectsReceivedByNewId_Ljava_lang_String_Handler")]
		public override unsafe global::Org.Json.JSONArray GetLastChannelObjectsReceivedByNewId (string? id)
		{
			const string __id = "getLastChannelObjectsReceivedByNewId.(Ljava/lang/String;)Lorg/json/JSONArray;";
			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='initInfluencedTypeFromCache' and count(parameter)=0]"
		[Register ("initInfluencedTypeFromCache", "()V", "GetInitInfluencedTypeFromCacheHandler")]
		public override unsafe void InitInfluencedTypeFromCache ()
		{
			const string __id = "initInfluencedTypeFromCache.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSChannelTracker']/method[@name='saveChannelObjects' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("saveChannelObjects", "(Lorg/json/JSONArray;)V", "GetSaveChannelObjects_Lorg_json_JSONArray_Handler")]
		public override unsafe void SaveChannelObjects (global::Org.Json.JSONArray channelObjects)
		{
			const string __id = "saveChannelObjects.(Lorg/json/JSONArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((channelObjects == null) ? IntPtr.Zero : ((global::Java.Lang.Object) channelObjects).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (channelObjects);
			}
		}

	}
}
