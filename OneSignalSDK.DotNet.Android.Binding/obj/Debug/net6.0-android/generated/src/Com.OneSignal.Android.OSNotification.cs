using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']"
	[global::Android.Runtime.Register ("com/onesignal/OSNotification", DoNotGenerateAcw=true)]
	public partial class OSNotification : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.ActionButton']"
		[global::Android.Runtime.Register ("com/onesignal/OSNotification$ActionButton", DoNotGenerateAcw=true)]
		public partial class ActionButton : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotification$ActionButton", typeof (ActionButton));

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

			protected ActionButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.ActionButton']/constructor[@name='OSNotification.ActionButton' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ActionButton () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.ActionButton']/constructor[@name='OSNotification.ActionButton' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe ActionButton (string? id, string? text, string? icon) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString ((string?)id);
				IntPtr native_text = JNIEnv.NewString ((string?)text);
				IntPtr native_icon = JNIEnv.NewString ((string?)icon);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_id);
					__args [1] = new JniArgumentValue (native_text);
					__args [2] = new JniArgumentValue (native_icon);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_text);
					JNIEnv.DeleteLocalRef (native_icon);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.ActionButton']/constructor[@name='OSNotification.ActionButton' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
			public unsafe ActionButton (global::Org.Json.JSONObject? jsonObject) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/json/JSONObject;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (jsonObject);
				}
			}

			static Delegate? cb_getIcon;
#pragma warning disable 0169
			static Delegate GetGetIconHandler ()
			{
				if (cb_getIcon == null)
					cb_getIcon = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIcon);
				return cb_getIcon;
			}

			static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.ActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Icon);
			}
#pragma warning restore 0169

			public virtual unsafe string? Icon {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.ActionButton']/method[@name='getIcon' and count(parameter)=0]"
				[Register ("getIcon", "()Ljava/lang/String;", "GetGetIconHandler")]
				get {
					const string __id = "getIcon.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getId;
#pragma warning disable 0169
			static Delegate GetGetIdHandler ()
			{
				if (cb_getId == null)
					cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetId);
				return cb_getId;
			}

			static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.ActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Id);
			}
#pragma warning restore 0169

			public virtual unsafe string? Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.ActionButton']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getText;
#pragma warning disable 0169
			static Delegate GetGetTextHandler ()
			{
				if (cb_getText == null)
					cb_getText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetText);
				return cb_getText;
			}

			static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.ActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Text);
			}
#pragma warning restore 0169

			public virtual unsafe string? Text {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.ActionButton']/method[@name='getText' and count(parameter)=0]"
				[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
				get {
					const string __id = "getText.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_toJSONObject;
#pragma warning disable 0169
			static Delegate GetToJSONObjectHandler ()
			{
				if (cb_toJSONObject == null)
					cb_toJSONObject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToJSONObject);
				return cb_toJSONObject;
			}

			static IntPtr n_ToJSONObject (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.ActionButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.ActionButton']/method[@name='toJSONObject' and count(parameter)=0]"
			[Register ("toJSONObject", "()Lorg/json/JSONObject;", "GetToJSONObjectHandler")]
			public virtual unsafe global::Org.Json.JSONObject? ToJSONObject ()
			{
				const string __id = "toJSONObject.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.BackgroundImageLayout']"
		[global::Android.Runtime.Register ("com/onesignal/OSNotification$BackgroundImageLayout", DoNotGenerateAcw=true)]
		public partial class BackgroundImageLayout : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotification$BackgroundImageLayout", typeof (BackgroundImageLayout));

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

			protected BackgroundImageLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.BackgroundImageLayout']/constructor[@name='OSNotification.BackgroundImageLayout' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BackgroundImageLayout () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate? cb_getBodyTextColor;
#pragma warning disable 0169
			static Delegate GetGetBodyTextColorHandler ()
			{
				if (cb_getBodyTextColor == null)
					cb_getBodyTextColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBodyTextColor);
				return cb_getBodyTextColor;
			}

			static IntPtr n_GetBodyTextColor (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.BackgroundImageLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.BodyTextColor);
			}
#pragma warning restore 0169

			public virtual unsafe string? BodyTextColor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.BackgroundImageLayout']/method[@name='getBodyTextColor' and count(parameter)=0]"
				[Register ("getBodyTextColor", "()Ljava/lang/String;", "GetGetBodyTextColorHandler")]
				get {
					const string __id = "getBodyTextColor.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getImage;
#pragma warning disable 0169
			static Delegate GetGetImageHandler ()
			{
				if (cb_getImage == null)
					cb_getImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImage);
				return cb_getImage;
			}

			static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.BackgroundImageLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Image);
			}
#pragma warning restore 0169

			public virtual unsafe string? Image {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.BackgroundImageLayout']/method[@name='getImage' and count(parameter)=0]"
				[Register ("getImage", "()Ljava/lang/String;", "GetGetImageHandler")]
				get {
					const string __id = "getImage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getTitleTextColor;
#pragma warning disable 0169
			static Delegate GetGetTitleTextColorHandler ()
			{
				if (cb_getTitleTextColor == null)
					cb_getTitleTextColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTitleTextColor);
				return cb_getTitleTextColor;
			}

			static IntPtr n_GetTitleTextColor (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.BackgroundImageLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.TitleTextColor);
			}
