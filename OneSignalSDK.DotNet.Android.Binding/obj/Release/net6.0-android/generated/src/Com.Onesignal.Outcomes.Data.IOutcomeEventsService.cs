using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Outcomes.Data {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal.outcomes.data']/interface[@name='OutcomeEventsService']"
	[Register ("com/onesignal/outcomes/data/OutcomeEventsService", "", "Com.Onesignal.Outcomes.Data.IOutcomeEventsServiceInvoker")]
	public partial interface IOutcomeEventsService : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.data']/interface[@name='OutcomeEventsService']/method[@name='sendOutcomeEvent' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.onesignal.OneSignalApiResponseHandler']]"
		[Register ("sendOutcomeEvent", "(Lorg/json/JSONObject;Lcom/onesignal/OneSignalApiResponseHandler;)V", "GetSendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_Handler:Com.Onesignal.Outcomes.Data.IOutcomeEventsServiceInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void SendOutcomeEvent (global::Org.Json.JSONObject jsonObject, global::Com.OneSignal.Android.IOneSignalApiResponseHandler responseHandler);

	}

	[global::Android.Runtime.Register ("com/onesignal/outcomes/data/OutcomeEventsService", DoNotGenerateAcw=true)]
	internal partial class IOutcomeEventsServiceInvoker : global::Java.Lang.Object, IOutcomeEventsService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/outcomes/data/OutcomeEventsService", typeof (IOutcomeEventsServiceInvoker));

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

		public static IOutcomeEventsService? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOutcomeEventsService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.outcomes.data.OutcomeEventsService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOutcomeEventsServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_sendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
#pragma warning disable 0169
		static Delegate GetSendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_Handler ()
		{
			if (cb_sendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ == null)
				cb_sendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_);
			return cb_sendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
		}

		static void n_SendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject, IntPtr native_responseHandler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Onesignal.Outcomes.Data.IOutcomeEventsService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			var responseHandler = (global::Com.OneSignal.Android.IOneSignalApiResponseHandler?)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalApiResponseHandler> (native_responseHandler, JniHandleOwnership.DoNotTransfer);
			__this.SendOutcomeEvent (jsonObject!, responseHandler!);
		}
#pragma warning restore 0169

		IntPtr id_sendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_;
		public unsafe void SendOutcomeEvent (global::Org.Json.JSONObject jsonObject, global::Com.OneSignal.Android.IOneSignalApiResponseHandler responseHandler)
		{
			if (id_sendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ == IntPtr.Zero)
				id_sendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_ = JNIEnv.GetMethodID (class_ref, "sendOutcomeEvent", "(Lorg/json/JSONObject;Lcom/onesignal/OneSignalApiResponseHandler;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
			__args [1] = new JValue ((responseHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseHandler).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendOutcomeEvent_Lorg_json_JSONObject_Lcom_onesignal_OneSignalApiResponseHandler_, __args);
		}

	}
}
