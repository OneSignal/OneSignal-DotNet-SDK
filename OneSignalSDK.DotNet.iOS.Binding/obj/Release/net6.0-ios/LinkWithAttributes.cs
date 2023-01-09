[assembly: ObjCRuntime.LinkWith ("OneSignal.xcframework", ForceLoad = true, Frameworks = "SystemConfiguration UserNotifications WebKit CoreGraphics UIKit OneSignalOutcomes OneSignalCore OneSignalExtension")]
[assembly: ObjCRuntime.LinkWith ("OneSignalCore.xcframework", ForceLoad = true)]
[assembly: ObjCRuntime.LinkWith ("OneSignalExtension.xcframework", ForceLoad = true, Frameworks = "UserNotifications OneSignalCore OneSignalOutcomes")]
[assembly: ObjCRuntime.LinkWith ("OneSignalOutcomes.xcframework", ForceLoad = true, Frameworks = "OneSignalCore")]
