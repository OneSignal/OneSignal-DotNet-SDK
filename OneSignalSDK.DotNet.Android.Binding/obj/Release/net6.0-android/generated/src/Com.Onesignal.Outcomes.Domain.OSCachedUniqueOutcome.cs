using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Outcomes.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSCachedUniqueOutcome']"
	[global::Android.Runtime.Register ("com/onesignal/outcomes/domain/OSCachedUniqueOutcome", DoNotGenerateAcw=true)]
	public partial class OSCachedUniqueOutcome : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/outcomes/domain/OSCachedUniqueOutcome", typeof (OSCachedUniqueOutcome));

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

		protected OSCachedUniqueOutcome (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSCachedUniqueOutcome']/constructor[@name='OSCachedUniqueOutcome' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.influence.domain.OSInfluenceChannel']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/onesignal/influence/domain/OSInfluenceChannel;)V", "")]
		public unsafe OSCachedUniqueOutcome (string influenceId, global::Com.Onesignal.Influence.Domain.OSInfluenceChannel channel) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/onesignal/influence/domain/OSInfluenceChannel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_influenceId = JNIEnv.NewString ((string?)influenceId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_influenceId);
				__args [1] = new JniArgumentValue ((channel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) channel).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_influenceId);
				global::System.GC.KeepAlive (channel);
			}
		}

	}
}
