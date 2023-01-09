using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageOutcome']"
	[global::Android.Runtime.Register ("com/onesignal/OSInAppMessageOutcome", DoNotGenerateAcw=true)]
	public partial class OSInAppMessageOutcome : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OSInAppMessageOutcome", typeof (OSInAppMessageOutcome));

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

		protected OSInAppMessageOutcome (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate? cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageOutcome> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate? cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageOutcome> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Name = name;
		}
#pragma warning restore 0169

		public virtual unsafe string? Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageOutcome']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageOutcome']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate? cb_isUnique;
#pragma warning disable 0169
		static Delegate GetIsUniqueHandler ()
		{
			if (cb_isUnique == null)
				cb_isUnique = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUnique);
			return cb_isUnique;
		}

		static bool n_IsUnique (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageOutcome> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Unique;
		}
#pragma warning restore 0169

		static Delegate? cb_setUnique_Z;
#pragma warning disable 0169
		static Delegate GetSetUnique_ZHandler ()
		{
			if (cb_setUnique_Z == null)
				cb_setUnique_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUnique_Z);
			return cb_setUnique_Z;
		}

		static void n_SetUnique_Z (IntPtr jnienv, IntPtr native__this, bool unique)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageOutcome> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Unique = unique;
		}
#pragma warning restore 0169

		public virtual unsafe bool Unique {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageOutcome']/method[@name='isUnique' and count(parameter)=0]"
			[Register ("isUnique", "()Z", "GetIsUniqueHandler")]
			get {
				const string __id = "isUnique.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageOutcome']/method[@name='setUnique' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUnique", "(Z)V", "GetSetUnique_ZHandler")]
			set {
				const string __id = "setUnique.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate? cb_getWeight;
#pragma warning disable 0169
		static Delegate GetGetWeightHandler ()
		{
			if (cb_getWeight == null)
				cb_getWeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetWeight);
			return cb_getWeight;
		}

		static float n_GetWeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageOutcome> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Weight;
		}
#pragma warning restore 0169

		static Delegate? cb_setWeight_F;
#pragma warning disable 0169
		static Delegate GetSetWeight_FHandler ()
		{
			if (cb_setWeight_F == null)
				cb_setWeight_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetWeight_F);
			return cb_setWeight_F;
		}

		static void n_SetWeight_F (IntPtr jnienv, IntPtr native__this, float weight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageOutcome> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Weight = weight;
		}
#pragma warning restore 0169

		public virtual unsafe float Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageOutcome']/method[@name='getWeight' and count(parameter)=0]"
			[Register ("getWeight", "()F", "GetGetWeightHandler")]
			get {
				const string __id = "getWeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageOutcome']/method[@name='setWeight' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWeight", "(F)V", "GetSetWeight_FHandler")]
			set {
				const string __id = "setWeight.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OSInAppMessageOutcome> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OSInAppMessageOutcome']/method[@name='toJSONObject' and count(parameter)=0]"
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
