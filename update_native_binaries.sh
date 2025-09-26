#!/bin/bash
set -e

### Usage
# iOS     - Clone OneSignal-iOS-SDK first, see the code below
# Android - Run with the version you want to grab. Example:
#.        ./update_native_binaries.sh --android_native_version=5.1.37

WORKING_DIR=$(pwd)

# Parse input params from terminal
for arg in "$@"; do
    case $arg in
        --android_native_version=*)
        ANDROID_NATIVE_VERSION="${arg#*=}"
        shift
        ;;
        -*)
        echo "Unknown option: $arg" >&2
        exit 1
        ;;
    esac
done


move_ios_binary() {
    FRAMEWORK_PATH=$1
    cp -a "${FRAMEWORK_PATH}" "OneSignalSDK.DotNet.iOS.Binding"
}

# NOTE: Make sure to git clone and git checkout the version of the iOS SDK first
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

# After running, check for 404 or other errors in the terminal
update_android_binaries() {
    curl https://repo1.maven.org/maven2/com/onesignal/core/${ANDROID_NATIVE_VERSION}/core-${ANDROID_NATIVE_VERSION}.aar \
         --output OneSignalSDK.DotNet.Android.Core.Binding/Jars/core-release.aar \
         --fail
    echo $?

    curl https://repo1.maven.org/maven2/com/onesignal/notifications/${ANDROID_NATIVE_VERSION}/notifications-${ANDROID_NATIVE_VERSION}.aar \
         --output OneSignalSDK.DotNet.Android.Notifications.Binding/Jars/notifications-release.aar \
         --fail
    echo $?

    curl https://repo1.maven.org/maven2/com/onesignal/location/${ANDROID_NATIVE_VERSION}/location-${ANDROID_NATIVE_VERSION}.aar \
         --output OneSignalSDK.DotNet.Android.Location.Binding/Jars/location-release.aar \
         --fail
    echo $?

    curl https://repo1.maven.org/maven2/com/onesignal/in-app-messages/${ANDROID_NATIVE_VERSION}/in-app-messages-${ANDROID_NATIVE_VERSION}.aar \
         --output OneSignalSDK.DotNet.Android.InAppMessages.Binding/Jars/in-app-messages-release.aar \
         --fail
    echo $?
}

update_ios_binaries
update_android_binaries
