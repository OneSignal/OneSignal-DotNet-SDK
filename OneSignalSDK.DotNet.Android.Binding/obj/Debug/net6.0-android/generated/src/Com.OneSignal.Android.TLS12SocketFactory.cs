using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='TLS12SocketFactory']"
	[global::Android.Runtime.Register ("com/onesignal/TLS12SocketFactory", DoNotGenerateAcw=true)]
	public partial class TLS12SocketFactory : global::Javax.Net.Ssl.SSLSocketFactory {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/TLS12SocketFactory", typeof (TLS12SocketFactory));

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

		protected TLS12SocketFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='TLS12SocketFactory']/constructor[@name='TLS12SocketFactory' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
		[Register (".ctor", "(Ljavax/net/ssl/SSLSocketFactory;)V", "")]
		public unsafe TLS12SocketFactory (global::Javax.Net.Ssl.SSLSocketFactory? sslSocketFactory) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljavax/net/ssl/SSLSocketFactory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sslSocketFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sslSocketFactory).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sslSocketFactory);
			}
		}

		static Delegate? cb_createSocket_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_lang_String_IHandler ()
		{
			if (cb_createSocket_Ljava_lang_String_I == null)
				cb_createSocket_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_CreateSocket_Ljava_lang_String_I);
			return cb_createSocket_Ljava_lang_String_I;
		}

		static IntPtr n_CreateSocket_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_host, int port)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.TLS12SocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (host, port));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='TLS12SocketFactory']/method[@name='createSocket' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", "GetCreateSocket_Ljava_lang_String_IHandler")]
		public override unsafe global::Java.Net.Socket? CreateSocket (string? host, int port)
		{
			const string __id = "createSocket.(Ljava/lang/String;I)Ljava/net/Socket;";
			IntPtr native_host = JNIEnv.NewString ((string?)host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_host);
				__args [1] = new JniArgumentValue (port);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		static Delegate? cb_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_lang_String_ILjava_net_InetAddress_IHandler ()
		{
			if (cb_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I == null)
				cb_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILI_L) n_CreateSocket_Ljava_lang_String_ILjava_net_InetAddress_I);
			return cb_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I;
		}

		static IntPtr n_CreateSocket_Ljava_lang_String_ILjava_net_InetAddress_I (IntPtr jnienv, IntPtr native__this, IntPtr native_host, int port, IntPtr native_localHost, int localPort)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.TLS12SocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
			var localHost = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_localHost, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (host, port, localHost, localPort));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='TLS12SocketFactory']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.net.InetAddress'] and parameter[4][@type='int']]"
		[Register ("createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;", "GetCreateSocket_Ljava_lang_String_ILjava_net_InetAddress_IHandler")]
		public override unsafe global::Java.Net.Socket? CreateSocket (string? host, int port, global::Java.Net.InetAddress? localHost, int localPort)
		{
			const string __id = "createSocket.(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;";
			IntPtr native_host = JNIEnv.NewString ((string?)host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_host);
				__args [1] = new JniArgumentValue (port);
				__args [2] = new JniArgumentValue ((localHost == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localHost).Handle);
				__args [3] = new JniArgumentValue (localPort);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
				global::System.GC.KeepAlive (localHost);
			}
		}

		static Delegate? cb_createSocket_Ljava_net_InetAddress_I;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_net_InetAddress_IHandler ()
		{
			if (cb_createSocket_Ljava_net_InetAddress_I == null)
				cb_createSocket_Ljava_net_InetAddress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_CreateSocket_Ljava_net_InetAddress_I);
			return cb_createSocket_Ljava_net_InetAddress_I;
		}

		static IntPtr n_CreateSocket_Ljava_net_InetAddress_I (IntPtr jnienv, IntPtr native__this, IntPtr native_host, int port)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.TLS12SocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var host = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_host, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (host, port));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='TLS12SocketFactory']/method[@name='createSocket' and count(parameter)=2 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int']]"
		[Register ("createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;", "GetCreateSocket_Ljava_net_InetAddress_IHandler")]
		public override unsafe global::Java.Net.Socket? CreateSocket (global::Java.Net.InetAddress? host, int port)
		{
			const string __id = "createSocket.(Ljava/net/InetAddress;I)Ljava/net/Socket;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((host == null) ? IntPtr.Zero : ((global::Java.Lang.Object) host).Handle);
				__args [1] = new JniArgumentValue (port);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (host);
			}
		}

		static Delegate? cb_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_IHandler ()
		{
			if (cb_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I == null)
				cb_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILI_L) n_CreateSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I);
			return cb_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I;
		}

		static IntPtr n_CreateSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I (IntPtr jnienv, IntPtr native__this, IntPtr native_address, int port, IntPtr native_localAddress, int localPort)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.TLS12SocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var address = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_address, JniHandleOwnership.DoNotTransfer);
			var localAddress = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_localAddress, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (address, port, localAddress, localPort));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='TLS12SocketFactory']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int'] and parameter[3][@type='java.net.InetAddress'] and parameter[4][@type='int']]"
		[Register ("createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;", "GetCreateSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_IHandler")]
		public override unsafe global::Java.Net.Socket? CreateSocket (global::Java.Net.InetAddress? address, int port, global::Java.Net.InetAddress? localAddress, int localPort)
		{
			const string __id = "createSocket.(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((address == null) ? IntPtr.Zero : ((global::Java.Lang.Object) address).Handle);
				__args [1] = new JniArgumentValue (port);
				__args [2] = new JniArgumentValue ((localAddress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localAddress).Handle);
				__args [3] = new JniArgumentValue (localPort);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (address);
				global::System.GC.KeepAlive (localAddress);
			}
		}

		static Delegate? cb_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_net_Socket_Ljava_lang_String_IZHandler ()
		{
			if (cb_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ == null)
				cb_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIZ_L) n_CreateSocket_Ljava_net_Socket_Ljava_lang_String_IZ);
			return cb_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ;
		}

		static IntPtr n_CreateSocket_Ljava_net_Socket_Ljava_lang_String_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_host, int port, bool autoClose)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.TLS12SocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var s = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_s, JniHandleOwnership.DoNotTransfer);
			var host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (s, host, port, autoClose));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='TLS12SocketFactory']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.net.Socket'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", "GetCreateSocket_Ljava_net_Socket_Ljava_lang_String_IZHandler")]
		public override unsafe global::Java.Net.Socket? CreateSocket (global::Java.Net.Socket? s, string? host, int port, bool autoClose)
		{
			const string __id = "createSocket.(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;";
			IntPtr native_host = JNIEnv.NewString ((string?)host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				__args [1] = new JniArgumentValue (native_host);
				__args [2] = new JniArgumentValue (port);
				__args [3] = new JniArgumentValue (autoClose);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
				global::System.GC.KeepAlive (s);
			}
		}

		static Delegate? cb_getDefaultCipherSuites;
