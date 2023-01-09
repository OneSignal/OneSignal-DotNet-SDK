using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.language']/class[@name='LanguageProviderAppDefined']"
	[global::Android.Runtime.Register ("com/onesignal/language/LanguageProviderAppDefined", DoNotGenerateAcw=true)]
	public partial class LanguageProviderAppDefined : global::Java.Lang.Object, global::Com.Onesignal.Language.ILanguageProvider {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal.language']/class[@name='LanguageProviderAppDefined']/field[@name='PREFS_OS_LANGUAGE']"
		[Register ("PREFS_OS_LANGUAGE")]
		public const string PrefsOsLanguage = (string) "PREFS_OS_LANGUAGE";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/language/LanguageProviderAppDefined", typeof (LanguageProviderAppDefined));

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

		protected LanguageProviderAppDefined (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.language']/class[@name='LanguageProviderAppDefined']/constructor[@name='LanguageProviderAppDefined' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSSharedPreferences']]"
		[Register (".ctor", "(Lcom/onesignal/OSSharedPreferences;)V", "")]
		public unsafe LanguageProviderAppDefined (global::Com.OneSignal.Android.IOSSharedPreferences? preferences) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Language.LanguageProviderAppDefined> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static Delegate? cb_setLanguage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLanguage_Ljava_lang_String_Handler ()
		{
			if (cb_setLanguage_Ljava_lang_String_ == null)
				cb_setLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLanguage_Ljava_lang_String_);
			return cb_setLanguage_Ljava_lang_String_;
		}

		static void n_SetLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_language)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Language.LanguageProviderAppDefined> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var language = JNIEnv.GetString (native_language, JniHandleOwnership.DoNotTransfer);
			__this.Language = language!;
		}
#pragma warning restore 0169

		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.language']/class[@name='LanguageProviderAppDefined']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				const string __id = "getLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.language']/class[@name='LanguageProviderAppDefined']/method[@name='setLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLanguage.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
