using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OSPermissionObserver']"
	[Register ("com/onesignal/OSPermissionObserver", "", "Com.OneSignal.Android.IOSPermissionObserverInvoker")]
	public partial interface IOSPermissionObserver : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSPermissionObserver']/method[@name='onOSPermissionChanged' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSPermissionStateChanges']]"
		[Register ("onOSPermissionChanged", "(Lcom/onesignal/OSPermissionStateChanges;)V", "GetOnOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_Handler:Com.OneSignal.Android.IOSPermissionObserverInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void OnOSPermissionChanged (global::Com.OneSignal.Android.OSPermissionStateChanges? p0);

	}

	[global::Android.Runtime.Register ("com/onesignal/OSPermissionObserver", DoNotGenerateAcw=true)]
	internal partial class IOSPermissionObserverInvoker : global::Java.Lang.Object, IOSPermissionObserver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSPermissionObserver", typeof (IOSPermissionObserverInvoker));

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

		public static IOSPermissionObserver? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOSPermissionObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OSPermissionObserver'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOSPermissionObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_;
#pragma warning disable 0169
		static Delegate GetOnOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_Handler ()
		{
			if (cb_onOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_ == null)
				cb_onOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_);
			return cb_onOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_;
		}

		static void n_OnOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOSPermissionObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSPermissionStateChanges> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOSPermissionChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_;
		public unsafe void OnOSPermissionChanged (global::Com.OneSignal.Android.OSPermissionStateChanges? p0)
		{
			if (id_onOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_ == IntPtr.Zero)
				id_onOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_ = JNIEnv.GetMethodID (class_ref, "onOSPermissionChanged", "(Lcom/onesignal/OSPermissionStateChanges;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOSPermissionChanged_Lcom_onesignal_OSPermissionStateChanges_, __args);
		}

	}
}
