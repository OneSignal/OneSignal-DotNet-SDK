using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']"
	[global::Android.Runtime.Register ("com/onesignal/OSNotificationGenerationJob", DoNotGenerateAcw=true)]
	public partial class OSNotificationGenerationJob : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotificationGenerationJob", typeof (OSNotificationGenerationJob));

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

		protected OSNotificationGenerationJob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static Delegate? cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static void n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Context = context;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context? Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
			set {
				const string __id = "setContext.(Landroid/content/Context;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getJsonPayload;
#pragma warning disable 0169
		static Delegate GetGetJsonPayloadHandler ()
		{
			if (cb_getJsonPayload == null)
				cb_getJsonPayload = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJsonPayload);
			return cb_getJsonPayload;
		}

		static IntPtr n_GetJsonPayload (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.JsonPayload);
		}
#pragma warning restore 0169

		static Delegate? cb_setJsonPayload_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetJsonPayload_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setJsonPayload_Lorg_json_JSONObject_ == null)
				cb_setJsonPayload_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetJsonPayload_Lorg_json_JSONObject_);
			return cb_setJsonPayload_Lorg_json_JSONObject_;
		}

		static void n_SetJsonPayload_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonPayload)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var jsonPayload = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonPayload, JniHandleOwnership.DoNotTransfer);
			__this.JsonPayload = jsonPayload;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject? JsonPayload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='getJsonPayload' and count(parameter)=0]"
			[Register ("getJsonPayload", "()Lorg/json/JSONObject;", "GetGetJsonPayloadHandler")]
			get {
				const string __id = "getJsonPayload.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setJsonPayload' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setJsonPayload", "(Lorg/json/JSONObject;)V", "GetSetJsonPayload_Lorg_json_JSONObject_Handler")]
			set {
				const string __id = "setJsonPayload.(Lorg/json/JSONObject;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getNotification;
#pragma warning disable 0169
		static Delegate GetGetNotificationHandler ()
		{
			if (cb_getNotification == null)
				cb_getNotification = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNotification);
			return cb_getNotification;
		}

		static IntPtr n_GetNotification (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Notification);
		}
#pragma warning restore 0169

		static Delegate? cb_setNotification_Lcom_onesignal_OSNotification_;
#pragma warning disable 0169
		static Delegate GetSetNotification_Lcom_onesignal_OSNotification_Handler ()
		{
			if (cb_setNotification_Lcom_onesignal_OSNotification_ == null)
				cb_setNotification_Lcom_onesignal_OSNotification_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNotification_Lcom_onesignal_OSNotification_);
			return cb_setNotification_Lcom_onesignal_OSNotification_;
		}

		static void n_SetNotification_Lcom_onesignal_OSNotification_ (IntPtr jnienv, IntPtr native__this, IntPtr native_notification)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var notification = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (native_notification, JniHandleOwnership.DoNotTransfer);
			__this.Notification = notification;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSNotification? Notification {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='getNotification' and count(parameter)=0]"
			[Register ("getNotification", "()Lcom/onesignal/OSNotification;", "GetGetNotificationHandler")]
			get {
				const string __id = "getNotification.()Lcom/onesignal/OSNotification;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setNotification' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSNotification']]"
			[Register ("setNotification", "(Lcom/onesignal/OSNotification;)V", "GetSetNotification_Lcom_onesignal_OSNotification_Handler")]
			set {
				const string __id = "setNotification.(Lcom/onesignal/OSNotification;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getOrgFlags;
#pragma warning disable 0169
		static Delegate GetGetOrgFlagsHandler ()
		{
			if (cb_getOrgFlags == null)
				cb_getOrgFlags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOrgFlags);
			return cb_getOrgFlags;
		}

		static IntPtr n_GetOrgFlags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OrgFlags);
		}
