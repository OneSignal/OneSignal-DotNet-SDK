using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Outcomes.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSource']"
	[global::Android.Runtime.Register ("com/onesignal/outcomes/domain/OSOutcomeSource", DoNotGenerateAcw=true)]
	public sealed partial class OSOutcomeSource : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/outcomes/domain/OSOutcomeSource", typeof (OSOutcomeSource));

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

		internal OSOutcomeSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSource']/constructor[@name='OSOutcomeSource' and count(parameter)=2 and parameter[1][@type='com.onesignal.outcomes.domain.OSOutcomeSourceBody'] and parameter[2][@type='com.onesignal.outcomes.domain.OSOutcomeSourceBody']]"
		[Register (".ctor", "(Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;)V", "")]
		public unsafe OSOutcomeSource (global::Com.Onesignal.Outcomes.Domain.OSOutcomeSourceBody? directBody, global::Com.Onesignal.Outcomes.Domain.OSOutcomeSourceBody? indirectBody) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((directBody == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directBody).Handle);
				__args [1] = new JniArgumentValue ((indirectBody == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indirectBody).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (directBody);
				global::System.GC.KeepAlive (indirectBody);
			}
		}

		public unsafe global::Com.Onesignal.Outcomes.Domain.OSOutcomeSourceBody? DirectBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSource']/method[@name='getDirectBody' and count(parameter)=0]"
			[Register ("getDirectBody", "()Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;", "")]
			get {
				const string __id = "getDirectBody.()Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.OSOutcomeSourceBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSource']/method[@name='setDirectBody' and count(parameter)=1 and parameter[1][@type='com.onesignal.outcomes.domain.OSOutcomeSourceBody']]"
			[Register ("setDirectBody", "(Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;)V", "")]
			set {
				const string __id = "setDirectBody.(Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Com.Onesignal.Outcomes.Domain.OSOutcomeSourceBody? IndirectBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSource']/method[@name='getIndirectBody' and count(parameter)=0]"
			[Register ("getIndirectBody", "()Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;", "")]
			get {
				const string __id = "getIndirectBody.()Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.OSOutcomeSourceBody> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSource']/method[@name='setIndirectBody' and count(parameter)=1 and parameter[1][@type='com.onesignal.outcomes.domain.OSOutcomeSourceBody']]"
			[Register ("setIndirectBody", "(Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;)V", "")]
			set {
				const string __id = "setIndirectBody.(Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSource']/method[@name='setDirectBody' and count(parameter)=1 and parameter[1][@type='com.onesignal.outcomes.domain.OSOutcomeSourceBody']]"
		[Register ("setDirectBody", "(Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;)Lcom/onesignal/outcomes/domain/OSOutcomeSource;", "")]
		public unsafe global::Com.Onesignal.Outcomes.Domain.OSOutcomeSource SetDirectBody (global::Com.Onesignal.Outcomes.Domain.OSOutcomeSourceBody? directBody)
		{
			const string __id = "setDirectBody.(Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;)Lcom/onesignal/outcomes/domain/OSOutcomeSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((directBody == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directBody).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.OSOutcomeSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (directBody);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSource']/method[@name='setIndirectBody' and count(parameter)=1 and parameter[1][@type='com.onesignal.outcomes.domain.OSOutcomeSourceBody']]"
		[Register ("setIndirectBody", "(Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;)Lcom/onesignal/outcomes/domain/OSOutcomeSource;", "")]
		public unsafe global::Com.Onesignal.Outcomes.Domain.OSOutcomeSource SetIndirectBody (global::Com.Onesignal.Outcomes.Domain.OSOutcomeSourceBody? indirectBody)
		{
			const string __id = "setIndirectBody.(Lcom/onesignal/outcomes/domain/OSOutcomeSourceBody;)Lcom/onesignal/outcomes/domain/OSOutcomeSource;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((indirectBody == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indirectBody).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Domain.OSOutcomeSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (indirectBody);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.domain']/class[@name='OSOutcomeSource']/method[@name='toJSONObject' and count(parameter)=0]"
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
