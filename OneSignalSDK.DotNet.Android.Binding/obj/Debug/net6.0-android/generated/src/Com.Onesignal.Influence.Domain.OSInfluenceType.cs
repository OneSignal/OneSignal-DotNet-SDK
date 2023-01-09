using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Influence.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']"
	[global::Android.Runtime.Register ("com/onesignal/influence/domain/OSInfluenceType", DoNotGenerateAcw=true)]
	public sealed partial class OSInfluenceType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/field[@name='DIRECT']"
		[Register ("DIRECT")]
		public static global::Com.Onesignal.Influence.Domain.OSInfluenceType? Direct {
			get {
				const string __id = "DIRECT.Lcom/onesignal/influence/domain/OSInfluenceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/field[@name='DISABLED']"
		[Register ("DISABLED")]
		public static global::Com.Onesignal.Influence.Domain.OSInfluenceType? Disabled {
			get {
				const string __id = "DISABLED.Lcom/onesignal/influence/domain/OSInfluenceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/field[@name='INDIRECT']"
		[Register ("INDIRECT")]
		public static global::Com.Onesignal.Influence.Domain.OSInfluenceType? Indirect {
			get {
				const string __id = "INDIRECT.Lcom/onesignal/influence/domain/OSInfluenceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/field[@name='UNATTRIBUTED']"
		[Register ("UNATTRIBUTED")]
		public static global::Com.Onesignal.Influence.Domain.OSInfluenceType? Unattributed {
			get {
				const string __id = "UNATTRIBUTED.Lcom/onesignal/influence/domain/OSInfluenceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType.Companion']"
		[global::Android.Runtime.Register ("com/onesignal/influence/domain/OSInfluenceType$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/influence/domain/OSInfluenceType$Companion", typeof (Companion));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType.Companion']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromString", "(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceType;", "")]
			public unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceType FromString (string? value)
			{
				const string __id = "fromString.(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceType;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/influence/domain/OSInfluenceType", typeof (OSInfluenceType));

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

		internal OSInfluenceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe bool IsAttributed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/method[@name='isAttributed' and count(parameter)=0]"
			[Register ("isAttributed", "()Z", "")]
			get {
				const string __id = "isAttributed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsDirect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/method[@name='isDirect' and count(parameter)=0]"
			[Register ("isDirect", "()Z", "")]
			get {
				const string __id = "isDirect.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsDisabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/method[@name='isDisabled' and count(parameter)=0]"
			[Register ("isDisabled", "()Z", "")]
			get {
				const string __id = "isDisabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsIndirect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/method[@name='isIndirect' and count(parameter)=0]"
			[Register ("isIndirect", "()Z", "")]
			get {
				const string __id = "isIndirect.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsUnattributed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/method[@name='isUnattributed' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceType;", "")]
		public static unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceType FromString (string? value)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceType;";
			IntPtr native_value = JNIEnv.NewString ((string?)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceType;", "")]
		public static unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceType? ValueOf (string? p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/onesignal/influence/domain/OSInfluenceType;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Domain.OSInfluenceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.domain']/class[@name='OSInfluenceType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/onesignal/influence/domain/OSInfluenceType;", "")]
		public static unsafe global::Com.Onesignal.Influence.Domain.OSInfluenceType[]? Values ()
		{
			const string __id = "values.()[Lcom/onesignal/influence/domain/OSInfluenceType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Onesignal.Influence.Domain.OSInfluenceType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Onesignal.Influence.Domain.OSInfluenceType));
			} finally {
			}
		}

	}
}
