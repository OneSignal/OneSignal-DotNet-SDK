using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSMutableNotification']"
	[global::Android.Runtime.Register ("com/onesignal/OSMutableNotification", DoNotGenerateAcw=true)]
	public partial class OSMutableNotification : global::Com.OneSignal.Android.OSNotification {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSMutableNotification", typeof (OSMutableNotification));

		internal static new IntPtr class_ref {
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

		protected OSMutableNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_setAndroidNotificationId_I;
#pragma warning disable 0169
		static Delegate GetSetAndroidNotificationId_IHandler ()
		{
			if (cb_setAndroidNotificationId_I == null)
				cb_setAndroidNotificationId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAndroidNotificationId_I);
			return cb_setAndroidNotificationId_I;
		}

		static void n_SetAndroidNotificationId_I (IntPtr jnienv, IntPtr native__this, int androidNotificationId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSMutableNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetAndroidNotificationId (androidNotificationId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSMutableNotification']/method[@name='setAndroidNotificationId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAndroidNotificationId", "(I)V", "GetSetAndroidNotificationId_IHandler")]
		public virtual unsafe void SetAndroidNotificationId (int androidNotificationId)
		{
			const string __id = "setAndroidNotificationId.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (androidNotificationId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
