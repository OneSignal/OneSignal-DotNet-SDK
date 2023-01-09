using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Shortcutbadger.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.shortcutbadger.impl']/class[@name='NovaHomeBadger']"
	[global::Android.Runtime.Register ("com/onesignal/shortcutbadger/impl/NovaHomeBadger", DoNotGenerateAcw=true)]
	public partial class NovaHomeBadger : global::Java.Lang.Object, global::Com.Onesignal.Shortcutbadger.IBadger {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/shortcutbadger/impl/NovaHomeBadger", typeof (NovaHomeBadger));

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

		protected NovaHomeBadger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.shortcutbadger.impl']/class[@name='NovaHomeBadger']/constructor[@name='NovaHomeBadger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NovaHomeBadger () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Shortcutbadger.Impl.NovaHomeBadger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.SupportLaunchers);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string>? SupportLaunchers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger.impl']/class[@name='NovaHomeBadger']/method[@name='getSupportLaunchers' and count(parameter)=0]"
			[Register ("getSupportLaunchers", "()Ljava/util/List;", "GetGetSupportLaunchersHandler")]
			get {
				const string __id = "getSupportLaunchers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static void n_ExecuteBadge_Landroid_content_Context_Landroid_content_ComponentName_I (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_componentName, int badgeCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Shortcutbadger.Impl.NovaHomeBadger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var componentName = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_componentName, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteBadge (context, componentName, badgeCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger.impl']/class[@name='NovaHomeBadger']/method[@name='executeBadge' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.ComponentName'] and parameter[3][@type='int']]"
		[Register ("executeBadge", "(Landroid/content/Context;Landroid/content/ComponentName;I)V", "GetExecuteBadge_Landroid_content_Context_Landroid_content_ComponentName_IHandler")]
		public virtual unsafe void ExecuteBadge (global::Android.Content.Context? context, global::Android.Content.ComponentName? componentName, int badgeCount)
		{
			const string __id = "executeBadge.(Landroid/content/Context;Landroid/content/ComponentName;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((componentName == null) ? IntPtr.Zero : ((global::Java.Lang.Object) componentName).Handle);
				__args [2] = new JniArgumentValue (badgeCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (componentName);
			}
		}

	}
}
