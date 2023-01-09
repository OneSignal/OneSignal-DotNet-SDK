using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']"
	[global::Android.Runtime.Register ("com/onesignal/FCMIntentJobService", DoNotGenerateAcw=true)]
	public partial class FCMIntentJobService : global::Android.App.Service {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/field[@name='BUNDLE_EXTRA']"
		[Register ("BUNDLE_EXTRA")]
		public const string BundleExtra = (string) "Bundle:Parcelable:Extras";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/FCMIntentJobService", typeof (FCMIntentJobService));

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

		protected FCMIntentJobService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/constructor[@name='FCMIntentJobService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FCMIntentJobService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_isStopped;
#pragma warning disable 0169
		static Delegate GetIsStoppedHandler ()
		{
			if (cb_isStopped == null)
				cb_isStopped = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStopped);
			return cb_isStopped;
		}

		static bool n_IsStopped (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.FCMIntentJobService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsStopped;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStopped {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/method[@name='isStopped' and count(parameter)=0]"
			[Register ("isStopped", "()Z", "GetIsStoppedHandler")]
			get {
				const string __id = "isStopped.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/method[@name='enqueueWork' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("enqueueWork", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void EnqueueWork (global::Android.Content.Context? context, global::Android.Content.Intent? intent)
		{
			const string __id = "enqueueWork.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (intent);
			}
		}

		static Delegate? cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.FCMIntentJobService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0!));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder? OnBind (global::Android.Content.Intent p0)
		{
			const string __id = "onBind.(Landroid/content/Intent;)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCreate);
			return cb_onCreate;
		}

		static void n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.FCMIntentJobService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnCreate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()V", "GetOnCreateHandler")]
		public override unsafe void OnCreate ()
		{
			const string __id = "onCreate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.FCMIntentJobService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public override unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_onHandleWork_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnHandleWork_Landroid_content_Intent_Handler ()
		{
			if (cb_onHandleWork_Landroid_content_Intent_ == null)
				cb_onHandleWork_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnHandleWork_Landroid_content_Intent_);
			return cb_onHandleWork_Landroid_content_Intent_;
		}

		static void n_OnHandleWork_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.FCMIntentJobService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleWork (intent!);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/method[@name='onHandleWork' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onHandleWork", "(Landroid/content/Intent;)V", "GetOnHandleWork_Landroid_content_Intent_Handler")]
		protected virtual unsafe void OnHandleWork (global::Android.Content.Intent intent)
		{
			const string __id = "onHandleWork.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (intent);
			}
		}

		static Delegate? cb_onStartCommand_Landroid_content_Intent_II;
#pragma warning disable 0169
		static Delegate GetOnStartCommand_Landroid_content_Intent_IIHandler ()
		{
			if (cb_onStartCommand_Landroid_content_Intent_II == null)
				cb_onStartCommand_Landroid_content_Intent_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_I) n_OnStartCommand_Landroid_content_Intent_II);
			return cb_onStartCommand_Landroid_content_Intent_II;
		}

		static int n_OnStartCommand_Landroid_content_Intent_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.FCMIntentJobService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.App.StartCommandFlags) native_p1;
			int __ret = (int) __this.OnStartCommand (p0, p1!, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/method[@name='onStartCommand' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onStartCommand", "(Landroid/content/Intent;II)I", "GetOnStartCommand_Landroid_content_Intent_IIHandler")]
		public override unsafe global::Android.App.StartCommandResult OnStartCommand (global::Android.Content.Intent? p0, [global::Android.Runtime.GeneratedEnum] global::Android.App.StartCommandFlags p1, int p2)
		{
			const string __id = "onStartCommand.(Landroid/content/Intent;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return (global::Android.App.StartCommandResult) __rm!;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_onStopCurrentWork;
#pragma warning disable 0169
		static Delegate GetOnStopCurrentWorkHandler ()
		{
			if (cb_onStopCurrentWork == null)
				cb_onStopCurrentWork = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_OnStopCurrentWork);
			return cb_onStopCurrentWork;
		}

		static bool n_OnStopCurrentWork (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.FCMIntentJobService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.OnStopCurrentWork ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/method[@name='onStopCurrentWork' and count(parameter)=0]"
		[Register ("onStopCurrentWork", "()Z", "GetOnStopCurrentWorkHandler")]
		public virtual unsafe bool OnStopCurrentWork ()
		{
			const string __id = "onStopCurrentWork.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_setInterruptIfStopped_Z;
#pragma warning disable 0169
		static Delegate GetSetInterruptIfStopped_ZHandler ()
		{
			if (cb_setInterruptIfStopped_Z == null)
				cb_setInterruptIfStopped_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetInterruptIfStopped_Z);
			return cb_setInterruptIfStopped_Z;
		}

		static void n_SetInterruptIfStopped_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.FCMIntentJobService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetInterruptIfStopped (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='FCMIntentJobService']/method[@name='setInterruptIfStopped' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInterruptIfStopped", "(Z)V", "GetSetInterruptIfStopped_ZHandler")]
		public virtual unsafe void SetInterruptIfStopped (bool p0)
		{
			const string __id = "setInterruptIfStopped.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='JobIntentService']/method[@name='enqueueWork' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.ComponentName'] and parameter[3][@type='int'] and parameter[4][@type='android.content.Intent'] and parameter[5][@type='boolean']]"
		[Register ("enqueueWork", "(Landroid/content/Context;Landroid/content/ComponentName;ILandroid/content/Intent;Z)V", "")]
		public static unsafe void EnqueueWork (global::Android.Content.Context context, global::Android.Content.ComponentName component, int jobId, global::Android.Content.Intent work, bool useWakefulService)
		{
			const string __id = "enqueueWork.(Landroid/content/Context;Landroid/content/ComponentName;ILandroid/content/Intent;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((component == null) ? IntPtr.Zero : ((global::Java.Lang.Object) component).Handle);
				__args [2] = new JniArgumentValue (jobId);
				__args [3] = new JniArgumentValue ((work == null) ? IntPtr.Zero : ((global::Java.Lang.Object) work).Handle);
				__args [4] = new JniArgumentValue (useWakefulService);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (component);
				global::System.GC.KeepAlive (work);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='JobIntentService']/method[@name='enqueueWork' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='int'] and parameter[4][@type='android.content.Intent'] and parameter[5][@type='boolean']]"
		[Register ("enqueueWork", "(Landroid/content/Context;Ljava/lang/Class;ILandroid/content/Intent;Z)V", "")]
		public static unsafe void EnqueueWork (global::Android.Content.Context context, global::Java.Lang.Class cls, int jobId, global::Android.Content.Intent work, bool useWakefulService)
		{
			const string __id = "enqueueWork.(Landroid/content/Context;Ljava/lang/Class;ILandroid/content/Intent;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
				__args [2] = new JniArgumentValue (jobId);
				__args [3] = new JniArgumentValue ((work == null) ? IntPtr.Zero : ((global::Java.Lang.Object) work).Handle);
				__args [4] = new JniArgumentValue (useWakefulService);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (cls);
				global::System.GC.KeepAlive (work);
			}
		}

	}
}
