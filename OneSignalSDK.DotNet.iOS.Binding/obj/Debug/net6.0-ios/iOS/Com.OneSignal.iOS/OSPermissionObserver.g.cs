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
	[Protocol (Name = "OSPermissionObserver", WrapperType = typeof (OSPermissionObserverWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnOSPermissionChanged", Selector = "onOSPermissionChanged:", ParameterType = new Type [] { typeof (Com.OneSignal.iOS.OSPermissionStateChanges) }, ParameterByRef = new bool [] { false })]
	public partial interface IOSPermissionObserver : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onOSPermissionChanged:")]
		[Preserve (Conditional = true)]
		void OnOSPermissionChanged (OSPermissionStateChanges stateChanges);
	}
	internal sealed class OSPermissionObserverWrapper : BaseWrapper, IOSPermissionObserver {
		[Preserve (Conditional = true)]
		public OSPermissionObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onOSPermissionChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnOSPermissionChanged (OSPermissionStateChanges stateChanges)
		{
			var stateChanges__handle__ = stateChanges!.GetNonNullHandle (nameof (stateChanges));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("onOSPermissionChanged:"), stateChanges__handle__);
		}
	}
}
namespace Com.OneSignal.iOS {
	[Protocol()]
	[Register("ApiDefinition__Com_OneSignal_iOS_OSPermissionObserver", false)]
	[Model]
	public unsafe abstract partial class OSPermissionObserver : NSObject, IOSPermissionObserver {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected OSPermissionObserver () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected OSPermissionObserver (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal OSPermissionObserver (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onOSPermissionChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnOSPermissionChanged (OSPermissionStateChanges stateChanges)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class OSPermissionObserver */
}
