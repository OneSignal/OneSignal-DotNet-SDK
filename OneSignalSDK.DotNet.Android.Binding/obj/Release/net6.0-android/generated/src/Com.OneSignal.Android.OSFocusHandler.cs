using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler']"
	[global::Android.Runtime.Register ("com/onesignal/OSFocusHandler", DoNotGenerateAcw=true)]
	public sealed partial class OSFocusHandler : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler.Companion']"
		[global::Android.Runtime.Register ("com/onesignal/OSFocusHandler$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSFocusHandler$Companion", typeof (Companion));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler.Companion']/method[@name='onLostFocusDoWork' and count(parameter)=0]"
			[Register ("onLostFocusDoWork", "()V", "")]
			public unsafe void OnLostFocusDoWork ()
			{
				const string __id = "onLostFocusDoWork.()V";
				try {
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSFocusHandler", typeof (OSFocusHandler));

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

		internal OSFocusHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler']/constructor[@name='OSFocusHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSFocusHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public unsafe bool HasBackgrounded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler']/method[@name='hasBackgrounded' and count(parameter)=0]"
			[Register ("hasBackgrounded", "()Z", "")]
			get {
				const string __id = "hasBackgrounded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool HasCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler']/method[@name='hasCompleted' and count(parameter)=0]"
			[Register ("hasCompleted", "()Z", "")]
			get {
				const string __id = "hasCompleted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler']/method[@name='cancelOnLostFocusWorker' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("cancelOnLostFocusWorker", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe void CancelOnLostFocusWorker (string tag, global::Android.Content.Context context)
		{
			const string __id = "cancelOnLostFocusWorker.(Ljava/lang/String;Landroid/content/Context;)V";
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler']/method[@name='startOnFocusWork' and count(parameter)=0]"
		[Register ("startOnFocusWork", "()V", "")]
		public unsafe void StartOnFocusWork ()
		{
			const string __id = "startOnFocusWork.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler']/method[@name='startOnLostFocusWorker' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='android.content.Context']]"
		[Register ("startOnLostFocusWorker", "(Ljava/lang/String;JLandroid/content/Context;)V", "")]
		public unsafe void StartOnLostFocusWorker (string tag, long delay, global::Android.Content.Context context)
		{
			const string __id = "startOnLostFocusWorker.(Ljava/lang/String;JLandroid/content/Context;)V";
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (delay);
				__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler']/method[@name='startOnStartFocusWork' and count(parameter)=0]"
		[Register ("startOnStartFocusWork", "()V", "")]
		public unsafe void StartOnStartFocusWork ()
		{
			const string __id = "startOnStartFocusWork.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSFocusHandler']/method[@name='startOnStopFocusWork' and count(parameter)=0]"
		[Register ("startOnStopFocusWork", "()V", "")]
		public unsafe void StartOnStopFocusWork ()
		{
			const string __id = "startOnStopFocusWork.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
