using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Outcomes.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeEventParams']"
	[global::Android.Runtime.Register ("com/onesignal/outcomes/domain/OSOutcomeEventParams", DoNotGenerateAcw=true)]
	public sealed partial class OSOutcomeEventParams : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/outcomes/domain/OSOutcomeEventParams", typeof (OSOutcomeEventParams));

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

		internal OSOutcomeEventParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeEventParams']/constructor[@name='OSOutcomeEventParams' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.outcomes.domain.OSOutcomeSource'] and parameter[3][@type='float'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/onesignal/outcomes/domain/OSOutcomeSource;FJ)V", "")]
		public unsafe OSOutcomeEventParams (string outcomeId, global::Com.Onesignal.Outcomes.Domain.OSOutcomeSource? outcomeSource, float weight, long timestamp) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/onesignal/outcomes/domain/OSOutcomeSource;FJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_outcomeId = JNIEnv.NewString ((string?)outcomeId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_outcomeId);
				__args [1] = new JniArgumentValue ((outcomeSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outcomeSource).Handle);
				__args [2] = new JniArgumentValue (weight);
				__args [3] = new JniArgumentValue (timestamp);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_outcomeId);
				global::System.GC.KeepAlive (outcomeSource);
			}
		}

		public unsafe bool IsUnattributed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeEventParams']/method[@name='isUnattributed' and count(parameter)=0]"
			[Register ("isUnattributed", "()Z", "")]
			get {
				const string __id = "isUnattributed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string OutcomeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeEventParams']/method[@name='getOutcomeId' and count(parameter)=0]"
			[Register ("getOutcomeId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getOutcomeId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Onesignal.Outcomes.Domain.OSOutcomeSource? OutcomeSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeEventParams']/method[@name='getOutcomeSource' and count(parameter)=0]"
			[Register ("getOutcomeSource", "()Lcom/onesignal/outcomes/domain/OSOutcomeSource;", "")]
			get {
				const string __id = "getOutcomeSource.()Lcom/onesignal/outcomes/domain/OSOutcomeSource;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.OSOutcomeSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeEventParams']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "")]
			get {
				const string __id = "getTimestamp.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeEventParams']/method[@name='setTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTimestamp", "(J)V", "")]
			set {
				const string __id = "setTimestamp.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeEventParams']/method[@name='getWeight' and count(parameter)=0]"
			[Register ("getWeight", "()F", "")]
			get {
				const string __id = "getWeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeEventParams']/method[@name='setWeight' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWeight", "(F)V", "")]
			set {
				const string __id = "setWeight.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeEventParams']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject ToJSONObject ()
		{
			const string __id = "toJSONObject.()Lorg/json/JSONObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}
}
