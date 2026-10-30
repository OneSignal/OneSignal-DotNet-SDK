namespace OneSignalDemo.Models;

public enum InAppMessageType
{
    TopBanner,
    BottomBanner,
    CenterModal,
    Html,
    FullScreen,
    FullBleed,
    Carousel,
    CarouselBleed,
}

public static class InAppMessageTypeExtensions
{
    public static string GetTriggerValue(this InAppMessageType type) =>
        type switch
        {
            InAppMessageType.TopBanner => "top_banner",
            InAppMessageType.BottomBanner => "bottom_banner",
            InAppMessageType.CenterModal => "center_modal",
            InAppMessageType.Html => "html",
            InAppMessageType.FullScreen => "full_screen",
            InAppMessageType.FullBleed => "full_bleed",
            InAppMessageType.Carousel => "carousel",
            InAppMessageType.CarouselBleed => "carousel_bleed",
            _ => "top_banner",
        };

    public static string GetDisplayName(this InAppMessageType type) =>
        type switch
        {
            InAppMessageType.TopBanner => "Top Banner",
            InAppMessageType.BottomBanner => "Bottom Banner",
            InAppMessageType.CenterModal => "Center Modal",
            InAppMessageType.Html => "HTML",
            InAppMessageType.FullScreen => "Full Screen",
            InAppMessageType.FullBleed => "Full Bleed",
            InAppMessageType.Carousel => "Carousel",
            InAppMessageType.CarouselBleed => "Carousel Bleed",
            _ => "Top Banner",
        };
}
