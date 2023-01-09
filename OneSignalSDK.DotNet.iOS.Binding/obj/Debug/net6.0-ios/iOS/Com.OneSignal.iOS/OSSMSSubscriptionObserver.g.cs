//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Com.OneSignal.iOS {
	[Protocol (Name = "OSSMSSubscriptionObserver", WrapperType = typeof (OSSMSSubscriptionObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnOSSMSSubscriptionChanged", Selector = "onOSSMSSubscriptionChanged:", ParameterType = new Type [] { typeof (Com.OneSignal.iOS.OSSMSSubscriptionStateChanges) }, ParameterByRef = new bool [] { false })]
	public partial interface IOSSMSSubscriptionObserver : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onOSSMSSubscriptionChanged:")]
		[Preserve (Conditional = true)]
		void OnOSSMSSubscriptionChanged (OSSMSSubscriptionStateChanges stateChanges);
	}
	internal sealed class OSSMSSubscriptionObserverWrapper : BaseWrapper, IOSSMSSubscriptionObserver {
		[Preserve (Conditional = true)]
		public OSSMSSubscriptionObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onOSSMSSubscriptionChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnOSSMSSubscriptionChanged (OSSMSSubscriptionStateChanges stateChanges)
		{
			var stateChanges__handle__ = stateChanges!.GetNonNullHandle (nameof (stateChanges));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("onOSSMSSubscriptionChanged:"), stateChanges__handle__);
		}
	}
}
namespace Com.OneSignal.iOS {
	[Protocol()]
	[Register("ApiDefinition__Com_OneSignal_iOS_OSSMSSubscriptionObserver", false)]
	[Model]
	public unsafe abstract partial class OSSMSSubscriptionObserver : NSObject, IOSSMSSubscriptionObserver {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected OSSMSSubscriptionObserver () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected OSSMSSubscriptionObserver (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal OSSMSSubscriptionObserver (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onOSSMSSubscriptionChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnOSSMSSubscriptionChanged (OSSMSSubscriptionStateChanges stateChanges)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class OSSMSSubscriptionObserver */
}
