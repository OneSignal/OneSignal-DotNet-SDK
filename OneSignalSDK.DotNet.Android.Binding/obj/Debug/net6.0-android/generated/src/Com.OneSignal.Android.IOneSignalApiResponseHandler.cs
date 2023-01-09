using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalApiResponseHandler']"
	[Register ("com/onesignal/OneSignalApiResponseHandler", "", "Com.OneSignal.Android.IOneSignalApiResponseHandlerInvoker")]
	public partial interface IOneSignalApiResponseHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalApiResponseHandler']/method[@name='onFailure' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("onFailure", "(ILjava/lang/String;Ljava/lang/Throwable;)V", "GetOnFailure_ILjava_lang_String_Ljava_lang_Throwable_Handler:Com.OneSignal.Android.IOneSignalApiResponseHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void OnFailure (int p0, string? p1, global::Java.Lang.Throwable? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalApiResponseHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.OneSignal.Android.IOneSignalApiResponseHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void OnSuccess (string? p0);

	}

	[global::Android.Runtime.Register ("com/onesignal/OneSignalApiResponseHandler", DoNotGenerateAcw=true)]
	internal partial class IOneSignalApiResponseHandlerInvoker : global::Java.Lang.Object, IOneSignalApiResponseHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignalApiResponseHandler", typeof (IOneSignalApiResponseHandlerInvoker));

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

		public static IOneSignalApiResponseHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOneSignalApiResponseHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignalApiResponseHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOneSignalApiResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onFailure_ILjava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFailure_ILjava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFailure_ILjava_lang_String_Ljava_lang_Throwable_ == null)
				cb_onFailure_ILjava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_V) n_OnFailure_ILjava_lang_String_Ljava_lang_Throwable_);
			return cb_onFailure_ILjava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_OnFailure_ILjava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalApiResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_ILjava_lang_String_Ljava_lang_Throwable_;
		public unsafe void OnFailure (int p0, string? p1, global::Java.Lang.Throwable? p2)
		{
			if (id_onFailure_ILjava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onFailure_ILjava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(ILjava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_ILjava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalApiResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_String_;
		public unsafe void OnSuccess (string? p0)
		{
			if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
