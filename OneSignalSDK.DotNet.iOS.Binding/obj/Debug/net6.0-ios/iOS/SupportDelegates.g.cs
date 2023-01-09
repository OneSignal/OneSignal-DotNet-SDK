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
	#nullable enable
	public delegate void IosContentHandlerBlock (UserNotifications.UNNotificationContent arg0);
	public delegate void OSEmailFailureBlock (NSError arg0);
	public delegate void OSEmailSuccessBlock ();
	public delegate void OSFailureBlock (NSError arg0);
	public delegate void OSInAppMessageClickBlock (Com.OneSignal.iOS.OSInAppMessageAction arg0);
	public delegate void OSNotificationDisplayResponse (Com.OneSignal.iOS.OSNotification? arg0);
	public delegate void OSNotificationOpenedBlock (Com.OneSignal.iOS.OSNotificationOpenedResult arg0);
	public delegate void OSNotificationWillShowInForegroundBlock (Com.OneSignal.iOS.OSNotification arg0, Com.OneSignal.iOS.OSNotificationDisplayResponse arg1);
	public delegate void OSResultSuccessBlock (NSDictionary arg0);
	public delegate void OSSMSFailureBlock (NSError arg0);
	public delegate void OSSMSSuccessBlock (NSDictionary arg0);
	public delegate void OSSendOutcomeSuccess (Com.OneSignal.iOS.OSOutcomeEvent arg0);
	public delegate void OSUpdateExternalUserIdFailureBlock (NSError arg0);
	public delegate void OSUpdateExternalUserIdSuccessBlock (NSDictionary arg0);
	public delegate void OSUpdateLanguageFailureBlock (NSError arg0);
	public delegate void OSUpdateLanguageSuccessBlock ();
	public delegate void OSUserResponseBlock (bool arg0);
}
