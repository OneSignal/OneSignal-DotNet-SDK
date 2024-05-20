#!/bin/bash
set -e

WORKING_DIR=$(pwd)

move_ios_binary() {
    FRAMEWORK_PATH=$1
    cp -a "${FRAMEWORK_PATH}" "OneSignalSDK.DotNet.iOS.Binding"
}

update_ios_binaries() {
    rm -rf OneSignalSDK.DotNet.iOS.Binding/OneSignalCore.xcframework/
    rm -rf OneSignalSDK.DotNet.iOS.Binding/OneSignalExtension.xcframework/
    rm -rf OneSignalSDK.DotNet.iOS.Binding/OneSignalFramework.xcframework/
    rm -rf OneSignalSDK.DotNet.iOS.Binding/OneSignalNotifications.xcframework/
    rm -rf OneSignalSDK.DotNet.iOS.Binding/OneSignalOSCore.xcframework/
    rm -rf OneSignalSDK.DotNet.iOS.Binding/OneSignalOutcomes.xcframework/
    rm -rf OneSignalSDK.DotNet.iOS.Binding/OneSignalUser.xcframework/
    rm -rf OneSignalSDK.DotNet.iOS.Binding/OneSignalInAppMessages.xcframework/
    rm -rf OneSignalSDK.DotNet.iOS.Binding/OneSignalLocation.xcframework/
    rm -rf OneSignalSDK.DotNet.iOS.Binding/OneSignalLiveActivities.xcframework/
    move_ios_binary "../OneSignal-iOS-SDK/iOS_SDK/OneSignalSDK/OneSignal_XCFramework/OneSignalFramework.xcframework"
    move_ios_binary "../OneSignal-iOS-SDK/iOS_SDK/OneSignalSDK/OneSignal_Core/OneSignalCore.xcframework"
    move_ios_binary "../OneSignal-iOS-SDK/iOS_SDK/OneSignalSDK/OneSignal_Extension/OneSignalExtension.xcframework"
    move_ios_binary "../OneSignal-iOS-SDK/iOS_SDK/OneSignalSDK/OneSignal_Notifications/OneSignalNotifications.xcframework"
    move_ios_binary "../OneSignal-iOS-SDK/iOS_SDK/OneSignalSDK/OneSignal_OSCore/OneSignalOSCore.xcframework"
    move_ios_binary "../OneSignal-iOS-SDK/iOS_SDK/OneSignalSDK/OneSignal_Outcomes/OneSignalOutcomes.xcframework"
    move_ios_binary "../OneSignal-iOS-SDK/iOS_SDK/OneSignalSDK/OneSignal_User/OneSignalUser.xcframework"
    move_ios_binary "../OneSignal-iOS-SDK/iOS_SDK/OneSignalSDK/OneSignal_InAppMessages/OneSignalInAppMessages.xcframework"
    move_ios_binary "../OneSignal-iOS-SDK/iOS_SDK/OneSignalSDK/OneSignal_Location/OneSignalLocation.xcframework"
    move_ios_binary "../OneSignal-iOS-SDK/iOS_SDK/OneSignalSDK/OneSignal_LiveActivities/OneSignalLiveActivities.xcframework"
}

update_ios_binaries