#pragma warning restore 0169

			public virtual unsafe string? TitleTextColor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.BackgroundImageLayout']/method[@name='getTitleTextColor' and count(parameter)=0]"
				[Register ("getTitleTextColor", "()Ljava/lang/String;", "GetGetTitleTextColorHandler")]
				get {
					const string __id = "getTitleTextColor.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']"
		[global::Android.Runtime.Register ("com/onesignal/OSNotification$OSNotificationBuilder", DoNotGenerateAcw=true)]
		public partial class OSNotificationBuilder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotification$OSNotificationBuilder", typeof (OSNotificationBuilder));

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

			protected OSNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/constructor[@name='OSNotification.OSNotificationBuilder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe OSNotificationBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate? cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/onesignal/OSNotification;", "GetBuildHandler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification? Build ()
			{
				const string __id = "build.()Lcom/onesignal/OSNotification;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_setActionButtons_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSetActionButtons_Ljava_util_List_Handler ()
			{
				if (cb_setActionButtons_Ljava_util_List_ == null)
					cb_setActionButtons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetActionButtons_Ljava_util_List_);
				return cb_setActionButtons_Ljava_util_List_;
			}

			static IntPtr n_SetActionButtons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_actionButtons)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var actionButtons = global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSNotification.ActionButton>.FromJniHandle (native_actionButtons, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetActionButtons (actionButtons));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setActionButtons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.onesignal.OSNotification.ActionButton&gt;']]"
			[Register ("setActionButtons", "(Ljava/util/List;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetActionButtons_Ljava_util_List_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetActionButtons (global::System.Collections.Generic.IList<global::Com.OneSignal.Android.OSNotification.ActionButton>? actionButtons)
			{
				const string __id = "setActionButtons.(Ljava/util/List;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_actionButtons = global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSNotification.ActionButton>.ToLocalJniHandle (actionButtons);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_actionButtons);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_actionButtons);
					global::System.GC.KeepAlive (actionButtons);
				}
			}

			static Delegate? cb_setAdditionalData_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetSetAdditionalData_Lorg_json_JSONObject_Handler ()
			{
				if (cb_setAdditionalData_Lorg_json_JSONObject_ == null)
					cb_setAdditionalData_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetAdditionalData_Lorg_json_JSONObject_);
				return cb_setAdditionalData_Lorg_json_JSONObject_;
			}

			static IntPtr n_SetAdditionalData_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_additionalData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var additionalData = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_additionalData, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAdditionalData (additionalData));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setAdditionalData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setAdditionalData", "(Lorg/json/JSONObject;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetAdditionalData_Lorg_json_JSONObject_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetAdditionalData (global::Org.Json.JSONObject? additionalData)
			{
				const string __id = "setAdditionalData.(Lorg/json/JSONObject;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((additionalData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) additionalData).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (additionalData);
				}
			}

			static Delegate? cb_setAndroidNotificationId_I;
