using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageTag']"
	[global::Android.Runtime.Register ("com/onesignal/OSInAppMessageTag", DoNotGenerateAcw=true)]
	public partial class OSInAppMessageTag : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSInAppMessageTag", typeof (OSInAppMessageTag));

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

		protected OSInAppMessageTag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getTagsToAdd;
#pragma warning disable 0169
		static Delegate GetGetTagsToAddHandler ()
		{
			if (cb_getTagsToAdd == null)
				cb_getTagsToAdd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTagsToAdd);
			return cb_getTagsToAdd;
		}

		static IntPtr n_GetTagsToAdd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageTag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.TagsToAdd);
		}
#pragma warning restore 0169

		static Delegate? cb_setTagsToAdd_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetTagsToAdd_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setTagsToAdd_Lorg_json_JSONObject_ == null)
				cb_setTagsToAdd_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTagsToAdd_Lorg_json_JSONObject_);
			return cb_setTagsToAdd_Lorg_json_JSONObject_;
		}

		static void n_SetTagsToAdd_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tagsToAdd)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageTag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tagsToAdd = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_tagsToAdd, JniHandleOwnership.DoNotTransfer);
			__this.TagsToAdd = tagsToAdd;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject? TagsToAdd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageTag']/method[@name='getTagsToAdd' and count(parameter)=0]"
			[Register ("getTagsToAdd", "()Lorg/json/JSONObject;", "GetGetTagsToAddHandler")]
			get {
				const string __id = "getTagsToAdd.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageTag']/method[@name='setTagsToAdd' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setTagsToAdd", "(Lorg/json/JSONObject;)V", "GetSetTagsToAdd_Lorg_json_JSONObject_Handler")]
			set {
				const string __id = "setTagsToAdd.(Lorg/json/JSONObject;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate? cb_getTagsToRemove;
#pragma warning disable 0169
		static Delegate GetGetTagsToRemoveHandler ()
		{
			if (cb_getTagsToRemove == null)
				cb_getTagsToRemove = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTagsToRemove);
			return cb_getTagsToRemove;
		}

		static IntPtr n_GetTagsToRemove (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageTag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.TagsToRemove);
		}
#pragma warning restore 0169

		static Delegate? cb_setTagsToRemove_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetSetTagsToRemove_Lorg_json_JSONArray_Handler ()
		{
			if (cb_setTagsToRemove_Lorg_json_JSONArray_ == null)
				cb_setTagsToRemove_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTagsToRemove_Lorg_json_JSONArray_);
			return cb_setTagsToRemove_Lorg_json_JSONArray_;
		}

		static void n_SetTagsToRemove_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tagsToRemove)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageTag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tagsToRemove = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_tagsToRemove, JniHandleOwnership.DoNotTransfer);
			__this.TagsToRemove = tagsToRemove;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONArray? TagsToRemove {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageTag']/method[@name='getTagsToRemove' and count(parameter)=0]"
			[Register ("getTagsToRemove", "()Lorg/json/JSONArray;", "GetGetTagsToRemoveHandler")]
			get {
				const string __id = "getTagsToRemove.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageTag']/method[@name='setTagsToRemove' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
			[Register ("setTagsToRemove", "(Lorg/json/JSONArray;)V", "GetSetTagsToRemove_Lorg_json_JSONArray_Handler")]
			set {
				const string __id = "setTagsToRemove.(Lorg/json/JSONArray;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageTag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageTag']/method[@name='toJSONObject' and count(parameter)=0]"
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
