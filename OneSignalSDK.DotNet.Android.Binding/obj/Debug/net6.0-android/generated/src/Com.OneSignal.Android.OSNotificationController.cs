using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationController']"
	[global::Android.Runtime.Register ("com/onesignal/OSNotificationController", DoNotGenerateAcw=true)]
	public partial class OSNotificationController : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotificationController", typeof (OSNotificationController));

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

		protected OSNotificationController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_isFromBackgroundLogic;
#pragma warning disable 0169
		static Delegate GetIsFromBackgroundLogicHandler ()
		{
			if (cb_isFromBackgroundLogic == null)
				cb_isFromBackgroundLogic = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFromBackgroundLogic);
			return cb_isFromBackgroundLogic;
		}

		static bool n_IsFromBackgroundLogic (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.FromBackgroundLogic;
		}
#pragma warning restore 0169

		static Delegate? cb_setFromBackgroundLogic_Z;
#pragma warning disable 0169
		static Delegate GetSetFromBackgroundLogic_ZHandler ()
		{
			if (cb_setFromBackgroundLogic_Z == null)
				cb_setFromBackgroundLogic_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFromBackgroundLogic_Z);
			return cb_setFromBackgroundLogic_Z;
		}

		static void n_SetFromBackgroundLogic_Z (IntPtr jnienv, IntPtr native__this, bool fromBackgroundLogic)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.FromBackgroundLogic = fromBackgroundLogic;
		}
#pragma warning restore 0169

		public virtual unsafe bool FromBackgroundLogic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationController']/method[@name='isFromBackgroundLogic' and count(parameter)=0]"
			[Register ("isFromBackgroundLogic", "()Z", "GetIsFromBackgroundLogicHandler")]
			get {
				const string __id = "isFromBackgroundLogic.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationController']/method[@name='setFromBackgroundLogic' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFromBackgroundLogic", "(Z)V", "GetSetFromBackgroundLogic_ZHandler")]
			set {
				const string __id = "setFromBackgroundLogic.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_isNotificationWithinTTL;
#pragma warning disable 0169
		static Delegate GetIsNotificationWithinTTLHandler ()
		{
			if (cb_isNotificationWithinTTL == null)
				cb_isNotificationWithinTTL = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNotificationWithinTTL);
			return cb_isNotificationWithinTTL;
		}

		static bool n_IsNotificationWithinTTL (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsNotificationWithinTTL;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNotificationWithinTTL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationController']/method[@name='isNotificationWithinTTL' and count(parameter)=0]"
			[Register ("isNotificationWithinTTL", "()Z", "GetIsNotificationWithinTTLHandler")]
			get {
				const string __id = "isNotificationWithinTTL.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getNotificationJob;
#pragma warning disable 0169
		static Delegate GetGetNotificationJobHandler ()
		{
			if (cb_getNotificationJob == null)
				cb_getNotificationJob = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNotificationJob);
			return cb_getNotificationJob;
		}

		static IntPtr n_GetNotificationJob (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.NotificationJob);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSNotificationGenerationJob? NotificationJob {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationController']/method[@name='getNotificationJob' and count(parameter)=0]"
			[Register ("getNotificationJob", "()Lcom/onesignal/OSNotificationGenerationJob;", "GetGetNotificationJobHandler")]
			get {
				const string __id = "getNotificationJob.()Lcom/onesignal/OSNotificationGenerationJob;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getNotificationReceivedEvent;
#pragma warning disable 0169
		static Delegate GetGetNotificationReceivedEventHandler ()
		{
			if (cb_getNotificationReceivedEvent == null)
				cb_getNotificationReceivedEvent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNotificationReceivedEvent);
			return cb_getNotificationReceivedEvent;
		}

		static IntPtr n_GetNotificationReceivedEvent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.NotificationReceivedEvent);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSNotificationReceivedEvent? NotificationReceivedEvent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationController']/method[@name='getNotificationReceivedEvent' and count(parameter)=0]"
			[Register ("getNotificationReceivedEvent", "()Lcom/onesignal/OSNotificationReceivedEvent;", "GetGetNotificationReceivedEventHandler")]
			get {
				const string __id = "getNotificationReceivedEvent.()Lcom/onesignal/OSNotificationReceivedEvent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationReceivedEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_isRestoring;
#pragma warning disable 0169
		static Delegate GetIsRestoringHandler ()
		{
			if (cb_isRestoring == null)
				cb_isRestoring = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRestoring);
			return cb_isRestoring;
		}

		static bool n_IsRestoring (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Restoring;
		}
#pragma warning restore 0169

		static Delegate? cb_setRestoring_Z;
#pragma warning disable 0169
		static Delegate GetSetRestoring_ZHandler ()
		{
			if (cb_setRestoring_Z == null)
				cb_setRestoring_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetRestoring_Z);
			return cb_setRestoring_Z;
		}

		static void n_SetRestoring_Z (IntPtr jnienv, IntPtr native__this, bool restoring)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Restoring = restoring;
		}
#pragma warning restore 0169

		public virtual unsafe bool Restoring {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationController']/method[@name='isRestoring' and count(parameter)=0]"
			[Register ("isRestoring", "()Z", "GetIsRestoringHandler")]
			get {
				const string __id = "isRestoring.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationController']/method[@name='setRestoring' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRestoring", "(Z)V", "GetSetRestoring_ZHandler")]
			set {
				const string __id = "setRestoring.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
