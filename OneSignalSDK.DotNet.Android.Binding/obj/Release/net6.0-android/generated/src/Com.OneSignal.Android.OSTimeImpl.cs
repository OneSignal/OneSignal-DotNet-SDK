using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSTimeImpl']"
	[global::Android.Runtime.Register ("com/onesignal/OSTimeImpl", DoNotGenerateAcw=true)]
	public partial class OSTimeImpl : global::Java.Lang.Object, global::Com.OneSignal.Android.IOSTime {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSTimeImpl", typeof (OSTimeImpl));

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

		protected OSTimeImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSTimeImpl']/constructor[@name='OSTimeImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSTimeImpl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_getCurrentTimeMillis;
#pragma warning disable 0169
		static Delegate GetGetCurrentTimeMillisHandler ()
		{
			if (cb_getCurrentTimeMillis == null)
				cb_getCurrentTimeMillis = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCurrentTimeMillis);
			return cb_getCurrentTimeMillis;
		}

		static long n_GetCurrentTimeMillis (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSTimeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CurrentTimeMillis;
		}
#pragma warning restore 0169

		public virtual unsafe long CurrentTimeMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSTimeImpl']/method[@name='getCurrentTimeMillis' and count(parameter)=0]"
			[Register ("getCurrentTimeMillis", "()J", "GetGetCurrentTimeMillisHandler")]
			get {
				const string __id = "getCurrentTimeMillis.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getElapsedRealtime;
#pragma warning disable 0169
		static Delegate GetGetElapsedRealtimeHandler ()
		{
			if (cb_getElapsedRealtime == null)
				cb_getElapsedRealtime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetElapsedRealtime);
			return cb_getElapsedRealtime;
		}

		static long n_GetElapsedRealtime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSTimeImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ElapsedRealtime;
		}
#pragma warning restore 0169

		public virtual unsafe long ElapsedRealtime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSTimeImpl']/method[@name='getElapsedRealtime' and count(parameter)=0]"
			[Register ("getElapsedRealtime", "()J", "GetGetElapsedRealtimeHandler")]
			get {
				const string __id = "getElapsedRealtime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
