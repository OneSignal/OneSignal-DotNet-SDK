using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;
using WebKit;

namespace Com.OneSignal.iOS {
    // @interface OSNotification : NSObject
    [BaseType(typeof(NSObject))]
    interface OSNotification
    {
        // @property (readonly) NSString * _Nullable notificationId;
        [NullAllowed, Export ("notificationId")]
        string NotificationId { get; }

        // @property (readonly) NSString * _Nullable templateId;
        [NullAllowed, Export ("templateId")]
        string TemplateId { get; }

        // @property (readonly) NSString * _Nullable templateName;
        [NullAllowed, Export ("templateName")]
        string TemplateName { get; }

        // @property (readonly) BOOL contentAvailable;
        [Export ("contentAvailable")]
        bool ContentAvailable { get; }

        // @property (readonly, getter = hasMutableContent) BOOL mutableContent;
        [Export ("mutableContent")]
        bool MutableContent { [Bind("hasMutableContent")] get; }

        // @property (readonly) NSString * _Nullable category;
        [NullAllowed, Export ("category")]
        string Category { get; }

        // @property (readonly) NSInteger badge;
        [Export ("badge")]
        nint Badge { get; }

        // @property (readonly) NSInteger badgeIncrement;
        [Export ("badgeIncrement")]
        nint BadgeIncrement { get; }

        // @property (readonly) NSString * _Nullable sound;
        [NullAllowed, Export ("sound")]
        string Sound { get; }

        // @property (readonly) NSString * _Nullable title;
        [NullAllowed, Export ("title")]
        string Title { get; }

        // @property (readonly) NSString * _Nullable subtitle;
        [NullAllowed, Export ("subtitle")]
        string Subtitle { get; }

        // @property (readonly) NSString * _Nullable body;
        [NullAllowed, Export ("body")]
        string Body { get; }

        // @property (readonly) NSString * _Nullable launchURL;
        [NullAllowed, Export ("launchURL")]
        string LaunchURL { get; }

        // @property (readonly) NSDictionary * _Nullable additionalData;
        [NullAllowed, Export ("additionalData")]
        NSDictionary AdditionalData { get; }

        // @property (readonly) NSDictionary * _Nullable attachments;
        [NullAllowed, Export ("attachments")]
        NSDictionary Attachments { get; }

        // @property (readonly) NSArray * _Nullable actionButtons;
        [NullAllowed, Export ("actionButtons")]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] ActionButtons { get; }

        // @property (readonly) NSDictionary * _Nonnull rawPayload;
        [Export ("rawPayload")]
        NSDictionary RawPayload { get; }

        // @property (readonly) NSString * _Nullable threadId;
        [NullAllowed, Export ("threadId")]
        string ThreadId { get; }

        // @property (readonly) NSNumber * _Nullable relevanceScore;
        [NullAllowed, Export ("relevanceScore")]
        NSNumber RelevanceScore { get; }

        // @property (readonly) NSString * _Nullable interruptionLevel;
        [NullAllowed, Export ("interruptionLevel")]
        string InterruptionLevel { get; }

        // @property (readonly) NSString * _Nullable collapseId;
        [NullAllowed, Export ("collapseId")]
        string CollapseId { get; }

        // +(instancetype _Nullable)parseWithApns:(NSDictionary * _Nonnull)message;
        [Static]
        [Export ("parseWithApns:")]
        [return: NullAllowed]
        OSNotification ParseWithApns(NSDictionary message);

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonRepresentation { get; }