#pragma warning disable 0169
		static Delegate GetGetDefaultCipherSuitesHandler ()
		{
			if (cb_getDefaultCipherSuites == null)
				cb_getDefaultCipherSuites = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultCipherSuites);
			return cb_getDefaultCipherSuites;
		}

		static IntPtr n_GetDefaultCipherSuites (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.TLS12SocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetDefaultCipherSuites ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='TLS12SocketFactory']/method[@name='getDefaultCipherSuites' and count(parameter)=0]"
		[Register ("getDefaultCipherSuites", "()[Ljava/lang/String;", "GetGetDefaultCipherSuitesHandler")]
		public override unsafe string[]? GetDefaultCipherSuites ()
		{
			const string __id = "getDefaultCipherSuites.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate? cb_getSupportedCipherSuites;
#pragma warning disable 0169
		static Delegate GetGetSupportedCipherSuitesHandler ()
		{
			if (cb_getSupportedCipherSuites == null)
				cb_getSupportedCipherSuites = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportedCipherSuites);
			return cb_getSupportedCipherSuites;
		}

		static IntPtr n_GetSupportedCipherSuites (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.TLS12SocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetSupportedCipherSuites ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='TLS12SocketFactory']/method[@name='getSupportedCipherSuites' and count(parameter)=0]"
		[Register ("getSupportedCipherSuites", "()[Ljava/lang/String;", "GetGetSupportedCipherSuitesHandler")]
		public override unsafe string[]? GetSupportedCipherSuites ()
		{
			const string __id = "getSupportedCipherSuites.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
