using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalAPIClient']"
	[Register ("com/onesignal/OneSignalAPIClient", "", "Com.OneSignal.Android.IOneSignalAPIClientInvoker")]
	public partial interface IOneSignalAPIClient : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalAPIClient']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignalApiResponseHandler'] and parameter[3][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;Lcom/onesignal/OneSignalApiResponseHandler;Ljava/lang/String;)V", "GetGet_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_Handler:Com.OneSignal.Android.IOneSignalAPIClientInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void Get (string? p0, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalAPIClient']/method[@name='getSync' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignalApiResponseHandler'] and parameter[3][@type='java.lang.String']]"
		[Register ("getSync", "(Ljava/lang/String;Lcom/onesignal/OneSignalApiResponseHandler;Ljava/lang/String;)V", "GetGetSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_Handler:Com.OneSignal.Android.IOneSignalAPIClientInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void GetSync (string? p0, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalAPIClient']/method[@name='post' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.onesignal.OneSignalApiResponseHandler']]"
		[Register ("post", "(Ljava/lang/String;Lorg/json/JSONObject;Lcom/onesignal/OneSignalApiResponseHandler;)V", "GetPost_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_Handler:Com.OneSignal.Android.IOneSignalAPIClientInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void Post (string? p0, global::Org.Json.JSONObject? p1, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalAPIClient']/method[@name='postSync' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.onesignal.OneSignalApiResponseHandler']]"
		[Register ("postSync", "(Ljava/lang/String;Lorg/json/JSONObject;Lcom/onesignal/OneSignalApiResponseHandler;)V", "GetPostSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_Handler:Com.OneSignal.Android.IOneSignalAPIClientInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void PostSync (string? p0, global::Org.Json.JSONObject? p1, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalAPIClient']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.onesignal.OneSignalApiResponseHandler']]"
		[Register ("put", "(Ljava/lang/String;Lorg/json/JSONObject;Lcom/onesignal/OneSignalApiResponseHandler;)V", "GetPut_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_Handler:Com.OneSignal.Android.IOneSignalAPIClientInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void Put (string? p0, global::Org.Json.JSONObject? p1, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalAPIClient']/method[@name='putSync' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.onesignal.OneSignalApiResponseHandler']]"
		[Register ("putSync", "(Ljava/lang/String;Lorg/json/JSONObject;Lcom/onesignal/OneSignalApiResponseHandler;)V", "GetPutSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_Handler:Com.OneSignal.Android.IOneSignalAPIClientInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void PutSync (string? p0, global::Org.Json.JSONObject? p1, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p2);

	}

	[global::Android.Runtime.Register ("com/onesignal/OneSignalAPIClient", DoNotGenerateAcw=true)]
	internal partial class IOneSignalAPIClientInvoker : global::Java.Lang.Object, IOneSignalAPIClient {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignalAPIClient", typeof (IOneSignalAPIClientInvoker));

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

		public static IOneSignalAPIClient? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOneSignalAPIClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignalAPIClient'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOneSignalAPIClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_get_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Get_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_;
		}

		static void n_Get_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalAPIClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.OneSignal.Android.IOneSignalApiResponseHandler?)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalApiResponseHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1, p2!);
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_;
		public unsafe void Get (string? p0, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p1, string p2)
		{
			if (id_get_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Lcom/onesignal/OneSignalApiResponseHandler;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate? cb_getSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_Handler ()
		{
			if (cb_getSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_ == null)
				cb_getSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_GetSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_);
			return cb_getSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_;
		}

		static void n_GetSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalAPIClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.OneSignal.Android.IOneSignalApiResponseHandler?)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalApiResponseHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetSync (p0, p1, p2!);
		}
#pragma warning restore 0169

		IntPtr id_getSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_;
		public unsafe void GetSync (string? p0, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p1, string p2)
		{
			if (id_getSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_ == IntPtr.Zero)
				id_getSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSync", "(Ljava/lang/String;Lcom/onesignal/OneSignalApiResponseHandler;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getSync_Ljava_lang_String_Lcom_onesignal_OneSignalApiResponseHandler_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate? cb_post_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_Handler ()
		{
			if (cb_post_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ == null)
				cb_post_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Post_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_);
			return cb_post_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
		}

		static void n_Post_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalAPIClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.OneSignal.Android.IOneSignalApiResponseHandler?)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalApiResponseHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Post (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_post_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
		public unsafe void Post (string? p0, global::Org.Json.JSONObject? p1, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p2)
		{
			if (id_post_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Lorg/json/JSONObject;Lcom/onesignal/OneSignalApiResponseHandler;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_postSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
#pragma warning disable 0169
		static Delegate GetPostSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_Handler ()
		{
			if (cb_postSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ == null)
				cb_postSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PostSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_);
			return cb_postSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
		}

		static void n_PostSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalAPIClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.OneSignal.Android.IOneSignalApiResponseHandler?)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalApiResponseHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PostSync (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_postSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
		public unsafe void PostSync (string? p0, global::Org.Json.JSONObject? p1, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p2)
		{
			if (id_postSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ == IntPtr.Zero)
				id_postSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ = JNIEnv.GetMethodID (class_ref, "postSync", "(Ljava/lang/String;Lorg/json/JSONObject;Lcom/onesignal/OneSignalApiResponseHandler;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_put_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ == null)
				cb_put_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Put_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_);
			return cb_put_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
		}

		static void n_Put_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalAPIClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.OneSignal.Android.IOneSignalApiResponseHandler?)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalApiResponseHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
		public unsafe void Put (string? p0, global::Org.Json.JSONObject? p1, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p2)
		{
			if (id_put_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Lorg/json/JSONObject;Lcom/onesignal/OneSignalApiResponseHandler;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_putSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
#pragma warning disable 0169
		static Delegate GetPutSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_Handler ()
		{
			if (cb_putSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ == null)
				cb_putSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PutSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_);
			return cb_putSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
		}

		static void n_PutSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalAPIClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.OneSignal.Android.IOneSignalApiResponseHandler?)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalApiResponseHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PutSync (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_putSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
		public unsafe void PutSync (string? p0, global::Org.Json.JSONObject? p1, global::Com.OneSignal.Android.IOneSignalApiResponseHandler? p2)
		{
			if (id_putSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ == IntPtr.Zero)
				id_putSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ = JNIEnv.GetMethodID (class_ref, "putSync", "(Ljava/lang/String;Lorg/json/JSONObject;Lcom/onesignal/OneSignalApiResponseHandler;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putSync_Ljava_lang_String_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
