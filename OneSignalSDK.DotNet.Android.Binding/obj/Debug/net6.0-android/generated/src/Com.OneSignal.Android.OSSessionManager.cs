using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSSessionManager']"
	[global::Android.Runtime.Register ("com/onesignal/OSSessionManager", DoNotGenerateAcw=true)]
	public partial class OSSessionManager : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSSessionManager']/field[@name='trackerFactory']"
		[Register ("trackerFactory")]
		protected global::Com.Onesignal.Influence.Data.OSTrackerFactory? TrackerFactory {
			get {
				const string __id = "trackerFactory.Lcom/onesignal/influence/data/OSTrackerFactory;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSTrackerFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "trackerFactory.Lcom/onesignal/influence/data/OSTrackerFactory;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSessionManager.SessionListener']"
		[Register ("com/onesignal/OSSessionManager$SessionListener", "", "Com.OneSignal.Android.OSSessionManager/ISessionListenerInvoker")]
		public partial interface ISessionListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OSSessionManager.SessionListener']/method[@name='onSessionEnding' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.onesignal.influence.domain.OSInfluence&gt;']]"
			[Register ("onSessionEnding", "(Ljava/util/List;)V", "GetOnSessionEnding_Ljava_util_List_Handler:Com.OneSignal.Android.OSSessionManager/ISessionListenerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnSessionEnding (global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OSSessionManager$SessionListener", DoNotGenerateAcw=true)]
		internal partial class ISessionListenerInvoker : global::Java.Lang.Object, ISessionListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSSessionManager$SessionListener", typeof (ISessionListenerInvoker));

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

			public static ISessionListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISessionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OSSessionManager.SessionListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISessionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onSessionEnding_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetOnSessionEnding_Ljava_util_List_Handler ()
			{
				if (cb_onSessionEnding_Ljava_util_List_ == null)
					cb_onSessionEnding_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSessionEnding_Ljava_util_List_);
				return cb_onSessionEnding_Ljava_util_List_;
			}

			static void n_OnSessionEnding_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSSessionManager.ISessionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Domain.OSInfluence>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSessionEnding (p0!);
			}
#pragma warning restore 0169

			IntPtr id_onSessionEnding_Ljava_util_List_;
			public unsafe void OnSessionEnding (global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> p0)
			{
				if (id_onSessionEnding_Ljava_util_List_ == IntPtr.Zero)
					id_onSessionEnding_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onSessionEnding", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Domain.OSInfluence>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSessionEnding_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for com.onesignal.OSSessionManager.SessionListener.onSessionEnding
		public partial class SessionEventArgs : global::System.EventArgs {
			public SessionEventArgs (global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> p0)
			{
				this.p0 = p0;
			}

			global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> p0;

			public global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> P0 {
				get { return p0; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/onesignal/OSSessionManager_SessionListenerImplementor")]
		internal sealed partial class ISessionListenerImplementor : global::Java.Lang.Object, ISessionListener {

			object sender;

			public ISessionListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/onesignal/OSSessionManager_SessionListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<SessionEventArgs>? Handler;
			#pragma warning restore 0649

			public void OnSessionEnding (global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SessionEventArgs (p0));
			}

			internal static bool __IsEmpty (ISessionListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSSessionManager", typeof (OSSessionManager));

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

		protected OSSessionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSSessionManager']/constructor[@name='OSSessionManager' and count(parameter)=3 and parameter[1][@type='com.onesignal.OSSessionManager.SessionListener'] and parameter[2][@type='com.onesignal.influence.data.OSTrackerFactory'] and parameter[3][@type='com.onesignal.OSLogger']]"
		[Register (".ctor", "(Lcom/onesignal/OSSessionManager$SessionListener;Lcom/onesignal/influence/data/OSTrackerFactory;Lcom/onesignal/OSLogger;)V", "")]
		public unsafe OSSessionManager (global::Com.OneSignal.Android.OSSessionManager.ISessionListener sessionListener, global::Com.Onesignal.Influence.Data.OSTrackerFactory? trackerFactory, global::Com.OneSignal.Android.IOSLogger? logger) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/OSSessionManager$SessionListener;Lcom/onesignal/influence/data/OSTrackerFactory;Lcom/onesignal/OSLogger;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((sessionListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sessionListener).Handle);
				__args [1] = new JniArgumentValue ((trackerFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackerFactory).Handle);
				__args [2] = new JniArgumentValue ((logger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logger).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sessionListener);
				global::System.GC.KeepAlive (trackerFactory);
				global::System.GC.KeepAlive (logger);
			}
		}

	}
}
