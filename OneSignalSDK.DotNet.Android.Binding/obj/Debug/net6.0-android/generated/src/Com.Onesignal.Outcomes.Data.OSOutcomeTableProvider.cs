using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Onesignal.Outcomes.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal.outcomes.data']/class[@name='OSOutcomeTableProvider']"
	[global::Android.Runtime.Register ("com/onesignal/outcomes/data/OSOutcomeTableProvider", DoNotGenerateAcw=true)]
	public sealed partial class OSOutcomeTableProvider : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/onesignal/outcomes/data/OSOutcomeTableProvider", typeof (OSOutcomeTableProvider));

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

		internal OSOutcomeTableProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal.outcomes.data']/class[@name='OSOutcomeTableProvider']/constructor[@name='OSOutcomeTableProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSOutcomeTableProvider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.data']/class[@name='OSOutcomeTableProvider']/method[@name='upgradeCacheOutcomeTableRevision1To2' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("upgradeCacheOutcomeTableRevision1To2", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public unsafe void UpgradeCacheOutcomeTableRevision1To2 (global::Android.Database.Sqlite.SQLiteDatabase db)
		{
			const string __id = "upgradeCacheOutcomeTableRevision1To2.(Landroid/database/sqlite/SQLiteDatabase;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.data']/class[@name='OSOutcomeTableProvider']/method[@name='upgradeOutcomeTableRevision1To2' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("upgradeOutcomeTableRevision1To2", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public unsafe void UpgradeOutcomeTableRevision1To2 (global::Android.Database.Sqlite.SQLiteDatabase db)
		{
			const string __id = "upgradeOutcomeTableRevision1To2.(Landroid/database/sqlite/SQLiteDatabase;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal.outcomes.data']/class[@name='OSOutcomeTableProvider']/method[@name='upgradeOutcomeTableRevision2To3' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("upgradeOutcomeTableRevision2To3", "(Landroid/database/sqlite/SQLiteDatabase;)V", "")]
		public unsafe void UpgradeOutcomeTableRevision2To3 (global::Android.Database.Sqlite.SQLiteDatabase db)
		{
			const string __id = "upgradeOutcomeTableRevision2To3.(Landroid/database/sqlite/SQLiteDatabase;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (db);
			}
		}

	}
}
