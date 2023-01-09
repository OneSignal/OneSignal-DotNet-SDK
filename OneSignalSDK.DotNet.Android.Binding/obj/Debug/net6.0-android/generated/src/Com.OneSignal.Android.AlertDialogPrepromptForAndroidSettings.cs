using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='AlertDialogPrepromptForAndroidSettings']"
	[global::Android.Runtime.Register ("com/onesignal/AlertDialogPrepromptForAndroidSettings", DoNotGenerateAcw=true)]
	public sealed partial class AlertDialogPrepromptForAndroidSettings : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='AlertDialogPrepromptForAndroidSettings']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.OneSignal.Android.AlertDialogPrepromptForAndroidSettings Instance {
			get {
				const string __id = "INSTANCE.Lcom/onesignal/AlertDialogPrepromptForAndroidSettings;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.AlertDialogPrepromptForAndroidSettings> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='AlertDialogPrepromptForAndroidSettings.Callback']"
		[Register ("com/onesignal/AlertDialogPrepromptForAndroidSettings$Callback", "", "Com.OneSignal.Android.AlertDialogPrepromptForAndroidSettings/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='AlertDialogPrepromptForAndroidSettings.Callback']/method[@name='onAccept' and count(parameter)=0]"
			[Register ("onAccept", "()V", "GetOnAcceptHandler:Com.OneSignal.Android.AlertDialogPrepromptForAndroidSettings/ICallbackInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnAccept ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='AlertDialogPrepromptForAndroidSettings.Callback']/method[@name='onDecline' and count(parameter)=0]"
			[Register ("onDecline", "()V", "GetOnDeclineHandler:Com.OneSignal.Android.AlertDialogPrepromptForAndroidSettings/ICallbackInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnDecline ();

		}

		[global::Android.Runtime.Register ("com/onesignal/AlertDialogPrepromptForAndroidSettings$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/AlertDialogPrepromptForAndroidSettings$Callback", typeof (ICallbackInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ICallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.AlertDialogPrepromptForAndroidSettings.Callback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onAccept;
#pragma warning disable 0169
			static Delegate GetOnAcceptHandler ()
			{
				if (cb_onAccept == null)
					cb_onAccept = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnAccept);
				return cb_onAccept;
			}

			static void n_OnAccept (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.AlertDialogPrepromptForAndroidSettings.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnAccept ();
			}
#pragma warning restore 0169

			IntPtr id_onAccept;
			public unsafe void OnAccept ()
			{
				if (id_onAccept == IntPtr.Zero)
					id_onAccept = JNIEnv.GetMethodID (class_ref, "onAccept", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccept);
			}

			static Delegate? cb_onDecline;
#pragma warning disable 0169
			static Delegate GetOnDeclineHandler ()
			{
				if (cb_onDecline == null)
					cb_onDecline = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDecline);
				return cb_onDecline;
			}

			static void n_OnDecline (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.AlertDialogPrepromptForAndroidSettings.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnDecline ();
			}
#pragma warning restore 0169

			IntPtr id_onDecline;
			public unsafe void OnDecline ()
			{
				if (id_onDecline == IntPtr.Zero)
					id_onDecline = JNIEnv.GetMethodID (class_ref, "onDecline", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDecline);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/AlertDialogPrepromptForAndroidSettings", typeof (AlertDialogPrepromptForAndroidSettings));

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

		internal AlertDialogPrepromptForAndroidSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='AlertDialogPrepromptForAndroidSettings']/method[@name='show' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.onesignal.AlertDialogPrepromptForAndroidSettings.Callback']]"
		[Register ("show", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Lcom/onesignal/AlertDialogPrepromptForAndroidSettings$Callback;)V", "")]
		public unsafe void Show (global::Android.App.Activity activity, string titlePrefix, string previouslyDeniedPostfix, global::Com.OneSignal.Android.AlertDialogPrepromptForAndroidSettings.ICallback @callback)
		{
			const string __id = "show.(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Lcom/onesignal/AlertDialogPrepromptForAndroidSettings$Callback;)V";
			IntPtr native_titlePrefix = JNIEnv.NewString ((string?)titlePrefix);
			IntPtr native_previouslyDeniedPostfix = JNIEnv.NewString ((string?)previouslyDeniedPostfix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (native_titlePrefix);
				__args [2] = new JniArgumentValue (native_previouslyDeniedPostfix);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_titlePrefix);
				JNIEnv.DeleteLocalRef (native_previouslyDeniedPostfix);
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
