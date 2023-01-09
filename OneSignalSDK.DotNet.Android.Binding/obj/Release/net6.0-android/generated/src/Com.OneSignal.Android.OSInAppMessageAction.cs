using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction']"
	[global::Android.Runtime.Register ("com/onesignal/OSInAppMessageAction", DoNotGenerateAcw=true)]
	public partial class OSInAppMessageAction : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction.OSInAppMessageActionUrlType']"
		[global::Android.Runtime.Register ("com/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType", DoNotGenerateAcw=true)]
		public sealed partial class OSInAppMessageActionUrlType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction.OSInAppMessageActionUrlType']/field[@name='BROWSER']"
			[Register ("BROWSER")]
			public static global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType? Browser {
				get {
					const string __id = "BROWSER.Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction.OSInAppMessageActionUrlType']/field[@name='IN_APP_WEBVIEW']"
			[Register ("IN_APP_WEBVIEW")]
			public static global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType? InAppWebview {
				get {
					const string __id = "IN_APP_WEBVIEW.Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction.OSInAppMessageActionUrlType']/field[@name='REPLACE_CONTENT']"
			[Register ("REPLACE_CONTENT")]
			public static global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType? ReplaceContent {
				get {
					const string __id = "REPLACE_CONTENT.Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType", typeof (OSInAppMessageActionUrlType));

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

			internal OSInAppMessageActionUrlType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction.OSInAppMessageActionUrlType']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromString", "(Ljava/lang/String;)Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;", "")]
			public static unsafe global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType? FromString (string? text)
			{
				const string __id = "fromString.(Ljava/lang/String;)Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;";
				IntPtr native_text = JNIEnv.NewString ((string?)text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction.OSInAppMessageActionUrlType']/method[@name='toJSONObject' and count(parameter)=0]"
			[Register ("toJSONObject", "()Lorg/json/JSONObject;", "")]
			public unsafe global::Org.Json.JSONObject? ToJSONObject ()
			{
				const string __id = "toJSONObject.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction.OSInAppMessageActionUrlType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;", "")]
			public static unsafe global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType? ValueOf (string? name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction.OSInAppMessageActionUrlType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;", "")]
			public static unsafe global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType[]? Values ()
			{
				const string __id = "values.()[Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSInAppMessageAction", typeof (OSInAppMessageAction));

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

		protected OSInAppMessageAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getClickName;
#pragma warning disable 0169
		static Delegate GetGetClickNameHandler ()
		{
			if (cb_getClickName == null)
				cb_getClickName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClickName);
			return cb_getClickName;
		}

		static IntPtr n_GetClickName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ClickName);
		}
#pragma warning restore 0169

		public virtual unsafe string? ClickName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction']/method[@name='getClickName' and count(parameter)=0]"
			[Register ("getClickName", "()Ljava/lang/String;", "GetGetClickNameHandler")]
			get {
				const string __id = "getClickName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getClickUrl;
#pragma warning disable 0169
		static Delegate GetGetClickUrlHandler ()
		{
			if (cb_getClickUrl == null)
				cb_getClickUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClickUrl);
			return cb_getClickUrl;
		}

		static IntPtr n_GetClickUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ClickUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string? ClickUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction']/method[@name='getClickUrl' and count(parameter)=0]"
			[Register ("getClickUrl", "()Ljava/lang/String;", "GetGetClickUrlHandler")]
			get {
				const string __id = "getClickUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_isFirstClick;
#pragma warning disable 0169
		static Delegate GetIsFirstClickHandler ()
		{
			if (cb_isFirstClick == null)
				cb_isFirstClick = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFirstClick);
			return cb_isFirstClick;
		}

		static bool n_IsFirstClick (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFirstClick;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFirstClick {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction']/method[@name='isFirstClick' and count(parameter)=0]"
			[Register ("isFirstClick", "()Z", "GetIsFirstClickHandler")]
			get {
				const string __id = "isFirstClick.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_getOutcomes;
#pragma warning disable 0169
		static Delegate GetGetOutcomesHandler ()
		{
			if (cb_getOutcomes == null)
				cb_getOutcomes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOutcomes);
			return cb_getOutcomes;
		}

		static IntPtr n_GetOutcomes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSInAppMessageOutcome>.ToLocalJniHandle (__this.Outcomes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.OneSignal.Android.OSInAppMessageOutcome> Outcomes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction']/method[@name='getOutcomes' and count(parameter)=0]"
			[Register ("getOutcomes", "()Ljava/util/List;", "GetGetOutcomesHandler")]
			get {
				const string __id = "getOutcomes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSInAppMessageOutcome>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		static Delegate? cb_getPrompts;
#pragma warning disable 0169
		static Delegate GetGetPromptsHandler ()
		{
			if (cb_getPrompts == null)
				cb_getPrompts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrompts);
			return cb_getPrompts;
		}

		static IntPtr n_GetPrompts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSInAppMessagePrompt>.ToLocalJniHandle (__this.Prompts);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.OneSignal.Android.OSInAppMessagePrompt> Prompts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction']/method[@name='getPrompts' and count(parameter)=0]"
			[Register ("getPrompts", "()Ljava/util/List;", "GetGetPromptsHandler")]
			get {
				const string __id = "getPrompts.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.OneSignal.Android.OSInAppMessagePrompt>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		static Delegate? cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSInAppMessageTag? Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Lcom/onesignal/OSInAppMessageTag;", "GetGetTagsHandler")]
			get {
				const string __id = "getTags.()Lcom/onesignal/OSInAppMessageTag;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageTag> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getUrlTarget;
#pragma warning disable 0169
		static Delegate GetGetUrlTargetHandler ()
		{
			if (cb_getUrlTarget == null)
				cb_getUrlTarget = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUrlTarget);
			return cb_getUrlTarget;
		}

		static IntPtr n_GetUrlTarget (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.UrlTarget);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType? UrlTarget {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction']/method[@name='getUrlTarget' and count(parameter)=0]"
			[Register ("getUrlTarget", "()Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;", "GetGetUrlTargetHandler")]
			get {
				const string __id = "getUrlTarget.()Lcom/onesignal/OSInAppMessageAction$OSInAppMessageActionUrlType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction.OSInAppMessageActionUrlType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_doesCloseMessage;
#pragma warning disable 0169
		static Delegate GetDoesCloseMessageHandler ()
		{
			if (cb_doesCloseMessage == null)
				cb_doesCloseMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_DoesCloseMessage);
			return cb_doesCloseMessage;
		}

		static bool n_DoesCloseMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.DoesCloseMessage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction']/method[@name='doesCloseMessage' and count(parameter)=0]"
		[Register ("doesCloseMessage", "()Z", "GetDoesCloseMessageHandler")]
		public virtual unsafe bool DoesCloseMessage ()
		{
			const string __id = "doesCloseMessage.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageAction']/method[@name='toJSONObject' and count(parameter)=0]"
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