#pragma warning disable 0169
			static Delegate GetSetAndroidNotificationId_IHandler ()
			{
				if (cb_setAndroidNotificationId_I == null)
					cb_setAndroidNotificationId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetAndroidNotificationId_I);
				return cb_setAndroidNotificationId_I;
			}

			static IntPtr n_SetAndroidNotificationId_I (IntPtr jnienv, IntPtr native__this, int androidNotificationId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SetAndroidNotificationId (androidNotificationId));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setAndroidNotificationId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAndroidNotificationId", "(I)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetAndroidNotificationId_IHandler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetAndroidNotificationId (int androidNotificationId)
			{
				const string __id = "setAndroidNotificationId.(I)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (androidNotificationId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_setBackgroundImageLayout_Lcom_onesignal_OSNotification_BackgroundImageLayout_;
#pragma warning disable 0169
			static Delegate GetSetBackgroundImageLayout_Lcom_onesignal_OSNotification_BackgroundImageLayout_Handler ()
			{
				if (cb_setBackgroundImageLayout_Lcom_onesignal_OSNotification_BackgroundImageLayout_ == null)
					cb_setBackgroundImageLayout_Lcom_onesignal_OSNotification_BackgroundImageLayout_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetBackgroundImageLayout_Lcom_onesignal_OSNotification_BackgroundImageLayout_);
				return cb_setBackgroundImageLayout_Lcom_onesignal_OSNotification_BackgroundImageLayout_;
			}

			static IntPtr n_SetBackgroundImageLayout_Lcom_onesignal_OSNotification_BackgroundImageLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_backgroundImageLayout)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var backgroundImageLayout = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.BackgroundImageLayout> (native_backgroundImageLayout, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBackgroundImageLayout (backgroundImageLayout));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setBackgroundImageLayout' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSNotification.BackgroundImageLayout']]"
			[Register ("setBackgroundImageLayout", "(Lcom/onesignal/OSNotification$BackgroundImageLayout;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetBackgroundImageLayout_Lcom_onesignal_OSNotification_BackgroundImageLayout_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetBackgroundImageLayout (global::Com.OneSignal.Android.OSNotification.BackgroundImageLayout? backgroundImageLayout)
			{
				const string __id = "setBackgroundImageLayout.(Lcom/onesignal/OSNotification$BackgroundImageLayout;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((backgroundImageLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) backgroundImageLayout).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (backgroundImageLayout);
				}
			}

			static Delegate? cb_setBigPicture_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBigPicture_Ljava_lang_String_Handler ()
			{
				if (cb_setBigPicture_Ljava_lang_String_ == null)
					cb_setBigPicture_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetBigPicture_Ljava_lang_String_);
				return cb_setBigPicture_Ljava_lang_String_;
			}

			static IntPtr n_SetBigPicture_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bigPicture)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var bigPicture = JNIEnv.GetString (native_bigPicture, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBigPicture (bigPicture));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setBigPicture' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBigPicture", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetBigPicture_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetBigPicture (string? bigPicture)
			{
				const string __id = "setBigPicture.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_bigPicture = JNIEnv.NewString ((string?)bigPicture);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_bigPicture);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_bigPicture);
				}
			}

			static Delegate? cb_setBody_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBody_Ljava_lang_String_Handler ()
			{
				if (cb_setBody_Ljava_lang_String_ == null)
					cb_setBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetBody_Ljava_lang_String_);
				return cb_setBody_Ljava_lang_String_;
			}

			static IntPtr n_SetBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_body)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var body = JNIEnv.GetString (native_body, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBody (body));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBody", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetBody_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetBody (string? body)
			{
				const string __id = "setBody.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_body = JNIEnv.NewString ((string?)body);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_body);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_body);
				}
			}

			static Delegate? cb_setCollapseId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCollapseId_Ljava_lang_String_Handler ()
			{
				if (cb_setCollapseId_Ljava_lang_String_ == null)
					cb_setCollapseId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetCollapseId_Ljava_lang_String_);
				return cb_setCollapseId_Ljava_lang_String_;
			}

			static IntPtr n_SetCollapseId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collapseId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var collapseId = JNIEnv.GetString (native_collapseId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCollapseId (collapseId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setCollapseId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCollapseId", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetCollapseId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetCollapseId (string? collapseId)
			{
				const string __id = "setCollapseId.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_collapseId = JNIEnv.NewString ((string?)collapseId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_collapseId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_collapseId);
				}
			}

			static Delegate? cb_setFromProjectNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFromProjectNumber_Ljava_lang_String_Handler ()
			{
				if (cb_setFromProjectNumber_Ljava_lang_String_ == null)
					cb_setFromProjectNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetFromProjectNumber_Ljava_lang_String_);
				return cb_setFromProjectNumber_Ljava_lang_String_;
			}

			static IntPtr n_SetFromProjectNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fromProjectNumber)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var fromProjectNumber = JNIEnv.GetString (native_fromProjectNumber, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFromProjectNumber (fromProjectNumber));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setFromProjectNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFromProjectNumber", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetFromProjectNumber_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetFromProjectNumber (string? fromProjectNumber)
			{
				const string __id = "setFromProjectNumber.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_fromProjectNumber = JNIEnv.NewString ((string?)fromProjectNumber);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_fromProjectNumber);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_fromProjectNumber);
				}
			}

			static Delegate? cb_setGroupKey_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetGroupKey_Ljava_lang_String_Handler ()
			{
				if (cb_setGroupKey_Ljava_lang_String_ == null)
					cb_setGroupKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetGroupKey_Ljava_lang_String_);
				return cb_setGroupKey_Ljava_lang_String_;
			}

			static IntPtr n_SetGroupKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_groupKey)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var groupKey = JNIEnv.GetString (native_groupKey, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGroupKey (groupKey));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setGroupKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGroupKey", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetGroupKey_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetGroupKey (string? groupKey)
			{
				const string __id = "setGroupKey.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_groupKey = JNIEnv.NewString ((string?)groupKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_groupKey);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_groupKey);
				}
			}

			static Delegate? cb_setGroupMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetGroupMessage_Ljava_lang_String_Handler ()
			{
				if (cb_setGroupMessage_Ljava_lang_String_ == null)
					cb_setGroupMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetGroupMessage_Ljava_lang_String_);
				return cb_setGroupMessage_Ljava_lang_String_;
			}

			static IntPtr n_SetGroupMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_groupMessage)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var groupMessage = JNIEnv.GetString (native_groupMessage, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGroupMessage (groupMessage));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setGroupMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGroupMessage", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetGroupMessage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetGroupMessage (string? groupMessage)
			{
				const string __id = "setGroupMessage.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_groupMessage = JNIEnv.NewString ((string?)groupMessage);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_groupMessage);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_groupMessage);
				}
			}

			static Delegate? cb_setGroupedNotifications_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSetGroupedNotifications_Ljava_util_List_Handler ()
			{
				if (cb_setGroupedNotifications_Ljava_util_List_ == null)
					cb_setGroupedNotifications_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetGroupedNotifications_Ljava_util_List_);
				return cb_setGroupedNotifications_Ljava_util_List_;
			}

			static IntPtr n_SetGroupedNotifications_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_groupedNotifications)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var groupedNotifications = global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSNotification>.FromJniHandle (native_groupedNotifications, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGroupedNotifications (groupedNotifications));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setGroupedNotifications' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.onesignal.OSNotification&gt;']]"
			[Register ("setGroupedNotifications", "(Ljava/util/List;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetGroupedNotifications_Ljava_util_List_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetGroupedNotifications (global::System.Collections.Generic.IList<global::Com.OneSignal.Android.OSNotification>? groupedNotifications)
			{
				const string __id = "setGroupedNotifications.(Ljava/util/List;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_groupedNotifications = global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSNotification>.ToLocalJniHandle (groupedNotifications);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_groupedNotifications);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_groupedNotifications);
					global::System.GC.KeepAlive (groupedNotifications);
				}
			}

			static Delegate? cb_setLargeIcon_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetLargeIcon_Ljava_lang_String_Handler ()
			{
				if (cb_setLargeIcon_Ljava_lang_String_ == null)
					cb_setLargeIcon_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetLargeIcon_Ljava_lang_String_);
				return cb_setLargeIcon_Ljava_lang_String_;
			}

			static IntPtr n_SetLargeIcon_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_largeIcon)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var largeIcon = JNIEnv.GetString (native_largeIcon, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLargeIcon (largeIcon));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setLargeIcon' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLargeIcon", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetLargeIcon_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetLargeIcon (string? largeIcon)
			{
				const string __id = "setLargeIcon.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_largeIcon = JNIEnv.NewString ((string?)largeIcon);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_largeIcon);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_largeIcon);
				}
			}

			static Delegate? cb_setLaunchURL_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetLaunchURL_Ljava_lang_String_Handler ()
			{
				if (cb_setLaunchURL_Ljava_lang_String_ == null)
					cb_setLaunchURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetLaunchURL_Ljava_lang_String_);
				return cb_setLaunchURL_Ljava_lang_String_;
			}

			static IntPtr n_SetLaunchURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_launchURL)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var launchURL = JNIEnv.GetString (native_launchURL, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLaunchURL (launchURL));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setLaunchURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLaunchURL", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetLaunchURL_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetLaunchURL (string? launchURL)
			{
				const string __id = "setLaunchURL.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_launchURL = JNIEnv.NewString ((string?)launchURL);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_launchURL);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_launchURL);
				}
			}

			static Delegate? cb_setLedColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetLedColor_Ljava_lang_String_Handler ()
			{
				if (cb_setLedColor_Ljava_lang_String_ == null)
					cb_setLedColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetLedColor_Ljava_lang_String_);
				return cb_setLedColor_Ljava_lang_String_;
			}

			static IntPtr n_SetLedColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ledColor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var ledColor = JNIEnv.GetString (native_ledColor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLedColor (ledColor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setLedColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLedColor", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetLedColor_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetLedColor (string? ledColor)
			{
				const string __id = "setLedColor.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_ledColor = JNIEnv.NewString ((string?)ledColor);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_ledColor);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_ledColor);
				}
			}

			static Delegate? cb_setLockScreenVisibility_I;
#pragma warning disable 0169
			static Delegate GetSetLockScreenVisibility_IHandler ()
			{
				if (cb_setLockScreenVisibility_I == null)
					cb_setLockScreenVisibility_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetLockScreenVisibility_I);
				return cb_setLockScreenVisibility_I;
			}

			static IntPtr n_SetLockScreenVisibility_I (IntPtr jnienv, IntPtr native__this, int lockScreenVisibility)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SetLockScreenVisibility (lockScreenVisibility));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setLockScreenVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLockScreenVisibility", "(I)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetLockScreenVisibility_IHandler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetLockScreenVisibility (int lockScreenVisibility)
			{
				const string __id = "setLockScreenVisibility.(I)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (lockScreenVisibility);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_setNotificationId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNotificationId_Ljava_lang_String_Handler ()
			{
				if (cb_setNotificationId_Ljava_lang_String_ == null)
					cb_setNotificationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetNotificationId_Ljava_lang_String_);
				return cb_setNotificationId_Ljava_lang_String_;
			}

			static IntPtr n_SetNotificationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_notificationId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var notificationId = JNIEnv.GetString (native_notificationId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNotificationId (notificationId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setNotificationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotificationId", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetNotificationId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetNotificationId (string? notificationId)
			{
				const string __id = "setNotificationId.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_notificationId = JNIEnv.NewString ((string?)notificationId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_notificationId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_notificationId);
				}
			}

			static Delegate? cb_setPriority_I;
#pragma warning disable 0169
			static Delegate GetSetPriority_IHandler ()
			{
				if (cb_setPriority_I == null)
					cb_setPriority_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetPriority_I);
				return cb_setPriority_I;
			}

			static IntPtr n_SetPriority_I (IntPtr jnienv, IntPtr native__this, int priority)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SetPriority (priority));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setPriority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPriority", "(I)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetPriority_IHandler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetPriority (int priority)
			{
				const string __id = "setPriority.(I)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (priority);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_setRawPayload_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetRawPayload_Ljava_lang_String_Handler ()
			{
				if (cb_setRawPayload_Ljava_lang_String_ == null)
					cb_setRawPayload_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRawPayload_Ljava_lang_String_);
				return cb_setRawPayload_Ljava_lang_String_;
			}

			static IntPtr n_SetRawPayload_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rawPayload)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var rawPayload = JNIEnv.GetString (native_rawPayload, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRawPayload (rawPayload));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setRawPayload' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRawPayload", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetRawPayload_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetRawPayload (string? rawPayload)
			{
				const string __id = "setRawPayload.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_rawPayload = JNIEnv.NewString ((string?)rawPayload);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_rawPayload);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_rawPayload);
				}
			}

			static Delegate? cb_setSenttime_J;
