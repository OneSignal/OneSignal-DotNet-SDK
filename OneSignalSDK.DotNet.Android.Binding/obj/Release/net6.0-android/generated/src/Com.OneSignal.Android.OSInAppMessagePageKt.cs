using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessagePageKt']"
	[global::Android.Runtime.Register ("com/onesignal/OSInAppMessagePageKt", DoNotGenerateAcw=true)]
	public sealed partial class OSInAppMessagePageKt : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessagePageKt']/field[@name='PAGE_ID']"
		[Register ("PAGE_ID")]
		public const string PageId = (string) "pageId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessagePageKt']/field[@name='PAGE_INDEX']"
		[Register ("PAGE_INDEX")]
		public const string PageIndex = (string) "pageIndex";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSInAppMessagePageKt", typeof (OSInAppMessagePageKt));

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

		internal OSInAppMessagePageKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
