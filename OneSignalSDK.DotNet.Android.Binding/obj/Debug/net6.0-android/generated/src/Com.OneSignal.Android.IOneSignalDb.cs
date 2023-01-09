using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalDb']"
	[Register ("com/onesignal/OneSignalDb", "", "Com.OneSignal.Android.IOneSignalDbInvoker")]
	public partial interface IOneSignalDb : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalDb']/method[@name='delete' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "GetDelete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Handler:Com.OneSignal.Android.IOneSignalDbInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void Delete (string p0, string? p1, string[]? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalDb']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.ContentValues']]"
		[Register ("insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)V", "GetInsert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_Handler:Com.OneSignal.Android.IOneSignalDbInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void Insert (string p0, string? p1, global::Android.Content.ContentValues? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalDb']/method[@name='insertOrThrow' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.ContentValues']]"
		[Register ("insertOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)V", "GetInsertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_Handler:Com.OneSignal.Android.IOneSignalDbInvoker, OneSignalSDK.DotNet.Android.Binding")]
		void InsertOrThrow (string p0, string? p1, global::Android.Content.ContentValues? p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalDb']/method[@name='query' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.OneSignal.Android.IOneSignalDbInvoker, OneSignalSDK.DotNet.Android.Binding")]
		global::Android.Database.ICursor? Query (string p0, string[]? p1, string? p2, string[]? p3, string? p4, string? p5, string? p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalDb']/method[@name='query' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.OneSignal.Android.IOneSignalDbInvoker, OneSignalSDK.DotNet.Android.Binding")]
		global::Android.Database.ICursor? Query (string p0, string[]? p1, string? p2, string[]? p3, string? p4, string? p5, string? p6, string? p7);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignalDb']/method[@name='update' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.ContentValues'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", "GetUpdate_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler:Com.OneSignal.Android.IOneSignalDbInvoker, OneSignalSDK.DotNet.Android.Binding")]
		int Update (string p0, global::Android.Content.ContentValues p1, string? p2, string[]? p3);

	}

	[global::Android.Runtime.Register ("com/onesignal/OneSignalDb", DoNotGenerateAcw=true)]
	internal partial class IOneSignalDbInvoker : global::Java.Lang.Object, IOneSignalDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/OneSignalDb", typeof (IOneSignalDbInvoker));

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

		public static IOneSignalDb? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOneSignalDb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.onesignal.OneSignalDb'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOneSignalDbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static void n_Delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (string[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Delete (p0!, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_;
		public unsafe void Delete (string p0, string? p1, string[]? p2)
		{
			if (id_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate? cb_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetInsert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_Handler ()
		{
			if (cb_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ == null)
				cb_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_);
			return cb_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_;
		}

		static void n_Insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0!, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_;
		public unsafe void Insert (string p0, string? p1, global::Android.Content.ContentValues? p2)
		{
			if (id_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ == IntPtr.Zero)
				id_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_insertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetInsertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_Handler ()
		{
			if (cb_insertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ == null)
				cb_insertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_InsertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_);
			return cb_insertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_;
		}

		static void n_InsertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.InsertOrThrow (p0!, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_insertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_;
		public unsafe void InsertOrThrow (string p0, string? p1, global::Android.Content.ContentValues? p2)
		{
			if (id_insertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ == IntPtr.Zero)
				id_insertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "insertOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insertOrThrow_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate? cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLLL_L) n_Query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (string[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (string[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			var p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0!, p1, p2, p3, p4, p5, p6));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Android.Database.ICursor? Query (string p0, string[]? p1, string? p2, string[]? p3, string? p4, string? p5, string? p6)
		{
			if (id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
			IntPtr native_p5 = JNIEnv.NewString ((string?)p5);
			IntPtr native_p6 = JNIEnv.NewString ((string?)p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
			return __ret;
		}

		static Delegate? cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLLLL_L) n_Query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (string[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (string[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			var p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			var p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0!, p1, p2, p3, p4, p5, p6, p7));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Android.Database.ICursor? Query (string p0, string[]? p1, string? p2, string[]? p3, string? p4, string? p5, string? p6, string? p7)
		{
			if (id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
			IntPtr native_p5 = JNIEnv.NewString ((string?)p5);
			IntPtr native_p6 = JNIEnv.NewString ((string?)p6);
			IntPtr native_p7 = JNIEnv.NewString ((string?)p7);
			JValue* __args = stackalloc JValue [8];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			__args [7] = new JValue (native_p7);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
			JNIEnv.DeleteLocalRef (native_p7);
			return __ret;
		}

		static Delegate? cb_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_I) n_Update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IOneSignalDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (string[]?) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Update (p0!, p1!, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		public unsafe int Update (string p0, global::Android.Content.ContentValues p1, string? p2, string[]? p3)
		{
			if (id_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

	}
}
