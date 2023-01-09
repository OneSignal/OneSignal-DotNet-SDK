using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationPermissionController']"
	[global::Android.Runtime.Register ("com/onesignal/NotificationPermissionController", DoNotGenerateAcw=true)]
	public sealed partial class NotificationPermissionController : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationPermissionController']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.OneSignal.Android.NotificationPermissionController Instance {
			get {
				const string __id = "INSTANCE.Lcom/onesignal/NotificationPermissionController;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.NotificationPermissionController> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/NotificationPermissionController", typeof (NotificationPermissionController));

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

		internal NotificationPermissionController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe bool SupportsNativePrompt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationPermissionController']/method[@name='getSupportsNativePrompt' and count(parameter)=0]"
			[Register ("getSupportsNativePrompt", "()Z", "")]
			get {
				const string __id = "getSupportsNativePrompt.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationPermissionController']/method[@name='onAccept' and count(parameter)=0]"
		[Register ("onAccept", "()V", "")]
		public unsafe void OnAccept ()
		{
			const string __id = "onAccept.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationPermissionController']/method[@name='onAppForegrounded' and count(parameter)=0]"
		[Register ("onAppForegrounded", "()V", "")]
		public unsafe void OnAppForegrounded ()
		{
			const string __id = "onAppForegrounded.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationPermissionController']/method[@name='onReject' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onReject", "(Z)V", "")]
		public unsafe void OnReject (bool fallbackToSettings)
		{
			const string __id = "onReject.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fallbackToSettings);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationPermissionController']/method[@name='prompt' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.onesignal.OneSignal.PromptForPushNotificationPermissionResponseHandler']]"
		[Register ("prompt", "(ZLcom/onesignal/OneSignal$PromptForPushNotificationPermissionResponseHandler;)V", "")]
		public unsafe void Prompt (bool fallbackToSettings, global::Com.OneSignal.Android.OneSignal.IPromptForPushNotificationPermissionResponseHandler? @callback)
		{
			const string __id = "prompt.(ZLcom/onesignal/OneSignal$PromptForPushNotificationPermissionResponseHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fallbackToSettings);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
