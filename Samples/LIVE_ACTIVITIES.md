The Live Activities functionality is disabled by default as it requires manual work for the solution to successfull build.
This example is based off the work of https://github.com/chamons/xamarin-ios-swift-extension, which is an example of how to add a native Widget to a Xamarin application.

To establish a Live Activity from a Xamarin application you must create a native LiveActivity Widget, build it natively, then import it into the Xamarin project via the `AdditionalAppExtensions` csproj target.

To enable this functionality in the sample app, you must do the following on a mac:

1. Run `pod install` within `Samples/native/example`.
2. Using Xcode, open `Samples/native/example/example.xcworkspace`.
3. Go to menu File -> Workspace Settings and change `Derived Data` to `Project-relative Location` with path `DerivedData`.
4. Build the product for iPhone and/or the iPhoneSimulator, which will populate the `Derived Data` directory with the build output.
5. Using Visual Studio, open `OneSignal.sln`.
6. Within `Samples/OneSignalApp/OneSignalApp.csproj`, uncomment the block below `LIVE ACTIVITES: UNCOMMENT BELOW OUT FOR LIVE ACTIVITIES WIDGET`.
7. Change the platform to either `iPhone` or `iPhoneSimulator`, then build/run as the startup project `OneSignalApp`!