#pragma warning disable 0169
			static Delegate GetSetSenttime_JHandler ()
			{
				if (cb_setSenttime_J == null)
					cb_setSenttime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_SetSenttime_J);
				return cb_setSenttime_J;
			}

			static IntPtr n_SetSenttime_J (IntPtr jnienv, IntPtr native__this, long sentTime)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SetSenttime (sentTime));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setSenttime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSenttime", "(J)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetSenttime_JHandler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetSenttime (long sentTime)
			{
				const string __id = "setSenttime.(J)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (sentTime);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_setSmallIcon_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSmallIcon_Ljava_lang_String_Handler ()
			{
				if (cb_setSmallIcon_Ljava_lang_String_ == null)
					cb_setSmallIcon_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSmallIcon_Ljava_lang_String_);
				return cb_setSmallIcon_Ljava_lang_String_;
			}

			static IntPtr n_SetSmallIcon_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_smallIcon)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var smallIcon = JNIEnv.GetString (native_smallIcon, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSmallIcon (smallIcon));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setSmallIcon' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSmallIcon", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetSmallIcon_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetSmallIcon (string? smallIcon)
			{
				const string __id = "setSmallIcon.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_smallIcon = JNIEnv.NewString ((string?)smallIcon);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_smallIcon);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_smallIcon);
				}
			}

			static Delegate? cb_setSmallIconAccentColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSmallIconAccentColor_Ljava_lang_String_Handler ()
			{
				if (cb_setSmallIconAccentColor_Ljava_lang_String_ == null)
					cb_setSmallIconAccentColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSmallIconAccentColor_Ljava_lang_String_);
				return cb_setSmallIconAccentColor_Ljava_lang_String_;
			}

			static IntPtr n_SetSmallIconAccentColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_smallIconAccentColor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var smallIconAccentColor = JNIEnv.GetString (native_smallIconAccentColor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSmallIconAccentColor (smallIconAccentColor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setSmallIconAccentColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSmallIconAccentColor", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetSmallIconAccentColor_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetSmallIconAccentColor (string? smallIconAccentColor)
			{
				const string __id = "setSmallIconAccentColor.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_smallIconAccentColor = JNIEnv.NewString ((string?)smallIconAccentColor);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_smallIconAccentColor);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_smallIconAccentColor);
				}
			}

			static Delegate? cb_setSound_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSound_Ljava_lang_String_Handler ()
			{
				if (cb_setSound_Ljava_lang_String_ == null)
					cb_setSound_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSound_Ljava_lang_String_);
				return cb_setSound_Ljava_lang_String_;
			}

			static IntPtr n_SetSound_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sound)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var sound = JNIEnv.GetString (native_sound, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSound (sound));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setSound' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSound", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetSound_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetSound (string? sound)
			{
				const string __id = "setSound.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_sound = JNIEnv.NewString ((string?)sound);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_sound);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_sound);
				}
			}

			static Delegate? cb_setTTL_I;
