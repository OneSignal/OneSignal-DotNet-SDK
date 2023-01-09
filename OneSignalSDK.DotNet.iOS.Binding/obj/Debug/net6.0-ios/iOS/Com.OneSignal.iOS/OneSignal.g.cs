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
	[Register("OneSignal", true)]
	public unsafe partial class OneSignal : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("OneSignal");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public OneSignal () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected OneSignal (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal OneSignal (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addEmailSubscriptionObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddEmailSubscriptionObserver (OSEmailSubscriptionObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("addEmailSubscriptionObserver:"), observer__handle__);
		}
		[Export ("addPermissionObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddPermissionObserver (OSPermissionObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("addPermissionObserver:"), observer__handle__);
		}
		[Export ("addSMSSubscriptionObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddSMSSubscriptionObserver (OSSMSSubscriptionObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("addSMSSubscriptionObserver:"), observer__handle__);
		}
		[Export ("addSubscriptionObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddSubscriptionObserver (OSSubscriptionObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("addSubscriptionObserver:"), observer__handle__);
		}
		[Export ("addTrigger:withValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddTrigger (string key, NSObject value)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("addTrigger:withValue:"), nskey, value__handle__);
			CFString.ReleaseNative (nskey);
		}
		[Export ("addTriggers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddTriggers (NSDictionary triggers)
		{
			var triggers__handle__ = triggers!.GetNonNullHandle (nameof (triggers));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("addTriggers:"), triggers__handle__);
		}
		[Export ("consentGranted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ConsentGranted (bool granted)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("consentGranted:"), granted);
		}
		[Export ("deleteTag:onSuccess:onFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DeleteTag (string key, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock? failureBlock)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("deleteTag:onSuccess:onFailure:"), nskey, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nskey);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("deleteTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteTag (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("deleteTag:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[Export ("deleteTags:onSuccess:onFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DeleteTags (NSObject[] keys, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock? failureBlock)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			var nsa_keys = NSArray.FromNSObjects (keys);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("deleteTags:onSuccess:onFailure:"), nsa_keys.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			nsa_keys.Dispose ();
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("deleteTags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteTags (string[] keys)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			var nsa_keys = NSArray.FromStrings (keys);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("deleteTags:"), nsa_keys.Handle);
			nsa_keys.Dispose ();
		}
		[Export ("deleteTagsWithJsonString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteTagsWithJsonString (string jsonString)
		{
			if (jsonString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (jsonString));
			var nsjsonString = CFString.CreateNative (jsonString);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("deleteTagsWithJsonString:"), nsjsonString);
			CFString.ReleaseNative (nsjsonString);
		}
		[Export ("getDeviceState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static OSDeviceState DeviceState ()
		{
			return  Runtime.GetNSObject<OSDeviceState> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getDeviceState")))!;
		}
		[Export ("didReceiveNotificationExtensionRequest:withMutableNotificationContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UserNotifications.UNMutableNotificationContent DidReceiveNotificationExtensionRequest (global::UserNotifications.UNNotificationRequest request, global::UserNotifications.UNMutableNotificationContent? replacementContent)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var replacementContent__handle__ = replacementContent.GetHandle ();
			return  Runtime.GetNSObject<global::UserNotifications.UNMutableNotificationContent> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("didReceiveNotificationExtensionRequest:withMutableNotificationContent:"), request__handle__, replacementContent__handle__))!;
		}
		[Export ("didReceiveNotificationExtensionRequest:withMutableNotificationContent:withContentHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static global::UserNotifications.UNMutableNotificationContent DidReceiveNotificationExtensionRequest (global::UserNotifications.UNNotificationRequest request, global::UserNotifications.UNMutableNotificationContent? replacementContent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDIosContentHandlerBlock))]IosContentHandlerBlock contentHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var replacementContent__handle__ = replacementContent.GetHandle ();
			if (contentHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (contentHandler));
			BlockLiteral *block_ptr_contentHandler;
			BlockLiteral block_contentHandler;
			block_contentHandler = new BlockLiteral ();
			block_ptr_contentHandler = &block_contentHandler;
			block_contentHandler.SetupBlockUnsafe (Trampolines.SDIosContentHandlerBlock.Handler, contentHandler);
			global::UserNotifications.UNMutableNotificationContent? ret;
			ret =  Runtime.GetNSObject<global::UserNotifications.UNMutableNotificationContent> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("didReceiveNotificationExtensionRequest:withMutableNotificationContent:withContentHandler:"), request__handle__, replacementContent__handle__, (IntPtr) block_ptr_contentHandler))!;
			block_ptr_contentHandler->CleanupBlock ();
			return ret!;
		}
		[Export ("disablePush:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DisablePush (bool disable)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("disablePush:"), disable);
		}
		[Export ("enterLiveActivity:withToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EnterLiveActivity (string activityId, string token)
		{
			if (activityId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (activityId));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			var nsactivityId = CFString.CreateNative (activityId);
			var nstoken = CFString.CreateNative (token);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("enterLiveActivity:withToken:"), nsactivityId, nstoken);
			CFString.ReleaseNative (nsactivityId);
			CFString.ReleaseNative (nstoken);
		}
		[Export ("enterLiveActivity:withToken:withSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void EnterLiveActivity (string activityId, string token, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock? failureBlock)
		{
			if (activityId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (activityId));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			var nsactivityId = CFString.CreateNative (activityId);
			var nstoken = CFString.CreateNative (token);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("enterLiveActivity:withToken:withSuccess:withFailure:"), nsactivityId, nstoken, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nsactivityId);
			CFString.ReleaseNative (nstoken);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("exitLiveActivity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ExitLiveActivity (string activityId)
		{
			if (activityId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (activityId));
			var nsactivityId = CFString.CreateNative (activityId);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("exitLiveActivity:"), nsactivityId);
			CFString.ReleaseNative (nsactivityId);
		}
		[Export ("exitLiveActivity:withSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ExitLiveActivity (string activityId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock? failureBlock)
		{
			if (activityId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (activityId));
			var nsactivityId = CFString.CreateNative (activityId);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("exitLiveActivity:withSuccess:withFailure:"), nsactivityId, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nsactivityId);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("getTags:onFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetTags ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock? failureBlock)
		{
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("getTags:onFailure:"), (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("getTags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetTags ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock? successBlock)
		{
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getTags:"), (IntPtr) block_ptr_successBlock);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
		}
		[Export ("getTriggerValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? GetTriggerValueForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getTriggerValueForKey:"), nskey))!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("getTriggers")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSObject> GetTriggers ()
		{
			return  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getTriggers")))!;
		}
		[Export ("initWithLaunchOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InitWithLaunchOptions (NSDictionary? launchOptions)
		{
			var launchOptions__handle__ = launchOptions.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("initWithLaunchOptions:"), launchOptions__handle__);
		}
		[Export ("isInAppMessagingPaused")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsInAppMessagingPaused ()
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isInAppMessagingPaused"));
		}
		[Export ("isLocationShared")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsLocationShared ()
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isLocationShared"));
		}
		[Export ("logoutEmail")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LogoutEmail ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("logoutEmail"));
		}
		[Export ("logoutEmailWithSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LogoutEmailWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSEmailSuccessBlock))]OSEmailSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSEmailFailureBlock))]OSEmailFailureBlock? failureBlock)
		{
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSEmailSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSEmailFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("logoutEmailWithSuccess:withFailure:"), (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("logoutSMSNumber")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LogoutSMSNumber ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("logoutSMSNumber"));
		}
		[Export ("logoutSMSNumberWithSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LogoutSMSNumberWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSSMSSuccessBlock))]OSSMSSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSSMSFailureBlock))]OSSMSFailureBlock? failureBlock)
		{
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSSMSSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSSMSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("logoutSMSNumberWithSuccess:withFailure:"), (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("onesignalLog:message:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnesignalLog (OneSLogLevel logLevel, string message)
		{
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (class_ptr, Selector.GetHandle ("onesignalLog:message:"), (UIntPtr) (ulong) logLevel, nsmessage);
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("pauseInAppMessages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PauseInAppMessages (bool pause)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("pauseInAppMessages:"), pause);
		}
		[Export ("postNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PostNotification (NSDictionary jsonData)
		{
			var jsonData__handle__ = jsonData!.GetNonNullHandle (nameof (jsonData));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("postNotification:"), jsonData__handle__);
		}
		[Export ("postNotification:onSuccess:onFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PostNotification (NSDictionary jsonData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock? failureBlock)
		{
			var jsonData__handle__ = jsonData!.GetNonNullHandle (nameof (jsonData));
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("postNotification:onSuccess:onFailure:"), jsonData__handle__, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("postNotificationWithJsonString:onSuccess:onFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PostNotificationWithJsonString (string jsonData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock? failureBlock)
		{
			if (jsonData is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (jsonData));
			var nsjsonData = CFString.CreateNative (jsonData);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("postNotificationWithJsonString:onSuccess:onFailure:"), nsjsonData, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nsjsonData);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("promptForPushNotificationsWithUserResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PromptForPushNotificationsWithUserResponse ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUserResponseBlock))]OSUserResponseBlock block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlockUnsafe (Trampolines.SDOSUserResponseBlock.Handler, block);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("promptForPushNotificationsWithUserResponse:"), (IntPtr) block_ptr_block);
			block_ptr_block->CleanupBlock ();
		}
		[Export ("promptForPushNotificationsWithUserResponse:fallbackToSettings:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PromptForPushNotificationsWithUserResponse ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUserResponseBlock))]OSUserResponseBlock block, bool fallback)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlockUnsafe (Trampolines.SDOSUserResponseBlock.Handler, block);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_bool (class_ptr, Selector.GetHandle ("promptForPushNotificationsWithUserResponse:fallbackToSettings:"), (IntPtr) block_ptr_block, fallback);
			block_ptr_block->CleanupBlock ();
		}
		[Export ("promptLocation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PromptLocation ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("promptLocation"));
		}
		[Export ("registerForProvisionalAuthorization:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RegisterForProvisionalAuthorization ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUserResponseBlock))]OSUserResponseBlock block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlockUnsafe (Trampolines.SDOSUserResponseBlock.Handler, block);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("registerForProvisionalAuthorization:"), (IntPtr) block_ptr_block);
			block_ptr_block->CleanupBlock ();
		}
		[Export ("registerForPushNotifications")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterForPushNotifications ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("registerForPushNotifications"));
		}
		[Export ("removeEmailSubscriptionObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveEmailSubscriptionObserver (OSEmailSubscriptionObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("removeEmailSubscriptionObserver:"), observer__handle__);
		}
		[Export ("removeExternalUserId")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveExternalUserId ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("removeExternalUserId"));
		}
		[Export ("removeExternalUserId:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RemoveExternalUserId ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUpdateExternalUserIdSuccessBlock))]OSUpdateExternalUserIdSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUpdateExternalUserIdFailureBlock))]OSUpdateExternalUserIdFailureBlock? failureBlock)
		{
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSUpdateExternalUserIdSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSUpdateExternalUserIdFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("removeExternalUserId:withFailure:"), (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("removePermissionObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemovePermissionObserver (OSPermissionObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("removePermissionObserver:"), observer__handle__);
		}
		[Export ("removeSMSSubscriptionObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveSMSSubscriptionObserver (OSSMSSubscriptionObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("removeSMSSubscriptionObserver:"), observer__handle__);
		}
		[Export ("removeSubscriptionObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveSubscriptionObserver (OSSubscriptionObserver observer)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("removeSubscriptionObserver:"), observer__handle__);
		}
		[Export ("removeTriggerForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveTriggerForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("removeTriggerForKey:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[Export ("removeTriggersForKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveTriggersForKeys (string[] keys)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			var nsa_keys = NSArray.FromStrings (keys);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("removeTriggersForKeys:"), nsa_keys.Handle);
			nsa_keys.Dispose ();
		}
		[Export ("requiresUserPrivacyConsent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool RequiresUserPrivacyConsent ()
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("requiresUserPrivacyConsent"));
		}
		[Export ("sendOutcome:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SendOutcome (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("sendOutcome:"), nsname);
			CFString.ReleaseNative (nsname);
		}
		[Export ("sendOutcome:onSuccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SendOutcome (string name, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSSendOutcomeSuccess))]OSSendOutcomeSuccess? success)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			if (success is null){
				block_ptr_success = null;
			} else {
				block_success = new BlockLiteral ();
				block_ptr_success = &block_success;
				block_success.SetupBlockUnsafe (Trampolines.SDOSSendOutcomeSuccess.Handler, success);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("sendOutcome:onSuccess:"), nsname, (IntPtr) block_ptr_success);
			CFString.ReleaseNative (nsname);
			if (block_ptr_success != null)
				block_ptr_success->CleanupBlock ();
		}
		[Export ("sendOutcomeWithValue:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SendOutcomeWithValue (string name, NSNumber value)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nsname = CFString.CreateNative (name);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("sendOutcomeWithValue:value:"), nsname, value__handle__);
			CFString.ReleaseNative (nsname);
		}
		[Export ("sendOutcomeWithValue:value:onSuccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SendOutcomeWithValue (string name, NSNumber value, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSSendOutcomeSuccess))]OSSendOutcomeSuccess? success)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nsname = CFString.CreateNative (name);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			if (success is null){
				block_ptr_success = null;
			} else {
				block_success = new BlockLiteral ();
				block_ptr_success = &block_success;
				block_success.SetupBlockUnsafe (Trampolines.SDOSSendOutcomeSuccess.Handler, success);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("sendOutcomeWithValue:value:onSuccess:"), nsname, value__handle__, (IntPtr) block_ptr_success);
			CFString.ReleaseNative (nsname);
			if (block_ptr_success != null)
				block_ptr_success->CleanupBlock ();
		}
		[Export ("sendTag:value:onSuccess:onFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SendTag (string key, string value, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock? failureBlock)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nskey = CFString.CreateNative (key);
			var nsvalue = CFString.CreateNative (value);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("sendTag:value:onSuccess:onFailure:"), nskey, nsvalue, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsvalue);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("sendTag:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SendTag (string key, string value)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nskey = CFString.CreateNative (key);
			var nsvalue = CFString.CreateNative (value);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("sendTag:value:"), nskey, nsvalue);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsvalue);
		}
		[Export ("sendTags:onSuccess:onFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SendTags (NSDictionary keyValuePair, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock? failureBlock)
		{
			var keyValuePair__handle__ = keyValuePair!.GetNonNullHandle (nameof (keyValuePair));
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("sendTags:onSuccess:onFailure:"), keyValuePair__handle__, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("sendTags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SendTags (NSDictionary keyValuePair)
		{
			var keyValuePair__handle__ = keyValuePair!.GetNonNullHandle (nameof (keyValuePair));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("sendTags:"), keyValuePair__handle__);
		}
		[Export ("sendTagsWithJsonString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SendTagsWithJsonString (string jsonString)
		{
			if (jsonString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (jsonString));
			var nsjsonString = CFString.CreateNative (jsonString);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("sendTagsWithJsonString:"), nsjsonString);
			CFString.ReleaseNative (nsjsonString);
		}
		[Export ("sendUniqueOutcome:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SendUniqueOutcome (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("sendUniqueOutcome:"), nsname);
			CFString.ReleaseNative (nsname);
		}
		[Export ("sendUniqueOutcome:onSuccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SendUniqueOutcome (string name, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSSendOutcomeSuccess))]OSSendOutcomeSuccess? success)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			if (success is null){
				block_ptr_success = null;
			} else {
				block_success = new BlockLiteral ();
				block_ptr_success = &block_success;
				block_success.SetupBlockUnsafe (Trampolines.SDOSSendOutcomeSuccess.Handler, success);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("sendUniqueOutcome:onSuccess:"), nsname, (IntPtr) block_ptr_success);
			CFString.ReleaseNative (nsname);
			if (block_ptr_success != null)
				block_ptr_success->CleanupBlock ();
		}
		[Export ("serviceExtensionTimeWillExpireRequest:withMutableNotificationContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UserNotifications.UNMutableNotificationContent ServiceExtensionTimeWillExpireRequest (global::UserNotifications.UNNotificationRequest request, global::UserNotifications.UNMutableNotificationContent? replacementContent)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var replacementContent__handle__ = replacementContent.GetHandle ();
			return  Runtime.GetNSObject<global::UserNotifications.UNMutableNotificationContent> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("serviceExtensionTimeWillExpireRequest:withMutableNotificationContent:"), request__handle__, replacementContent__handle__))!;
		}
		[Export ("setEmail:withEmailAuthHashToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEmail (string email, string? hashToken)
		{
			if (email is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (email));
			var nsemail = CFString.CreateNative (email);
			var nshashToken = CFString.CreateNative (hashToken);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setEmail:withEmailAuthHashToken:"), nsemail, nshashToken);
			CFString.ReleaseNative (nsemail);
			CFString.ReleaseNative (nshashToken);
		}
		[Export ("setEmail:withEmailAuthHashToken:withSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetEmail (string email, string? hashToken, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSEmailSuccessBlock))]OSEmailSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSEmailFailureBlock))]OSEmailFailureBlock? failureBlock)
		{
			if (email is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (email));
			var nsemail = CFString.CreateNative (email);
			var nshashToken = CFString.CreateNative (hashToken);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSEmailSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSEmailFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setEmail:withEmailAuthHashToken:withSuccess:withFailure:"), nsemail, nshashToken, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nsemail);
			CFString.ReleaseNative (nshashToken);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("setEmail:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEmail (string email)
		{
			if (email is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (email));
			var nsemail = CFString.CreateNative (email);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setEmail:"), nsemail);
			CFString.ReleaseNative (nsemail);
		}
		[Export ("setEmail:withSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetEmail (string email, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSEmailSuccessBlock))]OSEmailSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSEmailFailureBlock))]OSEmailFailureBlock? failureBlock)
		{
			if (email is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (email));
			var nsemail = CFString.CreateNative (email);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSEmailSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSEmailFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setEmail:withSuccess:withFailure:"), nsemail, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nsemail);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("setExternalUserId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetExternalUserId (string externalId)
		{
			if (externalId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (externalId));
			var nsexternalId = CFString.CreateNative (externalId);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setExternalUserId:"), nsexternalId);
			CFString.ReleaseNative (nsexternalId);
		}
		[Export ("setExternalUserId:withSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetExternalUserId (string externalId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUpdateExternalUserIdSuccessBlock))]OSUpdateExternalUserIdSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUpdateExternalUserIdFailureBlock))]OSUpdateExternalUserIdFailureBlock? failureBlock)
		{
			if (externalId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (externalId));
			var nsexternalId = CFString.CreateNative (externalId);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSUpdateExternalUserIdSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSUpdateExternalUserIdFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setExternalUserId:withSuccess:withFailure:"), nsexternalId, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nsexternalId);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("setExternalUserId:withExternalIdAuthHashToken:withSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetExternalUserId (string externalId, string hashToken, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUpdateExternalUserIdSuccessBlock))]OSUpdateExternalUserIdSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUpdateExternalUserIdFailureBlock))]OSUpdateExternalUserIdFailureBlock? failureBlock)
		{
			if (externalId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (externalId));
			if (hashToken is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (hashToken));
			var nsexternalId = CFString.CreateNative (externalId);
			var nshashToken = CFString.CreateNative (hashToken);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSUpdateExternalUserIdSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSUpdateExternalUserIdFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setExternalUserId:withExternalIdAuthHashToken:withSuccess:withFailure:"), nsexternalId, nshashToken, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nsexternalId);
			CFString.ReleaseNative (nshashToken);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("setInAppMessageClickHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetInAppMessageClickHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSInAppMessageClickBlock))]OSInAppMessageClickBlock? block)
		{
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			if (block is null){
				block_ptr_block = null;
			} else {
				block_block = new BlockLiteral ();
				block_ptr_block = &block_block;
				block_block.SetupBlockUnsafe (Trampolines.SDOSInAppMessageClickBlock.Handler, block);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setInAppMessageClickHandler:"), (IntPtr) block_ptr_block);
			if (block_ptr_block != null)
				block_ptr_block->CleanupBlock ();
		}
		[Export ("setInAppMessageLifecycleHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInAppMessageLifecycleHandler (OSInAppMessageLifecycleHandler? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setInAppMessageLifecycleHandler:"), @delegate__handle__);
		}
		[Export ("setLanguage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLanguage (string language)
		{
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nslanguage = CFString.CreateNative (language);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setLanguage:"), nslanguage);
			CFString.ReleaseNative (nslanguage);
		}
		[Export ("setLanguage:withSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetLanguage (string language, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUpdateLanguageSuccessBlock))]OSUpdateLanguageSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSUpdateLanguageFailureBlock))]OSUpdateLanguageFailureBlock failureBlock)
		{
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			if (failureBlock is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (failureBlock));
			var nslanguage = CFString.CreateNative (language);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSUpdateLanguageSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSUpdateLanguageFailureBlock.Handler, failureBlock);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setLanguage:withSuccess:withFailure:"), nslanguage, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nslanguage);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("setLaunchURLsInApp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLaunchURLsInApp (bool launchInApp)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setLaunchURLsInApp:"), launchInApp);
		}
		[Export ("setLocationShared:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLocationShared (bool enable)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setLocationShared:"), enable);
		}
		[Export ("setLogLevel:visualLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLogLevel (OneSLogLevel logLevel, OneSLogLevel visualLogLevel)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (class_ptr, Selector.GetHandle ("setLogLevel:visualLevel:"), (UIntPtr) (ulong) logLevel, (UIntPtr) (ulong) visualLogLevel);
		}
		[Export ("setMSDKType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetMSDKType (string type)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var nstype = CFString.CreateNative (type);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setMSDKType:"), nstype);
			CFString.ReleaseNative (nstype);
		}
		[Export ("setNotificationOpenedHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetNotificationOpenedHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSNotificationOpenedBlock))]OSNotificationOpenedBlock? block)
		{
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			if (block is null){
				block_ptr_block = null;
			} else {
				block_block = new BlockLiteral ();
				block_ptr_block = &block_block;
				block_block.SetupBlockUnsafe (Trampolines.SDOSNotificationOpenedBlock.Handler, block);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setNotificationOpenedHandler:"), (IntPtr) block_ptr_block);
			if (block_ptr_block != null)
				block_ptr_block->CleanupBlock ();
		}
		[Export ("setNotificationWillShowInForegroundHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetNotificationWillShowInForegroundHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSNotificationWillShowInForegroundBlock))]OSNotificationWillShowInForegroundBlock? block)
		{
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			if (block is null){
				block_ptr_block = null;
			} else {
				block_block = new BlockLiteral ();
				block_ptr_block = &block_block;
				block_block.SetupBlockUnsafe (Trampolines.SDOSNotificationWillShowInForegroundBlock.Handler, block);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setNotificationWillShowInForegroundHandler:"), (IntPtr) block_ptr_block);
			if (block_ptr_block != null)
				block_ptr_block->CleanupBlock ();
		}
		[Export ("setProvidesNotificationSettingsView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetProvidesNotificationSettingsView (bool providesView)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setProvidesNotificationSettingsView:"), providesView);
		}
		[Export ("setRequiresUserPrivacyConsent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetRequiresUserPrivacyConsent (bool required)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setRequiresUserPrivacyConsent:"), required);
		}
		[Export ("setSMSNumber:withSMSAuthHashToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSMSNumber (string smsNumber, string? hashToken)
		{
			if (smsNumber is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (smsNumber));
			var nssmsNumber = CFString.CreateNative (smsNumber);
			var nshashToken = CFString.CreateNative (hashToken);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setSMSNumber:withSMSAuthHashToken:"), nssmsNumber, nshashToken);
			CFString.ReleaseNative (nssmsNumber);
			CFString.ReleaseNative (nshashToken);
		}
		[Export ("setSMSNumber:withSMSAuthHashToken:withSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetSMSNumber (string smsNumber, string? hashToken, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSSMSSuccessBlock))]OSSMSSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSSMSFailureBlock))]OSSMSFailureBlock? failureBlock)
		{
			if (smsNumber is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (smsNumber));
			var nssmsNumber = CFString.CreateNative (smsNumber);
			var nshashToken = CFString.CreateNative (hashToken);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSSMSSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSSMSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setSMSNumber:withSMSAuthHashToken:withSuccess:withFailure:"), nssmsNumber, nshashToken, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nssmsNumber);
			CFString.ReleaseNative (nshashToken);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[Export ("setSMSNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSMSNumber (string smsNumber)
		{
			if (smsNumber is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (smsNumber));
			var nssmsNumber = CFString.CreateNative (smsNumber);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setSMSNumber:"), nssmsNumber);
			CFString.ReleaseNative (nssmsNumber);
		}
		[Export ("setSMSNumber:withSuccess:withFailure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetSMSNumber (string smsNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSSMSSuccessBlock))]OSSMSSuccessBlock? successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSSMSFailureBlock))]OSSMSFailureBlock? failureBlock)
		{
			if (smsNumber is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (smsNumber));
			var nssmsNumber = CFString.CreateNative (smsNumber);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			if (successBlock is null){
				block_ptr_successBlock = null;
			} else {
				block_successBlock = new BlockLiteral ();
				block_ptr_successBlock = &block_successBlock;
				block_successBlock.SetupBlockUnsafe (Trampolines.SDOSSMSSuccessBlock.Handler, successBlock);
			}
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			if (failureBlock is null){
				block_ptr_failureBlock = null;
			} else {
				block_failureBlock = new BlockLiteral ();
				block_ptr_failureBlock = &block_failureBlock;
				block_failureBlock.SetupBlockUnsafe (Trampolines.SDOSSMSFailureBlock.Handler, failureBlock);
			}
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setSMSNumber:withSuccess:withFailure:"), nssmsNumber, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			CFString.ReleaseNative (nssmsNumber);
			if (block_ptr_successBlock != null)
				block_ptr_successBlock->CleanupBlock ();
			if (block_ptr_failureBlock != null)
				block_ptr_failureBlock->CleanupBlock ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string AppId {
			[Export ("appId")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("appId")))!;
			}
			[Export ("setAppId:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setAppId:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string SdkSemanticVersion {
			[Export ("sdkSemanticVersion")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sdkSemanticVersion")))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string SdkVersionRaw {
			[Export ("sdkVersionRaw")]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sdkVersionRaw")))!;
			}
		}
	} /* class OneSignal */
}
