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
	[Protocol (Name = "OSInAppMessageLifecycleHandler", WrapperType = typeof (OSInAppMessageLifecycleHandlerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnWillDisplayInAppMessage", Selector = "onWillDisplayInAppMessage:", ParameterType = new Type [] { typeof (Com.OneSignal.iOS.OSInAppMessage) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnDidDisplayInAppMessage", Selector = "onDidDisplayInAppMessage:", ParameterType = new Type [] { typeof (Com.OneSignal.iOS.OSInAppMessage) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnWillDismissInAppMessage", Selector = "onWillDismissInAppMessage:", ParameterType = new Type [] { typeof (Com.OneSignal.iOS.OSInAppMessage) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnDidDismissInAppMessage", Selector = "onDidDismissInAppMessage:", ParameterType = new Type [] { typeof (Com.OneSignal.iOS.OSInAppMessage) }, ParameterByRef = new bool [] { false })]
	public partial interface IOSInAppMessageLifecycleHandler : INativeObject, IDisposable
	{
	}
	public static partial class OSInAppMessageLifecycleHandler_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnWillDisplayInAppMessage (this IOSInAppMessageLifecycleHandler This, OSInAppMessage message)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("onWillDisplayInAppMessage:"), message__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnDidDisplayInAppMessage (this IOSInAppMessageLifecycleHandler This, OSInAppMessage message)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("onDidDisplayInAppMessage:"), message__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnWillDismissInAppMessage (this IOSInAppMessageLifecycleHandler This, OSInAppMessage message)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("onWillDismissInAppMessage:"), message__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnDidDismissInAppMessage (this IOSInAppMessageLifecycleHandler This, OSInAppMessage message)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("onDidDismissInAppMessage:"), message__handle__);
		}
	}
	internal sealed class OSInAppMessageLifecycleHandlerWrapper : BaseWrapper, IOSInAppMessageLifecycleHandler {
		[Preserve (Conditional = true)]
		public OSInAppMessageLifecycleHandlerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Com.OneSignal.iOS {
	[Protocol()]
	[Register("ApiDefinition__Com_OneSignal_iOS_OSInAppMessageLifecycleHandler", false)]
	[Model]
	public unsafe partial class OSInAppMessageLifecycleHandler : NSObject, IOSInAppMessageLifecycleHandler {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public OSInAppMessageLifecycleHandler () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected OSInAppMessageLifecycleHandler (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal OSInAppMessageLifecycleHandler (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onDidDismissInAppMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnDidDismissInAppMessage (OSInAppMessage message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onDidDisplayInAppMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnDidDisplayInAppMessage (OSInAppMessage message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onWillDismissInAppMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnWillDismissInAppMessage (OSInAppMessage message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onWillDisplayInAppMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnWillDisplayInAppMessage (OSInAppMessage message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class OSInAppMessageLifecycleHandler */
}