#pragma warning disable 0169
			static Delegate GetSetTTL_IHandler ()
			{
				if (cb_setTTL_I == null)
					cb_setTTL_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetTTL_I);
				return cb_setTTL_I;
			}

			static IntPtr n_SetTTL_I (IntPtr jnienv, IntPtr native__this, int ttl)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.SetTTL (ttl));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setTTL' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTTL", "(I)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetTTL_IHandler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetTTL (int ttl)
			{
				const string __id = "setTTL.(I)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (ttl);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate? cb_setTemplateId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTemplateId_Ljava_lang_String_Handler ()
			{
				if (cb_setTemplateId_Ljava_lang_String_ == null)
					cb_setTemplateId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTemplateId_Ljava_lang_String_);
				return cb_setTemplateId_Ljava_lang_String_;
			}

			static IntPtr n_SetTemplateId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_templateId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var templateId = JNIEnv.GetString (native_templateId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTemplateId (templateId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setTemplateId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTemplateId", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetTemplateId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetTemplateId (string? templateId)
			{
				const string __id = "setTemplateId.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_templateId = JNIEnv.NewString ((string?)templateId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_templateId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_templateId);
				}
			}

			static Delegate? cb_setTemplateName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTemplateName_Ljava_lang_String_Handler ()
			{
				if (cb_setTemplateName_Ljava_lang_String_ == null)
					cb_setTemplateName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTemplateName_Ljava_lang_String_);
				return cb_setTemplateName_Ljava_lang_String_;
			}

			static IntPtr n_SetTemplateName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_templateName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var templateName = JNIEnv.GetString (native_templateName, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTemplateName (templateName));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setTemplateName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTemplateName", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetTemplateName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetTemplateName (string? templateName)
			{
				const string __id = "setTemplateName.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_templateName = JNIEnv.NewString ((string?)templateName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_templateName);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_templateName);
				}
			}

			static Delegate? cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTitle_Ljava_lang_String_Handler ()
			{
				if (cb_setTitle_Ljava_lang_String_ == null)
					cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTitle_Ljava_lang_String_);
				return cb_setTitle_Ljava_lang_String_;
			}

			static IntPtr n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitle (title));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification.OSNotificationBuilder']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;", "GetSetTitle_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder? SetTitle (string? title)
			{
				const string __id = "setTitle.(Ljava/lang/String;)Lcom/onesignal/OSNotification$OSNotificationBuilder;";
				IntPtr native_title = JNIEnv.NewString ((string?)title);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_title);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.OSNotificationBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_title);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSNotification", typeof (OSNotification));

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

		protected OSNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/constructor[@name='OSNotification' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe OSNotification () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/constructor[@name='OSNotification' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSNotification']]"
		[Register (".ctor", "(Lcom/onesignal/OSNotification;)V", "")]
		protected unsafe OSNotification (global::Com.OneSignal.Android.OSNotification? notification) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/OSNotification;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((notification == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notification).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (notification);
			}
		}

		static Delegate? cb_getActionButtons;
#pragma warning disable 0169
		static Delegate GetGetActionButtonsHandler ()
		{
			if (cb_getActionButtons == null)
				cb_getActionButtons = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetActionButtons);
			return cb_getActionButtons;
		}

		static IntPtr n_GetActionButtons (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSNotification.ActionButton>.ToLocalJniHandle (__this.ActionButtons);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.OneSignal.Android.OSNotification.ActionButton>? ActionButtons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getActionButtons' and count(parameter)=0]"
			[Register ("getActionButtons", "()Ljava/util/List;", "GetGetActionButtonsHandler")]
			get {
				const string __id = "getActionButtons.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSNotification.ActionButton>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getAdditionalData;
#pragma warning disable 0169
		static Delegate GetGetAdditionalDataHandler ()
		{
			if (cb_getAdditionalData == null)
				cb_getAdditionalData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdditionalData);
			return cb_getAdditionalData;
		}

		static IntPtr n_GetAdditionalData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AdditionalData);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject? AdditionalData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getAdditionalData' and count(parameter)=0]"
			[Register ("getAdditionalData", "()Lorg/json/JSONObject;", "GetGetAdditionalDataHandler")]
			get {
				const string __id = "getAdditionalData.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getAndroidNotificationId;
#pragma warning disable 0169
		static Delegate GetGetAndroidNotificationIdHandler ()
		{
			if (cb_getAndroidNotificationId == null)
				cb_getAndroidNotificationId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAndroidNotificationId);
			return cb_getAndroidNotificationId;
		}

		static int n_GetAndroidNotificationId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.AndroidNotificationId;
		}
