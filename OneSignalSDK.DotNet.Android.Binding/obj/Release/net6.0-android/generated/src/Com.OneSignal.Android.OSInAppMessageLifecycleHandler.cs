using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageLifecycleHandler']"
	[global::Android.Runtime.Register ("com/onesignal/OSInAppMessageLifecycleHandler", DoNotGenerateAcw=true)]
	public abstract partial class OSInAppMessageLifecycleHandler : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSInAppMessageLifecycleHandler", typeof (OSInAppMessageLifecycleHandler));

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

		protected OSInAppMessageLifecycleHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageLifecycleHandler']/constructor[@name='OSInAppMessageLifecycleHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSInAppMessageLifecycleHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_onDidDismissInAppMessage_Lcom_onesignal_OSInAppMessage_;
#pragma warning disable 0169
		static Delegate GetOnDidDismissInAppMessage_Lcom_onesignal_OSInAppMessage_Handler ()
		{
			if (cb_onDidDismissInAppMessage_Lcom_onesignal_OSInAppMessage_ == null)
				cb_onDidDismissInAppMessage_Lcom_onesignal_OSInAppMessage_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDidDismissInAppMessage_Lcom_onesignal_OSInAppMessage_);
			return cb_onDidDismissInAppMessage_Lcom_onesignal_OSInAppMessage_;
		}

		static void n_OnDidDismissInAppMessage_Lcom_onesignal_OSInAppMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageLifecycleHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.OnDidDismissInAppMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageLifecycleHandler']/method[@name='onDidDismissInAppMessage' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSInAppMessage']]"
		[Register ("onDidDismissInAppMessage", "(Lcom/onesignal/OSInAppMessage;)V", "GetOnDidDismissInAppMessage_Lcom_onesignal_OSInAppMessage_Handler")]
		public virtual unsafe void OnDidDismissInAppMessage (global::Com.OneSignal.Android.OSInAppMessage? message)
		{
			const string __id = "onDidDismissInAppMessage.(Lcom/onesignal/OSInAppMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (message);
			}
		}

		static Delegate? cb_onDidDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_;
#pragma warning disable 0169
		static Delegate GetOnDidDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_Handler ()
		{
			if (cb_onDidDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_ == null)
				cb_onDidDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDidDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_);
			return cb_onDidDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_;
		}

		static void n_OnDidDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageLifecycleHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.OnDidDisplayInAppMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageLifecycleHandler']/method[@name='onDidDisplayInAppMessage' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSInAppMessage']]"
		[Register ("onDidDisplayInAppMessage", "(Lcom/onesignal/OSInAppMessage;)V", "GetOnDidDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_Handler")]
		public virtual unsafe void OnDidDisplayInAppMessage (global::Com.OneSignal.Android.OSInAppMessage? message)
		{
			const string __id = "onDidDisplayInAppMessage.(Lcom/onesignal/OSInAppMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (message);
			}
		}

		static Delegate? cb_onWillDismissInAppMessage_Lcom_onesignal_OSInAppMessage_;
#pragma warning disable 0169
		static Delegate GetOnWillDismissInAppMessage_Lcom_onesignal_OSInAppMessage_Handler ()
		{
			if (cb_onWillDismissInAppMessage_Lcom_onesignal_OSInAppMessage_ == null)
				cb_onWillDismissInAppMessage_Lcom_onesignal_OSInAppMessage_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnWillDismissInAppMessage_Lcom_onesignal_OSInAppMessage_);
			return cb_onWillDismissInAppMessage_Lcom_onesignal_OSInAppMessage_;
		}

		static void n_OnWillDismissInAppMessage_Lcom_onesignal_OSInAppMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageLifecycleHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.OnWillDismissInAppMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageLifecycleHandler']/method[@name='onWillDismissInAppMessage' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSInAppMessage']]"
		[Register ("onWillDismissInAppMessage", "(Lcom/onesignal/OSInAppMessage;)V", "GetOnWillDismissInAppMessage_Lcom_onesignal_OSInAppMessage_Handler")]
		public virtual unsafe void OnWillDismissInAppMessage (global::Com.OneSignal.Android.OSInAppMessage? message)
		{
			const string __id = "onWillDismissInAppMessage.(Lcom/onesignal/OSInAppMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (message);
			}
		}

		static Delegate? cb_onWillDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_;
#pragma warning disable 0169
		static Delegate GetOnWillDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_Handler ()
		{
			if (cb_onWillDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_ == null)
				cb_onWillDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnWillDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_);
			return cb_onWillDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_;
		}

		static void n_OnWillDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageLifecycleHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var message = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.OnWillDisplayInAppMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageLifecycleHandler']/method[@name='onWillDisplayInAppMessage' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSInAppMessage']]"
		[Register ("onWillDisplayInAppMessage", "(Lcom/onesignal/OSInAppMessage;)V", "GetOnWillDisplayInAppMessage_Lcom_onesignal_OSInAppMessage_Handler")]
		public virtual unsafe void OnWillDisplayInAppMessage (global::Com.OneSignal.Android.OSInAppMessage? message)
		{
			const string __id = "onWillDisplayInAppMessage.(Lcom/onesignal/OSInAppMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (message);
			}
		}

	}

	[global::Android.Runtime.Register ("com/onesignal/OSInAppMessageLifecycleHandler", DoNotGenerateAcw=true)]
	internal partial class OSInAppMessageLifecycleHandlerInvoker : OSInAppMessageLifecycleHandler {
		public OSInAppMessageLifecycleHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSInAppMessageLifecycleHandler", typeof (OSInAppMessageLifecycleHandlerInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
