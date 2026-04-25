using Foundation;
using UIKit;

namespace OneSignalDemo;

// CommunityToolkit.Maui's Popup (v12+) presents as a transparent modal
// ContentPage and is not wired into MAUI's KeyboardAutoManagerScroll, so
// when the keyboard slides up the popup stays put and bottom-aligned
// action buttons end up under the keyboard (e.g. the "Send" button on
// `Send Outcome` after focusing the numeric value field).
//
// Strategy: instead of translating the popup view, push the keyboard's
// height into the topmost presented UIViewController's
// AdditionalSafeAreaInsets.Bottom. UIKit then re-lays out the popup VC
// inside the reduced safe area, MAUI re-centers the card vertically,
// and the result is a card that always sits above the keyboard with the
// title fully visible. This is the same pattern Apple recommends for
// UIKit form sheets and avoids the pitfalls of CATransform-based
// approaches (no over-shift past the safe area, no per-popup geometry
// tracking, no view-tree responder scanning).
internal static class PopupKeyboardAvoider
{
    private static NSObject? _willChangeToken;
    private static NSObject? _willHideToken;

    public static void Install()
    {
        if (_willChangeToken is not null)
            return;

        Console.WriteLine("[PopupKeyboardAvoider] Install");

        _willChangeToken = NSNotificationCenter.DefaultCenter.AddObserver(
            UIKeyboard.WillChangeFrameNotification,
            OnKeyboardFrameChange
        );
        _willHideToken = NSNotificationCenter.DefaultCenter.AddObserver(
            UIKeyboard.WillHideNotification,
            OnKeyboardHide
        );
    }

    private static void OnKeyboardFrameChange(NSNotification note)
    {
        var window = GetKeyWindow();
        var vc = GetTopPresentedPopupVc(window);
        if (window is null || vc?.View is null)
        {
            return;
        }

        var keyboardFrameInWindow = UIKeyboard.FrameEndFromNotification(note);
        var viewFrameInWindow =
            vc.View.Superview?.ConvertRectToView(vc.View.Frame, null) ?? vc.View.Frame;
        var bottomOverlap =
            viewFrameInWindow.Y + viewFrameInWindow.Height - keyboardFrameInWindow.Y;
        if (bottomOverlap < 0)
        {
            bottomOverlap = 0;
        }

        Console.WriteLine(
            $"[PopupKeyboardAvoider] frameChange overlap={bottomOverlap} vc={vc.GetType().Name}"
        );

        ApplyBottomInset(note, vc, bottomOverlap);
    }

    private static void OnKeyboardHide(NSNotification note)
    {
        var vc = GetTopPresentedPopupVc(GetKeyWindow());
        if (vc is null)
            return;
        ApplyBottomInset(note, vc, 0);
    }

    private static void ApplyBottomInset(NSNotification note, UIViewController vc, nfloat bottom)
    {
        var current = vc.AdditionalSafeAreaInsets;
        if (current.Bottom == bottom)
            return;

        var duration = UIKeyboard.AnimationDurationFromNotification(note);
        if (duration <= 0)
            duration = 0.25;

        UIView.Animate(
            duration,
            () =>
            {
                var insets = vc.AdditionalSafeAreaInsets;
                insets.Bottom = bottom;
                vc.AdditionalSafeAreaInsets = insets;
                vc.View?.LayoutIfNeeded();
            }
        );
    }

    private static UIViewController? GetTopPresentedPopupVc(UIWindow? window)
    {
        var root = window?.RootViewController;
        if (root is null)
            return null;

        var top = root;
        while (top.PresentedViewController is not null)
        {
            top = top.PresentedViewController;
        }

        return ReferenceEquals(top, root) ? null : top;
    }

    private static UIWindow? GetKeyWindow()
    {
        foreach (var scene in UIApplication.SharedApplication.ConnectedScenes)
        {
            if (scene is UIWindowScene ws)
            {
                foreach (var w in ws.Windows)
                {
                    if (w.IsKeyWindow)
                        return w;
                }
            }
        }
        return null;
    }
}
