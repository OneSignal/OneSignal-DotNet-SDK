using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OSEmailSubscriptionObserver']"
	[Register ("com/onesignal/OSEmailSubscriptionObserver", "", "Com.OneSignal.Android.IOSEmailSubscriptionObserverInvoker")]
	public partial interface IOSEmailSubscriptionObserver : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSEmailSubscriptionObserver']/method[@name='onOSEmailSubscriptionChanged' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSEmailSubscriptionStateChanges']]"
		[Register ("onOSEmailSubscriptionChanged", "(Lcom/onesignal/OSEmailSubscriptionStateChanges;)V", "GetOnOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_Handler:Com.OneSignal.Android.IOSEmailSubscriptionObserverInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void OnOSEmailSubscriptionChanged (global::Com.OneSignal.Android.OSEmailSubscriptionStateChanges? p0);

	}

	[global::Android.Runtime.Register ("com/onesignal/OSEmailSubscriptionObserver", DoNotGenerateAcw=true)]
	internal partial class IOSEmailSubscriptionObserverInvoker : global::Java.Lang.Object, IOSEmailSubscriptionObserver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSEmailSubscriptionObserver", typeof (IOSEmailSubscriptionObserverInvoker));

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

		public static IOSEmailSubscriptionObserver? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSEmailSubscriptionObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OSEmailSubscriptionObserver'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSEmailSubscriptionObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_;
#pragma warning disable 0169
		static Delegate GetOnOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_Handler ()
		{
			if (cb_onOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_ == null)
				cb_onOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_);
			return cb_onOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_;
		}

		static void n_OnOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSEmailSubscriptionObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSEmailSubscriptionStateChanges> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOSEmailSubscriptionChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_;
		public unsafe void OnOSEmailSubscriptionChanged (global::Com.OneSignal.Android.OSEmailSubscriptionStateChanges? p0)
		{
			if (id_onOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_ == IntPtr.Zero)
				id_onOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_ = JNIEnv.GetMethodID (class_ref, "onOSEmailSubscriptionChanged", "(Lcom/onesignal/OSEmailSubscriptionStateChanges;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOSEmailSubscriptionChanged_Lcom_onesignal_OSEmailSubscriptionStateChanges_, __args);
		}

	}
}
