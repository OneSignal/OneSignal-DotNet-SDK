using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.language']/class[@name='LanguageContext']"
	[global::Android.Runtime.Register ("com/onesignal/language/LanguageContext", DoNotGenerateAcw=true)]
	public partial class LanguageContext : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/language/LanguageContext", typeof (LanguageContext));

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

		protected LanguageContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.language']/class[@name='LanguageContext']/constructor[@name='LanguageContext' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSSharedPreferences']]"
		[Register (".ctor", "(Lcom/onesignal/OSSharedPreferences;)V", "")]
		public unsafe LanguageContext (global::Com.OneSignal.Android.IOSSharedPreferences? preferences) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Onesignal.Language.LanguageContext? Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.language']/class[@name='LanguageContext']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/onesignal/language/LanguageContext;", "")]
			get {
				const string __id = "getInstance.()Lcom/onesignal/language/LanguageContext;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Language.LanguageContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Language.LanguageContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.language']/class[@name='LanguageContext']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				const string __id = "getLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		static Delegate? cb_setStrategy_Lcom_onesignal_language_LanguageProvider_;
#pragma warning disable 0169
		static Delegate GetSetStrategy_Lcom_onesignal_language_LanguageProvider_Handler ()
		{
			if (cb_setStrategy_Lcom_onesignal_language_LanguageProvider_ == null)
				cb_setStrategy_Lcom_onesignal_language_LanguageProvider_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetStrategy_Lcom_onesignal_language_LanguageProvider_);
			return cb_setStrategy_Lcom_onesignal_language_LanguageProvider_;
		}

		static void n_SetStrategy_Lcom_onesignal_language_LanguageProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strategy)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Language.LanguageContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var strategy = (global::Com.Onesignal.Language.ILanguageProvider?)global::Java.Lang.Object.GetObject<global::Com.Onesignal.Language.ILanguageProvider> (native_strategy, JniHandleOwnership.DoNotTransfer);
			__this.SetStrategy (strategy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.language']/class[@name='LanguageContext']/method[@name='setStrategy' and count(parameter)=1 and parameter[1][@type='com.onesignal.language.LanguageProvider']]"
		[Register ("setStrategy", "(Lcom/onesignal/language/LanguageProvider;)V", "GetSetStrategy_Lcom_onesignal_language_LanguageProvider_Handler")]
		public virtual unsafe void SetStrategy (global::Com.Onesignal.Language.ILanguageProvider? strategy)
		{
			const string __id = "setStrategy.(Lcom/onesignal/language/LanguageProvider;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (strategy);
			}
		}

	}
}