#pragma warning restore 0169

		public virtual unsafe int AndroidNotificationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getAndroidNotificationId' and count(parameter)=0]"
			[Register ("getAndroidNotificationId", "()I", "GetGetAndroidNotificationIdHandler")]
			get {
				const string __id = "getAndroidNotificationId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getBigPicture;
#pragma warning disable 0169
		static Delegate GetGetBigPictureHandler ()
		{
			if (cb_getBigPicture == null)
				cb_getBigPicture = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBigPicture);
			return cb_getBigPicture;
		}

		static IntPtr n_GetBigPicture (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.BigPicture);
		}
#pragma warning restore 0169

		public virtual unsafe string? BigPicture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getBigPicture' and count(parameter)=0]"
			[Register ("getBigPicture", "()Ljava/lang/String;", "GetGetBigPictureHandler")]
			get {
				const string __id = "getBigPicture.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Body);
		}
#pragma warning restore 0169

		public virtual unsafe string? Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/lang/String;", "GetGetBodyHandler")]
			get {
				const string __id = "getBody.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getCollapseId;
#pragma warning disable 0169
		static Delegate GetGetCollapseIdHandler ()
		{
			if (cb_getCollapseId == null)
				cb_getCollapseId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCollapseId);
			return cb_getCollapseId;
		}

		static IntPtr n_GetCollapseId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.CollapseId);
		}
#pragma warning restore 0169

		public virtual unsafe string? CollapseId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getCollapseId' and count(parameter)=0]"
			[Register ("getCollapseId", "()Ljava/lang/String;", "GetGetCollapseIdHandler")]
			get {
				const string __id = "getCollapseId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getFromProjectNumber;
#pragma warning disable 0169
		static Delegate GetGetFromProjectNumberHandler ()
		{
			if (cb_getFromProjectNumber == null)
				cb_getFromProjectNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFromProjectNumber);
			return cb_getFromProjectNumber;
		}

		static IntPtr n_GetFromProjectNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.FromProjectNumber);
		}
#pragma warning restore 0169

		public virtual unsafe string? FromProjectNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getFromProjectNumber' and count(parameter)=0]"
			[Register ("getFromProjectNumber", "()Ljava/lang/String;", "GetGetFromProjectNumberHandler")]
			get {
				const string __id = "getFromProjectNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getGroupKey;
#pragma warning disable 0169
		static Delegate GetGetGroupKeyHandler ()
		{
			if (cb_getGroupKey == null)
				cb_getGroupKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGroupKey);
			return cb_getGroupKey;
		}

		static IntPtr n_GetGroupKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.GroupKey);
		}
#pragma warning restore 0169

		public virtual unsafe string? GroupKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getGroupKey' and count(parameter)=0]"
			[Register ("getGroupKey", "()Ljava/lang/String;", "GetGetGroupKeyHandler")]
			get {
				const string __id = "getGroupKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getGroupMessage;
#pragma warning disable 0169
		static Delegate GetGetGroupMessageHandler ()
		{
			if (cb_getGroupMessage == null)
				cb_getGroupMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGroupMessage);
			return cb_getGroupMessage;
		}

		static IntPtr n_GetGroupMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.GroupMessage);
		}
#pragma warning restore 0169

		public virtual unsafe string? GroupMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getGroupMessage' and count(parameter)=0]"
			[Register ("getGroupMessage", "()Ljava/lang/String;", "GetGetGroupMessageHandler")]
			get {
				const string __id = "getGroupMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getGroupedNotifications;
#pragma warning disable 0169
		static Delegate GetGetGroupedNotificationsHandler ()
		{
			if (cb_getGroupedNotifications == null)
				cb_getGroupedNotifications = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGroupedNotifications);
			return cb_getGroupedNotifications;
		}

		static IntPtr n_GetGroupedNotifications (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSNotification>.ToLocalJniHandle (__this.GroupedNotifications);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.OneSignal.Android.OSNotification>? GroupedNotifications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getGroupedNotifications' and count(parameter)=0]"
			[Register ("getGroupedNotifications", "()Ljava/util/List;", "GetGetGroupedNotificationsHandler")]
			get {
				const string __id = "getGroupedNotifications.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSNotification>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getLargeIcon;
#pragma warning disable 0169
		static Delegate GetGetLargeIconHandler ()
		{
			if (cb_getLargeIcon == null)
				cb_getLargeIcon = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLargeIcon);
			return cb_getLargeIcon;
		}

		static IntPtr n_GetLargeIcon (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LargeIcon);
		}
