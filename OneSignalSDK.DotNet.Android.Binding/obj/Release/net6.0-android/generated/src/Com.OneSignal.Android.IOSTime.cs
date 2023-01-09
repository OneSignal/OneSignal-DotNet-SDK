using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OSTime']"
	[Register ("com/onesignal/OSTime", "", "Com.OneSignal.Android.IOSTimeInvoker")]
	public partial interface IOSTime : IJavaObject, IJavaPeerable {
		long CurrentTimeMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSTime']/method[@name='getCurrentTimeMillis' and count(parameter)=0]"
			[Register ("getCurrentTimeMillis", "()J", "GetGetCurrentTimeMillisHandler:Com.OneSignal.Android.IOSTimeInvoker, OneSignalSDK.DotNet.Android.Binding")]
			get; 
		}

		long ElapsedRealtime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSTime']/method[@name='getElapsedRealtime' and count(parameter)=0]"
			[Register ("getElapsedRealtime", "()J", "GetGetElapsedRealtimeHandler:Com.OneSignal.Android.IOSTimeInvoker, OneSignalSDK.DotNet.Android.Binding")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/onesignal/OSTime", DoNotGenerateAcw=true)]
	internal partial class IOSTimeInvoker : global::Java.Lang.Object, IOSTime {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSTime", typeof (IOSTimeInvoker));

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

		public static IOSTime? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSTime> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OSTime'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSTimeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CurrentTimeMillis;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTimeMillis;
		public unsafe long CurrentTimeMillis {
			get {
				if (id_getCurrentTimeMillis == IntPtr.Zero)
					id_getCurrentTimeMillis = JNIEnv.GetMethodID (class_ref, "getCurrentTimeMillis", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTimeMillis);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ElapsedRealtime;
		}
#pragma warning restore 0169

		IntPtr id_getElapsedRealtime;
		public unsafe long ElapsedRealtime {
			get {
				if (id_getElapsedRealtime == IntPtr.Zero)
					id_getElapsedRealtime = JNIEnv.GetMethodID (class_ref, "getElapsedRealtime", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getElapsedRealtime);
			}
		}

	}
}
