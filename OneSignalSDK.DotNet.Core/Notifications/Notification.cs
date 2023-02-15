﻿using System;
using System.Collections.Generic;

namespace OneSignalSDK.DotNet.Core.Notifications;

/// <summary>
/// Represents a notification.
/// </summary>
public record Notification
{
    /// <summary>
    /// The title displayed to the user.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// The body displayed to the user.
    /// </summary>
    public string? Body { get; init; }

    /// <summary>
    /// The sound information specified when creating the notification.
    /// </summary>
    public string? Sound { get; init; }

    /// <summary>
    /// The launch URL information specified when creating the notification.
    /// </summary>
    public string? LaunchUrl { get; init; }

    /// <summary>
    /// The action buttons specified when creating the notification.
    /// </summary>
    public IList<ActionButton> ActionButtons { get; init; } = new List<ActionButton>();

    /// <summary>
    /// The key/value custom additional data specified when creating the notification.
    /// </summary>
    public IDictionary<string, object> AdditionalData { get; init; } = new Dictionary<string, object>();

    /// <summary>
    /// The OneSignal notification id.
    /// </summary>
    public string? NotificationId { get; init; }

    /// <summary>
    /// When non-null this is a summary notification, and this contains the list of notifications this summarizes.
    /// </summary>
    public IList<Notification>? GroupedNotifications { get; init; }

    /// <summary>
    /// The background image layout information specified when creating the notification.
    /// </summary>
    public BackgroundImageLayout? BackgroundImageLayout { get; init; }

    /// <summary>
    /// The id of the OneSignal tempalte that created this notification. If no template was used,
    /// this will be null.
    /// </summary>
    public string? TemplateId { get; init; }

    /// <summary>
    /// The name of the OneSignal template that created this notification. If no template was
    /// used, this will be null.
    /// </summary>
    public string? TemplateName { get; init; }

    #region Android
    /// <summary>
    /// (Android Only) The group key information specified when creating the notification.
    /// </summary>
    public string? GroupKey { get; init; }

    /// <summary>
    /// (Android Only) The group message information specified when creating the notification.
    /// </summary>
    public string? GroupMessage { get; init; }

    /// <summary>
    /// (Android Only) The LED color information specified when creating the notification.
    /// </summary>
    public string? LedColor { get; init; }

    /// <summary>
    /// (Android Only) The priority information specified when creating the notification.
    /// </summary>
    public int? Priority { get; init; }

    /// <summary>
    /// (Android Only) The small icon information specified when creating the notification.
    /// </summary>
    public string? SmallIcon { get; init; }

    /// <summary>
    /// (Android Only) The large icon information specified when creating the notification.
    /// </summary>
    public string? LargeIcon { get; init; }

    /// <summary>
    /// (Android Only) The big picture information specified when creating the notification.
    /// </summary>
    public string? BigPicture { get; init; }

    /// <summary>
    /// (Android Only) The collapse ID specified when creating the notification.
    /// </summary>
    public string? CollapseId { get; init; }

    /// <summary>
    /// (Android Only) The from project information specified when creating the notification.
    /// </summary>
    public string? FromProjectNumber { get; init; }

    /// <summary>
    /// (Android Only) The accent color of the small icon specified when creating the notification.
    /// </summary>
    public string? SmallIconAccentColor { get; init; }

    /// <summary>
    /// (Android Only) The lock screen visibility information specified when creating the notification.
    /// </summary>
    public int? LockScreenVisibility { get; init; }

    /// <summary>
    /// (Android Only) Android notification id. Can later be used to dismiss the notification programmatically.
    /// </summary>
    public int? AndroidNotificationId { get; init; }
    #endregion Android

    #region iOS
    public string? Badge { get; init; }

    public string? BadgeIncrement { get; init; }

    /// <summary>
    /// (iOS Only) Show associated actions and buttons for the category.
    /// </summary>
    public string? Category { get; init; }

    public string? ThreadId { get; init; }

    /// <summary>
    /// (iOS Only) The subtitle of the notification.
    /// </summary>
    public string? Subtitle { get; init; }

    /// <summary>
    /// (iOS Only) The order the notification is shown for users that have chosen to receive your notifications as part
    /// of their Scheduled Summary digest (iOS 15+).
    /// </summary>
    public float? RelevanceScore { get; init; }

    /// <summary>
    /// (iOS Only) Whether content is mutable.
    /// </summary>
    public bool? MutableContent { get; init; }

    /// <summary>
    /// (iOS Only) Whether content is available.
    /// </summary>
    public bool? ContentAvailable { get; init; }

    /// <summary>
    /// (iOS Only) When and how the notification is displayed.
    /// </summary>
    public string? InterruptionLevel { get; init; }
    #endregion iOS
}

/// <summary>
/// An action button within a <see cref="Notification"/>.
/// </summary>
public record ActionButton
{
    /// <summary>
    /// The ID of the action button specified when creating the notification.
    /// </summary>
    public string? Id { get; init; }

    /// <summary>
    /// The text displayed on the action button.
    /// </summary>
    public string? Text { get; init; }

    /// <summary>
    /// The icon displayed on the action button.
    /// </summary>
    public string? Icon { get; init; }
}

/// <summary>
/// Background image layout information for a <see cref="Notification"/>.
/// </summary>
public record BackgroundImageLayout
{
    /// <summary>
    /// The asset file, android resource name, or URL to remote image.
    /// </summary>
    public string? Image { get; init; }

    /// <summary>
    /// The title text color.
    /// </summary>
    public string? TitleTextColor { get; init; }

    /// <summary>
    /// The body text color.
    /// </summary>
    public string? BodyTextColor { get; init; }
}