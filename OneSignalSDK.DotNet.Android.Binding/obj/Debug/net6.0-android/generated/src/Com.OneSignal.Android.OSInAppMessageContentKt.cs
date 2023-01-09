using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageContentKt']"
	[global::Android.Runtime.Register ("com/onesignal/OSInAppMessageContentKt", DoNotGenerateAcw=true)]
	public sealed partial class OSInAppMessageContentKt : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageContentKt']/field[@name='DISPLAY_DURATION']"
		[Register ("DISPLAY_DURATION")]
		public const string DisplayDuration = (string) "display_duration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageContentKt']/field[@name='HTML']"
		[Register ("HTML")]
		public const string Html = (string) "html";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageContentKt']/field[@name='REMOVE_HEIGHT_MARGIN']"
		[Register ("REMOVE_HEIGHT_MARGIN")]
		public const string RemoveHeightMargin = (string) "remove_height_margin";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageContentKt']/field[@name='REMOVE_WIDTH_MARGIN']"
		[Register ("REMOVE_WIDTH_MARGIN")]
		public const string RemoveWidthMargin = (string) "remove_width_margin";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageContentKt']/field[@name='STYLES']"
		[Register ("STYLES")]
		public const string Styles = (string) "styles";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSInAppMessageContentKt", typeof (OSInAppMessageContentKt));

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

		internal OSInAppMessageContentKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
