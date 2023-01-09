using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Influence.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']"
	[global::Android.Runtime.Register ("com/onesignal/influence/domain/OSInfluence", DoNotGenerateAcw=true)]
	public sealed partial class OSInfluence : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/influence/domain/OSInfluence", typeof (OSInfluence));

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

		internal OSInfluence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']/constructor[@name='OSInfluence' and count(parameter)=3 and parameter[1][@type='com.onesignal.influence.domain.OSInfluenceChannel'] and parameter[2][@type='com.onesignal.influence.domain.OSInfluenceType'] and parameter[3][@type='org.json.JSONArray']]"
		[Register (".ctor", "(Lcom/onesignal/influence/domain/OSInfluenceChannel;Lcom/onesignal/influence/domain/OSInfluenceType;Lorg/json/JSONArray;)V", "")]
		public unsafe OSInfluence (global::Com.Onesignal.Influence.Domain.OSInfluenceChannel influenceChannel, global::Com.Onesignal.Influence.Domain.OSInfluenceType influenceType, global::Org.Json.JSONArray? ids) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/influence/domain/OSInfluenceChannel;Lcom/onesignal/influence/domain/OSInfluenceType;Lorg/json/JSONArray;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((influenceChannel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) influenceChannel).Handle);
				__args [1] = new JniArgumentValue ((influenceType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) influenceType).Handle);
				__args [2] = new JniArgumentValue ((ids == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ids).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (influenceChannel);
				global::System.GC.KeepAlive (influenceType);
				global::System.GC.KeepAlive (ids);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']/constructor[@name='OSInfluence' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe OSInfluence (string jsonString) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_jsonString = JNIEnv.NewString ((string?)jsonString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonString);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonString);
			}
		}

		public unsafe string? DirectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']/method[@name='getDirectId' and count(parameter)=0]"
			[Register ("getDirectId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDirectId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Org.Json.JSONArray? Ids {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']/method[@name='getIds' and count(parameter)=0]"
			[Register ("getIds", "()Lorg/json/JSONArray;", "")]
			get {
				const string __id = "getIds.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']/method[@name='setIds' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
			[Register ("setIds", "(Lorg/json/JSONArray;)V", "")]
			set {
				const string __id = "setIds.(Lorg/json/JSONArray;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceChannel InfluenceChannel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']/method[@name='getInfluenceChannel' and count(parameter)=0]"
			[Register ("getInfluenceChannel", "()Lcom/onesignal/influence/domain/OSInfluenceChannel;", "")]
			get {
				const string __id = "getInfluenceChannel.()Lcom/onesignal/influence/domain/OSInfluenceChannel;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceType InfluenceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']/method[@name='getInfluenceType' and count(parameter)=0]"
			[Register ("getInfluenceType", "()Lcom/onesignal/influence/domain/OSInfluenceType;", "")]
			get {
				const string __id = "getInfluenceType.()Lcom/onesignal/influence/domain/OSInfluenceType;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']/method[@name='setInfluenceType' and count(parameter)=1 and parameter[1][@type='com.onesignal.influence.domain.OSInfluenceType']]"
			[Register ("setInfluenceType", "(Lcom/onesignal/influence/domain/OSInfluenceType;)V", "")]
			set {
				const string __id = "setInfluenceType.(Lcom/onesignal/influence/domain/OSInfluenceType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/onesignal/influence/domain/OSInfluence;", "")]
		public unsafe global::Com.Onesignal.Influence.Domain.OSInfluence Copy ()
		{
			const string __id = "copy.()Lcom/onesignal/influence/domain/OSInfluence;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluence> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluence']/method[@name='toJSONString' and count(parameter)=0]"
		[Register ("toJSONString", "()Ljava/lang/String;", "")]
		public unsafe string ToJSONString ()
		{
			const string __id = "toJSONString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}
}
