using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Shortcutbadger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal.shortcutbadger']/interface[@name='Badger']"
	[Register ("com/onesignal/shortcutbadger/Badger", "", "Com.Onesignal.Shortcutbadger.IBadgerInvoker")]
	public partial interface IBadger : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IList<string>? SupportLaunchers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger']/interface[@name='Badger']/method[@name='getSupportLaunchers' and count(parameter)=0]"
			[Register ("getSupportLaunchers", "()Ljava/util/List;", "GetGetSupportLaunchersHandler:Com.Onesignal.Shortcutbadger.IBadgerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger']/interface[@name='Badger']/method[@name='executeBadge' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.ComponentName'] and parameter[3][@type='int']]"
		[Register ("executeBadge", "(Landroid/content/Context;Landroid/content/ComponentName;I)V", "GetExecuteBadge_Landroid_content_Context_Landroid_content_ComponentName_IHandler:Com.Onesignal.Shortcutbadger.IBadgerInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void ExecuteBadge (global::Android.Content.Context? p0, global::Android.Content.ComponentName? p1, int p2);

	}

	[global::Android.Runtime.Register ("com/onesignal/shortcutbadger/Badger", DoNotGenerateAcw=true)]
	internal partial class IBadgerInvoker : global::Java.Lang.Object, IBadger {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/shortcutbadger/Badger", typeof (IBadgerInvoker));

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

		public static IBadger? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBadger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.shortcutbadger.Badger'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBadgerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getSupportLaunchers;
#pragma warning disable 0169
		static Delegate GetGetSupportLaunchersHandler ()
		{
			if (cb_getSupportLaunchers == null)
				cb_getSupportLaunchers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportLaunchers);
			return cb_getSupportLaunchers;
		}

		static IntPtr n_GetSupportLaunchers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Shortcutbadger.IBadger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.SupportLaunchers);
		}
#pragma warning restore 0169

		IntPtr id_getSupportLaunchers;
		public unsafe global::System.Collections.Generic.IList<string>? SupportLaunchers {
			get {
				if (id_getSupportLaunchers == IntPtr.Zero)
					id_getSupportLaunchers = JNIEnv.GetMethodID (class_ref, "getSupportLaunchers", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportLaunchers), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_executeBadge_Landroid_content_Context_Landroid_content_ComponentName_I;
#pragma warning disable 0169
		static Delegate GetExecuteBadge_Landroid_content_Context_Landroid_content_ComponentName_IHandler ()
		{
			if (cb_executeBadge_Landroid_content_Context_Landroid_content_ComponentName_I == null)
				cb_executeBadge_Landroid_content_Context_Landroid_content_ComponentName_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_ExecuteBadge_Landroid_content_Context_Landroid_content_ComponentName_I);
			return cb_executeBadge_Landroid_content_Context_Landroid_content_ComponentName_I;
		}

		static void n_ExecuteBadge_Landroid_content_Context_Landroid_content_ComponentName_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Shortcutbadger.IBadger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteBadge (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_executeBadge_Landroid_content_Context_Landroid_content_ComponentName_I;
		public unsafe void ExecuteBadge (global::Android.Content.Context? p0, global::Android.Content.ComponentName? p1, int p2)
		{
			if (id_executeBadge_Landroid_content_Context_Landroid_content_ComponentName_I == IntPtr.Zero)
				id_executeBadge_Landroid_content_Context_Landroid_content_ComponentName_I = JNIEnv.GetMethodID (class_ref, "executeBadge", "(Landroid/content/Context;Landroid/content/ComponentName;I)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_executeBadge_Landroid_content_Context_Landroid_content_ComponentName_I, __args);
		}

	}
}
