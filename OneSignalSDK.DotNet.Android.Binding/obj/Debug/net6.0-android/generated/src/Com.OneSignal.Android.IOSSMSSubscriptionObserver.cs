using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSMSSubscriptionObserver']"
	[Register ("com/onesignal/OSSMSSubscriptionObserver", "", "Com.OneSignal.Android.IOSSMSSubscriptionObserverInvoker")]
	public partial interface IOSSMSSubscriptionObserver : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSMSSubscriptionObserver']/method[@name='onSMSSubscriptionChanged' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSSMSSubscriptionStateChanges']]"
		[Register ("onSMSSubscriptionChanged", "(Lcom/onesignal/OSSMSSubscriptionStateChanges;)V", "GetOnSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_Handler:Com.OneSignal.Android.IOSSMSSubscriptionObserverInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void OnSMSSubscriptionChanged (global::Com.OneSignal.Android.OSSMSSubscriptionStateChanges? p0);

	}

	[global::Android.Runtime.Register ("com/onesignal/OSSMSSubscriptionObserver", DoNotGenerateAcw=true)]
	internal partial class IOSSMSSubscriptionObserverInvoker : global::Java.Lang.Object, IOSSMSSubscriptionObserver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSSMSSubscriptionObserver", typeof (IOSSMSSubscriptionObserverInvoker));

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

		public static IOSSMSSubscriptionObserver? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSSMSSubscriptionObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OSSMSSubscriptionObserver'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSSMSSubscriptionObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_;
#pragma warning disable 0169
		static Delegate GetOnSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_Handler ()
		{
			if (cb_onSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_ == null)
				cb_onSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_);
			return cb_onSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_;
		}

		static void n_OnSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSSMSSubscriptionObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSMSSubscriptionStateChanges> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSMSSubscriptionChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_;
		public unsafe void OnSMSSubscriptionChanged (global::Com.OneSignal.Android.OSSMSSubscriptionStateChanges? p0)
		{
			if (id_onSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_ == IntPtr.Zero)
				id_onSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_ = JNIEnv.GetMethodID (class_ref, "onSMSSubscriptionChanged", "(Lcom/onesignal/OSSMSSubscriptionStateChanges;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSMSSubscriptionChanged_Lcom_onesignal_OSSMSSubscriptionStateChanges_, __args);
		}

	}
}
