using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']"
	[Register ("com/onesignal/BundleCompat", "", "Com.OneSignal.Android.IBundleCompatInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IBundleCompat : IJavaObject, IJavaPeerable {
		global::Java.Lang.Object? Bundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='getBundle' and count(parameter)=0]"
			[Register ("getBundle", "()Ljava/lang/Object;", "GetGetBundleHandler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsKey", "(Ljava/lang/String;)Z", "GetContainsKey_Ljava_lang_String_Handler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		bool ContainsKey (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		bool GetBoolean (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='getBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_ZHandler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		bool GetBoolean (string? p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInt", "(Ljava/lang/String;)Ljava/lang/Integer;", "GetGetInt_Ljava_lang_String_Handler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		global::Java.Lang.Integer? GetInt (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)Ljava/lang/Long;", "GetGetLong_Ljava_lang_String_Handler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		global::Java.Lang.Long? GetLong (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		string? GetString (string? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='putBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("putBoolean", "(Ljava/lang/String;Ljava/lang/Boolean;)V", "GetPutBoolean_Ljava_lang_String_Ljava_lang_Boolean_Handler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void PutBoolean (string? p0, global::Java.Lang.Boolean? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='putInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("putInt", "(Ljava/lang/String;Ljava/lang/Integer;)V", "GetPutInt_Ljava_lang_String_Ljava_lang_Integer_Handler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void PutInt (string? p0, global::Java.Lang.Integer? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='putLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("putLong", "(Ljava/lang/String;Ljava/lang/Long;)V", "GetPutLong_Ljava_lang_String_Ljava_lang_Long_Handler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void PutLong (string? p0, global::Java.Lang.Long? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='putString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutString_Ljava_lang_String_Ljava_lang_String_Handler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void PutString (string? p0, string? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='BundleCompat']/method[@name='setBundle' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("setBundle", "(Landroid/os/Parcelable;)V", "GetSetBundle_Landroid_os_Parcelable_Handler:Com.OneSignal.Android.IBundleCompatInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SetBundle (global::Android.OS.IParcelable? p0);

	}

	[global::Android.Runtime.Register ("com/onesignal/BundleCompat", DoNotGenerateAcw=true)]
	internal partial class IBundleCompatInvoker : global::Java.Lang.Object, IBundleCompat {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/BundleCompat", typeof (IBundleCompatInvoker));

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

		public static IBundleCompat? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBundleCompat> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.BundleCompat'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBundleCompatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getBundle;
#pragma warning disable 0169
		static Delegate GetGetBundleHandler ()
		{
			if (cb_getBundle == null)
				cb_getBundle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBundle);
			return cb_getBundle;
		}

		static IntPtr n_GetBundle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Bundle);
		}
#pragma warning restore 0169

		IntPtr id_getBundle;
		public unsafe global::Java.Lang.Object? Bundle {
			get {
				if (id_getBundle == IntPtr.Zero)
					id_getBundle = JNIEnv.GetMethodID (class_ref, "getBundle", "()Ljava/lang/Object;");
				return (global::Java.Lang.Object?) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBundle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_containsKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_String_Handler ()
		{
			if (cb_containsKey_Ljava_lang_String_ == null)
				cb_containsKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ContainsKey_Ljava_lang_String_);
			return cb_containsKey_Ljava_lang_String_;
		}

		static bool n_ContainsKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_containsKey_Ljava_lang_String_;
		public unsafe bool ContainsKey (string? p0)
		{
			if (id_containsKey_Ljava_lang_String_ == IntPtr.Zero)
				id_containsKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsKey", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsKey_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_getBoolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Handler ()
		{
			if (cb_getBoolean_Ljava_lang_String_ == null)
				cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_GetBoolean_Ljava_lang_String_);
			return cb_getBoolean_Ljava_lang_String_;
		}

		static bool n_GetBoolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBoolean_Ljava_lang_String_;
		public unsafe bool GetBoolean (string? p0)
		{
			if (id_getBoolean_Ljava_lang_String_ == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBoolean_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_getBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBoolean_Ljava_lang_String_Z == null)
				cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_GetBoolean_Ljava_lang_String_Z);
			return cb_getBoolean_Ljava_lang_String_Z;
		}

		static bool n_GetBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBoolean_Ljava_lang_String_Z;
		public unsafe bool GetBoolean (string? p0, bool p1)
		{
			if (id_getBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBoolean_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_getInt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Handler ()
		{
			if (cb_getInt_Ljava_lang_String_ == null)
				cb_getInt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetInt_Ljava_lang_String_);
			return cb_getInt_Ljava_lang_String_;
		}

		static IntPtr n_GetInt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInt (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInt_Ljava_lang_String_;
		public unsafe global::Java.Lang.Integer? GetInt (string? p0)
		{
			if (id_getInt_Ljava_lang_String_ == IntPtr.Zero)
				id_getInt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;)Ljava/lang/Integer;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static IntPtr n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLong (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLong_Ljava_lang_String_;
		public unsafe global::Java.Lang.Long? GetLong (string? p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLong_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Ljava_lang_String_;
		public unsafe string? GetString (string? p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate? cb_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetPutBoolean_Ljava_lang_String_Ljava_lang_Boolean_Handler ()
		{
			if (cb_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_ == null)
				cb_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PutBoolean_Ljava_lang_String_Ljava_lang_Boolean_);
			return cb_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_;
		}

		static void n_PutBoolean_Ljava_lang_String_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutBoolean (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_;
		public unsafe void PutBoolean (string? p0, global::Java.Lang.Boolean? p1)
		{
			if (id_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "putBoolean", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBoolean_Ljava_lang_String_Ljava_lang_Boolean_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_putInt_Ljava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetPutInt_Ljava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_putInt_Ljava_lang_String_Ljava_lang_Integer_ == null)
				cb_putInt_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PutInt_Ljava_lang_String_Ljava_lang_Integer_);
			return cb_putInt_Ljava_lang_String_Ljava_lang_Integer_;
		}

		static void n_PutInt_Ljava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutInt (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putInt_Ljava_lang_String_Ljava_lang_Integer_;
		public unsafe void PutInt (string? p0, global::Java.Lang.Integer? p1)
		{
			if (id_putInt_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
				id_putInt_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "putInt", "(Ljava/lang/String;Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putInt_Ljava_lang_String_Ljava_lang_Integer_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_putLong_Ljava_lang_String_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetPutLong_Ljava_lang_String_Ljava_lang_Long_Handler ()
		{
			if (cb_putLong_Ljava_lang_String_Ljava_lang_Long_ == null)
				cb_putLong_Ljava_lang_String_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PutLong_Ljava_lang_String_Ljava_lang_Long_);
			return cb_putLong_Ljava_lang_String_Ljava_lang_Long_;
		}

		static void n_PutLong_Ljava_lang_String_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutLong (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putLong_Ljava_lang_String_Ljava_lang_Long_;
		public unsafe void PutLong (string? p0, global::Java.Lang.Long? p1)
		{
			if (id_putLong_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_putLong_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "putLong", "(Ljava/lang/String;Ljava/lang/Long;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putLong_Ljava_lang_String_Ljava_lang_Long_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_putString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PutString_Ljava_lang_String_Ljava_lang_String_);
			return cb_putString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutString (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_putString_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void PutString (string? p0, string? p1)
		{
			if (id_putString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putString_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_setBundle_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetSetBundle_Landroid_os_Parcelable_Handler ()
		{
			if (cb_setBundle_Landroid_os_Parcelable_ == null)
				cb_setBundle_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBundle_Landroid_os_Parcelable_);
			return cb_setBundle_Landroid_os_Parcelable_;
		}

		static void n_SetBundle_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IBundleCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Android.OS.IParcelable?)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBundle (p0);
		}
#pragma warning restore 0169

		IntPtr id_setBundle_Landroid_os_Parcelable_;
		public unsafe void SetBundle (global::Android.OS.IParcelable? p0)
		{
			if (id_setBundle_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_setBundle_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "setBundle", "(Landroid/os/Parcelable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBundle_Landroid_os_Parcelable_, __args);
		}

	}
}