#pragma warning restore 0169

		public virtual unsafe string? LargeIcon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getLargeIcon' and count(parameter)=0]"
			[Register ("getLargeIcon", "()Ljava/lang/String;", "GetGetLargeIconHandler")]
			get {
				const string __id = "getLargeIcon.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getLaunchURL;
#pragma warning disable 0169
		static Delegate GetGetLaunchURLHandler ()
		{
			if (cb_getLaunchURL == null)
				cb_getLaunchURL = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLaunchURL);
			return cb_getLaunchURL;
		}

		static IntPtr n_GetLaunchURL (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LaunchURL);
		}
#pragma warning restore 0169

		public virtual unsafe string? LaunchURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getLaunchURL' and count(parameter)=0]"
			[Register ("getLaunchURL", "()Ljava/lang/String;", "GetGetLaunchURLHandler")]
			get {
				const string __id = "getLaunchURL.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getLedColor;
#pragma warning disable 0169
		static Delegate GetGetLedColorHandler ()
		{
			if (cb_getLedColor == null)
				cb_getLedColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLedColor);
			return cb_getLedColor;
		}

		static IntPtr n_GetLedColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LedColor);
		}
#pragma warning restore 0169

		public virtual unsafe string? LedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getLedColor' and count(parameter)=0]"
			[Register ("getLedColor", "()Ljava/lang/String;", "GetGetLedColorHandler")]
			get {
				const string __id = "getLedColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getLockScreenVisibility;
#pragma warning disable 0169
		static Delegate GetGetLockScreenVisibilityHandler ()
		{
			if (cb_getLockScreenVisibility == null)
				cb_getLockScreenVisibility = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLockScreenVisibility);
			return cb_getLockScreenVisibility;
		}

		static int n_GetLockScreenVisibility (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.LockScreenVisibility;
		}
#pragma warning restore 0169

		public virtual unsafe int LockScreenVisibility {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getLockScreenVisibility' and count(parameter)=0]"
			[Register ("getLockScreenVisibility", "()I", "GetGetLockScreenVisibilityHandler")]
			get {
				const string __id = "getLockScreenVisibility.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getNotificationId;
#pragma warning disable 0169
		static Delegate GetGetNotificationIdHandler ()
		{
			if (cb_getNotificationId == null)
				cb_getNotificationId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNotificationId);
			return cb_getNotificationId;
		}

		static IntPtr n_GetNotificationId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.NotificationId);
		}
#pragma warning restore 0169

		public virtual unsafe string? NotificationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getNotificationId' and count(parameter)=0]"
			[Register ("getNotificationId", "()Ljava/lang/String;", "GetGetNotificationIdHandler")]
			get {
				const string __id = "getNotificationId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getPriority;
#pragma warning disable 0169
		static Delegate GetGetPriorityHandler ()
		{
			if (cb_getPriority == null)
				cb_getPriority = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPriority);
			return cb_getPriority;
		}

		static int n_GetPriority (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Priority;
		}
#pragma warning restore 0169

		public virtual unsafe int Priority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getPriority' and count(parameter)=0]"
			[Register ("getPriority", "()I", "GetGetPriorityHandler")]
			get {
				const string __id = "getPriority.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getRawPayload;
#pragma warning disable 0169
		static Delegate GetGetRawPayloadHandler ()
		{
			if (cb_getRawPayload == null)
				cb_getRawPayload = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRawPayload);
			return cb_getRawPayload;
		}

		static IntPtr n_GetRawPayload (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.RawPayload);
		}
#pragma warning restore 0169

		public virtual unsafe string? RawPayload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getRawPayload' and count(parameter)=0]"
			[Register ("getRawPayload", "()Ljava/lang/String;", "GetGetRawPayloadHandler")]
			get {
				const string __id = "getRawPayload.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getSentTime;
#pragma warning disable 0169
		static Delegate GetGetSentTimeHandler ()
		{
			if (cb_getSentTime == null)
				cb_getSentTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSentTime);
			return cb_getSentTime;
		}

		static long n_GetSentTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SentTime;
		}
#pragma warning restore 0169

		public virtual unsafe long SentTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getSentTime' and count(parameter)=0]"
			[Register ("getSentTime", "()J", "GetGetSentTimeHandler")]
			get {
				const string __id = "getSentTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getSmallIcon;
#pragma warning disable 0169
		static Delegate GetGetSmallIconHandler ()
		{
			if (cb_getSmallIcon == null)
				cb_getSmallIcon = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSmallIcon);
			return cb_getSmallIcon;
		}

		static IntPtr n_GetSmallIcon (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SmallIcon);
		}
#pragma warning restore 0169

		public virtual unsafe string? SmallIcon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getSmallIcon' and count(parameter)=0]"
			[Register ("getSmallIcon", "()Ljava/lang/String;", "GetGetSmallIconHandler")]
			get {
				const string __id = "getSmallIcon.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getSmallIconAccentColor;
#pragma warning disable 0169
		static Delegate GetGetSmallIconAccentColorHandler ()
		{
			if (cb_getSmallIconAccentColor == null)
				cb_getSmallIconAccentColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSmallIconAccentColor);
			return cb_getSmallIconAccentColor;
		}

		static IntPtr n_GetSmallIconAccentColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SmallIconAccentColor);
		}
