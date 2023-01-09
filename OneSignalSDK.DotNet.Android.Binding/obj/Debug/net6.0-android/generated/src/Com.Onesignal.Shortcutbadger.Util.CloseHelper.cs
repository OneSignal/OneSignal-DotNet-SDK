using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Shortcutbadger.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.shortcutbadger.util']/class[@name='CloseHelper']"
	[global::Android.Runtime.Register ("com/onesignal/shortcutbadger/util/CloseHelper", DoNotGenerateAcw=true)]
	public partial class CloseHelper : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/shortcutbadger/util/CloseHelper", typeof (CloseHelper));

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

		protected CloseHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.shortcutbadger.util']/class[@name='CloseHelper']/constructor[@name='CloseHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CloseHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger.util']/class[@name='CloseHelper']/method[@name='close' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("close", "(Landroid/database/Cursor;)V", "")]
		public static unsafe void Close (global::Android.Database.ICursor? cursor)
		{
			const string __id = "close.(Landroid/database/Cursor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cursor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cursor).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (cursor);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.shortcutbadger.util']/class[@name='CloseHelper']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseQuietly (global::Java.IO.ICloseable? closeable)
		{
			const string __id = "closeQuietly.(Ljava/io/Closeable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((closeable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) closeable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (closeable);
			}
		}

	}
}
