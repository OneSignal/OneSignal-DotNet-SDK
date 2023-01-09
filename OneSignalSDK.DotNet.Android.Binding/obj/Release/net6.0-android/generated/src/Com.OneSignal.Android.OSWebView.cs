using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSWebView']"
	[global::Android.Runtime.Register ("com/onesignal/OSWebView", DoNotGenerateAcw=true)]
	public partial class OSWebView : global::Android.Webkit.WebView {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSWebView", typeof (OSWebView));

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

		protected OSWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSWebView']/constructor[@name='OSWebView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe OSWebView (global::Android.Content.Context? context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate? cb_overScrollBy_IIIIIIIIZ;
#pragma warning disable 0169
		static Delegate GetOverScrollBy_IIIIIIIIZHandler ()
		{
			if (cb_overScrollBy_IIIIIIIIZ == null)
				cb_overScrollBy_IIIIIIIIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIIIIIIZ_Z) n_OverScrollBy_IIIIIIIIZ);
			return cb_overScrollBy_IIIIIIIIZ;
		}

		static bool n_OverScrollBy_IIIIIIIIZ (IntPtr jnienv, IntPtr native__this, int deltaX, int deltaY, int scrollX, int scrollY, int scrollRangeX, int scrollRangeY, int maxOverScrollX, int maxOverScrollY, bool isTouchEvent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.OverScrollBy (deltaX, deltaY, scrollX, scrollY, scrollRangeX, scrollRangeY, maxOverScrollX, maxOverScrollY, isTouchEvent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSWebView']/method[@name='overScrollBy' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='boolean']]"
		[Register ("overScrollBy", "(IIIIIIIIZ)Z", "GetOverScrollBy_IIIIIIIIZHandler")]
		public virtual unsafe bool OverScrollBy (int deltaX, int deltaY, int scrollX, int scrollY, int scrollRangeX, int scrollRangeY, int maxOverScrollX, int maxOverScrollY, bool isTouchEvent)
		{
			const string __id = "overScrollBy.(IIIIIIIIZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (deltaX);
				__args [1] = new JniArgumentValue (deltaY);
				__args [2] = new JniArgumentValue (scrollX);
				__args [3] = new JniArgumentValue (scrollY);
				__args [4] = new JniArgumentValue (scrollRangeX);
				__args [5] = new JniArgumentValue (scrollRangeY);
				__args [6] = new JniArgumentValue (maxOverScrollX);
				__args [7] = new JniArgumentValue (maxOverScrollY);
				__args [8] = new JniArgumentValue (isTouchEvent);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
