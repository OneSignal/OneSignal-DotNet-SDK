using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']"
	[Register ("com/onesignal/OSSharedPreferences", "", "Com.OneSignal.Android.IOSSharedPreferencesInvoker")]
	public partial interface IOSSharedPreferences : IJavaObject, IJavaPeerable {
		string? OutcomesV2KeyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='getOutcomesV2KeyName' and count(parameter)=0]"
			[Register ("getOutcomesV2KeyName", "()Ljava/lang/String;", "GetGetOutcomesV2KeyNameHandler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
			get; 
		}

		string? PreferencesName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='getPreferencesName' and count(parameter)=0]"
			[Register ("getPreferencesName", "()Ljava/lang/String;", "GetGetPreferencesNameHandler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='getBool' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getBool", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "GetGetBool_Ljava_lang_String_Ljava_lang_String_ZHandler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		bool GetBool (string? p0, string? p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='getInt' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;Ljava/lang/String;I)I", "GetGetInt_Ljava_lang_String_Ljava_lang_String_IHandler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		int GetInt (string? p0, string? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='getLong' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("getLong", "(Ljava/lang/String;Ljava/lang/String;J)J", "GetGetLong_Ljava_lang_String_Ljava_lang_String_JHandler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		long GetLong (string? p0, string? p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='getObject' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("getObject", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "GetGetObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Handler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		global::Java.Lang.Object? GetObject (string? p0, string? p1, global::Java.Lang.Object? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='getString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		string? GetString (string? p0, string? p1, string? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='getStringSet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getStringSet", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;", "GetGetStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_Handler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		global::System.Collections.Generic.ICollection<string>? GetStringSet (string p0, string p1, global::System.Collections.Generic.ICollection<string>? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='saveBool' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("saveBool", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetSaveBool_Ljava_lang_String_Ljava_lang_String_ZHandler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SaveBool (string? p0, string? p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='saveInt' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("saveInt", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetSaveInt_Ljava_lang_String_Ljava_lang_String_IHandler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SaveInt (string? p0, string? p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='saveLong' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("saveLong", "(Ljava/lang/String;Ljava/lang/String;J)V", "GetSaveLong_Ljava_lang_String_Ljava_lang_String_JHandler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SaveLong (string? p0, string? p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='saveObject' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("saveObject", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "GetSaveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Handler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SaveObject (string? p0, string? p1, global::Java.Lang.Object? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='saveString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("saveString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSaveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SaveString (string? p0, string? p1, string? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSharedPreferences']/method[@name='saveStringSet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("saveStringSet", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)V", "GetSaveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_Handler:Com.OneSignal.Android.IOSSharedPreferencesInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SaveStringSet (string p0, string p1, global::System.Collections.Generic.ICollection<string> p2);

	}

	[global::Android.Runtime.Register ("com/onesignal/OSSharedPreferences", DoNotGenerateAcw=true)]
	internal partial class IOSSharedPreferencesInvoker : global::Java.Lang.Object, IOSSharedPreferences {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSSharedPreferences", typeof (IOSSharedPreferencesInvoker));

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

		public static IOSSharedPreferences? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSSharedPreferences> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OSSharedPreferences'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSSharedPreferencesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getOutcomesV2KeyName;
#pragma warning disable 0169
		static Delegate GetGetOutcomesV2KeyNameHandler ()
		{
			if (cb_getOutcomesV2KeyName == null)
				cb_getOutcomesV2KeyName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOutcomesV2KeyName);
			return cb_getOutcomesV2KeyName;
		}

		static IntPtr n_GetOutcomesV2KeyName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.OutcomesV2KeyName);
		}
#pragma warning restore 0169

		IntPtr id_getOutcomesV2KeyName;
		public unsafe string? OutcomesV2KeyName {
			get {
				if (id_getOutcomesV2KeyName == IntPtr.Zero)
					id_getOutcomesV2KeyName = JNIEnv.GetMethodID (class_ref, "getOutcomesV2KeyName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutcomesV2KeyName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getPreferencesName;
#pragma warning disable 0169
		static Delegate GetGetPreferencesNameHandler ()
		{
			if (cb_getPreferencesName == null)
				cb_getPreferencesName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPreferencesName);
			return cb_getPreferencesName;
		}

		static IntPtr n_GetPreferencesName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PreferencesName);
		}
#pragma warning restore 0169

		IntPtr id_getPreferencesName;
		public unsafe string? PreferencesName {
			get {
				if (id_getPreferencesName == IntPtr.Zero)
					id_getPreferencesName = JNIEnv.GetMethodID (class_ref, "getPreferencesName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreferencesName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getBool_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBool_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBool_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_getBool_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_Z) n_GetBool_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_getBool_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static bool n_GetBool_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBool (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBool_Ljava_lang_String_Ljava_lang_String_Z;
		public unsafe bool GetBool (string? p0, string? p1, bool p2)
		{
			if (id_getBool_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBool_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBool", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBool_Ljava_lang_String_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_getInt_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_getInt_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_getInt_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_I) n_GetInt_Ljava_lang_String_Ljava_lang_String_I);
			return cb_getInt_Ljava_lang_String_Ljava_lang_String_I;
		}

		static int n_GetInt_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInt_Ljava_lang_String_Ljava_lang_String_I;
		public unsafe int GetInt (string? p0, string? p1, int p2)
		{
			if (id_getInt_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInt_Ljava_lang_String_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_getLong_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_getLong_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_getLong_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_J) n_GetLong_Ljava_lang_String_Ljava_lang_String_J);
			return cb_getLong_Ljava_lang_String_Ljava_lang_String_J;
		}

		static long n_GetLong_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLong_Ljava_lang_String_Ljava_lang_String_J;
		public unsafe long GetLong (string? p0, string? p1, long p2)
		{
			if (id_getLong_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_getLong_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;Ljava/lang/String;J)J");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLong_Ljava_lang_String_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_getObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetObject (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object? GetObject (string? p0, string? p1, global::Java.Lang.Object? p2)
		{
			if (id_getObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getObject", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate? cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string? GetString (string? p0, string? p1, string? p2)
		{
			if (id_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate? cb_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetGetStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_Handler ()
		{
			if (cb_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ == null)
				cb_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_);
			return cb_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
		}

		static IntPtr n_GetStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.GetStringSet (p0!, p1!, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
		public unsafe global::System.Collections.Generic.ICollection<string>? GetStringSet (string p0, string p1, global::System.Collections.Generic.ICollection<string>? p2)
		{
			if (id_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ == IntPtr.Zero)
				id_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "getStringSet", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate? cb_saveBool_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSaveBool_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_saveBool_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_saveBool_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_SaveBool_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_saveBool_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_SaveBool_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveBool (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_saveBool_Ljava_lang_String_Ljava_lang_String_Z;
		public unsafe void SaveBool (string? p0, string? p1, bool p2)
		{
			if (id_saveBool_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_saveBool_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "saveBool", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveBool_Ljava_lang_String_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_saveInt_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSaveInt_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_saveInt_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_saveInt_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_SaveInt_Ljava_lang_String_Ljava_lang_String_I);
			return cb_saveInt_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_SaveInt_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveInt (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_saveInt_Ljava_lang_String_Ljava_lang_String_I;
		public unsafe void SaveInt (string? p0, string? p1, int p2)
		{
			if (id_saveInt_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_saveInt_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "saveInt", "(Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveInt_Ljava_lang_String_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_saveLong_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetSaveLong_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_saveLong_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_saveLong_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJ_V) n_SaveLong_Ljava_lang_String_Ljava_lang_String_J);
			return cb_saveLong_Ljava_lang_String_Ljava_lang_String_J;
		}

		static void n_SaveLong_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveLong (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_saveLong_Ljava_lang_String_Ljava_lang_String_J;
		public unsafe void SaveLong (string? p0, string? p1, long p2)
		{
			if (id_saveLong_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_saveLong_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "saveLong", "(Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveLong_Ljava_lang_String_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_saveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSaveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_saveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_saveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SaveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_);
			return cb_saveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SaveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SaveObject (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_saveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void SaveObject (string? p0, string? p1, global::Java.Lang.Object? p2)
		{
			if (id_saveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_saveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "saveObject", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveObject_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_saveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_saveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_saveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SaveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_saveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SaveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SaveString (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_saveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SaveString (string? p0, string? p1, string? p2)
		{
			if (id_saveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_saveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate? cb_saveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSaveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_Handler ()
		{
			if (cb_saveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ == null)
				cb_saveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SaveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_);
			return cb_saveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
		}

		static void n_SaveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SaveStringSet (p0!, p1!, p2!);
		}
#pragma warning restore 0169

		IntPtr id_saveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
		public unsafe void SaveStringSet (string p0, string p1, global::System.Collections.Generic.ICollection<string> p2)
		{
			if (id_saveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ == IntPtr.Zero)
				id_saveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "saveStringSet", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}
