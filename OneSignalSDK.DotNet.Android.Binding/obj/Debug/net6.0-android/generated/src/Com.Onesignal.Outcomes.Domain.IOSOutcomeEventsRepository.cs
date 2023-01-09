using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Outcomes.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal.outcomes.domain']/interface[@name='OSOutcomeEventsRepository']"
	[Register ("com/onesignal/outcomes/domain/OSOutcomeEventsRepository", "", "Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepositoryInvoker")]
	public partial interface IOSOutcomeEventsRepository : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IList<global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams> SavedOutcomeEvents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/interface[@name='OSOutcomeEventsRepository']/method[@name='getSavedOutcomeEvents' and count(parameter)=0]"
			[Register ("getSavedOutcomeEvents", "()Ljava/util/List;", "GetGetSavedOutcomeEventsHandler:Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepositoryInvoker, OneSignalSDK.DotNet.Android.Binding")]
			get; 
		}

		global::System.Collections.Generic.ICollection<string>? UnattributedUniqueOutcomeEventsSent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/interface[@name='OSOutcomeEventsRepository']/method[@name='getUnattributedUniqueOutcomeEventsSent' and count(parameter)=0]"
			[Register ("getUnattributedUniqueOutcomeEventsSent", "()Ljava/util/Set;", "GetGetUnattributedUniqueOutcomeEventsSentHandler:Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepositoryInvoker, OneSignalSDK.DotNet.Android.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/interface[@name='OSOutcomeEventsRepository']/method[@name='cleanCachedUniqueOutcomeEventNotifications' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("cleanCachedUniqueOutcomeEventNotifications", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_Handler:Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepositoryInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void CleanCachedUniqueOutcomeEventNotifications (string notificationTableName, string notificationIdColumnName);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/interface[@name='OSOutcomeEventsRepository']/method[@name='getNotCachedUniqueOutcome' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.onesignal.influence.domain.OSInfluence&gt;']]"
		[Register ("getNotCachedUniqueOutcome", "(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "GetGetNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_Handler:Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepositoryInvoker, OneSignalSDK.DotNet.Android.Binding")]
		global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> GetNotCachedUniqueOutcome (string name, global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> influences);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/interface[@name='OSOutcomeEventsRepository']/method[@name='removeEvent' and count(parameter)=1 and parameter[1][@type='com.onesignal.outcomes.domain.OSOutcomeEventParams']]"
		[Register ("removeEvent", "(Lcom/onesignal/outcomes/domain/OSOutcomeEventParams;)V", "GetRemoveEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_Handler:Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepositoryInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void RemoveEvent (global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams outcomeEvent);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/interface[@name='OSOutcomeEventsRepository']/method[@name='requestMeasureOutcomeEvent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.onesignal.outcomes.domain.OSOutcomeEventParams'] and parameter[4][@type='com.onesignal.OneSignalApiResponseHandler']]"
		[Register ("requestMeasureOutcomeEvent", "(Ljava/lang/String;ILcom/onesignal/outcomes/domain/OSOutcomeEventParams;Lcom/onesignal/OneSignalApiResponseHandler;)V", "GetRequestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_Handler:Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepositoryInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void RequestMeasureOutcomeEvent (string appId, int deviceType, global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams e, global::Com.OneSignal.Android.IOneSignalApiResponseHandler responseHandler);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/interface[@name='OSOutcomeEventsRepository']/method[@name='saveOutcomeEvent' and count(parameter)=1 and parameter[1][@type='com.onesignal.outcomes.domain.OSOutcomeEventParams']]"
		[Register ("saveOutcomeEvent", "(Lcom/onesignal/outcomes/domain/OSOutcomeEventParams;)V", "GetSaveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_Handler:Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepositoryInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SaveOutcomeEvent (global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams e);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/interface[@name='OSOutcomeEventsRepository']/method[@name='saveUnattributedUniqueOutcomeEventsSent' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("saveUnattributedUniqueOutcomeEventsSent", "(Ljava/util/Set;)V", "GetSaveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_Handler:Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepositoryInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SaveUnattributedUniqueOutcomeEventsSent (global::System.Collections.Generic.ICollection<string> unattributedUniqueOutcomeEvents);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/interface[@name='OSOutcomeEventsRepository']/method[@name='saveUniqueOutcomeNotifications' and count(parameter)=1 and parameter[1][@type='com.onesignal.outcomes.domain.OSOutcomeEventParams']]"
		[Register ("saveUniqueOutcomeNotifications", "(Lcom/onesignal/outcomes/domain/OSOutcomeEventParams;)V", "GetSaveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_Handler:Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepositoryInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SaveUniqueOutcomeNotifications (global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams eventParams);

	}

	[global::Android.Runtime.Register ("com/onesignal/outcomes/domain/OSOutcomeEventsRepository", DoNotGenerateAcw=true)]
	internal partial class IOSOutcomeEventsRepositoryInvoker : global::Java.Lang.Object, IOSOutcomeEventsRepository {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/outcomes/domain/OSOutcomeEventsRepository", typeof (IOSOutcomeEventsRepositoryInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOSOutcomeEventsRepository? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSOutcomeEventsRepository> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.outcomes.domain.OSOutcomeEventsRepository'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSOutcomeEventsRepositoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getSavedOutcomeEvents;
#pragma warning disable 0169
		static Delegate GetGetSavedOutcomeEventsHandler ()
		{
			if (cb_getSavedOutcomeEvents == null)
				cb_getSavedOutcomeEvents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSavedOutcomeEvents);
			return cb_getSavedOutcomeEvents;
		}

		static IntPtr n_GetSavedOutcomeEvents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams>.ToLocalJniHandle (__this.SavedOutcomeEvents);
		}
#pragma warning restore 0169

		IntPtr id_getSavedOutcomeEvents;
		public unsafe global::System.Collections.Generic.IList<global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams> SavedOutcomeEvents {
			get {
				if (id_getSavedOutcomeEvents == IntPtr.Zero)
					id_getSavedOutcomeEvents = JNIEnv.GetMethodID (class_ref, "getSavedOutcomeEvents", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSavedOutcomeEvents), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getUnattributedUniqueOutcomeEventsSent;
#pragma warning disable 0169
		static Delegate GetGetUnattributedUniqueOutcomeEventsSentHandler ()
		{
			if (cb_getUnattributedUniqueOutcomeEventsSent == null)
				cb_getUnattributedUniqueOutcomeEventsSent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUnattributedUniqueOutcomeEventsSent);
			return cb_getUnattributedUniqueOutcomeEventsSent;
		}

		static IntPtr n_GetUnattributedUniqueOutcomeEventsSent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.UnattributedUniqueOutcomeEventsSent);
		}
#pragma warning restore 0169

		IntPtr id_getUnattributedUniqueOutcomeEventsSent;
		public unsafe global::System.Collections.Generic.ICollection<string>? UnattributedUniqueOutcomeEventsSent {
			get {
				if (id_getUnattributedUniqueOutcomeEventsSent == IntPtr.Zero)
					id_getUnattributedUniqueOutcomeEventsSent = JNIEnv.GetMethodID (class_ref, "getUnattributedUniqueOutcomeEventsSent", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUnattributedUniqueOutcomeEventsSent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_cleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_cleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_cleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_);
			return cb_cleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_notificationTableName, IntPtr native_notificationIdColumnName)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var notificationTableName = JNIEnv.GetString (native_notificationTableName, JniHandleOwnership.DoNotTransfer);
			var notificationIdColumnName = JNIEnv.GetString (native_notificationIdColumnName, JniHandleOwnership.DoNotTransfer);
			__this.CleanCachedUniqueOutcomeEventNotifications (notificationTableName!, notificationIdColumnName!);
		}
#pragma warning restore 0169

		IntPtr id_cleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void CleanCachedUniqueOutcomeEventNotifications (string notificationTableName, string notificationIdColumnName)
		{
			if (id_cleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_cleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cleanCachedUniqueOutcomeEventNotifications", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_notificationTableName = JNIEnv.NewString ((string?)notificationTableName);
			IntPtr native_notificationIdColumnName = JNIEnv.NewString ((string?)notificationIdColumnName);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_notificationTableName);
			__args [1] = new JValue (native_notificationIdColumnName);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cleanCachedUniqueOutcomeEventNotifications_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_notificationTableName);
			JNIEnv.DeleteLocalRef (native_notificationIdColumnName);
		}

		static Delegate? cb_getNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_getNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_ == null)
				cb_getNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_);
			return cb_getNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_GetNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_influences)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var influences = global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Domain.OSInfluence>.FromJniHandle (native_influences, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Domain.OSInfluence>.ToLocalJniHandle (__this.GetNotCachedUniqueOutcome (name!, influences!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> GetNotCachedUniqueOutcome (string name, global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> influences)
		{
			if (id_getNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_getNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getNotCachedUniqueOutcome", "(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;");
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			IntPtr native_influences = global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Domain.OSInfluence>.ToLocalJniHandle (influences);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_name);
			__args [1] = new JValue (native_influences);
			var __ret = global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Domain.OSInfluence>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotCachedUniqueOutcome_Ljava_lang_String_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef)!;
			JNIEnv.DeleteLocalRef (native_name);
			JNIEnv.DeleteLocalRef (native_influences);
			return __ret;
		}

		static Delegate? cb_removeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_;
#pragma warning disable 0169
		static Delegate GetRemoveEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_Handler ()
		{
			if (cb_removeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ == null)
				cb_removeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_);
			return cb_removeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_;
		}

		static void n_RemoveEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_outcomeEvent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var outcomeEvent = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams> (native_outcomeEvent, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEvent (outcomeEvent!);
		}
#pragma warning restore 0169

		IntPtr id_removeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_;
		public unsafe void RemoveEvent (global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams outcomeEvent)
		{
			if (id_removeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ == IntPtr.Zero)
				id_removeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ = JNIEnv.GetMethodID (class_ref, "removeEvent", "(Lcom/onesignal/outcomes/domain/OSOutcomeEventParams;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((outcomeEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outcomeEvent).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_, __args);
		}

		static Delegate? cb_requestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_;
#pragma warning disable 0169
		static Delegate GetRequestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_Handler ()
		{
			if (cb_requestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_ == null)
				cb_requestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILL_V) n_RequestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_);
			return cb_requestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_;
		}

		static void n_RequestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appId, int deviceType, IntPtr native_e, IntPtr native_responseHandler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var appId = JNIEnv.GetString (native_appId, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams> (native_e, JniHandleOwnership.DoNotTransfer);
			var responseHandler = (global::Com.OneSignal.Android.IOneSignalApiResponseHandler?)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalApiResponseHandler> (native_responseHandler, JniHandleOwnership.DoNotTransfer);
			__this.RequestMeasureOutcomeEvent (appId!, deviceType, e!, responseHandler!);
		}
#pragma warning restore 0169

		IntPtr id_requestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_;
		public unsafe void RequestMeasureOutcomeEvent (string appId, int deviceType, global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams e, global::Com.OneSignal.Android.IOneSignalApiResponseHandler responseHandler)
		{
			if (id_requestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_ == IntPtr.Zero)
				id_requestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_ = JNIEnv.GetMethodID (class_ref, "requestMeasureOutcomeEvent", "(Ljava/lang/String;ILcom/onesignal/outcomes/domain/OSOutcomeEventParams;Lcom/onesignal/OneSignalApiResponseHandler;)V");
			IntPtr native_appId = JNIEnv.NewString ((string?)appId);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_appId);
			__args [1] = new JValue (deviceType);
			__args [2] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			__args [3] = new JValue ((responseHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseHandler).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestMeasureOutcomeEvent_Ljava_lang_String_ILcom_onesignal_outcomes_domain_OSOutcomeEventParams_Lcom_onesignal_OneSignalApiResponseHandler_, __args);
			JNIEnv.DeleteLocalRef (native_appId);
		}

		static Delegate? cb_saveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_;
#pragma warning disable 0169
		static Delegate GetSaveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_Handler ()
		{
			if (cb_saveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ == null)
				cb_saveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_);
			return cb_saveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_;
		}

		static void n_SaveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var e = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.SaveOutcomeEvent (e!);
		}
#pragma warning restore 0169

		IntPtr id_saveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_;
		public unsafe void SaveOutcomeEvent (global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams e)
		{
			if (id_saveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ == IntPtr.Zero)
				id_saveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ = JNIEnv.GetMethodID (class_ref, "saveOutcomeEvent", "(Lcom/onesignal/outcomes/domain/OSOutcomeEventParams;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveOutcomeEvent_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_, __args);
		}

		static Delegate? cb_saveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSaveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_Handler ()
		{
			if (cb_saveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_ == null)
				cb_saveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_);
			return cb_saveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_;
		}

		static void n_SaveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unattributedUniqueOutcomeEvents)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var unattributedUniqueOutcomeEvents = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_unattributedUniqueOutcomeEvents, JniHandleOwnership.DoNotTransfer);
			__this.SaveUnattributedUniqueOutcomeEventsSent (unattributedUniqueOutcomeEvents!);
		}
