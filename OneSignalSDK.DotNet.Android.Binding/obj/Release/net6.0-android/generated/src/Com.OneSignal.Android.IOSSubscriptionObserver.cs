using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSubscriptionObserver']"
	[Register ("com/onesignal/OSSubscriptionObserver", "", "Com.OneSignal.Android.IOSSubscriptionObserverInvoker")]
	public partial interface IOSSubscriptionObserver : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSubscriptionObserver']/method[@name='onOSSubscriptionChanged' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSSubscriptionStateChanges']]"
		[Register ("onOSSubscriptionChanged", "(Lcom/onesignal/OSSubscriptionStateChanges;)V", "GetOnOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_Handler:Com.OneSignal.Android.IOSSubscriptionObserverInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void OnOSSubscriptionChanged (global::Com.OneSignal.Android.OSSubscriptionStateChanges? p0);

	}

	[global::Android.Runtime.Register ("com/onesignal/OSSubscriptionObserver", DoNotGenerateAcw=true)]
	internal partial class IOSSubscriptionObserverInvoker : global::Java.Lang.Object, IOSSubscriptionObserver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSSubscriptionObserver", typeof (IOSSubscriptionObserverInvoker));

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

		public static IOSSubscriptionObserver? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSSubscriptionObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OSSubscriptionObserver'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSSubscriptionObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_;
#pragma warning disable 0169
		static Delegate GetOnOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_Handler ()
		{
			if (cb_onOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_ == null)
				cb_onOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_);
			return cb_onOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_;
		}

		static void n_OnOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSubscriptionObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSubscriptionStateChanges> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOSSubscriptionChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_;
		public unsafe void OnOSSubscriptionChanged (global::Com.OneSignal.Android.OSSubscriptionStateChanges? p0)
		{
			if (id_onOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_ == IntPtr.Zero)
				id_onOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_ = JNIEnv.GetMethodID (class_ref, "onOSSubscriptionChanged", "(Lcom/onesignal/OSSubscriptionStateChanges;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOSSubscriptionChanged_Lcom_onesignal_OSSubscriptionStateChanges_, __args);
		}

	}
}
