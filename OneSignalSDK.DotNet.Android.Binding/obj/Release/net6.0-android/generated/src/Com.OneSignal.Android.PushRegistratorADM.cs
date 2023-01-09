using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='PushRegistratorADM']"
	[global::Android.Runtime.Register ("com/onesignal/PushRegistratorADM", DoNotGenerateAcw=true)]
	public partial class PushRegistratorADM : global::Java.Lang.Object, global::Com.OneSignal.Android.IPushRegistrator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/PushRegistratorADM", typeof (PushRegistratorADM));

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

		protected PushRegistratorADM (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='PushRegistratorADM']/constructor[@name='PushRegistratorADM' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushRegistratorADM () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='PushRegistratorADM']/method[@name='fireCallback' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fireCallback", "(Ljava/lang/String;)V", "")]
		public static unsafe void FireCallback (string? id)
		{
			const string __id = "fireCallback.(Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString ((string?)id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate? cb_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_;
#pragma warning disable 0169
		static Delegate GetRegisterForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_Handler ()
		{
			if (cb_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_ == null)
				cb_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_RegisterForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_);
			return cb_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_;
		}

		static void n_RegisterForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_noKeyNeeded, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.PushRegistratorADM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var noKeyNeeded = JNIEnv.GetString (native_noKeyNeeded, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.OneSignal.Android.IPushRegistrator.IRegisteredHandler?)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IPushRegistrator.IRegisteredHandler> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RegisterForPush (context, noKeyNeeded, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='PushRegistratorADM']/method[@name='registerForPush' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.onesignal.PushRegistrator.RegisteredHandler']]"
		[Register ("registerForPush", "(Landroid/content/Context;Ljava/lang/String;Lcom/onesignal/PushRegistrator$RegisteredHandler;)V", "GetRegisterForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_Handler")]
		public virtual unsafe void RegisterForPush (global::Android.Content.Context? context, string? noKeyNeeded, global::Com.OneSignal.Android.IPushRegistrator.IRegisteredHandler? @callback)
		{
			const string __id = "registerForPush.(Landroid/content/Context;Ljava/lang/String;Lcom/onesignal/PushRegistrator$RegisteredHandler;)V";
			IntPtr native_noKeyNeeded = JNIEnv.NewString ((string?)noKeyNeeded);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_noKeyNeeded);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_noKeyNeeded);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
