using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Outcomes.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.outcomes.data']/class[@name='OSOutcomeEventsFactory']"
	[global::Android.Runtime.Register ("com/onesignal/outcomes/data/OSOutcomeEventsFactory", DoNotGenerateAcw=true)]
	public sealed partial class OSOutcomeEventsFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/outcomes/data/OSOutcomeEventsFactory", typeof (OSOutcomeEventsFactory));

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

		internal OSOutcomeEventsFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.outcomes.data']/class[@name='OSOutcomeEventsFactory']/constructor[@name='OSOutcomeEventsFactory' and count(parameter)=4 and parameter[1][@type='com.onesignal.OSLogger'] and parameter[2][@type='com.onesignal.OneSignalAPIClient'] and parameter[3][@type='com.onesignal.OneSignalDb'] and parameter[4][@type='com.onesignal.OSSharedPreferences']]"
		[Register (".ctor", "(Lcom/onesignal/OSLogger;Lcom/onesignal/OneSignalAPIClient;Lcom/onesignal/OneSignalDb;Lcom/onesignal/OSSharedPreferences;)V", "")]
		public unsafe OSOutcomeEventsFactory (global::Com.OneSignal.Android.IOSLogger logger, global::Com.OneSignal.Android.IOneSignalAPIClient apiClient, global::Com.OneSignal.Android.IOneSignalDb? dbHelper, global::Com.OneSignal.Android.IOSSharedPreferences? preferences) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/OSLogger;Lcom/onesignal/OneSignalAPIClient;Lcom/onesignal/OneSignalDb;Lcom/onesignal/OSSharedPreferences;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((logger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logger).Handle);
				__args [1] = new JniArgumentValue ((apiClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apiClient).Handle);
				__args [2] = new JniArgumentValue ((dbHelper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dbHelper).Handle);
				__args [3] = new JniArgumentValue ((preferences == null) ? IntPtr.Zero : ((global::Java.Lang.Object) preferences).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (logger);
				global::System.GC.KeepAlive (apiClient);
				global::System.GC.KeepAlive (dbHelper);
				global::System.GC.KeepAlive (preferences);
			}
		}

	}
}
