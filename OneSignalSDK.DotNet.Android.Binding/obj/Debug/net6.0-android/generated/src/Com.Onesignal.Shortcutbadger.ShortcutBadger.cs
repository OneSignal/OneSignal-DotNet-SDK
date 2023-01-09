using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Shortcutbadger {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.shortcutbadger']/class[@name='ShortcutBadger']"
	[global::Android.Runtime.Register ("com/onesignal/shortcutbadger/ShortcutBadger", DoNotGenerateAcw=true)]
	public sealed partial class ShortcutBadger : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/shortcutbadger/ShortcutBadger", typeof (ShortcutBadger));

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

		internal ShortcutBadger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger']/class[@name='ShortcutBadger']/method[@name='applyCount' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("applyCount", "(Landroid/content/Context;I)Z", "")]
		public static unsafe bool ApplyCount (global::Android.Content.Context? context, int badgeCount)
		{
			const string __id = "applyCount.(Landroid/content/Context;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (badgeCount);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger']/class[@name='ShortcutBadger']/method[@name='applyCountOrThrow' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("applyCountOrThrow", "(Landroid/content/Context;I)V", "")]
		public static unsafe void ApplyCountOrThrow (global::Android.Content.Context? context, int badgeCount)
		{
			const string __id = "applyCountOrThrow.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (badgeCount);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger']/class[@name='ShortcutBadger']/method[@name='applyNotification' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.app.Notification'] and parameter[3][@type='int']]"
		[Register ("applyNotification", "(Landroid/content/Context;Landroid/app/Notification;I)V", "")]
		public static unsafe void ApplyNotification (global::Android.Content.Context? context, global::Android.App.Notification? notification, int badgeCount)
		{
			const string __id = "applyNotification.(Landroid/content/Context;Landroid/app/Notification;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((notification == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notification).Handle);
				__args [2] = new JniArgumentValue (badgeCount);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (notification);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger']/class[@name='ShortcutBadger']/method[@name='isBadgeCounterSupported' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isBadgeCounterSupported", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsBadgeCounterSupported (global::Android.Content.Context? context)
		{
			const string __id = "isBadgeCounterSupported.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger']/class[@name='ShortcutBadger']/method[@name='removeCount' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("removeCount", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool RemoveCount (global::Android.Content.Context? context)
		{
			const string __id = "removeCount.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger']/class[@name='ShortcutBadger']/method[@name='removeCountOrThrow' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("removeCountOrThrow", "(Landroid/content/Context;)V", "")]
		public static unsafe void RemoveCountOrThrow (global::Android.Content.Context? context)
		{
			const string __id = "removeCountOrThrow.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
