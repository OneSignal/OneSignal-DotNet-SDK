using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams']"
	[global::Android.Runtime.Register ("com/onesignal/OneSignalRemoteParams", DoNotGenerateAcw=true)]
	public partial class OneSignalRemoteParams : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams']/field[@name='DEFAULT_INDIRECT_ATTRIBUTION_WINDOW']"
		[Register ("DEFAULT_INDIRECT_ATTRIBUTION_WINDOW")]
		public const int DefaultIndirectAttributionWindow = (int) 1440;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams']/field[@name='DEFAULT_NOTIFICATION_LIMIT']"
		[Register ("DEFAULT_NOTIFICATION_LIMIT")]
		public const int DefaultNotificationLimit = (int) 10;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams.InfluenceParams']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignalRemoteParams$InfluenceParams", DoNotGenerateAcw=true)]
		public partial class InfluenceParams : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignalRemoteParams$InfluenceParams", typeof (InfluenceParams));

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

			protected InfluenceParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams.InfluenceParams']/constructor[@name='OneSignalRemoteParams.InfluenceParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe InfluenceParams () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate? cb_getIamLimit;
#pragma warning disable 0169
			static Delegate GetGetIamLimitHandler ()
			{
				if (cb_getIamLimit == null)
					cb_getIamLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIamLimit);
				return cb_getIamLimit;
			}

			static int n_GetIamLimit (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignalRemoteParams.InfluenceParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IamLimit;
			}
#pragma warning restore 0169

			public virtual unsafe int IamLimit {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams.InfluenceParams']/method[@name='getIamLimit' and count(parameter)=0]"
				[Register ("getIamLimit", "()I", "GetGetIamLimitHandler")]
				get {
					const string __id = "getIamLimit.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getIndirectIAMAttributionWindow;
#pragma warning disable 0169
			static Delegate GetGetIndirectIAMAttributionWindowHandler ()
			{
				if (cb_getIndirectIAMAttributionWindow == null)
					cb_getIndirectIAMAttributionWindow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIndirectIAMAttributionWindow);
				return cb_getIndirectIAMAttributionWindow;
			}

			static int n_GetIndirectIAMAttributionWindow (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignalRemoteParams.InfluenceParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IndirectIAMAttributionWindow;
			}
#pragma warning restore 0169

			public virtual unsafe int IndirectIAMAttributionWindow {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams.InfluenceParams']/method[@name='getIndirectIAMAttributionWindow' and count(parameter)=0]"
				[Register ("getIndirectIAMAttributionWindow", "()I", "GetGetIndirectIAMAttributionWindowHandler")]
				get {
					const string __id = "getIndirectIAMAttributionWindow.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getIndirectNotificationAttributionWindow;
#pragma warning disable 0169
			static Delegate GetGetIndirectNotificationAttributionWindowHandler ()
			{
				if (cb_getIndirectNotificationAttributionWindow == null)
					cb_getIndirectNotificationAttributionWindow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIndirectNotificationAttributionWindow);
				return cb_getIndirectNotificationAttributionWindow;
			}

			static int n_GetIndirectNotificationAttributionWindow (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignalRemoteParams.InfluenceParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IndirectNotificationAttributionWindow;
			}
#pragma warning restore 0169

			public virtual unsafe int IndirectNotificationAttributionWindow {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams.InfluenceParams']/method[@name='getIndirectNotificationAttributionWindow' and count(parameter)=0]"
				[Register ("getIndirectNotificationAttributionWindow", "()I", "GetGetIndirectNotificationAttributionWindowHandler")]
				get {
					const string __id = "getIndirectNotificationAttributionWindow.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_isDirectEnabled;
#pragma warning disable 0169
			static Delegate GetIsDirectEnabledHandler ()
			{
				if (cb_isDirectEnabled == null)
					cb_isDirectEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDirectEnabled);
				return cb_isDirectEnabled;
			}

			static bool n_IsDirectEnabled (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignalRemoteParams.InfluenceParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsDirectEnabled;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsDirectEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams.InfluenceParams']/method[@name='isDirectEnabled' and count(parameter)=0]"
				[Register ("isDirectEnabled", "()Z", "GetIsDirectEnabledHandler")]
				get {
					const string __id = "isDirectEnabled.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_isIndirectEnabled;
#pragma warning disable 0169
			static Delegate GetIsIndirectEnabledHandler ()
			{
				if (cb_isIndirectEnabled == null)
					cb_isIndirectEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIndirectEnabled);
				return cb_isIndirectEnabled;
			}

			static bool n_IsIndirectEnabled (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignalRemoteParams.InfluenceParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsIndirectEnabled;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsIndirectEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams.InfluenceParams']/method[@name='isIndirectEnabled' and count(parameter)=0]"
				[Register ("isIndirectEnabled", "()Z", "GetIsIndirectEnabledHandler")]
				get {
					const string __id = "isIndirectEnabled.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_isUnattributedEnabled;
#pragma warning disable 0169
			static Delegate GetIsUnattributedEnabledHandler ()
			{
				if (cb_isUnattributedEnabled == null)
					cb_isUnattributedEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUnattributedEnabled);
				return cb_isUnattributedEnabled;
			}

			static bool n_IsUnattributedEnabled (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignalRemoteParams.InfluenceParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.IsUnattributedEnabled;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsUnattributedEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams.InfluenceParams']/method[@name='isUnattributedEnabled' and count(parameter)=0]"
				[Register ("isUnattributedEnabled", "()Z", "GetIsUnattributedEnabledHandler")]
				get {
					const string __id = "isUnattributedEnabled.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getNotificationLimit;
#pragma warning disable 0169
			static Delegate GetGetNotificationLimitHandler ()
			{
				if (cb_getNotificationLimit == null)
					cb_getNotificationLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNotificationLimit);
				return cb_getNotificationLimit;
			}

			static int n_GetNotificationLimit (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignalRemoteParams.InfluenceParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.NotificationLimit;
			}
#pragma warning restore 0169

			public virtual unsafe int NotificationLimit {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams.InfluenceParams']/method[@name='getNotificationLimit' and count(parameter)=0]"
				[Register ("getNotificationLimit", "()I", "GetGetNotificationLimitHandler")]
				get {
					const string __id = "getNotificationLimit.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignalRemoteParams", typeof (OneSignalRemoteParams));

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

		protected OneSignalRemoteParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignalRemoteParams']/constructor[@name='OneSignalRemoteParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OneSignalRemoteParams () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}