#pragma warning restore 0169

		static Delegate? cb_setOrgFlags_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetOrgFlags_Ljava_lang_Integer_Handler ()
		{
			if (cb_setOrgFlags_Ljava_lang_Integer_ == null)
				cb_setOrgFlags_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOrgFlags_Ljava_lang_Integer_);
			return cb_setOrgFlags_Ljava_lang_Integer_;
		}

		static void n_SetOrgFlags_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_orgFlags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var orgFlags = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_orgFlags, JniHandleOwnership.DoNotTransfer);
			__this.OrgFlags = orgFlags;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer? OrgFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='getOrgFlags' and count(parameter)=0]"
			[Register ("getOrgFlags", "()Ljava/lang/Integer;", "GetGetOrgFlagsHandler")]
			get {
				const string __id = "getOrgFlags.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setOrgFlags' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setOrgFlags", "(Ljava/lang/Integer;)V", "GetSetOrgFlags_Ljava_lang_Integer_Handler")]
			set {
				const string __id = "setOrgFlags.(Ljava/lang/Integer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getOrgSound;
#pragma warning disable 0169
		static Delegate GetGetOrgSoundHandler ()
		{
			if (cb_getOrgSound == null)
				cb_getOrgSound = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOrgSound);
			return cb_getOrgSound;
		}

		static IntPtr n_GetOrgSound (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OrgSound);
		}
#pragma warning restore 0169

		static Delegate? cb_setOrgSound_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetOrgSound_Landroid_net_Uri_Handler ()
		{
			if (cb_setOrgSound_Landroid_net_Uri_ == null)
				cb_setOrgSound_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOrgSound_Landroid_net_Uri_);
			return cb_setOrgSound_Landroid_net_Uri_;
		}

		static void n_SetOrgSound_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_orgSound)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var orgSound = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_orgSound, JniHandleOwnership.DoNotTransfer);
			__this.OrgSound = orgSound;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Net.Uri? OrgSound {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='getOrgSound' and count(parameter)=0]"
			[Register ("getOrgSound", "()Landroid/net/Uri;", "GetGetOrgSoundHandler")]
			get {
				const string __id = "getOrgSound.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setOrgSound' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("setOrgSound", "(Landroid/net/Uri;)V", "GetSetOrgSound_Landroid_net_Uri_Handler")]
			set {
				const string __id = "setOrgSound.(Landroid/net/Uri;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getOverriddenBodyFromExtender;
#pragma warning disable 0169
		static Delegate GetGetOverriddenBodyFromExtenderHandler ()
		{
			if (cb_getOverriddenBodyFromExtender == null)
				cb_getOverriddenBodyFromExtender = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOverriddenBodyFromExtender);
			return cb_getOverriddenBodyFromExtender;
		}

		static IntPtr n_GetOverriddenBodyFromExtender (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return CharSequence.ToLocalJniHandle (__this.OverriddenBodyFromExtenderFormatted);
		}
#pragma warning restore 0169

		static Delegate? cb_setOverriddenBodyFromExtender_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetOverriddenBodyFromExtender_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setOverriddenBodyFromExtender_Ljava_lang_CharSequence_ == null)
				cb_setOverriddenBodyFromExtender_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOverriddenBodyFromExtender_Ljava_lang_CharSequence_);
			return cb_setOverriddenBodyFromExtender_Ljava_lang_CharSequence_;
		}

		static void n_SetOverriddenBodyFromExtender_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_overriddenBodyFromExtender)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var overriddenBodyFromExtender = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_overriddenBodyFromExtender, JniHandleOwnership.DoNotTransfer);
			__this.OverriddenBodyFromExtenderFormatted = overriddenBodyFromExtender;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.ICharSequence? OverriddenBodyFromExtenderFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='getOverriddenBodyFromExtender' and count(parameter)=0]"
			[Register ("getOverriddenBodyFromExtender", "()Ljava/lang/CharSequence;", "GetGetOverriddenBodyFromExtenderHandler")]
			get {
				const string __id = "getOverriddenBodyFromExtender.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setOverriddenBodyFromExtender' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setOverriddenBodyFromExtender", "(Ljava/lang/CharSequence;)V", "GetSetOverriddenBodyFromExtender_Ljava_lang_CharSequence_Handler")]
			set {
				const string __id = "setOverriddenBodyFromExtender.(Ljava/lang/CharSequence;)V";
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public string? OverriddenBodyFromExtender {
			get { return OverriddenBodyFromExtenderFormatted == null ? null : OverriddenBodyFromExtenderFormatted.ToString (); }
			set {
				var jls = value == null ? null : new global::Java.Lang.String (value);
				OverriddenBodyFromExtenderFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate? cb_getOverriddenFlags;
#pragma warning disable 0169
		static Delegate GetGetOverriddenFlagsHandler ()
		{
			if (cb_getOverriddenFlags == null)
				cb_getOverriddenFlags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOverriddenFlags);
			return cb_getOverriddenFlags;
		}

		static IntPtr n_GetOverriddenFlags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OverriddenFlags);
		}
