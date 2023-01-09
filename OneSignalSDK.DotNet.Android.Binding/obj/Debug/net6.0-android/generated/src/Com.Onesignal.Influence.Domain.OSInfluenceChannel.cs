using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Influence.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceChannel']"
	[global::Android.Runtime.Register ("com/onesignal/influence/domain/OSInfluenceChannel", DoNotGenerateAcw=true)]
	public sealed partial class OSInfluenceChannel : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceChannel']/field[@name='IAM']"
		[Register ("IAM")]
		public static global::Com.Onesignal.Influence.Domain.OSInfluenceChannel? Iam {
			get {
				const string __id = "IAM.Lcom/onesignal/influence/domain/OSInfluenceChannel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceChannel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceChannel']/field[@name='NOTIFICATION']"
		[Register ("NOTIFICATION")]
		public static global::Com.Onesignal.Influence.Domain.OSInfluenceChannel? Notification {
			get {
				const string __id = "NOTIFICATION.Lcom/onesignal/influence/domain/OSInfluenceChannel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceChannel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceChannel.Companion']"
		[global::Android.Runtime.Register ("com/onesignal/influence/domain/OSInfluenceChannel$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/influence/domain/OSInfluenceChannel$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceChannel.Companion']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromString", "(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceChannel;", "")]
			public unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceChannel FromString (string? value)
			{
				const string __id = "fromString.(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceChannel;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/influence/domain/OSInfluenceChannel", typeof (OSInfluenceChannel));

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

		internal OSInfluenceChannel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceChannel']/method[@name='equalsName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("equalsName", "(Ljava/lang/String;)Z", "")]
		public unsafe bool EqualsName (string otherName)
		{
			const string __id = "equalsName.(Ljava/lang/String;)Z";
			IntPtr native_otherName = JNIEnv.NewString ((string?)otherName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_otherName);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_otherName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceChannel']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceChannel;", "")]
		public static unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceChannel FromString (string? value)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceChannel;";
			IntPtr native_value = JNIEnv.NewString ((string?)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceChannel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceChannel;", "")]
		public static unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceChannel? ValueOf (string? p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceChannel;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceChannel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/onesignal/influence/domain/OSInfluenceChannel;", "")]
		public static unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceChannel[]? Values ()
		{
			const string __id = "values.()[Lcom/onesignal/influence/domain/OSInfluenceChannel;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Onesignal.Influence.Domain.OSInfluenceChannel[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Onesignal.Influence.Domain.OSInfluenceChannel));
			} finally {
			}
		}

	}
}