        // -(NSString * _Nonnull)stringify;
        [Export ("stringify")]
        //[Verify(MethodToProperty)]
        string Stringify { get; }
    }

    // typedef void (^OSNotificationDisplayResponse)(OSNotification * _Nullable);
    delegate void OSNotificationDisplayResponse([NullAllowed] OSNotification arg0);

    // @interface OSNotificationClickResult : NSObject
    [BaseType(typeof(NSObject))]
    interface OSNotificationClickResult
    {
        // @property (readonly) NSString * _Nullable actionId;
        [NullAllowed, Export ("actionId")]
        string ActionId { get; }

        // @property (readonly) NSString * _Nullable url;
        [NullAllowed, Export ("url")]
        string Url { get; }
    }

    // @interface OSNotificationClickEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface OSNotificationClickEvent
    {
        // @property (readonly) OSNotification * _Nonnull notification;
        [Export ("notification")]
        OSNotification Notification { get; }

        // @property (readonly) OSNotificationClickResult * _Nonnull result;
        [Export ("result")]
        OSNotificationClickResult Result { get; }

        // -(NSString * _Nonnull)stringify;
        [Export ("stringify")]
        //[Verify(MethodToProperty)]
        string Stringify { get; }

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

    // @protocol OSDebug <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface OSDebug
    {
        // @required +(void)setLogLevel:(ONE_S_LOG_LEVEL)logLevel;
        //[Static, Abstract]
        [Export ("setLogLevel:")]
        void SetLogLevel(OneSLogLevel logLevel);

        // @required +(void)setAlertLevel:(ONE_S_LOG_LEVEL)logLevel __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("setAlertLevel:")]
        void SetAlertLevel(OneSLogLevel logLevel);
    }

    // @interface OneSignalWrapper : NSObject
    [BaseType(typeof(NSObject))]
    interface OneSignalWrapper
    {
        // @property (class) NSString * _Nullable sdkType;
        [Static]
        [NullAllowed, Export ("sdkType")]
        string SdkType { get; set; }

        // @property (class) NSString * _Nullable sdkVersion;
        [Static]
        [NullAllowed, Export ("sdkVersion")]
        string SdkVersion { get; set; }
    }

    // @protocol OSSession <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface OSSession
    {
        // @required +(void)addOutcome:(NSString * _Nonnull)name;
        //[Static, Abstract]
        [Export ("addOutcome:")]
        void AddOutcome(string name);

        // @required +(void)addUniqueOutcome:(NSString * _Nonnull)name;
        //[Static, Abstract]
        [Export ("addUniqueOutcome:")]
        void AddUniqueOutcome(string name);

        // @required +(void)addOutcomeWithValue:(NSString * _Nonnull)name value:(NSNumber * _Nonnull)value __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("addOutcomeWithValue:value:")]
        void AddOutcomeWithValue(string name, NSNumber value);
    }

    // @protocol OSNotificationPermissionObserver <NSObject>
    [Protocol]
    [Model]
    [BaseType(typeof(NSObject))]
    interface OSNotificationPermissionObserver
    {
        // @required -(void)onNotificationPermissionDidChange:(BOOL)permission;
        //[Abstract]
        [Export ("onNotificationPermissionDidChange:")]
        void OnNotificationPermissionDidChange(bool permission);
    }


    // @interface OSDisplayableNotification : OSNotification
    [BaseType(typeof(OSNotification))]
    interface OSDisplayableNotification
    {
        // -(void)display;
        [Export ("display")]
        void Display();
    }

    // @protocol OSNotificationClickListener <NSObject>
    [Protocol]
    [Model]
    [BaseType(typeof(NSObject))]
    interface OSNotificationClickListener
    {
        // @required -(void)onClickNotification:(OSNotificationClickEvent * _Nonnull)event __attribute__((swift_name("onClick(event:)")));
        //[Abstract]
        [Export ("onClickNotification:")]
        void OnClickNotification(OSNotificationClickEvent @event);
    }

    // @interface OSNotificationWillDisplayEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface OSNotificationWillDisplayEvent
    {
        // @property (readonly, nonatomic, strong) OSDisplayableNotification * _Nonnull notification;
        [Export ("notification", ArgumentSemantic.Strong)]
        OSDisplayableNotification Notification { get; }

        // -(void)preventDefault;
        [Export ("preventDefault")]
        void PreventDefault();
    }

    // @protocol OSNotificationLifecycleListener <NSObject>
    [Protocol]
    [Model]
    [BaseType(typeof(NSObject))]
    interface OSNotificationLifecycleListener
    {
        // @required -(void)onWillDisplayNotification:(OSNotificationWillDisplayEvent * _Nonnull)event __attribute__((swift_name("onWillDisplay(event:)")));
        //[Abstract]
        [Export ("onWillDisplayNotification:")]
        void OnWillDisplayNotification(OSNotificationWillDisplayEvent @event);
    }

    // typedef void (^OSUserResponseBlock)(BOOL);
    delegate void OSUserResponseBlock(bool arg0);

    // @protocol OSNotifications <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface OSNotifications
    {
        // @required +(BOOL)permission __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("permission")]
        //[Verify(MethodToProperty)]
        bool Permission { get; }

        // @required +(BOOL)canRequestPermission __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("canRequestPermission")]
        //[Verify(MethodToProperty)]
        bool CanRequestPermission { get; }

        // @required +(OSNotificationPermission)permissionNative __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("permissionNative")]
        //[Verify(MethodToProperty)]
        OSNotificationPermission PermissionNative { get; }

        // @required +(void)addForegroundLifecycleListener:(NSObject<OSNotificationLifecycleListener> * _Nullable)listener;
        //[Static, Abstract]
        [Export ("addForegroundLifecycleListener:")]
        void AddForegroundLifecycleListener([NullAllowed] OSNotificationLifecycleListener listener);

        // @required +(void)removeForegroundLifecycleListener:(NSObject<OSNotificationLifecycleListener> * _Nullable)listener;
        //[Static, Abstract]
        [Export ("removeForegroundLifecycleListener:")]
        void RemoveForegroundLifecycleListener([NullAllowed] OSNotificationLifecycleListener listener);

        // @required +(void)addClickListener:(NSObject<OSNotificationClickListener> * _Nonnull)listener __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("addClickListener:")]
        void AddClickListener(OSNotificationClickListener listener);

        // @required +(void)removeClickListener:(NSObject<OSNotificationClickListener> * _Nonnull)listener __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("removeClickListener:")]
        void RemoveClickListener(OSNotificationClickListener listener);

        // @required +(void)requestPermission:(OSUserResponseBlock _Nullable)block;
        //[Static, Abstract]
        [Export ("requestPermission:")]
        void RequestPermission([NullAllowed] OSUserResponseBlock block);

        // @required +(void)requestPermission:(OSUserResponseBlock _Nullable)block fallbackToSettings:(BOOL)fallback;
        //[Static, Abstract]
        [Export ("requestPermission:fallbackToSettings:")]
        void RequestPermission([NullAllowed] OSUserResponseBlock block, bool fallback);

        // @required +(void)registerForProvisionalAuthorization:(OSUserResponseBlock _Nullable)block __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("registerForProvisionalAuthorization:")]
        void RegisterForProvisionalAuthorization([NullAllowed] OSUserResponseBlock block);

        // @required +(void)addPermissionObserver:(NSObject<OSNotificationPermissionObserver> * _Nonnull)observer __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("addPermissionObserver:")]
        void AddPermissionObserver(OSNotificationPermissionObserver observer);

        // @required +(void)removePermissionObserver:(NSObject<OSNotificationPermissionObserver> * _Nonnull)observer __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("removePermissionObserver:")]
        void RemovePermissionObserver(OSNotificationPermissionObserver observer);

        // @required +(void)clearAll;
        //[Static, Abstract]
        [Export ("clearAll")]
        void ClearAll();
    }


    // @interface OSPushSubscriptionChangedState : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC13OneSignalUser30OSPushSubscriptionChangedState")]
    [DisableDefaultCtor]
    interface OSPushSubscriptionChangedState
    {
        // @property (readonly, nonatomic, strong) OSPushSubscriptionState * _Nonnull current;
        [Export ("current", ArgumentSemantic.Strong)]
        OSPushSubscriptionState Current { get; }

        // @property (readonly, nonatomic, strong) OSPushSubscriptionState * _Nonnull previous;
        [Export ("previous", ArgumentSemantic.Strong)]
        OSPushSubscriptionState Previous { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export ("description")]
        string Description { get; }

        // -(NSDictionary * _Nonnull)jsonRepresentation __attribute__((warn_unused_result("")));
        [Export ("jsonRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

    // @protocol OSPushSubscriptionObserver <NSObject>
    [Protocol(Name = "_TtP13OneSignalUser26OSPushSubscriptionObserver_")]
    [Model]
    [BaseType(typeof(NSObject))]
    interface OSPushSubscriptionObserver
    {
        // @required -(void)onPushSubscriptionDidChangeWithState:(OSPushSubscriptionChangedState * _Nonnull)state;
        //[Abstract]
        [Export ("onPushSubscriptionDidChangeWithState:")]
        void OnPushSubscriptionDidChangeWithState(OSPushSubscriptionChangedState state);
    }

    // @interface OSPushSubscriptionState : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC13OneSignalUser23OSPushSubscriptionState")]
    [DisableDefaultCtor]
    interface OSPushSubscriptionState
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable id;
        [NullAllowed, Export ("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable token;
        [NullAllowed, Export ("token")]
        string Token { get; }

        // @property (readonly, nonatomic) BOOL optedIn;
        [Export ("optedIn")]
        bool OptedIn { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export ("description")]
        string Description { get; }

        // -(NSDictionary * _Nonnull)jsonRepresentation __attribute__((warn_unused_result("")));
        [Export ("jsonRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

    // @protocol OSPushSubscription
    [Protocol(Name = "_TtP13OneSignalUser18OSPushSubscription_")]
    [BaseType(typeof(NSObject))]
    interface OSPushSubscription
    {
        // @required @property (readonly, copy, nonatomic) NSString * _Nullable id;
        //[Abstract]
        [NullAllowed, Export ("id")]
        string Id { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable token;
        //[Abstract]
        [NullAllowed, Export ("token")]
        string Token { get; }

        // @required @property (readonly, nonatomic) BOOL optedIn;
        //[Abstract]
        [Export ("optedIn")]
        bool OptedIn { get; }

        // @required -(void)optIn;
        //[Abstract]
        [Export ("optIn")]
        void OptIn();

        // @required -(void)optOut;
        //[Abstract]
        [Export ("optOut")]
        void OptOut();

        // @required -(void)addObserver:(id<OSPushSubscriptionObserver> _Nonnull)observer;
        //[Abstract]
        [Export ("addObserver:")]
        void AddObserver(OSPushSubscriptionObserver observer);

        // @required -(void)removeObserver:(id<OSPushSubscriptionObserver> _Nonnull)observer;
        //[Abstract]
        [Export ("removeObserver:")]
        void RemoveObserver(OSPushSubscriptionObserver observer);
    }

    // @interface OSUserState : NSObject
    [BaseType (typeof(NSObject), Name = "_TtC13OneSignalUser11OSUserState")]
    [DisableDefaultCtor]
    interface OSUserState
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable onesignalId;
        [NullAllowed, Export ("onesignalId")]
        string OnesignalId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable externalId;
        [NullAllowed, Export ("externalId")]
        string ExternalId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export ("description")]
        string Description { get; }

        // -(NSDictionary * _Nonnull)jsonRepresentation __attribute__((warn_unused_result("")));
        [Export ("jsonRepresentation")]
        //[Verify (MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

    // @interface OSUserChangedState : NSObject
    [BaseType (typeof(NSObject), Name = "_TtC13OneSignalUser18OSUserChangedState")]
    [DisableDefaultCtor]
    interface OSUserChangedState
    {
        // @property (readonly, nonatomic, strong) OSUserState * _Nonnull current;
        [Export ("current", ArgumentSemantic.Strong)]
        OSUserState Current { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export ("description")]
        string Description { get; }

        // -(NSDictionary * _Nonnull)jsonRepresentation __attribute__((warn_unused_result("")));
        [Export ("jsonRepresentation")]
        //[Verify (MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

    // @protocol OSUserStateObserver
    [Protocol (Name = "_TtP13OneSignalUser19OSUserStateObserver_")]
    [Model]
    [BaseType(typeof(NSObject))]
    interface OSUserStateObserver
    {
        // @required -(void)onUserStateDidChangeWithState:(OSUserChangedState * _Nonnull)state;
        //[Abstract]
        [Export ("onUserStateDidChangeWithState:")]
        void OnUserStateDidChangeWithState (OSUserChangedState state);
    }

    // @protocol OSUser
    [Protocol(Name = "_TtP13OneSignalUser6OSUser_")]
    [BaseType(typeof(NSObject))]
    interface OSUser
    {
        // @required @property (readonly, nonatomic, strong) id<OSPushSubscription> _Nonnull pushSubscription;
        //[Abstract]
        [Export ("pushSubscription", ArgumentSemantic.Strong)]
        OSPushSubscription PushSubscription { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable onesignalId;
        //[Abstract]
        [NullAllowed, Export ("onesignalId")]
        string OnesignalId { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable externalId;
        //[Abstract]
        [NullAllowed, Export ("externalId")]
        string ExternalId { get; }

        // @required -(void)addObserver:(id<OSUserStateObserver> _Nonnull)observer;
        //[Abstract]
        [Export ("addObserver:")]
        void AddObserver (OSUserStateObserver observer);

        // @required -(void)removeObserver:(id<OSUserStateObserver> _Nonnull)observer;
        [Abstract]
        [Export ("removeObserver:")]
        void RemoveObserver (OSUserStateObserver observer);

        // @required -(void)addAliasWithLabel:(NSString * _Nonnull)label id:(NSString * _Nonnull)id;
        //[Abstract]
        [Export ("addAliasWithLabel:id:")]
        void AddAliasWithLabel(string label, string id);

        // @required -(void)addAliases:(NSDictionary<NSString *,NSString *> * _Nonnull)aliases;
        //[Abstract]
        [Export ("addAliases:")]
        void AddAliases(NSDictionary<NSString, NSString> aliases);

        // @required -(void)removeAlias:(NSString * _Nonnull)label;
        //[Abstract]
        [Export ("removeAlias:")]
        void RemoveAlias(string label);

        // @required -(void)removeAliases:(NSArray<NSString *> * _Nonnull)labels;
        //[Abstract]
        [Export ("removeAliases:")]
        void RemoveAliases(string[] labels);

        // @required -(void)addTagWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
        //[Abstract]
        [Export ("addTagWithKey:value:")]
        void AddTagWithKey(string key, string value);

        // @required -(void)addTags:(NSDictionary<NSString *,NSString *> * _Nonnull)tags;
        //[Abstract]
        [Export ("addTags:")]
        void AddTags(NSDictionary<NSString, NSString> tags);

        // @required -(void)removeTag:(NSString * _Nonnull)tag;
        //[Abstract]
        [Export ("removeTag:")]
        void RemoveTag(string tag);

        // @required -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags;
        //[Abstract]
        [Export ("removeTags:")]
        void RemoveTags(string[] tags);

        // @required -(NSDictionary<NSString *,NSString *>)getTags;
        //[Abstract]
        [Export ("getTags")]
        [return: NullAllowed]
        NSDictionary<NSString, NSString> GetTags();

        // @required -(void)addEmail:(NSString * _Nonnull)email;
        //[Abstract]
        [Export ("addEmail:")]
        void AddEmail(string email);

        // @required -(void)removeEmail:(NSString * _Nonnull)email;
        //[Abstract]
        [Export ("removeEmail:")]
        void RemoveEmail(string email);

        // @required -(void)addSms:(NSString * _Nonnull)number;
        //[Abstract]
        [Export ("addSms:")]
        void AddSms(string number);

        // @required -(void)removeSms:(NSString * _Nonnull)number;
        //[Abstract]
        [Export ("removeSms:")]
        void RemoveSms(string number);

        // @required -(void)setLanguage:(NSString * _Nonnull)language;
        //[Abstract]
        [Export ("setLanguage:")]
        void SetLanguage(string language);

        // @required -(void)onJwtExpiredWithExpiredHandler:(void (^ _Nonnull)(NSString * _Nonnull, __attribute__((noescape)) void (^ _Nonnull)(NSString * _Nonnull)))expiredHandler;
        //[Abstract]
        //[Export ("onJwtExpiredWithExpiredHandler:")]
        //void OnJwtExpiredWithExpiredHandler(Action<NSString, Action<NSString>> expiredHandler);
    }

    // @interface OSInAppMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface OSInAppMessage
    {
        // @property (nonatomic, strong) NSString * _Nonnull messageId;
        [Export ("messageId", ArgumentSemantic.Strong)]
        string MessageId { get; set; }

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

    // @interface OSInAppMessageTag : NSObject
    [BaseType(typeof(NSObject))]
    interface OSInAppMessageTag
    {
        // @property (nonatomic, strong) NSDictionary * _Nullable tagsToAdd;
        [NullAllowed, Export ("tagsToAdd", ArgumentSemantic.Strong)]
        NSDictionary TagsToAdd { get; set; }

        // @property (nonatomic, strong) NSArray * _Nullable tagsToRemove;
        [NullAllowed, Export ("tagsToRemove", ArgumentSemantic.Strong)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] TagsToRemove { get; set; }

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }


    // @interface OSInAppMessageOutcome : NSObject
    [BaseType(typeof(NSObject))]
    interface OSInAppMessageOutcome
    {
        // @property (nonatomic, strong) NSString * _Nonnull name;
        [Export ("name", ArgumentSemantic.Strong)]
        string Name { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nonnull weight;
        [Export ("weight", ArgumentSemantic.Strong)]
        NSNumber Weight { get; set; }

        // @property (nonatomic) BOOL unique;
        [Export ("unique")]
        bool Unique { get; set; }

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }


    // @interface OSInAppMessageClickResult : NSObject
    [BaseType(typeof(NSObject))]
    interface OSInAppMessageClickResult
    {
        // @property (nonatomic, strong) NSString * _Nullable actionId;
        [NullAllowed, Export ("actionId", ArgumentSemantic.Strong)]
        string ActionId { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable url;
        [NullAllowed, Export ("url", ArgumentSemantic.Strong)]
        string Url { get; set; }

        // @property (nonatomic) BOOL closingMessage;
        [Export ("closingMessage")]
        bool ClosingMessage { get; set; }

        // @property (nonatomic) OSInAppMessageActionUrlType urlTarget;
        [Export ("urlTarget", ArgumentSemantic.Assign)]
        OSInAppMessageActionUrlType UrlTarget { get; set; }

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

    // @interface OSInAppMessageWillDisplayEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface OSInAppMessageWillDisplayEvent
    {
        // @property (readonly, nonatomic) OSInAppMessage * _Nonnull message;
        [Export ("message")]
        OSInAppMessage Message { get; }
    }

    // @interface OSInAppMessageDidDisplayEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface OSInAppMessageDidDisplayEvent
    {
        // @property (readonly, nonatomic) OSInAppMessage * _Nonnull message;
        [Export ("message")]
        OSInAppMessage Message { get; }
    }

    // @interface OSInAppMessageWillDismissEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface OSInAppMessageWillDismissEvent
    {
        // @property (readonly, nonatomic) OSInAppMessage * _Nonnull message;
        [Export ("message")]
        OSInAppMessage Message { get; }
    }

    // @interface OSInAppMessageDidDismissEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface OSInAppMessageDidDismissEvent
    {
        // @property (readonly, nonatomic) OSInAppMessage * _Nonnull message;
        [Export ("message")]
        OSInAppMessage Message { get; }
    }

    // @protocol OSInAppMessageLifecycleListener <NSObject>
    [Protocol]
    [Model]
    [BaseType(typeof(NSObject))]
    interface OSInAppMessageLifecycleListener
    {
        // @optional -(void)onWillDisplayInAppMessage:(OSInAppMessageWillDisplayEvent * _Nonnull)event __attribute__((swift_name("onWillDisplay(event:)")));
        [Export ("onWillDisplayInAppMessage:")]
        void OnWillDisplayInAppMessage(OSInAppMessageWillDisplayEvent @event);

        // @optional -(void)onDidDisplayInAppMessage:(OSInAppMessageDidDisplayEvent * _Nonnull)event __attribute__((swift_name("onDidDisplay(event:)")));
        [Export ("onDidDisplayInAppMessage:")]
        void OnDidDisplayInAppMessage(OSInAppMessageDidDisplayEvent @event);

        // @optional -(void)onWillDismissInAppMessage:(OSInAppMessageWillDismissEvent * _Nonnull)event __attribute__((swift_name("onWillDismiss(event:)")));
        [Export ("onWillDismissInAppMessage:")]
        void OnWillDismissInAppMessage(OSInAppMessageWillDismissEvent @event);

        // @optional -(void)onDidDismissInAppMessage:(OSInAppMessageDidDismissEvent * _Nonnull)event __attribute__((swift_name("onDidDismiss(event:)")));
        [Export ("onDidDismissInAppMessage:")]
        void OnDidDismissInAppMessage(OSInAppMessageDidDismissEvent @event);
    }

    // @interface OSInAppMessageClickEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface OSInAppMessageClickEvent
    {
        // @property (readonly, nonatomic) OSInAppMessage * _Nonnull message;
        [Export ("message")]
        OSInAppMessage Message { get; }

        // @property (readonly, nonatomic) OSInAppMessageClickResult * _Nonnull result;
        [Export ("result")]
        OSInAppMessageClickResult Result { get; }

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

    // @protocol OSInAppMessageClickListener <NSObject>
    [Protocol]
    [Model]
    [BaseType(typeof(NSObject))]
    interface OSInAppMessageClickListener
    {
        // @required -(void)onClickInAppMessage:(OSInAppMessageClickEvent * _Nonnull)event __attribute__((swift_name("onClick(event:)")));
        ////[Abstract]
        [Export ("onClickInAppMessage:")]
        void OnClickInAppMessage(OSInAppMessageClickEvent @event);
    }

    // @protocol OSInAppMessages <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface OSInAppMessages
    {
        // @required +(void)addTrigger:(NSString * _Nonnull)key withValue:(NSString * _Nonnull)value;
        //[Static, Abstract]
        [Export ("addTrigger:withValue:")]
        void AddTrigger(string key, string value);

        // @required +(void)addTriggers:(NSDictionary<NSString *,NSString *> * _Nonnull)triggers;
        //[Static, Abstract]
        [Export ("addTriggers:")]
        void AddTriggers(NSDictionary<NSString, NSString> triggers);

        // @required +(void)removeTrigger:(NSString * _Nonnull)key;
        //[Static, Abstract]
        [Export ("removeTrigger:")]
        void RemoveTrigger(string key);

        // @required +(void)removeTriggers:(NSArray<NSString *> * _Nonnull)keys;
        //[Static, Abstract]
        [Export ("removeTriggers:")]
        void RemoveTriggers(string[] keys);

        // @required +(void)clearTriggers;
        //[Static, Abstract]
        [Export ("clearTriggers")]
        void ClearTriggers();

        // @required +(BOOL)paused __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("paused")]
        //[Verify(MethodToProperty)]
        bool Paused { get; }

        // @required +(void)paused:(BOOL)pause __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("paused:")]
        void SetPaused(bool pause);

        // @required +(void)addClickListener:(NSObject<OSInAppMessageClickListener> * _Nullable)listener __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("addClickListener:")]
        void AddClickListener([NullAllowed] OSInAppMessageClickListener listener);

        // @required +(void)removeClickListener:(NSObject<OSInAppMessageClickListener> * _Nullable)listener __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("removeClickListener:")]
        void RemoveClickListener([NullAllowed] OSInAppMessageClickListener listener);

        // @required +(void)addLifecycleListener:(NSObject<OSInAppMessageLifecycleListener> * _Nullable)listener __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("addLifecycleListener:")]
        void AddLifecycleListener([NullAllowed] OSInAppMessageLifecycleListener listener);

        // @required +(void)removeLifecycleListener:(NSObject<OSInAppMessageLifecycleListener> * _Nullable)listener __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("removeLifecycleListener:")]
        void RemoveLifecycleListener([NullAllowed] OSInAppMessageLifecycleListener listener);
    }

    // @protocol OSLocation <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface OSLocation
    {
        // @required +(void)requestPermission;
        //[Static, Abstract]
        [Export ("requestPermission")]
        void RequestPermission();

        // @required +(void)setShared:(BOOL)enable __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("setShared:")]
        void SetShared(bool enable);

        // @required +(BOOL)isShared __attribute__((swift_private));
        //[Static, Abstract]
        [Export ("isShared")]
        //[Verify(MethodToProperty)]
        bool IsShared { get; }
    }

    // typedef void (^OSWebOpenURLResultBlock)(BOOL);
    delegate void OSWebOpenURLResultBlock(bool arg0);

    // typedef void (^OSResultSuccessBlock)(NSDictionary *);
    delegate void OSResultSuccessBlock(NSDictionary arg0);

    // typedef void (^OSFailureBlock)(NSError *);
    delegate void OSFailureBlock(NSError arg0);

    // @interface OneSignal : NSObject
    [BaseType(typeof(NSObject))]
    interface OneSignal
    {
        // +(NSString *)appId;
        [Static]
        [Export ("appId")]
        //[Verify(MethodToProperty)]
        string AppId { get; }

        // +(NSString * _Nonnull)sdkVersionRaw;
        [Static]
        [Export ("sdkVersionRaw")]
        //[Verify(MethodToProperty)]
        string SdkVersionRaw { get; }

        // +(NSString * _Nonnull)sdkSemanticVersion;
        [Static]
        [Export ("sdkSemanticVersion")]
        //[Verify(MethodToProperty)]
        string SdkSemanticVersion { get; }

        // +(id<OSUser>)User __attribute__((swift_private));
        [Static]
        [Export ("User")]
        //[Verify(MethodToProperty)]
        OSUser User { get; }

        // +(void)login:(NSString * _Nonnull)externalId;
        [Static]
        [Export ("login:")]
        void Login(string externalId);

        // +(void)login:(NSString * _Nonnull)externalId withToken:(NSString * _Nullable)token __attribute__((swift_name("login(externalId:token:)")));
        [Static]
        [Export ("login:withToken:")]
        void Login(string externalId, [NullAllowed] string token);

        // +(void)logout;
        [Static]
        [Export ("logout")]
        void Logout();

        // +(Class<OSNotifications>)Notifications __attribute__((swift_private));
        [Static]
        [Export ("Notifications")]
        //[Verify(MethodToProperty)]
        OSNotifications Notifications { get; }

        // +(void)setLaunchOptions:(NSDictionary * _Nullable)newLaunchOptions;
        [Static]
        [Export ("setLaunchOptions:")]
        void SetLaunchOptions([NullAllowed] NSDictionary newLaunchOptions);

        // +(void)initialize:(NSString * _Nonnull)newAppId withLaunchOptions:(NSDictionary * _Nullable)launchOptions;
        [Static]
        [Export ("initialize:withLaunchOptions:")]
        void Initialize(string newAppId, [NullAllowed] NSDictionary launchOptions);

        // +(void)setProvidesNotificationSettingsView:(BOOL)providesView;
        [Static]
        [Export ("setProvidesNotificationSettingsView:")]
        void SetProvidesNotificationSettingsView(bool providesView);

        // +(Class<OSLiveActivities>)LiveActivities __attribute__((swift_private));
        [Static]
        [Export ("LiveActivities")]
        //[Verify(MethodToProperty)]
        OSLiveActivities LiveActivities { get; }

        // +(Class<OSDebug>)Debug __attribute__((swift_private));
        [Static]
        [Export ("Debug")]
        //[Verify(MethodToProperty)]
        OSDebug Debug { get; }

        // +(void)setConsentRequired:(BOOL)required;
        [Static]
        [Export ("setConsentRequired:")]
        void SetConsentRequired(bool required);

        // +(void)setConsentGiven:(BOOL)granted;
        [Static]
        [Export ("setConsentGiven:")]
        void SetConsentGiven(bool granted);

        // +(Class<OSInAppMessages>)InAppMessages __attribute__((swift_private));
        [Static]
        [Export ("InAppMessages")]
        //[Verify(MethodToProperty)]
        OSInAppMessages InAppMessages { get; }

        // +(Class<OSLocation>)Location __attribute__((swift_private));
        [Static]
        [Export ("Location")]
        //[Verify(MethodToProperty)]
        OSLocation Location { get; }

        // +(Class<OSSession>)Session __attribute__((swift_private));
        [Static]
        [Export ("Session")]
        //[Verify(MethodToProperty)]
        OSSession Session { get; }

        // +(UNMutableNotificationContent *)didReceiveNotificationExtensionRequest:(UNNotificationRequest * _Nonnull)request withMutableNotificationContent:(UNMutableNotificationContent * _Nullable)replacementContent __attribute__((deprecated("Please use didReceiveNotificationExtensionRequest:withMutableNotificationContent:withContentHandler: instead.")));
        [Static]
        [Export ("didReceiveNotificationExtensionRequest:withMutableNotificationContent:")]
        UNMutableNotificationContent DidReceiveNotificationExtensionRequest(UNNotificationRequest request, [NullAllowed] UNMutableNotificationContent replacementContent);

        // +(UNMutableNotificationContent *)didReceiveNotificationExtensionRequest:(UNNotificationRequest * _Nonnull)request withMutableNotificationContent:(UNMutableNotificationContent * _Nullable)replacementContent withContentHandler:(void (^)(UNNotificationContent * _Nonnull))contentHandler;
        [Static]
        [Export ("didReceiveNotificationExtensionRequest:withMutableNotificationContent:withContentHandler:")]
        UNMutableNotificationContent DidReceiveNotificationExtensionRequest(UNNotificationRequest request, [NullAllowed] UNMutableNotificationContent replacementContent, Action<UNNotificationContent> contentHandler);

        // +(UNMutableNotificationContent *)serviceExtensionTimeWillExpireRequest:(UNNotificationRequest * _Nonnull)request withMutableNotificationContent:(UNMutableNotificationContent * _Nullable)replacementContent;
        [Static]
        [Export ("serviceExtensionTimeWillExpireRequest:withMutableNotificationContent:")]
        UNMutableNotificationContent ServiceExtensionTimeWillExpireRequest(UNNotificationRequest request, [NullAllowed] UNMutableNotificationContent replacementContent);
    }

    // @protocol OSLiveActivities <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface OSLiveActivities
    {
        // @required +(void)enter:(NSString * _Nonnull)activityId withToken:(NSString * _Nonnull)token;
        //[Static, Abstract]
        [Export ("enter:withToken:")]
        void Enter(string activityId, string token);

        // @required +(void)enter:(NSString * _Nonnull)activityId withToken:(NSString * _Nonnull)token withSuccess:(OSResultSuccessBlock _Nullable)successBlock withFailure:(OSFailureBlock _Nullable)failureBlock;
        //[Static, Abstract]
        [Export ("enter:withToken:withSuccess:withFailure:")]
        void Enter(string activityId, string token, [NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);

        // @required +(void)exit:(NSString * _Nonnull)activityId;
        //[Static, Abstract]
        [Export ("exit:")]
        void Exit(string activityId);

        // @required +(void)exit:(NSString * _Nonnull)activityId withSuccess:(OSResultSuccessBlock _Nullable)successBlock withFailure:(OSFailureBlock _Nullable)failureBlock;
        //[Static, Abstract]
        [Export ("exit:withSuccess:withFailure:")]
        void Exit(string activityId, [NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);
    }
}