#pragma warning restore 0169

		static Delegate? cb_setOverriddenFlags_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetOverriddenFlags_Ljava_lang_Integer_Handler ()
		{
			if (cb_setOverriddenFlags_Ljava_lang_Integer_ == null)
				cb_setOverriddenFlags_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOverriddenFlags_Ljava_lang_Integer_);
			return cb_setOverriddenFlags_Ljava_lang_Integer_;
		}

		static void n_SetOverriddenFlags_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_overriddenFlags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var overriddenFlags = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_overriddenFlags, JniHandleOwnership.DoNotTransfer);
			__this.OverriddenFlags = overriddenFlags;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer? OverriddenFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='getOverriddenFlags' and count(parameter)=0]"
			[Register ("getOverriddenFlags", "()Ljava/lang/Integer;", "GetGetOverriddenFlagsHandler")]
			get {
				const string __id = "getOverriddenFlags.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setOverriddenFlags' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setOverriddenFlags", "(Ljava/lang/Integer;)V", "GetSetOverriddenFlags_Ljava_lang_Integer_Handler")]
			set {
				const string __id = "setOverriddenFlags.(Ljava/lang/Integer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getOverriddenSound;
#pragma warning disable 0169
		static Delegate GetGetOverriddenSoundHandler ()
		{
			if (cb_getOverriddenSound == null)
				cb_getOverriddenSound = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOverriddenSound);
			return cb_getOverriddenSound;
		}

		static IntPtr n_GetOverriddenSound (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.OverriddenSound);
		}
