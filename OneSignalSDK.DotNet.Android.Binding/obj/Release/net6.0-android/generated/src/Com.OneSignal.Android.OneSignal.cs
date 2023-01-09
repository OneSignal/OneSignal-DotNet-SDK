using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']"
	[global::Android.Runtime.Register ("com/onesignal/OneSignal", DoNotGenerateAcw=true)]
	public partial class OneSignal : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/field[@name='sdkType']"
		[Register ("sdkType")]
		public static string? SdkType {
			get {
				const string __id = "sdkType.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sdkType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.AppEntryAction']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$AppEntryAction", DoNotGenerateAcw=true)]
		public sealed partial class AppEntryAction : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.AppEntryAction']/field[@name='APP_CLOSE']"
			[Register ("APP_CLOSE")]
			public static global::Com.OneSignal.Android.OneSignal.AppEntryAction? AppClose {
				get {
					const string __id = "APP_CLOSE.Lcom/onesignal/OneSignal$AppEntryAction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.AppEntryAction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.AppEntryAction']/field[@name='APP_OPEN']"
			[Register ("APP_OPEN")]
			public static global::Com.OneSignal.Android.OneSignal.AppEntryAction? AppOpen {
				get {
					const string __id = "APP_OPEN.Lcom/onesignal/OneSignal$AppEntryAction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.AppEntryAction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.AppEntryAction']/field[@name='NOTIFICATION_CLICK']"
			[Register ("NOTIFICATION_CLICK")]
			public static global::Com.OneSignal.Android.OneSignal.AppEntryAction? NotificationClick {
				get {
					const string __id = "NOTIFICATION_CLICK.Lcom/onesignal/OneSignal$AppEntryAction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.AppEntryAction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$AppEntryAction", typeof (AppEntryAction));

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

			internal AppEntryAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			public unsafe bool IsAppClose {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.AppEntryAction']/method[@name='isAppClose' and count(parameter)=0]"
				[Register ("isAppClose", "()Z", "")]
				get {
					const string __id = "isAppClose.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool IsAppOpen {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.AppEntryAction']/method[@name='isAppOpen' and count(parameter)=0]"
				[Register ("isAppOpen", "()Z", "")]
				get {
					const string __id = "isAppOpen.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool IsNotificationClick {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.AppEntryAction']/method[@name='isNotificationClick' and count(parameter)=0]"
				[Register ("isNotificationClick", "()Z", "")]
				get {
					const string __id = "isNotificationClick.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.AppEntryAction']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/onesignal/OneSignal$AppEntryAction;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.AppEntryAction? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/onesignal/OneSignal$AppEntryAction;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.AppEntryAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.AppEntryAction']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/onesignal/OneSignal$AppEntryAction;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.AppEntryAction[]? Values ()
			{
				const string __id = "values.()[Lcom/onesignal/OneSignal$AppEntryAction;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.OneSignal.Android.OneSignal.AppEntryAction[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.OneSignal.Android.OneSignal.AppEntryAction));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.ChangeTagsUpdateHandler']"
		[Register ("com/onesignal/OneSignal$ChangeTagsUpdateHandler", "", "Com.OneSignal.Android.OneSignal/IChangeTagsUpdateHandlerInvoker")]
		public partial interface IChangeTagsUpdateHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.ChangeTagsUpdateHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.SendTagsError']]"
			[Register ("onFailure", "(Lcom/onesignal/OneSignal$SendTagsError;)V", "GetOnFailure_Lcom_onesignal_OneSignal_SendTagsError_Handler:Com.OneSignal.Android.OneSignal/IChangeTagsUpdateHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnFailure (global::Com.OneSignal.Android.OneSignal.SendTagsError? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.ChangeTagsUpdateHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("onSuccess", "(Lorg/json/JSONObject;)V", "GetOnSuccess_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IChangeTagsUpdateHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnSuccess (global::Org.Json.JSONObject? p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$ChangeTagsUpdateHandler", DoNotGenerateAcw=true)]
		internal partial class IChangeTagsUpdateHandlerInvoker : global::Java.Lang.Object, IChangeTagsUpdateHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$ChangeTagsUpdateHandler", typeof (IChangeTagsUpdateHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IChangeTagsUpdateHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IChangeTagsUpdateHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.ChangeTagsUpdateHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IChangeTagsUpdateHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onFailure_Lcom_onesignal_OneSignal_SendTagsError_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_onesignal_OneSignal_SendTagsError_Handler ()
			{
				if (cb_onFailure_Lcom_onesignal_OneSignal_SendTagsError_ == null)
					cb_onFailure_Lcom_onesignal_OneSignal_SendTagsError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFailure_Lcom_onesignal_OneSignal_SendTagsError_);
				return cb_onFailure_Lcom_onesignal_OneSignal_SendTagsError_;
			}

			static void n_OnFailure_Lcom_onesignal_OneSignal_SendTagsError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IChangeTagsUpdateHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.SendTagsError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Lcom_onesignal_OneSignal_SendTagsError_;
			public unsafe void OnFailure (global::Com.OneSignal.Android.OneSignal.SendTagsError? p0)
			{
				if (id_onFailure_Lcom_onesignal_OneSignal_SendTagsError_ == IntPtr.Zero)
					id_onFailure_Lcom_onesignal_OneSignal_SendTagsError_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/onesignal/OneSignal$SendTagsError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_onesignal_OneSignal_SendTagsError_, __args);
			}

			static Delegate? cb_onSuccess_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lorg_json_JSONObject_Handler ()
			{
				if (cb_onSuccess_Lorg_json_JSONObject_ == null)
					cb_onSuccess_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lorg_json_JSONObject_);
				return cb_onSuccess_Lorg_json_JSONObject_;
			}

			static void n_OnSuccess_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IChangeTagsUpdateHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lorg_json_JSONObject_;
			public unsafe void OnSuccess (global::Org.Json.JSONObject? p0)
			{
				if (id_onSuccess_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_onSuccess_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lorg/json/JSONObject;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lorg_json_JSONObject_, __args);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.EmailErrorType']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$EmailErrorType", DoNotGenerateAcw=true)]
		public sealed partial class EmailErrorType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.EmailErrorType']/field[@name='INVALID_OPERATION']"
			[Register ("INVALID_OPERATION")]
			public static global::Com.OneSignal.Android.OneSignal.EmailErrorType? InvalidOperation {
				get {
					const string __id = "INVALID_OPERATION.Lcom/onesignal/OneSignal$EmailErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.EmailErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.EmailErrorType']/field[@name='NETWORK']"
			[Register ("NETWORK")]
			public static global::Com.OneSignal.Android.OneSignal.EmailErrorType? Network {
				get {
					const string __id = "NETWORK.Lcom/onesignal/OneSignal$EmailErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.EmailErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.EmailErrorType']/field[@name='REQUIRES_EMAIL_AUTH']"
			[Register ("REQUIRES_EMAIL_AUTH")]
			public static global::Com.OneSignal.Android.OneSignal.EmailErrorType? RequiresEmailAuth {
				get {
					const string __id = "REQUIRES_EMAIL_AUTH.Lcom/onesignal/OneSignal$EmailErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.EmailErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.EmailErrorType']/field[@name='VALIDATION']"
			[Register ("VALIDATION")]
			public static global::Com.OneSignal.Android.OneSignal.EmailErrorType? Validation {
				get {
					const string __id = "VALIDATION.Lcom/onesignal/OneSignal$EmailErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.EmailErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$EmailErrorType", typeof (EmailErrorType));

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

			internal EmailErrorType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.EmailErrorType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/onesignal/OneSignal$EmailErrorType;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.EmailErrorType? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/onesignal/OneSignal$EmailErrorType;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.EmailErrorType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.EmailErrorType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/onesignal/OneSignal$EmailErrorType;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.EmailErrorType[]? Values ()
			{
				const string __id = "values.()[Lcom/onesignal/OneSignal$EmailErrorType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.OneSignal.Android.OneSignal.EmailErrorType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.OneSignal.Android.OneSignal.EmailErrorType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.EmailUpdateError']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$EmailUpdateError", DoNotGenerateAcw=true)]
		public partial class EmailUpdateError : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$EmailUpdateError", typeof (EmailUpdateError));

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

			protected EmailUpdateError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate? cb_getMessage;
#pragma warning disable 0169
			static Delegate GetGetMessageHandler ()
			{
				if (cb_getMessage == null)
					cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
				return cb_getMessage;
			}

			static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.EmailUpdateError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Message);
			}
#pragma warning restore 0169

			public virtual unsafe string? Message {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.EmailUpdateError']/method[@name='getMessage' and count(parameter)=0]"
				[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
				get {
					const string __id = "getMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
				return cb_getType;
			}

			static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.EmailUpdateError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.Type);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.OneSignal.Android.OneSignal.EmailErrorType? Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.EmailUpdateError']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/onesignal/OneSignal$EmailErrorType;", "GetGetTypeHandler")]
				get {
					const string __id = "getType.()Lcom/onesignal/OneSignal$EmailErrorType;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.EmailErrorType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.EmailUpdateHandler']"
		[Register ("com/onesignal/OneSignal$EmailUpdateHandler", "", "Com.OneSignal.Android.OneSignal/IEmailUpdateHandlerInvoker")]
		public partial interface IEmailUpdateHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.EmailUpdateHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.EmailUpdateError']]"
			[Register ("onFailure", "(Lcom/onesignal/OneSignal$EmailUpdateError;)V", "GetOnFailure_Lcom_onesignal_OneSignal_EmailUpdateError_Handler:Com.OneSignal.Android.OneSignal/IEmailUpdateHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnFailure (global::Com.OneSignal.Android.OneSignal.EmailUpdateError? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.EmailUpdateHandler']/method[@name='onSuccess' and count(parameter)=0]"
			[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.OneSignal.Android.OneSignal/IEmailUpdateHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnSuccess ();

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$EmailUpdateHandler", DoNotGenerateAcw=true)]
		internal partial class IEmailUpdateHandlerInvoker : global::Java.Lang.Object, IEmailUpdateHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$EmailUpdateHandler", typeof (IEmailUpdateHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IEmailUpdateHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEmailUpdateHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.EmailUpdateHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEmailUpdateHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onFailure_Lcom_onesignal_OneSignal_EmailUpdateError_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_onesignal_OneSignal_EmailUpdateError_Handler ()
			{
				if (cb_onFailure_Lcom_onesignal_OneSignal_EmailUpdateError_ == null)
					cb_onFailure_Lcom_onesignal_OneSignal_EmailUpdateError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFailure_Lcom_onesignal_OneSignal_EmailUpdateError_);
				return cb_onFailure_Lcom_onesignal_OneSignal_EmailUpdateError_;
			}

			static void n_OnFailure_Lcom_onesignal_OneSignal_EmailUpdateError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IEmailUpdateHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.EmailUpdateError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Lcom_onesignal_OneSignal_EmailUpdateError_;
			public unsafe void OnFailure (global::Com.OneSignal.Android.OneSignal.EmailUpdateError? p0)
			{
				if (id_onFailure_Lcom_onesignal_OneSignal_EmailUpdateError_ == IntPtr.Zero)
					id_onFailure_Lcom_onesignal_OneSignal_EmailUpdateError_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/onesignal/OneSignal$EmailUpdateError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_onesignal_OneSignal_EmailUpdateError_, __args);
			}

			static Delegate? cb_onSuccess;
#pragma warning disable 0169
			static Delegate GetOnSuccessHandler ()
			{
				if (cb_onSuccess == null)
					cb_onSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSuccess);
				return cb_onSuccess;
			}

			static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IEmailUpdateHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnSuccess ();
			}
#pragma warning restore 0169

			IntPtr id_onSuccess;
			public unsafe void OnSuccess ()
			{
				if (id_onSuccess == IntPtr.Zero)
					id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.ExternalIdError']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$ExternalIdError", DoNotGenerateAcw=true)]
		public partial class ExternalIdError : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$ExternalIdError", typeof (ExternalIdError));

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

			protected ExternalIdError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate? cb_getMessage;
#pragma warning disable 0169
			static Delegate GetGetMessageHandler ()
			{
				if (cb_getMessage == null)
					cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
				return cb_getMessage;
			}

			static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.ExternalIdError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Message);
			}
#pragma warning restore 0169

			public virtual unsafe string? Message {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.ExternalIdError']/method[@name='getMessage' and count(parameter)=0]"
				[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
				get {
					const string __id = "getMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
				return cb_getType;
			}

			static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.ExternalIdError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.Type);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType? Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.ExternalIdError']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/onesignal/OneSignal$ExternalIdErrorType;", "GetGetTypeHandler")]
				get {
					const string __id = "getType.()Lcom/onesignal/OneSignal$ExternalIdErrorType;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.ExternalIdErrorType']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$ExternalIdErrorType", DoNotGenerateAcw=true)]
		public sealed partial class ExternalIdErrorType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.ExternalIdErrorType']/field[@name='INVALID_OPERATION']"
			[Register ("INVALID_OPERATION")]
			public static global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType? InvalidOperation {
				get {
					const string __id = "INVALID_OPERATION.Lcom/onesignal/OneSignal$ExternalIdErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.ExternalIdErrorType']/field[@name='NETWORK']"
			[Register ("NETWORK")]
			public static global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType? Network {
				get {
					const string __id = "NETWORK.Lcom/onesignal/OneSignal$ExternalIdErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.ExternalIdErrorType']/field[@name='REQUIRES_EXTERNAL_ID_AUTH']"
			[Register ("REQUIRES_EXTERNAL_ID_AUTH")]
			public static global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType? RequiresExternalIdAuth {
				get {
					const string __id = "REQUIRES_EXTERNAL_ID_AUTH.Lcom/onesignal/OneSignal$ExternalIdErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$ExternalIdErrorType", typeof (ExternalIdErrorType));

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

			internal ExternalIdErrorType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.ExternalIdErrorType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/onesignal/OneSignal$ExternalIdErrorType;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/onesignal/OneSignal$ExternalIdErrorType;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.ExternalIdErrorType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/onesignal/OneSignal$ExternalIdErrorType;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType[]? Values ()
			{
				const string __id = "values.()[Lcom/onesignal/OneSignal$ExternalIdErrorType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.OneSignal.Android.OneSignal.ExternalIdErrorType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$LOG_LEVEL", DoNotGenerateAcw=true)]
		public sealed partial class LOG_LEVEL : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='DEBUG']"
			[Register ("DEBUG")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? Debug {
				get {
					const string __id = "DEBUG.Lcom/onesignal/OneSignal$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? Error {
				get {
					const string __id = "ERROR.Lcom/onesignal/OneSignal$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='FATAL']"
			[Register ("FATAL")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? Fatal {
				get {
					const string __id = "FATAL.Lcom/onesignal/OneSignal$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? Info {
				get {
					const string __id = "INFO.Lcom/onesignal/OneSignal$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? None {
				get {
					const string __id = "NONE.Lcom/onesignal/OneSignal$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='VERBOSE']"
			[Register ("VERBOSE")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? Verbose {
				get {
					const string __id = "VERBOSE.Lcom/onesignal/OneSignal$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='WARN']"
			[Register ("WARN")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? Warn {
				get {
					const string __id = "WARN.Lcom/onesignal/OneSignal$LOG_LEVEL;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$LOG_LEVEL", typeof (LOG_LEVEL));

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

			internal LOG_LEVEL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/onesignal/OneSignal$LOG_LEVEL;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/onesignal/OneSignal$LOG_LEVEL;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/onesignal/OneSignal$LOG_LEVEL;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.LOG_LEVEL[]? Values ()
			{
				const string __id = "values.()[Lcom/onesignal/OneSignal$LOG_LEVEL;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.OneSignal.Android.OneSignal.LOG_LEVEL[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.OneSignal.Android.OneSignal.LOG_LEVEL));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSExternalUserIdUpdateCompletionHandler']"
		[Register ("com/onesignal/OneSignal$OSExternalUserIdUpdateCompletionHandler", "", "Com.OneSignal.Android.OneSignal/IOSExternalUserIdUpdateCompletionHandlerInvoker")]
		public partial interface IOSExternalUserIdUpdateCompletionHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSExternalUserIdUpdateCompletionHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.ExternalIdError']]"
			[Register ("onFailure", "(Lcom/onesignal/OneSignal$ExternalIdError;)V", "GetOnFailure_Lcom_onesignal_OneSignal_ExternalIdError_Handler:Com.OneSignal.Android.OneSignal/IOSExternalUserIdUpdateCompletionHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnFailure (global::Com.OneSignal.Android.OneSignal.ExternalIdError? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSExternalUserIdUpdateCompletionHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("onSuccess", "(Lorg/json/JSONObject;)V", "GetOnSuccess_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IOSExternalUserIdUpdateCompletionHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnSuccess (global::Org.Json.JSONObject? p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OSExternalUserIdUpdateCompletionHandler", DoNotGenerateAcw=true)]
		internal partial class IOSExternalUserIdUpdateCompletionHandlerInvoker : global::Java.Lang.Object, IOSExternalUserIdUpdateCompletionHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OSExternalUserIdUpdateCompletionHandler", typeof (IOSExternalUserIdUpdateCompletionHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOSExternalUserIdUpdateCompletionHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOSExternalUserIdUpdateCompletionHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.OSExternalUserIdUpdateCompletionHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOSExternalUserIdUpdateCompletionHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onFailure_Lcom_onesignal_OneSignal_ExternalIdError_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_onesignal_OneSignal_ExternalIdError_Handler ()
			{
				if (cb_onFailure_Lcom_onesignal_OneSignal_ExternalIdError_ == null)
					cb_onFailure_Lcom_onesignal_OneSignal_ExternalIdError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFailure_Lcom_onesignal_OneSignal_ExternalIdError_);
				return cb_onFailure_Lcom_onesignal_OneSignal_ExternalIdError_;
			}

			static void n_OnFailure_Lcom_onesignal_OneSignal_ExternalIdError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSExternalUserIdUpdateCompletionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.ExternalIdError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Lcom_onesignal_OneSignal_ExternalIdError_;
			public unsafe void OnFailure (global::Com.OneSignal.Android.OneSignal.ExternalIdError? p0)
			{
				if (id_onFailure_Lcom_onesignal_OneSignal_ExternalIdError_ == IntPtr.Zero)
					id_onFailure_Lcom_onesignal_OneSignal_ExternalIdError_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/onesignal/OneSignal$ExternalIdError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_onesignal_OneSignal_ExternalIdError_, __args);
			}

			static Delegate? cb_onSuccess_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lorg_json_JSONObject_Handler ()
			{
				if (cb_onSuccess_Lorg_json_JSONObject_ == null)
					cb_onSuccess_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lorg_json_JSONObject_);
				return cb_onSuccess_Lorg_json_JSONObject_;
			}

			static void n_OnSuccess_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSExternalUserIdUpdateCompletionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lorg_json_JSONObject_;
			public unsafe void OnSuccess (global::Org.Json.JSONObject? p0)
			{
				if (id_onSuccess_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_onSuccess_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lorg/json/JSONObject;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lorg_json_JSONObject_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSGetTagsHandler']"
		[Register ("com/onesignal/OneSignal$OSGetTagsHandler", "", "Com.OneSignal.Android.OneSignal/IOSGetTagsHandlerInvoker")]
		public partial interface IOSGetTagsHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSGetTagsHandler']/method[@name='tagsAvailable' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("tagsAvailable", "(Lorg/json/JSONObject;)V", "GetTagsAvailable_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IOSGetTagsHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void TagsAvailable (global::Org.Json.JSONObject? p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OSGetTagsHandler", DoNotGenerateAcw=true)]
		internal partial class IOSGetTagsHandlerInvoker : global::Java.Lang.Object, IOSGetTagsHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OSGetTagsHandler", typeof (IOSGetTagsHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOSGetTagsHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOSGetTagsHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.OSGetTagsHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOSGetTagsHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_tagsAvailable_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetTagsAvailable_Lorg_json_JSONObject_Handler ()
			{
				if (cb_tagsAvailable_Lorg_json_JSONObject_ == null)
					cb_tagsAvailable_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_TagsAvailable_Lorg_json_JSONObject_);
				return cb_tagsAvailable_Lorg_json_JSONObject_;
			}

			static void n_TagsAvailable_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSGetTagsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.TagsAvailable (p0);
			}
#pragma warning restore 0169

			IntPtr id_tagsAvailable_Lorg_json_JSONObject_;
			public unsafe void TagsAvailable (global::Org.Json.JSONObject? p0)
			{
				if (id_tagsAvailable_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_tagsAvailable_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "tagsAvailable", "(Lorg/json/JSONObject;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_tagsAvailable_Lorg_json_JSONObject_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSInAppMessageClickHandler']"
		[Register ("com/onesignal/OneSignal$OSInAppMessageClickHandler", "", "Com.OneSignal.Android.OneSignal/IOSInAppMessageClickHandlerInvoker")]
		public partial interface IOSInAppMessageClickHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSInAppMessageClickHandler']/method[@name='inAppMessageClicked' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSInAppMessageAction']]"
			[Register ("inAppMessageClicked", "(Lcom/onesignal/OSInAppMessageAction;)V", "GetInAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_Handler:Com.OneSignal.Android.OneSignal/IOSInAppMessageClickHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void InAppMessageClicked (global::Com.OneSignal.Android.OSInAppMessageAction? p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OSInAppMessageClickHandler", DoNotGenerateAcw=true)]
		internal partial class IOSInAppMessageClickHandlerInvoker : global::Java.Lang.Object, IOSInAppMessageClickHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OSInAppMessageClickHandler", typeof (IOSInAppMessageClickHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOSInAppMessageClickHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOSInAppMessageClickHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.OSInAppMessageClickHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOSInAppMessageClickHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_inAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_;
#pragma warning disable 0169
			static Delegate GetInAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_Handler ()
			{
				if (cb_inAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_ == null)
					cb_inAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_);
				return cb_inAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_;
			}

			static void n_InAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSInAppMessageClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.InAppMessageClicked (p0);
			}
#pragma warning restore 0169

			IntPtr id_inAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_;
			public unsafe void InAppMessageClicked (global::Com.OneSignal.Android.OSInAppMessageAction? p0)
			{
				if (id_inAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_ == IntPtr.Zero)
					id_inAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_ = JNIEnv.GetMethodID (class_ref, "inAppMessageClicked", "(Lcom/onesignal/OSInAppMessageAction;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inAppMessageClicked_Lcom_onesignal_OSInAppMessageAction_, __args);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.OSLanguageError']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OSLanguageError", DoNotGenerateAcw=true)]
		public partial class OSLanguageError : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OSLanguageError", typeof (OSLanguageError));

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

			protected OSLanguageError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate? cb_getCode;
#pragma warning disable 0169
			static Delegate GetGetCodeHandler ()
			{
				if (cb_getCode == null)
					cb_getCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCode);
				return cb_getCode;
			}

			static int n_GetCode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.OSLanguageError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Code;
			}
#pragma warning restore 0169

			public virtual unsafe int Code {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.OSLanguageError']/method[@name='getCode' and count(parameter)=0]"
				[Register ("getCode", "()I", "GetGetCodeHandler")]
				get {
					const string __id = "getCode.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getMessage;
#pragma warning disable 0169
			static Delegate GetGetMessageHandler ()
			{
				if (cb_getMessage == null)
					cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
				return cb_getMessage;
			}

			static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.OSLanguageError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Message);
			}
#pragma warning restore 0169

			public virtual unsafe string? Message {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.OSLanguageError']/method[@name='getMessage' and count(parameter)=0]"
				[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
				get {
					const string __id = "getMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSNotificationOpenedHandler']"
		[Register ("com/onesignal/OneSignal$OSNotificationOpenedHandler", "", "Com.OneSignal.Android.OneSignal/IOSNotificationOpenedHandlerInvoker")]
		public partial interface IOSNotificationOpenedHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSNotificationOpenedHandler']/method[@name='notificationOpened' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSNotificationOpenedResult']]"
			[Register ("notificationOpened", "(Lcom/onesignal/OSNotificationOpenedResult;)V", "GetNotificationOpened_Lcom_onesignal_OSNotificationOpenedResult_Handler:Com.OneSignal.Android.OneSignal/IOSNotificationOpenedHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void NotificationOpened (global::Com.OneSignal.Android.OSNotificationOpenedResult? p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OSNotificationOpenedHandler", DoNotGenerateAcw=true)]
		internal partial class IOSNotificationOpenedHandlerInvoker : global::Java.Lang.Object, IOSNotificationOpenedHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OSNotificationOpenedHandler", typeof (IOSNotificationOpenedHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOSNotificationOpenedHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOSNotificationOpenedHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.OSNotificationOpenedHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOSNotificationOpenedHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_notificationOpened_Lcom_onesignal_OSNotificationOpenedResult_;
#pragma warning disable 0169
			static Delegate GetNotificationOpened_Lcom_onesignal_OSNotificationOpenedResult_Handler ()
			{
				if (cb_notificationOpened_Lcom_onesignal_OSNotificationOpenedResult_ == null)
					cb_notificationOpened_Lcom_onesignal_OSNotificationOpenedResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_NotificationOpened_Lcom_onesignal_OSNotificationOpenedResult_);
				return cb_notificationOpened_Lcom_onesignal_OSNotificationOpenedResult_;
			}

			static void n_NotificationOpened_Lcom_onesignal_OSNotificationOpenedResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSNotificationOpenedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationOpenedResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NotificationOpened (p0);
			}
#pragma warning restore 0169

			IntPtr id_notificationOpened_Lcom_onesignal_OSNotificationOpenedResult_;
			public unsafe void NotificationOpened (global::Com.OneSignal.Android.OSNotificationOpenedResult? p0)
			{
				if (id_notificationOpened_Lcom_onesignal_OSNotificationOpenedResult_ == IntPtr.Zero)
					id_notificationOpened_Lcom_onesignal_OSNotificationOpenedResult_ = JNIEnv.GetMethodID (class_ref, "notificationOpened", "(Lcom/onesignal/OSNotificationOpenedResult;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notificationOpened_Lcom_onesignal_OSNotificationOpenedResult_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSNotificationWillShowInForegroundHandler']"
		[Register ("com/onesignal/OneSignal$OSNotificationWillShowInForegroundHandler", "", "Com.OneSignal.Android.OneSignal/IOSNotificationWillShowInForegroundHandlerInvoker")]
		public partial interface IOSNotificationWillShowInForegroundHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSNotificationWillShowInForegroundHandler']/method[@name='notificationWillShowInForeground' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSNotificationReceivedEvent']]"
			[Register ("notificationWillShowInForeground", "(Lcom/onesignal/OSNotificationReceivedEvent;)V", "GetNotificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_Handler:Com.OneSignal.Android.OneSignal/IOSNotificationWillShowInForegroundHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void NotificationWillShowInForeground (global::Com.OneSignal.Android.OSNotificationReceivedEvent? p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OSNotificationWillShowInForegroundHandler", DoNotGenerateAcw=true)]
		internal partial class IOSNotificationWillShowInForegroundHandlerInvoker : global::Java.Lang.Object, IOSNotificationWillShowInForegroundHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OSNotificationWillShowInForegroundHandler", typeof (IOSNotificationWillShowInForegroundHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOSNotificationWillShowInForegroundHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOSNotificationWillShowInForegroundHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.OSNotificationWillShowInForegroundHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOSNotificationWillShowInForegroundHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_notificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_;
#pragma warning disable 0169
			static Delegate GetNotificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_Handler ()
			{
				if (cb_notificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_ == null)
					cb_notificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_NotificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_);
				return cb_notificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_;
			}

			static void n_NotificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSNotificationWillShowInForegroundHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationReceivedEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NotificationWillShowInForeground (p0);
			}
#pragma warning restore 0169

			IntPtr id_notificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_;
			public unsafe void NotificationWillShowInForeground (global::Com.OneSignal.Android.OSNotificationReceivedEvent? p0)
			{
				if (id_notificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_ == IntPtr.Zero)
					id_notificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_ = JNIEnv.GetMethodID (class_ref, "notificationWillShowInForeground", "(Lcom/onesignal/OSNotificationReceivedEvent;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notificationWillShowInForeground_Lcom_onesignal_OSNotificationReceivedEvent_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSRemoteNotificationReceivedHandler']"
		[Register ("com/onesignal/OneSignal$OSRemoteNotificationReceivedHandler", "", "Com.OneSignal.Android.OneSignal/IOSRemoteNotificationReceivedHandlerInvoker")]
		public partial interface IOSRemoteNotificationReceivedHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSRemoteNotificationReceivedHandler']/method[@name='remoteNotificationReceived' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.onesignal.OSNotificationReceivedEvent']]"
			[Register ("remoteNotificationReceived", "(Landroid/content/Context;Lcom/onesignal/OSNotificationReceivedEvent;)V", "GetRemoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_Handler:Com.OneSignal.Android.OneSignal/IOSRemoteNotificationReceivedHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void RemoteNotificationReceived (global::Android.Content.Context? p0, global::Com.OneSignal.Android.OSNotificationReceivedEvent? p1);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OSRemoteNotificationReceivedHandler", DoNotGenerateAcw=true)]
		internal partial class IOSRemoteNotificationReceivedHandlerInvoker : global::Java.Lang.Object, IOSRemoteNotificationReceivedHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OSRemoteNotificationReceivedHandler", typeof (IOSRemoteNotificationReceivedHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOSRemoteNotificationReceivedHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOSRemoteNotificationReceivedHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.OSRemoteNotificationReceivedHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOSRemoteNotificationReceivedHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_remoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_;
#pragma warning disable 0169
			static Delegate GetRemoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_Handler ()
			{
				if (cb_remoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_ == null)
					cb_remoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RemoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_);
				return cb_remoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_;
			}

			static void n_RemoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSRemoteNotificationReceivedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSNotificationReceivedEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.RemoteNotificationReceived (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_remoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_;
			public unsafe void RemoteNotificationReceived (global::Android.Content.Context? p0, global::Com.OneSignal.Android.OSNotificationReceivedEvent? p1)
			{
				if (id_remoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_ == IntPtr.Zero)
					id_remoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_ = JNIEnv.GetMethodID (class_ref, "remoteNotificationReceived", "(Landroid/content/Context;Lcom/onesignal/OSNotificationReceivedEvent;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remoteNotificationReceived_Landroid_content_Context_Lcom_onesignal_OSNotificationReceivedEvent_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSSetLanguageCompletionHandler']"
		[Register ("com/onesignal/OneSignal$OSSetLanguageCompletionHandler", "", "Com.OneSignal.Android.OneSignal/IOSSetLanguageCompletionHandlerInvoker")]
		public partial interface IOSSetLanguageCompletionHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSSetLanguageCompletionHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.OSLanguageError']]"
			[Register ("onFailure", "(Lcom/onesignal/OneSignal$OSLanguageError;)V", "GetOnFailure_Lcom_onesignal_OneSignal_OSLanguageError_Handler:Com.OneSignal.Android.OneSignal/IOSSetLanguageCompletionHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnFailure (global::Com.OneSignal.Android.OneSignal.OSLanguageError? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSSetLanguageCompletionHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.OneSignal.Android.OneSignal/IOSSetLanguageCompletionHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnSuccess (string? p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OSSetLanguageCompletionHandler", DoNotGenerateAcw=true)]
		internal partial class IOSSetLanguageCompletionHandlerInvoker : global::Java.Lang.Object, IOSSetLanguageCompletionHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OSSetLanguageCompletionHandler", typeof (IOSSetLanguageCompletionHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOSSetLanguageCompletionHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOSSetLanguageCompletionHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.OSSetLanguageCompletionHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOSSetLanguageCompletionHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onFailure_Lcom_onesignal_OneSignal_OSLanguageError_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_onesignal_OneSignal_OSLanguageError_Handler ()
			{
				if (cb_onFailure_Lcom_onesignal_OneSignal_OSLanguageError_ == null)
					cb_onFailure_Lcom_onesignal_OneSignal_OSLanguageError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFailure_Lcom_onesignal_OneSignal_OSLanguageError_);
				return cb_onFailure_Lcom_onesignal_OneSignal_OSLanguageError_;
			}

			static void n_OnFailure_Lcom_onesignal_OneSignal_OSLanguageError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSSetLanguageCompletionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.OSLanguageError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Lcom_onesignal_OneSignal_OSLanguageError_;
			public unsafe void OnFailure (global::Com.OneSignal.Android.OneSignal.OSLanguageError? p0)
			{
				if (id_onFailure_Lcom_onesignal_OneSignal_OSLanguageError_ == IntPtr.Zero)
					id_onFailure_Lcom_onesignal_OneSignal_OSLanguageError_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/onesignal/OneSignal$OSLanguageError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_onesignal_OneSignal_OSLanguageError_, __args);
			}

			static Delegate? cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
			{
				if (cb_onSuccess_Ljava_lang_String_ == null)
					cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_lang_String_);
				return cb_onSuccess_Ljava_lang_String_;
			}

			static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSSetLanguageCompletionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Ljava_lang_String_;
			public unsafe void OnSuccess (string? p0)
			{
				if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
					id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.OSSMSUpdateError']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OSSMSUpdateError", DoNotGenerateAcw=true)]
		public partial class OSSMSUpdateError : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OSSMSUpdateError", typeof (OSSMSUpdateError));

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

			protected OSSMSUpdateError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate? cb_getMessage;
#pragma warning disable 0169
			static Delegate GetGetMessageHandler ()
			{
				if (cb_getMessage == null)
					cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
				return cb_getMessage;
			}

			static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.OSSMSUpdateError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Message);
			}
#pragma warning restore 0169

			public virtual unsafe string? Message {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.OSSMSUpdateError']/method[@name='getMessage' and count(parameter)=0]"
				[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
				get {
					const string __id = "getMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate? cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
				return cb_getType;
			}

			static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.OSSMSUpdateError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.ToLocalJniHandle (__this.Type);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.OneSignal.Android.OneSignal.SMSErrorType? Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.OSSMSUpdateError']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/onesignal/OneSignal$SMSErrorType;", "GetGetTypeHandler")]
				get {
					const string __id = "getType.()Lcom/onesignal/OneSignal$SMSErrorType;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.SMSErrorType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSSMSUpdateHandler']"
		[Register ("com/onesignal/OneSignal$OSSMSUpdateHandler", "", "Com.OneSignal.Android.OneSignal/IOSSMSUpdateHandlerInvoker")]
		public partial interface IOSSMSUpdateHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSSMSUpdateHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.OSSMSUpdateError']]"
			[Register ("onFailure", "(Lcom/onesignal/OneSignal$OSSMSUpdateError;)V", "GetOnFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_Handler:Com.OneSignal.Android.OneSignal/IOSSMSUpdateHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnFailure (global::Com.OneSignal.Android.OneSignal.OSSMSUpdateError? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OSSMSUpdateHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("onSuccess", "(Lorg/json/JSONObject;)V", "GetOnSuccess_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IOSSMSUpdateHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnSuccess (global::Org.Json.JSONObject? p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OSSMSUpdateHandler", DoNotGenerateAcw=true)]
		internal partial class IOSSMSUpdateHandlerInvoker : global::Java.Lang.Object, IOSSMSUpdateHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OSSMSUpdateHandler", typeof (IOSSMSUpdateHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOSSMSUpdateHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOSSMSUpdateHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.OSSMSUpdateHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOSSMSUpdateHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_Handler ()
			{
				if (cb_onFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_ == null)
					cb_onFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_);
				return cb_onFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_;
			}

			static void n_OnFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSSMSUpdateHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.OSSMSUpdateError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_;
			public unsafe void OnFailure (global::Com.OneSignal.Android.OneSignal.OSSMSUpdateError? p0)
			{
				if (id_onFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_ == IntPtr.Zero)
					id_onFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/onesignal/OneSignal$OSSMSUpdateError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_onesignal_OneSignal_OSSMSUpdateError_, __args);
			}

			static Delegate? cb_onSuccess_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lorg_json_JSONObject_Handler ()
			{
				if (cb_onSuccess_Lorg_json_JSONObject_ == null)
					cb_onSuccess_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lorg_json_JSONObject_);
				return cb_onSuccess_Lorg_json_JSONObject_;
			}

			static void n_OnSuccess_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOSSMSUpdateHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lorg_json_JSONObject_;
			public unsafe void OnSuccess (global::Org.Json.JSONObject? p0)
			{
				if (id_onSuccess_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_onSuccess_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lorg/json/JSONObject;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lorg_json_JSONObject_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OutcomeCallback']"
		[Register ("com/onesignal/OneSignal$OutcomeCallback", "", "Com.OneSignal.Android.OneSignal/IOutcomeCallbackInvoker")]
		public partial interface IOutcomeCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.OutcomeCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSOutcomeEvent']]"
			[Register ("onSuccess", "(Lcom/onesignal/OSOutcomeEvent;)V", "GetOnSuccess_Lcom_onesignal_OSOutcomeEvent_Handler:Com.OneSignal.Android.OneSignal/IOutcomeCallbackInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnSuccess (global::Com.OneSignal.Android.OSOutcomeEvent? p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$OutcomeCallback", DoNotGenerateAcw=true)]
		internal partial class IOutcomeCallbackInvoker : global::Java.Lang.Object, IOutcomeCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$OutcomeCallback", typeof (IOutcomeCallbackInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOutcomeCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOutcomeCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.OutcomeCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOutcomeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onSuccess_Lcom_onesignal_OSOutcomeEvent_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lcom_onesignal_OSOutcomeEvent_Handler ()
			{
				if (cb_onSuccess_Lcom_onesignal_OSOutcomeEvent_ == null)
					cb_onSuccess_Lcom_onesignal_OSOutcomeEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_onesignal_OSOutcomeEvent_);
				return cb_onSuccess_Lcom_onesignal_OSOutcomeEvent_;
			}

			static void n_OnSuccess_Lcom_onesignal_OSOutcomeEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IOutcomeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSOutcomeEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lcom_onesignal_OSOutcomeEvent_;
			public unsafe void OnSuccess (global::Com.OneSignal.Android.OSOutcomeEvent? p0)
			{
				if (id_onSuccess_Lcom_onesignal_OSOutcomeEvent_ == IntPtr.Zero)
					id_onSuccess_Lcom_onesignal_OSOutcomeEvent_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/onesignal/OSOutcomeEvent;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_onesignal_OSOutcomeEvent_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.PostNotificationResponseHandler']"
		[Register ("com/onesignal/OneSignal$PostNotificationResponseHandler", "", "Com.OneSignal.Android.OneSignal/IPostNotificationResponseHandlerInvoker")]
		public partial interface IPostNotificationResponseHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.PostNotificationResponseHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("onFailure", "(Lorg/json/JSONObject;)V", "GetOnFailure_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IPostNotificationResponseHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnFailure (global::Org.Json.JSONObject? p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.PostNotificationResponseHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("onSuccess", "(Lorg/json/JSONObject;)V", "GetOnSuccess_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IPostNotificationResponseHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void OnSuccess (global::Org.Json.JSONObject? p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$PostNotificationResponseHandler", DoNotGenerateAcw=true)]
		internal partial class IPostNotificationResponseHandlerInvoker : global::Java.Lang.Object, IPostNotificationResponseHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$PostNotificationResponseHandler", typeof (IPostNotificationResponseHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IPostNotificationResponseHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPostNotificationResponseHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.PostNotificationResponseHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPostNotificationResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onFailure_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lorg_json_JSONObject_Handler ()
			{
				if (cb_onFailure_Lorg_json_JSONObject_ == null)
					cb_onFailure_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFailure_Lorg_json_JSONObject_);
				return cb_onFailure_Lorg_json_JSONObject_;
			}

			static void n_OnFailure_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Lorg_json_JSONObject_;
			public unsafe void OnFailure (global::Org.Json.JSONObject? p0)
			{
				if (id_onFailure_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_onFailure_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lorg/json/JSONObject;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lorg_json_JSONObject_, __args);
			}

			static Delegate? cb_onSuccess_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lorg_json_JSONObject_Handler ()
			{
				if (cb_onSuccess_Lorg_json_JSONObject_ == null)
					cb_onSuccess_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lorg_json_JSONObject_);
				return cb_onSuccess_Lorg_json_JSONObject_;
			}

			static void n_OnSuccess_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lorg_json_JSONObject_;
			public unsafe void OnSuccess (global::Org.Json.JSONObject? p0)
			{
				if (id_onSuccess_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_onSuccess_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lorg/json/JSONObject;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lorg_json_JSONObject_, __args);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.PromptForPushNotificationPermissionResponseHandler']"
		[Register ("com/onesignal/OneSignal$PromptForPushNotificationPermissionResponseHandler", "", "Com.OneSignal.Android.OneSignal/IPromptForPushNotificationPermissionResponseHandlerInvoker")]
		public partial interface IPromptForPushNotificationPermissionResponseHandler : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.PromptForPushNotificationPermissionResponseHandler']/method[@name='response' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("response", "(Z)V", "GetResponse_ZHandler:Com.OneSignal.Android.OneSignal/IPromptForPushNotificationPermissionResponseHandlerInvoker, OneSignalSDK.DotNet.Android.Binding")]
			void Response (bool p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$PromptForPushNotificationPermissionResponseHandler", DoNotGenerateAcw=true)]
		internal partial class IPromptForPushNotificationPermissionResponseHandlerInvoker : global::Java.Lang.Object, IPromptForPushNotificationPermissionResponseHandler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$PromptForPushNotificationPermissionResponseHandler", typeof (IPromptForPushNotificationPermissionResponseHandlerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IPromptForPushNotificationPermissionResponseHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPromptForPushNotificationPermissionResponseHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignal.PromptForPushNotificationPermissionResponseHandler'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPromptForPushNotificationPermissionResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_response_Z;
#pragma warning disable 0169
			static Delegate GetResponse_ZHandler ()
			{
				if (cb_response_Z == null)
					cb_response_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Response_Z);
				return cb_response_Z;
			}

			static void n_Response_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IPromptForPushNotificationPermissionResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.Response (p0);
			}
#pragma warning restore 0169

			IntPtr id_response_Z;
			public unsafe void Response (bool p0)
			{
				if (id_response_Z == IntPtr.Zero)
					id_response_Z = JNIEnv.GetMethodID (class_ref, "response", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_response_Z, __args);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.SendTagsError']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$SendTagsError", DoNotGenerateAcw=true)]
		public partial class SendTagsError : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$SendTagsError", typeof (SendTagsError));

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

			protected SendTagsError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate? cb_getCode;
#pragma warning disable 0169
			static Delegate GetGetCodeHandler ()
			{
				if (cb_getCode == null)
					cb_getCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCode);
				return cb_getCode;
			}

			static int n_GetCode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.SendTagsError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return __this.Code;
			}
#pragma warning restore 0169

			public virtual unsafe int Code {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.SendTagsError']/method[@name='getCode' and count(parameter)=0]"
				[Register ("getCode", "()I", "GetGetCodeHandler")]
				get {
					const string __id = "getCode.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate? cb_getMessage;
#pragma warning disable 0169
			static Delegate GetGetMessageHandler ()
			{
				if (cb_getMessage == null)
					cb_getMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMessage);
				return cb_getMessage;
			}

			static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.SendTagsError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				return JNIEnv.NewString (__this.Message);
			}
#pragma warning restore 0169

			public virtual unsafe string? Message {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.SendTagsError']/method[@name='getMessage' and count(parameter)=0]"
				[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
				get {
					const string __id = "getMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.SMSErrorType']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$SMSErrorType", DoNotGenerateAcw=true)]
		public sealed partial class SMSErrorType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.SMSErrorType']/field[@name='INVALID_OPERATION']"
			[Register ("INVALID_OPERATION")]
			public static global::Com.OneSignal.Android.OneSignal.SMSErrorType? InvalidOperation {
				get {
					const string __id = "INVALID_OPERATION.Lcom/onesignal/OneSignal$SMSErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.SMSErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.SMSErrorType']/field[@name='NETWORK']"
			[Register ("NETWORK")]
			public static global::Com.OneSignal.Android.OneSignal.SMSErrorType? Network {
				get {
					const string __id = "NETWORK.Lcom/onesignal/OneSignal$SMSErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.SMSErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.SMSErrorType']/field[@name='REQUIRES_SMS_AUTH']"
			[Register ("REQUIRES_SMS_AUTH")]
			public static global::Com.OneSignal.Android.OneSignal.SMSErrorType? RequiresSmsAuth {
				get {
					const string __id = "REQUIRES_SMS_AUTH.Lcom/onesignal/OneSignal$SMSErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.SMSErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.SMSErrorType']/field[@name='VALIDATION']"
			[Register ("VALIDATION")]
			public static global::Com.OneSignal.Android.OneSignal.SMSErrorType? Validation {
				get {
					const string __id = "VALIDATION.Lcom/onesignal/OneSignal$SMSErrorType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.SMSErrorType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal$SMSErrorType", typeof (SMSErrorType));

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

			internal SMSErrorType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.SMSErrorType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/onesignal/OneSignal$SMSErrorType;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.SMSErrorType? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/onesignal/OneSignal$SMSErrorType;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.SMSErrorType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.SMSErrorType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/onesignal/OneSignal$SMSErrorType;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.SMSErrorType[]? Values ()
			{
				const string __id = "values.()[Lcom/onesignal/OneSignal$SMSErrorType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.OneSignal.Android.OneSignal.SMSErrorType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.OneSignal.Android.OneSignal.SMSErrorType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignal", typeof (OneSignal));

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

		protected OneSignal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/constructor[@name='OneSignal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OneSignal () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.OneSignal.Android.OSDeviceState? DeviceState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='getDeviceState' and count(parameter)=0]"
			[Register ("getDeviceState", "()Lcom/onesignal/OSDeviceState;", "")]
			get {
				const string __id = "getDeviceState.()Lcom/onesignal/OSDeviceState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSDeviceState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool IsInAppMessagingPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='isInAppMessagingPaused' and count(parameter)=0]"
			[Register ("isInAppMessagingPaused", "()Z", "")]
			get {
				const string __id = "isInAppMessagingPaused.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool LocationShared {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='isLocationShared' and count(parameter)=0]"
			[Register ("isLocationShared", "()Z", "")]
			get {
				const string __id = "isLocationShared.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setLocationShared' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLocationShared", "(Z)V", "")]
			set {
				const string __id = "setLocationShared.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe string? SdkVersionRaw {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='getSdkVersionRaw' and count(parameter)=0]"
			[Register ("getSdkVersionRaw", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSdkVersionRaw.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? Triggers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='getTriggers' and count(parameter)=0]"
			[Register ("getTriggers", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getTriggers.()Ljava/util/Map;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='addEmailSubscriptionObserver' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSEmailSubscriptionObserver']]"
		[Register ("addEmailSubscriptionObserver", "(Lcom/onesignal/OSEmailSubscriptionObserver;)V", "")]
		public static unsafe void AddEmailSubscriptionObserver (global::Com.OneSignal.Android.IOSEmailSubscriptionObserver observer)
		{
			const string __id = "addEmailSubscriptionObserver.(Lcom/onesignal/OSEmailSubscriptionObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='addPermissionObserver' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSPermissionObserver']]"
		[Register ("addPermissionObserver", "(Lcom/onesignal/OSPermissionObserver;)V", "")]
		public static unsafe void AddPermissionObserver (global::Com.OneSignal.Android.IOSPermissionObserver? observer)
		{
			const string __id = "addPermissionObserver.(Lcom/onesignal/OSPermissionObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='addSMSSubscriptionObserver' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSSMSSubscriptionObserver']]"
		[Register ("addSMSSubscriptionObserver", "(Lcom/onesignal/OSSMSSubscriptionObserver;)V", "")]
		public static unsafe void AddSMSSubscriptionObserver (global::Com.OneSignal.Android.IOSSMSSubscriptionObserver observer)
		{
			const string __id = "addSMSSubscriptionObserver.(Lcom/onesignal/OSSMSSubscriptionObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='addSubscriptionObserver' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSSubscriptionObserver']]"
		[Register ("addSubscriptionObserver", "(Lcom/onesignal/OSSubscriptionObserver;)V", "")]
		public static unsafe void AddSubscriptionObserver (global::Com.OneSignal.Android.IOSSubscriptionObserver? observer)
		{
			const string __id = "addSubscriptionObserver.(Lcom/onesignal/OSSubscriptionObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='addTrigger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("addTrigger", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void AddTrigger (string? key, global::Java.Lang.Object? @object)
		{
			const string __id = "addTrigger.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (@object);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='addTriggers' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("addTriggers", "(Ljava/util/Map;)V", "")]
		public static unsafe void AddTriggers (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>? triggers)
		{
			const string __id = "addTriggers.(Ljava/util/Map;)V";
			IntPtr native_triggers = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (triggers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_triggers);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_triggers);
				global::System.GC.KeepAlive (triggers);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='clearOneSignalNotifications' and count(parameter)=0]"
		[Register ("clearOneSignalNotifications", "()V", "")]
		public static unsafe void ClearOneSignalNotifications ()
		{
			const string __id = "clearOneSignalNotifications.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='deleteTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteTag", "(Ljava/lang/String;)V", "")]
		public static unsafe void DeleteTag (string? key)
		{
			const string __id = "deleteTag.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='deleteTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignal.ChangeTagsUpdateHandler']]"
		[Register ("deleteTag", "(Ljava/lang/String;Lcom/onesignal/OneSignal$ChangeTagsUpdateHandler;)V", "")]
		public static unsafe void DeleteTag (string? key, global::Com.OneSignal.Android.OneSignal.IChangeTagsUpdateHandler? handler)
		{
			const string __id = "deleteTag.(Ljava/lang/String;Lcom/onesignal/OneSignal$ChangeTagsUpdateHandler;)V";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (handler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='deleteTags' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteTags", "(Ljava/lang/String;)V", "")]
		public static unsafe void DeleteTags (string? jsonArrayString)
		{
			const string __id = "deleteTags.(Ljava/lang/String;)V";
			IntPtr native_jsonArrayString = JNIEnv.NewString ((string?)jsonArrayString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonArrayString);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonArrayString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='deleteTags' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignal.ChangeTagsUpdateHandler']]"
		[Register ("deleteTags", "(Ljava/lang/String;Lcom/onesignal/OneSignal$ChangeTagsUpdateHandler;)V", "")]
		public static unsafe void DeleteTags (string? jsonArrayString, global::Com.OneSignal.Android.OneSignal.IChangeTagsUpdateHandler? handler)
		{
			const string __id = "deleteTags.(Ljava/lang/String;Lcom/onesignal/OneSignal$ChangeTagsUpdateHandler;)V";
			IntPtr native_jsonArrayString = JNIEnv.NewString ((string?)jsonArrayString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_jsonArrayString);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonArrayString);
				global::System.GC.KeepAlive (handler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='deleteTags' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("deleteTags", "(Ljava/util/Collection;)V", "")]
		public static unsafe void DeleteTags (global::System.Collections.Generic.ICollection<string>? keys)
		{
			const string __id = "deleteTags.(Ljava/util/Collection;)V";
			IntPtr native_keys = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (keys);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_keys);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keys);
				global::System.GC.KeepAlive (keys);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='deleteTags' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;'] and parameter[2][@type='com.onesignal.OneSignal.ChangeTagsUpdateHandler']]"
		[Register ("deleteTags", "(Ljava/util/Collection;Lcom/onesignal/OneSignal$ChangeTagsUpdateHandler;)V", "")]
		public static unsafe void DeleteTags (global::System.Collections.Generic.ICollection<string>? keys, global::Com.OneSignal.Android.OneSignal.IChangeTagsUpdateHandler? handler)
		{
			const string __id = "deleteTags.(Ljava/util/Collection;Lcom/onesignal/OneSignal$ChangeTagsUpdateHandler;)V";
			IntPtr native_keys = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (keys);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_keys);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keys);
				global::System.GC.KeepAlive (keys);
				global::System.GC.KeepAlive (handler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='deleteTags' and count(parameter)=2 and parameter[1][@type='org.json.JSONArray'] and parameter[2][@type='com.onesignal.OneSignal.ChangeTagsUpdateHandler']]"
		[Register ("deleteTags", "(Lorg/json/JSONArray;Lcom/onesignal/OneSignal$ChangeTagsUpdateHandler;)V", "")]
		public static unsafe void DeleteTags (global::Org.Json.JSONArray? jsonArray, global::Com.OneSignal.Android.OneSignal.IChangeTagsUpdateHandler? handler)
		{
			const string __id = "deleteTags.(Lorg/json/JSONArray;Lcom/onesignal/OneSignal$ChangeTagsUpdateHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((jsonArray == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonArray).Handle);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (jsonArray);
				global::System.GC.KeepAlive (handler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='disableGMSMissingPrompt' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("disableGMSMissingPrompt", "(Z)V", "")]
		public static unsafe void DisableGMSMissingPrompt (bool promptDisable)
		{
			const string __id = "disableGMSMissingPrompt.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (promptDisable);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='disablePush' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("disablePush", "(Z)V", "")]
		public static unsafe void DisablePush (bool disable)
		{
			const string __id = "disablePush.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (disable);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='getTags' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.OSGetTagsHandler']]"
		[Register ("getTags", "(Lcom/onesignal/OneSignal$OSGetTagsHandler;)V", "")]
		public static unsafe void GetTags (global::Com.OneSignal.Android.OneSignal.IOSGetTagsHandler? getTagsHandler)
		{
			const string __id = "getTags.(Lcom/onesignal/OneSignal$OSGetTagsHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((getTagsHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) getTagsHandler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (getTagsHandler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='getTriggerValueForKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTriggerValueForKey", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object? GetTriggerValueForKey (string? key)
		{
			const string __id = "getTriggerValueForKey.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='initWithContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initWithContext", "(Landroid/content/Context;)V", "")]
		public static unsafe void InitWithContext (global::Android.Content.Context context)
		{
			const string __id = "initWithContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='logoutEmail' and count(parameter)=0]"
		[Register ("logoutEmail", "()V", "")]
		public static unsafe void LogoutEmail ()
		{
			const string __id = "logoutEmail.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='logoutEmail' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.EmailUpdateHandler']]"
		[Register ("logoutEmail", "(Lcom/onesignal/OneSignal$EmailUpdateHandler;)V", "")]
		public static unsafe void LogoutEmail (global::Com.OneSignal.Android.OneSignal.IEmailUpdateHandler? @callback)
		{
			const string __id = "logoutEmail.(Lcom/onesignal/OneSignal$EmailUpdateHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='logoutSMSNumber' and count(parameter)=0]"
		[Register ("logoutSMSNumber", "()V", "")]
		public static unsafe void LogoutSMSNumber ()
		{
			const string __id = "logoutSMSNumber.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='logoutSMSNumber' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.OSSMSUpdateHandler']]"
		[Register ("logoutSMSNumber", "(Lcom/onesignal/OneSignal$OSSMSUpdateHandler;)V", "")]
		public static unsafe void LogoutSMSNumber (global::Com.OneSignal.Android.OneSignal.IOSSMSUpdateHandler? @callback)
		{
			const string __id = "logoutSMSNumber.(Lcom/onesignal/OneSignal$OSSMSUpdateHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='onesignalLog' and count(parameter)=2 and parameter[1][@type='com.onesignal.OneSignal.LOG_LEVEL'] and parameter[2][@type='java.lang.String']]"
		[Register ("onesignalLog", "(Lcom/onesignal/OneSignal$LOG_LEVEL;Ljava/lang/String;)V", "")]
		public static unsafe void OnesignalLog (global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? level, string? message)
		{
			const string __id = "onesignalLog.(Lcom/onesignal/OneSignal$LOG_LEVEL;Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString ((string?)message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((level == null) ? IntPtr.Zero : ((global::Java.Lang.Object) level).Handle);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (level);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='pauseInAppMessages' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("pauseInAppMessages", "(Z)V", "")]
		public static unsafe void PauseInAppMessages (bool pause)
		{
			const string __id = "pauseInAppMessages.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pause);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='postNotification' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignal.PostNotificationResponseHandler']]"
		[Register ("postNotification", "(Ljava/lang/String;Lcom/onesignal/OneSignal$PostNotificationResponseHandler;)V", "")]
		public static unsafe void PostNotification (string? json, global::Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler? handler)
		{
			const string __id = "postNotification.(Ljava/lang/String;Lcom/onesignal/OneSignal$PostNotificationResponseHandler;)V";
			IntPtr native_json = JNIEnv.NewString ((string?)json);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_json);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
				global::System.GC.KeepAlive (handler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='postNotification' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.onesignal.OneSignal.PostNotificationResponseHandler']]"
		[Register ("postNotification", "(Lorg/json/JSONObject;Lcom/onesignal/OneSignal$PostNotificationResponseHandler;)V", "")]
		public static unsafe void PostNotification (global::Org.Json.JSONObject? json, global::Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler? handler)
		{
			const string __id = "postNotification.(Lorg/json/JSONObject;Lcom/onesignal/OneSignal$PostNotificationResponseHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((json == null) ? IntPtr.Zero : ((global::Java.Lang.Object) json).Handle);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (json);
				global::System.GC.KeepAlive (handler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='promptForPushNotifications' and count(parameter)=0]"
		[Register ("promptForPushNotifications", "()V", "")]
		public static unsafe void PromptForPushNotifications ()
		{
			const string __id = "promptForPushNotifications.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='promptForPushNotifications' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("promptForPushNotifications", "(Z)V", "")]
		public static unsafe void PromptForPushNotifications (bool fallbackToSettings)
		{
			const string __id = "promptForPushNotifications.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fallbackToSettings);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='promptForPushNotifications' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.onesignal.OneSignal.PromptForPushNotificationPermissionResponseHandler']]"
		[Register ("promptForPushNotifications", "(ZLcom/onesignal/OneSignal$PromptForPushNotificationPermissionResponseHandler;)V", "")]
		public static unsafe void PromptForPushNotifications (bool fallbackToSettings, global::Com.OneSignal.Android.OneSignal.IPromptForPushNotificationPermissionResponseHandler? handler)
		{
			const string __id = "promptForPushNotifications.(ZLcom/onesignal/OneSignal$PromptForPushNotificationPermissionResponseHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fallbackToSettings);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (handler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='promptLocation' and count(parameter)=0]"
		[Register ("promptLocation", "()V", "")]
		public static unsafe void PromptLocation ()
		{
			const string __id = "promptLocation.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='provideUserConsent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("provideUserConsent", "(Z)V", "")]
		public static unsafe void ProvideUserConsent (bool consent)
		{
			const string __id = "provideUserConsent.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (consent);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removeEmailSubscriptionObserver' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSEmailSubscriptionObserver']]"
		[Register ("removeEmailSubscriptionObserver", "(Lcom/onesignal/OSEmailSubscriptionObserver;)V", "")]
		public static unsafe void RemoveEmailSubscriptionObserver (global::Com.OneSignal.Android.IOSEmailSubscriptionObserver observer)
		{
			const string __id = "removeEmailSubscriptionObserver.(Lcom/onesignal/OSEmailSubscriptionObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removeExternalUserId' and count(parameter)=0]"
		[Register ("removeExternalUserId", "()V", "")]
		public static unsafe void RemoveExternalUserId ()
		{
			const string __id = "removeExternalUserId.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removeExternalUserId' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.OSExternalUserIdUpdateCompletionHandler']]"
		[Register ("removeExternalUserId", "(Lcom/onesignal/OneSignal$OSExternalUserIdUpdateCompletionHandler;)V", "")]
		public static unsafe void RemoveExternalUserId (global::Com.OneSignal.Android.OneSignal.IOSExternalUserIdUpdateCompletionHandler? completionHandler)
		{
			const string __id = "removeExternalUserId.(Lcom/onesignal/OneSignal$OSExternalUserIdUpdateCompletionHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((completionHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completionHandler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (completionHandler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removeGroupedNotifications' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeGroupedNotifications", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveGroupedNotifications (string? group)
		{
			const string __id = "removeGroupedNotifications.(Ljava/lang/String;)V";
			IntPtr native_group = JNIEnv.NewString ((string?)group);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_group);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_group);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removeNotification' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeNotification", "(I)V", "")]
		public static unsafe void RemoveNotification (int id)
		{
			const string __id = "removeNotification.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removePermissionObserver' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSPermissionObserver']]"
		[Register ("removePermissionObserver", "(Lcom/onesignal/OSPermissionObserver;)V", "")]
		public static unsafe void RemovePermissionObserver (global::Com.OneSignal.Android.IOSPermissionObserver? observer)
		{
			const string __id = "removePermissionObserver.(Lcom/onesignal/OSPermissionObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removeSMSSubscriptionObserver' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSSMSSubscriptionObserver']]"
		[Register ("removeSMSSubscriptionObserver", "(Lcom/onesignal/OSSMSSubscriptionObserver;)V", "")]
		public static unsafe void RemoveSMSSubscriptionObserver (global::Com.OneSignal.Android.IOSSMSSubscriptionObserver observer)
		{
			const string __id = "removeSMSSubscriptionObserver.(Lcom/onesignal/OSSMSSubscriptionObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removeSubscriptionObserver' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSSubscriptionObserver']]"
		[Register ("removeSubscriptionObserver", "(Lcom/onesignal/OSSubscriptionObserver;)V", "")]
		public static unsafe void RemoveSubscriptionObserver (global::Com.OneSignal.Android.IOSSubscriptionObserver? observer)
		{
			const string __id = "removeSubscriptionObserver.(Lcom/onesignal/OSSubscriptionObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (observer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removeTriggerForKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeTriggerForKey", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveTriggerForKey (string? key)
		{
			const string __id = "removeTriggerForKey.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removeTriggersForKeys' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("removeTriggersForKeys", "(Ljava/util/Collection;)V", "")]
		public static unsafe void RemoveTriggersForKeys (global::System.Collections.Generic.ICollection<string>? keys)
		{
			const string __id = "removeTriggersForKeys.(Ljava/util/Collection;)V";
			IntPtr native_keys = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (keys);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_keys);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keys);
				global::System.GC.KeepAlive (keys);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='requiresUserPrivacyConsent' and count(parameter)=0]"
		[Register ("requiresUserPrivacyConsent", "()Z", "")]
		public static unsafe bool RequiresUserPrivacyConsent ()
		{
			const string __id = "requiresUserPrivacyConsent.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendOutcome' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendOutcome", "(Ljava/lang/String;)V", "")]
		public static unsafe void SendOutcome (string name)
		{
			const string __id = "sendOutcome.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendOutcome' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignal.OutcomeCallback']]"
		[Register ("sendOutcome", "(Ljava/lang/String;Lcom/onesignal/OneSignal$OutcomeCallback;)V", "")]
		public static unsafe void SendOutcome (string name, global::Com.OneSignal.Android.OneSignal.IOutcomeCallback? @callback)
		{
			const string __id = "sendOutcome.(Ljava/lang/String;Lcom/onesignal/OneSignal$OutcomeCallback;)V";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendOutcomeWithValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("sendOutcomeWithValue", "(Ljava/lang/String;F)V", "")]
		public static unsafe void SendOutcomeWithValue (string name, float value)
		{
			const string __id = "sendOutcomeWithValue.(Ljava/lang/String;F)V";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendOutcomeWithValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='com.onesignal.OneSignal.OutcomeCallback']]"
		[Register ("sendOutcomeWithValue", "(Ljava/lang/String;FLcom/onesignal/OneSignal$OutcomeCallback;)V", "")]
		public static unsafe void SendOutcomeWithValue (string name, float value, global::Com.OneSignal.Android.OneSignal.IOutcomeCallback? @callback)
		{
			const string __id = "sendOutcomeWithValue.(Ljava/lang/String;FLcom/onesignal/OneSignal$OutcomeCallback;)V";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (value);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendTag", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SendTag (string? key, string? value)
		{
			const string __id = "sendTag.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			IntPtr native_value = JNIEnv.NewString ((string?)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendTags' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendTags", "(Ljava/lang/String;)V", "")]
		public static unsafe void SendTags (string? jsonString)
		{
			const string __id = "sendTags.(Ljava/lang/String;)V";
			IntPtr native_jsonString = JNIEnv.NewString ((string?)jsonString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonString);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonString);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendTags' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("sendTags", "(Lorg/json/JSONObject;)V", "")]
		public static unsafe void SendTags (global::Org.Json.JSONObject? keyValues)
		{
			const string __id = "sendTags.(Lorg/json/JSONObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyValues == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyValues).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (keyValues);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendTags' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.onesignal.OneSignal.ChangeTagsUpdateHandler']]"
		[Register ("sendTags", "(Lorg/json/JSONObject;Lcom/onesignal/OneSignal$ChangeTagsUpdateHandler;)V", "")]
		public static unsafe void SendTags (global::Org.Json.JSONObject? keyValues, global::Com.OneSignal.Android.OneSignal.IChangeTagsUpdateHandler? changeTagsUpdateHandler)
		{
			const string __id = "sendTags.(Lorg/json/JSONObject;Lcom/onesignal/OneSignal$ChangeTagsUpdateHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((keyValues == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyValues).Handle);
				__args [1] = new JniArgumentValue ((changeTagsUpdateHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) changeTagsUpdateHandler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (keyValues);
				global::System.GC.KeepAlive (changeTagsUpdateHandler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendUniqueOutcome' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendUniqueOutcome", "(Ljava/lang/String;)V", "")]
		public static unsafe void SendUniqueOutcome (string name)
		{
			const string __id = "sendUniqueOutcome.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendUniqueOutcome' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignal.OutcomeCallback']]"
		[Register ("sendUniqueOutcome", "(Ljava/lang/String;Lcom/onesignal/OneSignal$OutcomeCallback;)V", "")]
		public static unsafe void SendUniqueOutcome (string name, global::Com.OneSignal.Android.OneSignal.IOutcomeCallback? @callback)
		{
			const string __id = "sendUniqueOutcome.(Ljava/lang/String;Lcom/onesignal/OneSignal$OutcomeCallback;)V";
			IntPtr native_name = JNIEnv.NewString ((string?)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppId", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetAppId (string newAppId)
		{
			const string __id = "setAppId.(Ljava/lang/String;)V";
			IntPtr native_newAppId = JNIEnv.NewString ((string?)newAppId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newAppId);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_newAppId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEmail", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetEmail (string email)
		{
			const string __id = "setEmail.(Ljava/lang/String;)V";
			IntPtr native_email = JNIEnv.NewString ((string?)email);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_email);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_email);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setEmail' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignal.EmailUpdateHandler']]"
		[Register ("setEmail", "(Ljava/lang/String;Lcom/onesignal/OneSignal$EmailUpdateHandler;)V", "")]
		public static unsafe void SetEmail (string email, global::Com.OneSignal.Android.OneSignal.IEmailUpdateHandler? @callback)
		{
			const string __id = "setEmail.(Ljava/lang/String;Lcom/onesignal/OneSignal$EmailUpdateHandler;)V";
			IntPtr native_email = JNIEnv.NewString ((string?)email);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_email);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_email);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setEmail' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setEmail", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetEmail (string email, string? emailAuthHash)
		{
			const string __id = "setEmail.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_email = JNIEnv.NewString ((string?)email);
			IntPtr native_emailAuthHash = JNIEnv.NewString ((string?)emailAuthHash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_email);
				__args [1] = new JniArgumentValue (native_emailAuthHash);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_email);
				JNIEnv.DeleteLocalRef (native_emailAuthHash);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setEmail' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.onesignal.OneSignal.EmailUpdateHandler']]"
		[Register ("setEmail", "(Ljava/lang/String;Ljava/lang/String;Lcom/onesignal/OneSignal$EmailUpdateHandler;)V", "")]
		public static unsafe void SetEmail (string email, string? emailAuthHash, global::Com.OneSignal.Android.OneSignal.IEmailUpdateHandler? @callback)
		{
			const string __id = "setEmail.(Ljava/lang/String;Ljava/lang/String;Lcom/onesignal/OneSignal$EmailUpdateHandler;)V";
			IntPtr native_email = JNIEnv.NewString ((string?)email);
			IntPtr native_emailAuthHash = JNIEnv.NewString ((string?)emailAuthHash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_email);
				__args [1] = new JniArgumentValue (native_emailAuthHash);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_email);
				JNIEnv.DeleteLocalRef (native_emailAuthHash);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setExternalUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setExternalUserId", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetExternalUserId (string externalId)
		{
			const string __id = "setExternalUserId.(Ljava/lang/String;)V";
			IntPtr native_externalId = JNIEnv.NewString ((string?)externalId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_externalId);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_externalId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setExternalUserId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignal.OSExternalUserIdUpdateCompletionHandler']]"
		[Register ("setExternalUserId", "(Ljava/lang/String;Lcom/onesignal/OneSignal$OSExternalUserIdUpdateCompletionHandler;)V", "")]
		public static unsafe void SetExternalUserId (string externalId, global::Com.OneSignal.Android.OneSignal.IOSExternalUserIdUpdateCompletionHandler? completionCallback)
		{
			const string __id = "setExternalUserId.(Ljava/lang/String;Lcom/onesignal/OneSignal$OSExternalUserIdUpdateCompletionHandler;)V";
			IntPtr native_externalId = JNIEnv.NewString ((string?)externalId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_externalId);
				__args [1] = new JniArgumentValue ((completionCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completionCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_externalId);
				global::System.GC.KeepAlive (completionCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setExternalUserId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setExternalUserId", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetExternalUserId (string externalId, string? externalIdAuthHash)
		{
			const string __id = "setExternalUserId.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_externalId = JNIEnv.NewString ((string?)externalId);
			IntPtr native_externalIdAuthHash = JNIEnv.NewString ((string?)externalIdAuthHash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_externalId);
				__args [1] = new JniArgumentValue (native_externalIdAuthHash);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_externalId);
				JNIEnv.DeleteLocalRef (native_externalIdAuthHash);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setExternalUserId' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.onesignal.OneSignal.OSExternalUserIdUpdateCompletionHandler']]"
		[Register ("setExternalUserId", "(Ljava/lang/String;Ljava/lang/String;Lcom/onesignal/OneSignal$OSExternalUserIdUpdateCompletionHandler;)V", "")]
		public static unsafe void SetExternalUserId (string externalId, string? externalIdAuthHash, global::Com.OneSignal.Android.OneSignal.IOSExternalUserIdUpdateCompletionHandler? completionCallback)
		{
			const string __id = "setExternalUserId.(Ljava/lang/String;Ljava/lang/String;Lcom/onesignal/OneSignal$OSExternalUserIdUpdateCompletionHandler;)V";
			IntPtr native_externalId = JNIEnv.NewString ((string?)externalId);
			IntPtr native_externalIdAuthHash = JNIEnv.NewString ((string?)externalIdAuthHash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_externalId);
				__args [1] = new JniArgumentValue (native_externalIdAuthHash);
				__args [2] = new JniArgumentValue ((completionCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completionCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_externalId);
				JNIEnv.DeleteLocalRef (native_externalIdAuthHash);
				global::System.GC.KeepAlive (completionCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setInAppMessageClickHandler' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.OSInAppMessageClickHandler']]"
		[Register ("setInAppMessageClickHandler", "(Lcom/onesignal/OneSignal$OSInAppMessageClickHandler;)V", "")]
		public static unsafe void SetInAppMessageClickHandler (global::Com.OneSignal.Android.OneSignal.IOSInAppMessageClickHandler? @callback)
		{
			const string __id = "setInAppMessageClickHandler.(Lcom/onesignal/OneSignal$OSInAppMessageClickHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setInAppMessageLifecycleHandler' and count(parameter)=1 and parameter[1][@type='com.onesignal.OSInAppMessageLifecycleHandler']]"
		[Register ("setInAppMessageLifecycleHandler", "(Lcom/onesignal/OSInAppMessageLifecycleHandler;)V", "")]
		public static unsafe void SetInAppMessageLifecycleHandler (global::Com.OneSignal.Android.OSInAppMessageLifecycleHandler? handler)
		{
			const string __id = "setInAppMessageLifecycleHandler.(Lcom/onesignal/OSInAppMessageLifecycleHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (handler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLanguage", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetLanguage (string language)
		{
			const string __id = "setLanguage.(Ljava/lang/String;)V";
			IntPtr native_language = JNIEnv.NewString ((string?)language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_language);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_language);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setLanguage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignal.OSSetLanguageCompletionHandler']]"
		[Register ("setLanguage", "(Ljava/lang/String;Lcom/onesignal/OneSignal$OSSetLanguageCompletionHandler;)V", "")]
		public static unsafe void SetLanguage (string language, global::Com.OneSignal.Android.OneSignal.IOSSetLanguageCompletionHandler? completionCallback)
		{
			const string __id = "setLanguage.(Ljava/lang/String;Lcom/onesignal/OneSignal$OSSetLanguageCompletionHandler;)V";
			IntPtr native_language = JNIEnv.NewString ((string?)language);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_language);
				__args [1] = new JniArgumentValue ((completionCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completionCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_language);
				global::System.GC.KeepAlive (completionCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setLogLevel' and count(parameter)=2 and parameter[1][@type='com.onesignal.OneSignal.LOG_LEVEL'] and parameter[2][@type='com.onesignal.OneSignal.LOG_LEVEL']]"
		[Register ("setLogLevel", "(Lcom/onesignal/OneSignal$LOG_LEVEL;Lcom/onesignal/OneSignal$LOG_LEVEL;)V", "")]
		public static unsafe void SetLogLevel (global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? inLogCatLevel, global::Com.OneSignal.Android.OneSignal.LOG_LEVEL? inVisualLogLevel)
		{
			const string __id = "setLogLevel.(Lcom/onesignal/OneSignal$LOG_LEVEL;Lcom/onesignal/OneSignal$LOG_LEVEL;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((inLogCatLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inLogCatLevel).Handle);
				__args [1] = new JniArgumentValue ((inVisualLogLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inVisualLogLevel).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (inLogCatLevel);
				global::System.GC.KeepAlive (inVisualLogLevel);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setLogLevel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setLogLevel", "(II)V", "")]
		public static unsafe void SetLogLevel (int inLogCatLevel, int inVisualLogLevel)
		{
			const string __id = "setLogLevel.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (inLogCatLevel);
				__args [1] = new JniArgumentValue (inVisualLogLevel);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setNotificationOpenedHandler' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.OSNotificationOpenedHandler']]"
		[Register ("setNotificationOpenedHandler", "(Lcom/onesignal/OneSignal$OSNotificationOpenedHandler;)V", "")]
		public static unsafe void SetNotificationOpenedHandler (global::Com.OneSignal.Android.OneSignal.IOSNotificationOpenedHandler? @callback)
		{
			const string __id = "setNotificationOpenedHandler.(Lcom/onesignal/OneSignal$OSNotificationOpenedHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setNotificationWillShowInForegroundHandler' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.OSNotificationWillShowInForegroundHandler']]"
		[Register ("setNotificationWillShowInForegroundHandler", "(Lcom/onesignal/OneSignal$OSNotificationWillShowInForegroundHandler;)V", "")]
		public static unsafe void SetNotificationWillShowInForegroundHandler (global::Com.OneSignal.Android.OneSignal.IOSNotificationWillShowInForegroundHandler? @callback)
		{
			const string __id = "setNotificationWillShowInForegroundHandler.(Lcom/onesignal/OneSignal$OSNotificationWillShowInForegroundHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setRequiresUserPrivacyConsent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRequiresUserPrivacyConsent", "(Z)V", "")]
		public static unsafe void SetRequiresUserPrivacyConsent (bool required)
		{
			const string __id = "setRequiresUserPrivacyConsent.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (required);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setSMSNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSMSNumber", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetSMSNumber (string smsNumber)
		{
			const string __id = "setSMSNumber.(Ljava/lang/String;)V";
			IntPtr native_smsNumber = JNIEnv.NewString ((string?)smsNumber);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_smsNumber);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_smsNumber);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setSMSNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignal.OSSMSUpdateHandler']]"
		[Register ("setSMSNumber", "(Ljava/lang/String;Lcom/onesignal/OneSignal$OSSMSUpdateHandler;)V", "")]
		public static unsafe void SetSMSNumber (string smsNumber, global::Com.OneSignal.Android.OneSignal.IOSSMSUpdateHandler? @callback)
		{
			const string __id = "setSMSNumber.(Ljava/lang/String;Lcom/onesignal/OneSignal$OSSMSUpdateHandler;)V";
			IntPtr native_smsNumber = JNIEnv.NewString ((string?)smsNumber);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_smsNumber);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_smsNumber);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setSMSNumber' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSMSNumber", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetSMSNumber (string smsNumber, string? smsAuthHash)
		{
			const string __id = "setSMSNumber.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_smsNumber = JNIEnv.NewString ((string?)smsNumber);
			IntPtr native_smsAuthHash = JNIEnv.NewString ((string?)smsAuthHash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_smsNumber);
				__args [1] = new JniArgumentValue (native_smsAuthHash);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_smsNumber);
				JNIEnv.DeleteLocalRef (native_smsAuthHash);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setSMSNumber' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.onesignal.OneSignal.OSSMSUpdateHandler']]"
		[Register ("setSMSNumber", "(Ljava/lang/String;Ljava/lang/String;Lcom/onesignal/OneSignal$OSSMSUpdateHandler;)V", "")]
		public static unsafe void SetSMSNumber (string smsNumber, string? smsAuthHash, global::Com.OneSignal.Android.OneSignal.IOSSMSUpdateHandler? @callback)
		{
			const string __id = "setSMSNumber.(Ljava/lang/String;Ljava/lang/String;Lcom/onesignal/OneSignal$OSSMSUpdateHandler;)V";
			IntPtr native_smsNumber = JNIEnv.NewString ((string?)smsNumber);
			IntPtr native_smsAuthHash = JNIEnv.NewString ((string?)smsAuthHash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_smsNumber);
				__args [1] = new JniArgumentValue (native_smsAuthHash);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_smsNumber);
				JNIEnv.DeleteLocalRef (native_smsAuthHash);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='unsubscribeWhenNotificationsAreDisabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("unsubscribeWhenNotificationsAreDisabled", "(Z)V", "")]
		public static unsafe void UnsubscribeWhenNotificationsAreDisabled (bool set)
		{
			const string __id = "unsubscribeWhenNotificationsAreDisabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (set);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='userProvidedPrivacyConsent' and count(parameter)=0]"
		[Register ("userProvidedPrivacyConsent", "()Z", "")]
		public static unsafe bool UserProvidedPrivacyConsent ()
		{
			const string __id = "userProvidedPrivacyConsent.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

	}
}
