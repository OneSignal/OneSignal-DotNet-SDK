using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Influence.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']"
	[global::Android.Runtime.Register ("com/onesignal/influence/data/OSTrackerFactory", DoNotGenerateAcw=true)]
	public sealed partial class OSTrackerFactory : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory.WhenMappings']"
		[global::Android.Runtime.Register ("com/onesignal/influence/data/OSTrackerFactory$WhenMappings", DoNotGenerateAcw=true)]
		public sealed partial class WhenMappings : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/influence/data/OSTrackerFactory$WhenMappings", typeof (WhenMappings));

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

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/influence/data/OSTrackerFactory", typeof (OSTrackerFactory));

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

		internal OSTrackerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/constructor[@name='OSTrackerFactory' and count(parameter)=3 and parameter[1][@type='com.onesignal.OSSharedPreferences'] and parameter[2][@type='com.onesignal.OSLogger'] and parameter[3][@type='com.onesignal.OSTime']]"
		[Register (".ctor", "(Lcom/onesignal/OSSharedPreferences;Lcom/onesignal/OSLogger;Lcom/onesignal/OSTime;)V", "")]
		public unsafe OSTrackerFactory (global::Com.OneSignal.Android.IOSSharedPreferences preferences, global::Com.OneSignal.Android.IOSLogger logger, global::Com.OneSignal.Android.IOSTime timeProvider) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/onesignal/OSSharedPreferences;Lcom/onesignal/OSLogger;Lcom/onesignal/OSTime;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((preferences == null) ? IntPtr.Zero : ((global::Java.Lang.Object) preferences).Handle);
				__args [1] = new JniArgumentValue ((logger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logger).Handle);
				__args [2] = new JniArgumentValue ((timeProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeProvider).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (preferences);
				global::System.GC.KeepAlive (logger);
				global::System.GC.KeepAlive (timeProvider);
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Data.OSChannelTracker> Channels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/method[@name='getChannels' and count(parameter)=0]"
			[Register ("getChannels", "()Ljava/util/List;", "")]
			get {
				const string __id = "getChannels.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Data.OSChannelTracker>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Onesignal.Influence.Data.OSChannelTracker IAMChannelTracker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/method[@name='getIAMChannelTracker' and count(parameter)=0]"
			[Register ("getIAMChannelTracker", "()Lcom/onesignal/influence/data/OSChannelTracker;", "")]
			get {
				const string __id = "getIAMChannelTracker.()Lcom/onesignal/influence/data/OSChannelTracker;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> Influences {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/method[@name='getInfluences' and count(parameter)=0]"
			[Register ("getInfluences", "()Ljava/util/List;", "")]
			get {
				const string __id = "getInfluences.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Domain.OSInfluence>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Onesignal.Influence.Data.OSChannelTracker NotificationChannelTracker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/method[@name='getNotificationChannelTracker' and count(parameter)=0]"
			[Register ("getNotificationChannelTracker", "()Lcom/onesignal/influence/data/OSChannelTracker;", "")]
			get {
				const string __id = "getNotificationChannelTracker.()Lcom/onesignal/influence/data/OSChannelTracker;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> SessionInfluences {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/method[@name='getSessionInfluences' and count(parameter)=0]"
			[Register ("getSessionInfluences", "()Ljava/util/List;", "")]
			get {
				const string __id = "getSessionInfluences.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Domain.OSInfluence>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/method[@name='addSessionData' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.util.List&lt;com.onesignal.influence.domain.OSInfluence&gt;']]"
		[Register ("addSessionData", "(Lorg/json/JSONObject;Ljava/util/List;)V", "")]
		public unsafe void AddSessionData (global::Org.Json.JSONObject jsonObject, global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Domain.OSInfluence> influences)
		{
			const string __id = "addSessionData.(Lorg/json/JSONObject;Ljava/util/List;)V";
			IntPtr native_influences = global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Domain.OSInfluence>.ToLocalJniHandle (influences);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				__args [1] = new JniArgumentValue (native_influences);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_influences);
				global::System.GC.KeepAlive (jsonObject);
				global::System.GC.KeepAlive (influences);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/method[@name='getChannelByEntryAction' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.AppEntryAction']]"
		[Register ("getChannelByEntryAction", "(Lcom/onesignal/OneSignal$AppEntryAction;)Lcom/onesignal/influence/data/OSChannelTracker;", "")]
		public unsafe global::Com.Onesignal.Influence.Data.OSChannelTracker? GetChannelByEntryAction (global::Com.OneSignal.Android.OneSignal.AppEntryAction entryAction)
		{
			const string __id = "getChannelByEntryAction.(Lcom/onesignal/OneSignal$AppEntryAction;)Lcom/onesignal/influence/data/OSChannelTracker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((entryAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entryAction).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Onesignal.Influence.Data.OSChannelTracker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (entryAction);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/method[@name='getChannelsToResetByEntryAction' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.AppEntryAction']]"
		[Register ("getChannelsToResetByEntryAction", "(Lcom/onesignal/OneSignal$AppEntryAction;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Onesignal.Influence.Data.OSChannelTracker> GetChannelsToResetByEntryAction (global::Com.OneSignal.Android.OneSignal.AppEntryAction entryAction)
		{
			const string __id = "getChannelsToResetByEntryAction.(Lcom/onesignal/OneSignal$AppEntryAction;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((entryAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entryAction).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Onesignal.Influence.Data.OSChannelTracker>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
				global::System.GC.KeepAlive (entryAction);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/method[@name='initFromCache' and count(parameter)=0]"
		[Register ("initFromCache", "()V", "")]
		public unsafe void InitFromCache ()
		{
			const string __id = "initFromCache.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.influence.data']/class[@name='OSTrackerFactory']/method[@name='saveInfluenceParams' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignalRemoteParams.InfluenceParams']]"
		[Register ("saveInfluenceParams", "(Lcom/onesignal/OneSignalRemoteParams$InfluenceParams;)V", "")]
		public unsafe void SaveInfluenceParams (global::Com.OneSignal.Android.OneSignalRemoteParams.InfluenceParams influenceParams)
		{
			const string __id = "saveInfluenceParams.(Lcom/onesignal/OneSignalRemoteParams$InfluenceParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((influenceParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) influenceParams).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (influenceParams);
			}
		}

	}
}
