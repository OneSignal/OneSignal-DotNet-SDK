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
	[Protocol (Name = "OSEmailSubscriptionObserver", WrapperType = typeof (OSEmailSubscriptionObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnOSEmailSubscriptionChanged", Selector = "onOSEmailSubscriptionChanged:", ParameterType = new Type [] { typeof (Com.OneSignal.iOS.OSEmailSubscriptionStateChanges) }, ParameterByRef = new bool [] { false })]
	public partial interface IOSEmailSubscriptionObserver : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onOSEmailSubscriptionChanged:")]
		[Preserve (Conditional = true)]
		void OnOSEmailSubscriptionChanged (OSEmailSubscriptionStateChanges stateChanges);
	}
	internal sealed class OSEmailSubscriptionObserverWrapper : BaseWrapper, IOSEmailSubscriptionObserver {
		[Preserve (Conditional = true)]
		public OSEmailSubscriptionObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onOSEmailSubscriptionChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnOSEmailSubscriptionChanged (OSEmailSubscriptionStateChanges stateChanges)
		{
			var stateChanges__handle__ = stateChanges!.GetNonNullHandle (nameof (stateChanges));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("onOSEmailSubscriptionChanged:"), stateChanges__handle__);
		}
	}
}
namespace Com.OneSignal.iOS {
	[Protocol()]
	[Register("ApiDefinition__Com_OneSignal_iOS_OSEmailSubscriptionObserver", false)]
	[Model]
	public unsafe abstract partial class OSEmailSubscriptionObserver : NSObject, IOSEmailSubscriptionObserver {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected OSEmailSubscriptionObserver () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected OSEmailSubscriptionObserver (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal OSEmailSubscriptionObserver (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onOSEmailSubscriptionChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnOSEmailSubscriptionChanged (OSEmailSubscriptionStateChanges stateChanges)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class OSEmailSubscriptionObserver */
}