#pragma warning restore 0169

		IntPtr id_saveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_;
		public unsafe void SaveUnattributedUniqueOutcomeEventsSent (global::System.Collections.Generic.ICollection<string> unattributedUniqueOutcomeEvents)
		{
			if (id_saveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_ == IntPtr.Zero)
				id_saveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "saveUnattributedUniqueOutcomeEventsSent", "(Ljava/util/Set;)V");
			IntPtr native_unattributedUniqueOutcomeEvents = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (unattributedUniqueOutcomeEvents);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_unattributedUniqueOutcomeEvents);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveUnattributedUniqueOutcomeEventsSent_Ljava_util_Set_, __args);
			JNIEnv.DeleteLocalRef (native_unattributedUniqueOutcomeEvents);
		}

		static Delegate? cb_saveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_;
#pragma warning disable 0169
		static Delegate GetSaveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_Handler ()
		{
			if (cb_saveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ == null)
				cb_saveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_);
			return cb_saveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_;
		}

		static void n_SaveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventParams)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.IOSOutcomeEventsRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var eventParams = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams> (native_eventParams, JniHandleOwnership.DoNotTransfer);
			__this.SaveUniqueOutcomeNotifications (eventParams!);
		}
#pragma warning restore 0169

		IntPtr id_saveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_;
		public unsafe void SaveUniqueOutcomeNotifications (global::Com.Onesignal.Outcomes.Domain.OSOutcomeEventParams eventParams)
		{
			if (id_saveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ == IntPtr.Zero)
				id_saveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_ = JNIEnv.GetMethodID (class_ref, "saveUniqueOutcomeNotifications", "(Lcom/onesignal/outcomes/domain/OSOutcomeEventParams;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((eventParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventParams).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveUniqueOutcomeNotifications_Lcom_onesignal_outcomes_domain_OSOutcomeEventParams_, __args);
		}

	}
}
