#!/bin/bash
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
DEMO_DIR="$(dirname "$SCRIPT_DIR")"
BINDING_DIR="$DEMO_DIR/../../OneSignalSDK.DotNet.iOS.Binding"
WIDGET_SOURCES="$SCRIPT_DIR/OneSignalWidgetBundle.swift $SCRIPT_DIR/OneSignalWidgetLiveActivity.swift"

CONFIGURATION="${1:-Debug}"
PLATFORM="${2:-iossimulator}"  # iossimulator or ios
ARCH="${3:-arm64}"

BUILD_DIR="$SCRIPT_DIR/build"
APPEX_NAME="OneSignalWidgetExtension"
APPEX_DIR="$BUILD_DIR/$APPEX_NAME.appex"
BUNDLE_ID="com.onesignal.example.OneSignalWidget"

rm -rf "$BUILD_DIR"
mkdir -p "$APPEX_DIR"

if [ "$PLATFORM" = "iossimulator" ]; then
    SDK="iphonesimulator"
    TARGET="$ARCH-apple-ios16.2-simulator"
    FRAMEWORK_SLICE="ios-arm64_x86_64-simulator"
else
    SDK="iphoneos"
    TARGET="$ARCH-apple-ios16.2"
    FRAMEWORK_SLICE="ios-arm64"
fi

SDK_PATH=$(xcrun --sdk "$SDK" --show-sdk-path)
MIN_IOS="16.2"

FW_DIRS=""
FW_FLAGS=""
for fw in OneSignalLiveActivities OneSignalCore OneSignalOSCore OneSignalFramework OneSignalUser OneSignalNotifications OneSignalOutcomes OneSignalExtension OneSignalInAppMessages OneSignalLocation; do
    FW_PATH="$BINDING_DIR/$fw.xcframework/$FRAMEWORK_SLICE"
    if [ -d "$FW_PATH" ]; then
        FW_DIRS="$FW_DIRS -F $FW_PATH"
        FW_FLAGS="$FW_FLAGS -framework $fw"
    fi
done

echo "Building OneSignalWidget extension ($PLATFORM/$ARCH/$CONFIGURATION)..."

swiftc \
    -target "$TARGET" \
    -sdk "$SDK_PATH" \
    -O \
    -module-name "$APPEX_NAME" \
    $FW_DIRS \
    $FW_FLAGS \
    -framework WidgetKit \
    -framework SwiftUI \
    -framework ActivityKit \
    -Xlinker -rpath -Xlinker @executable_path/../../Frameworks \
    -emit-executable \
    -o "$APPEX_DIR/$APPEX_NAME" \
    $WIDGET_SOURCES

cp "$SCRIPT_DIR/Info.plist" "$APPEX_DIR/Info.plist"

# Add CFBundleIdentifier and other required keys to the extension Info.plist
/usr/libexec/PlistBuddy -c "Add :CFBundleIdentifier string $BUNDLE_ID" "$APPEX_DIR/Info.plist" 2>/dev/null || \
/usr/libexec/PlistBuddy -c "Set :CFBundleIdentifier $BUNDLE_ID" "$APPEX_DIR/Info.plist"

/usr/libexec/PlistBuddy -c "Add :CFBundleExecutable string $APPEX_NAME" "$APPEX_DIR/Info.plist" 2>/dev/null || \
/usr/libexec/PlistBuddy -c "Set :CFBundleExecutable $APPEX_NAME" "$APPEX_DIR/Info.plist"

/usr/libexec/PlistBuddy -c "Add :CFBundleName string $APPEX_NAME" "$APPEX_DIR/Info.plist" 2>/dev/null || \
/usr/libexec/PlistBuddy -c "Set :CFBundleName $APPEX_NAME" "$APPEX_DIR/Info.plist"

/usr/libexec/PlistBuddy -c "Add :CFBundleVersion string 1" "$APPEX_DIR/Info.plist" 2>/dev/null || \
/usr/libexec/PlistBuddy -c "Set :CFBundleVersion 1" "$APPEX_DIR/Info.plist"

/usr/libexec/PlistBuddy -c "Add :CFBundleShortVersionString string 1.0" "$APPEX_DIR/Info.plist" 2>/dev/null || \
/usr/libexec/PlistBuddy -c "Set :CFBundleShortVersionString 1.0" "$APPEX_DIR/Info.plist"

/usr/libexec/PlistBuddy -c "Add :CFBundlePackageType string XPC!" "$APPEX_DIR/Info.plist" 2>/dev/null || \
/usr/libexec/PlistBuddy -c "Set :CFBundlePackageType XPC!" "$APPEX_DIR/Info.plist"

/usr/libexec/PlistBuddy -c "Add :MinimumOSVersion string $MIN_IOS" "$APPEX_DIR/Info.plist" 2>/dev/null || \
/usr/libexec/PlistBuddy -c "Set :MinimumOSVersion $MIN_IOS" "$APPEX_DIR/Info.plist"

echo "Widget extension built at: $APPEX_DIR"