#pragma warning restore 0169

		public virtual unsafe string? SmallIconAccentColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getSmallIconAccentColor' and count(parameter)=0]"
			[Register ("getSmallIconAccentColor", "()Ljava/lang/String;", "GetGetSmallIconAccentColorHandler")]
			get {
				const string __id = "getSmallIconAccentColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getSound;
#pragma warning disable 0169
		static Delegate GetGetSoundHandler ()
		{
			if (cb_getSound == null)
				cb_getSound = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSound);
			return cb_getSound;
		}

		static IntPtr n_GetSound (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Sound);
		}
#pragma warning restore 0169

		public virtual unsafe string? Sound {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getSound' and count(parameter)=0]"
			[Register ("getSound", "()Ljava/lang/String;", "GetGetSoundHandler")]
			get {
				const string __id = "getSound.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getTemplateId;
#pragma warning disable 0169
		static Delegate GetGetTemplateIdHandler ()
		{
			if (cb_getTemplateId == null)
				cb_getTemplateId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTemplateId);
			return cb_getTemplateId;
		}

		static IntPtr n_GetTemplateId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.TemplateId);
		}
#pragma warning restore 0169

		public virtual unsafe string? TemplateId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getTemplateId' and count(parameter)=0]"
			[Register ("getTemplateId", "()Ljava/lang/String;", "GetGetTemplateIdHandler")]
			get {
				const string __id = "getTemplateId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getTemplateName;
#pragma warning disable 0169
		static Delegate GetGetTemplateNameHandler ()
		{
			if (cb_getTemplateName == null)
				cb_getTemplateName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTemplateName);
			return cb_getTemplateName;
		}

		static IntPtr n_GetTemplateName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.TemplateName);
		}
#pragma warning restore 0169

		public virtual unsafe string? TemplateName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getTemplateName' and count(parameter)=0]"
			[Register ("getTemplateName", "()Ljava/lang/String;", "GetGetTemplateNameHandler")]
			get {
				const string __id = "getTemplateName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public virtual unsafe string? Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getTtl;
#pragma warning disable 0169
		static Delegate GetGetTtlHandler ()
		{
			if (cb_getTtl == null)
				cb_getTtl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTtl);
			return cb_getTtl;
		}

		static int n_GetTtl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Ttl;
		}
#pragma warning restore 0169

		public virtual unsafe int Ttl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getTtl' and count(parameter)=0]"
			[Register ("getTtl", "()I", "GetGetTtlHandler")]
			get {
				const string __id = "getTtl.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getBackgroundImageLayout;
#pragma warning disable 0169
		static Delegate GetGetBackgroundImageLayoutHandler ()
		{
			if (cb_getBackgroundImageLayout == null)
				cb_getBackgroundImageLayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBackgroundImageLayout);
			return cb_getBackgroundImageLayout;
		}

		static IntPtr n_GetBackgroundImageLayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetBackgroundImageLayout ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='getBackgroundImageLayout' and count(parameter)=0]"
		[Register ("getBackgroundImageLayout", "()Lcom/onesignal/OSNotification$BackgroundImageLayout;", "GetGetBackgroundImageLayoutHandler")]
		public virtual unsafe global::Com.OneSignal.Android.OSNotification.BackgroundImageLayout? GetBackgroundImageLayout ()
		{
			const string __id = "getBackgroundImageLayout.()Lcom/onesignal/OSNotification$BackgroundImageLayout;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification.BackgroundImageLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_mutableCopy;
#pragma warning disable 0169
		static Delegate GetMutableCopyHandler ()
		{
			if (cb_mutableCopy == null)
				cb_mutableCopy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_MutableCopy);
			return cb_mutableCopy;
		}

		static IntPtr n_MutableCopy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.MutableCopy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='mutableCopy' and count(parameter)=0]"
		[Register ("mutableCopy", "()Lcom/onesignal/OSMutableNotification;", "GetMutableCopyHandler")]
		public virtual unsafe global::Com.OneSignal.Android.OSMutableNotification? MutableCopy ()
		{
			const string __id = "mutableCopy.()Lcom/onesignal/OSMutableNotification;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSMutableNotification> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_setAndroidNotificationId_I;
#pragma warning disable 0169
		static Delegate GetSetAndroidNotificationId_IHandler ()
		{
			if (cb_setAndroidNotificationId_I == null)
				cb_setAndroidNotificationId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAndroidNotificationId_I);
			return cb_setAndroidNotificationId_I;
		}

		static void n_SetAndroidNotificationId_I (IntPtr jnienv, IntPtr native__this, int androidNotificationId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.SetAndroidNotificationId (androidNotificationId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='setAndroidNotificationId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAndroidNotificationId", "(I)V", "GetSetAndroidNotificationId_IHandler")]
		protected virtual unsafe void SetAndroidNotificationId (int androidNotificationId)
		{
			const string __id = "setAndroidNotificationId.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (androidNotificationId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_toJSONObject;
#pragma warning disable 0169
		static Delegate GetToJSONObjectHandler ()
		{
			if (cb_toJSONObject == null)
				cb_toJSONObject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToJSONObject);
			return cb_toJSONObject;
		}

		static IntPtr n_ToJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSNotification']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "GetToJSONObjectHandler")]
		public virtual unsafe global::Org.Json.JSONObject? ToJSONObject ()
		{
			const string __id = "toJSONObject.()Lorg/json/JSONObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
