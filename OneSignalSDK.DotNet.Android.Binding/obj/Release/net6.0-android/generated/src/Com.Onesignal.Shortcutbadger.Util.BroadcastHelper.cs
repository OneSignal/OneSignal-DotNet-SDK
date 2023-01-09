using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Shortcutbadger.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.shortcutbadger.util']/class[@name='BroadcastHelper']"
	[global::Android.Runtime.Register ("com/onesignal/shortcutbadger/util/BroadcastHelper", DoNotGenerateAcw=true)]
	public partial class BroadcastHelper : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/shortcutbadger/util/BroadcastHelper", typeof (BroadcastHelper));

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

		protected BroadcastHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.shortcutbadger.util']/class[@name='BroadcastHelper']/constructor[@name='BroadcastHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BroadcastHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger.util']/class[@name='BroadcastHelper']/method[@name='canResolveBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("canResolveBroadcast", "(Landroid/content/Context;Landroid/content/Intent;)Z", "")]
		public static unsafe bool CanResolveBroadcast (global::Android.Content.Context? context, global::Android.Content.Intent? intent)
		{
			const string __id = "canResolveBroadcast.(Landroid/content/Context;Landroid/content/Intent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (intent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger.util']/class[@name='BroadcastHelper']/method[@name='resolveBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("resolveBroadcast", "(Landroid/content/Context;Landroid/content/Intent;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Content.PM.ResolveInfo>? ResolveBroadcast (global::Android.Content.Context? context, global::Android.Content.Intent? intent)
		{
			const string __id = "resolveBroadcast.(Landroid/content/Context;Landroid/content/Intent;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.Content.PM.ResolveInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (intent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger.util']/class[@name='BroadcastHelper']/method[@name='sendIntentExplicitly' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("sendIntentExplicitly", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void SendIntentExplicitly (global::Android.Content.Context? context, global::Android.Content.Intent? intent)
		{
			const string __id = "sendIntentExplicitly.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (intent);
			}
		}

	}
}