#pragma warning restore 0169

		static Delegate? cb_setOverriddenSound_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetOverriddenSound_Landroid_net_Uri_Handler ()
		{
			if (cb_setOverriddenSound_Landroid_net_Uri_ == null)
				cb_setOverriddenSound_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOverriddenSound_Landroid_net_Uri_);
			return cb_setOverriddenSound_Landroid_net_Uri_;
		}

		static void n_SetOverriddenSound_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_overriddenSound)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var overriddenSound = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_overriddenSound, JniHandleOwnership.DoNotTransfer);
			__this.OverriddenSound = overriddenSound;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Net.Uri? OverriddenSound {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='getOverriddenSound' and count(parameter)=0]"
			[Register ("getOverriddenSound", "()Landroid/net/Uri;", "GetGetOverriddenSoundHandler")]
			get {
				const string __id = "getOverriddenSound.()Landroid/net/Uri;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setOverriddenSound' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("setOverriddenSound", "(Landroid/net/Uri;)V", "GetSetOverriddenSound_Landroid_net_Uri_Handler")]
			set {
				const string __id = "setOverriddenSound.(Landroid/net/Uri;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getOverriddenTitleFromExtender;
#pragma warning disable 0169
		static Delegate GetGetOverriddenTitleFromExtenderHandler ()
		{
			if (cb_getOverriddenTitleFromExtender == null)
				cb_getOverriddenTitleFromExtender = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOverriddenTitleFromExtender);
			return cb_getOverriddenTitleFromExtender;
		}

		static IntPtr n_GetOverriddenTitleFromExtender (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return CharSequence.ToLocalJniHandle (__this.OverriddenTitleFromExtenderFormatted);
		}
#pragma warning restore 0169

		static Delegate? cb_setOverriddenTitleFromExtender_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetOverriddenTitleFromExtender_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setOverriddenTitleFromExtender_Ljava_lang_CharSequence_ == null)
				cb_setOverriddenTitleFromExtender_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOverriddenTitleFromExtender_Ljava_lang_CharSequence_);
			return cb_setOverriddenTitleFromExtender_Ljava_lang_CharSequence_;
		}

		static void n_SetOverriddenTitleFromExtender_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_overriddenTitleFromExtender)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var overriddenTitleFromExtender = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_overriddenTitleFromExtender, JniHandleOwnership.DoNotTransfer);
			__this.OverriddenTitleFromExtenderFormatted = overriddenTitleFromExtender;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.ICharSequence? OverriddenTitleFromExtenderFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='getOverriddenTitleFromExtender' and count(parameter)=0]"
			[Register ("getOverriddenTitleFromExtender", "()Ljava/lang/CharSequence;", "GetGetOverriddenTitleFromExtenderHandler")]
			get {
				const string __id = "getOverriddenTitleFromExtender.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setOverriddenTitleFromExtender' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setOverriddenTitleFromExtender", "(Ljava/lang/CharSequence;)V", "GetSetOverriddenTitleFromExtender_Ljava_lang_CharSequence_Handler")]
			set {
				const string __id = "setOverriddenTitleFromExtender.(Ljava/lang/CharSequence;)V";
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public string? OverriddenTitleFromExtender {
			get { return OverriddenTitleFromExtenderFormatted == null ? null : OverriddenTitleFromExtenderFormatted.ToString (); }
			set {
				var jls = value == null ? null : new global::Java.Lang.String (value);
				OverriddenTitleFromExtenderFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate? cb_isRestoring;
#pragma warning disable 0169
		static Delegate GetIsRestoringHandler ()
		{
			if (cb_isRestoring == null)
				cb_isRestoring = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRestoring);
			return cb_isRestoring;
		}

		static bool n_IsRestoring (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Restoring;
		}
#pragma warning restore 0169

		static Delegate? cb_setRestoring_Z;
#pragma warning disable 0169
		static Delegate GetSetRestoring_ZHandler ()
		{
			if (cb_setRestoring_Z == null)
				cb_setRestoring_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetRestoring_Z);
			return cb_setRestoring_Z;
		}

		static void n_SetRestoring_Z (IntPtr jnienv, IntPtr native__this, bool restoring)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Restoring = restoring;
		}
#pragma warning restore 0169

		public virtual unsafe bool Restoring {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='isRestoring' and count(parameter)=0]"
			[Register ("isRestoring", "()Z", "GetIsRestoringHandler")]
			get {
				const string __id = "isRestoring.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setRestoring' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRestoring", "(Z)V", "GetSetRestoring_ZHandler")]
			set {
				const string __id = "setRestoring.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getShownTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetShownTimeStampHandler ()
		{
			if (cb_getShownTimeStamp == null)
				cb_getShownTimeStamp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetShownTimeStamp);
			return cb_getShownTimeStamp;
		}

		static IntPtr n_GetShownTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ShownTimeStamp);
		}
#pragma warning restore 0169

		static Delegate? cb_setShownTimeStamp_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetShownTimeStamp_Ljava_lang_Long_Handler ()
		{
			if (cb_setShownTimeStamp_Ljava_lang_Long_ == null)
				cb_setShownTimeStamp_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetShownTimeStamp_Ljava_lang_Long_);
			return cb_setShownTimeStamp_Ljava_lang_Long_;
		}

		static void n_SetShownTimeStamp_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_shownTimeStamp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationGenerationJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var shownTimeStamp = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_shownTimeStamp, JniHandleOwnership.DoNotTransfer);
			__this.ShownTimeStamp = shownTimeStamp;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long? ShownTimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='getShownTimeStamp' and count(parameter)=0]"
			[Register ("getShownTimeStamp", "()Ljava/lang/Long;", "GetGetShownTimeStampHandler")]
			get {
				const string __id = "getShownTimeStamp.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotificationGenerationJob']/method[@name='setShownTimeStamp' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setShownTimeStamp", "(Ljava/lang/Long;)V", "GetSetShownTimeStamp_Ljava_lang_Long_Handler")]
			set {
				const string __id = "setShownTimeStamp.(Ljava/lang/Long;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
