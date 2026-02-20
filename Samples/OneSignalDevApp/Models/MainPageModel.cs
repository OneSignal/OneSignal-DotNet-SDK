using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalSDK.DotNet.Core.User.Subscriptions;

namespace OneSignalDevApp.Models
{
	public class MainPageModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _appId = "77e32082-ea27-42e3-a898-c72e141824ef";
        public string AppId {
            get => _appId;
            private set
            {
                if(_appId != value)
                {
                    _appId = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _hasGivenPrivacyConsent;
        public bool HasGivenPrivacyConsent
        {
            get => _hasGivenPrivacyConsent;
            private set
            {
                if (_hasGivenPrivacyConsent != value)
                {
                    _hasGivenPrivacyConsent = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _pushSubscriptionId;
        public string PushSubscriptionId
        {
            get => _pushSubscriptionId;
            private set
            {
                if (_pushSubscriptionId != value)
                {
                    _pushSubscriptionId = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isPushEnabled;
        public bool IsPushEnabled
        {
            get => _isPushEnabled;
            set
            {
                if (_isPushEnabled != value)
                {
                    if(value && !OneSignal.User.PushSubscription.OptedIn)
                    {
                        OneSignal.User.PushSubscription.OptIn();
                    }
                    else if(!value && OneSignal.User.PushSubscription.OptedIn)
                    {
                        OneSignal.User.PushSubscription.OptOut();
                    }

                    _isPushEnabled = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _hasPushPermission;
        public bool HasPushPermission
        {
            get => _hasPushPermission;
            private set
            {
                if (_hasPushPermission != value)
                {
                    _hasPushPermission = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isIAMPaused;
        public bool IsIAMPaused
        {
            get => _isIAMPaused;
            set
            {
                if (_isIAMPaused != value)
                {
                    if (value != OneSignal.InAppMessages.Paused)
                    {
                        OneSignal.InAppMessages.Paused = value;
                    }

                    _isIAMPaused = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _isLocationShared;
        public bool IsLocationShared
        {
            get => _isLocationShared;
            set
            {
                if (_isLocationShared != value)
                {
                    if (value != OneSignal.Location.IsShared)
                    {
                        OneSignal.Location.IsShared = value;
                    }

                    _isLocationShared = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _liveActivityId;
        public string LiveActivityId
        {
            get => _liveActivityId;
            set
            {
                if (_liveActivityId != value)
                {
                    _liveActivityId = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand GivePrivacyConsentCommand { get; }
        public ICommand RevokePrivacyConsentCommand { get; }
        public ICommand LoginUserCommand { get; }
        public ICommand LogoutUserCommand { get; }
        public ICommand TrackEventCommand { get; }
        public ICommand AddAliasCommand { get; }
        public ICommand PromptForPushCommand { get; }
        public ICommand AddEmailCommand { get; }
        public ICommand AddSMSCommand { get; }
        public ICommand AddTagCommand { get; }
        public ICommand AddOutcomeCommand { get; }
        public ICommand AddTriggerCommand { get; }
        public ICommand PromptForLocationCommand { get; }
        public ICommand EnterLiveActivityCommand { get; }
        public ICommand ExitLiveActivityCommand { get; }
        public ICommand ValidationCommand { get; }

        private Page _page;

        public MainPageModel(Page page)
        {
            _page = page;

            GivePrivacyConsentCommand = new Command(GivePrivacyConsent);
            RevokePrivacyConsentCommand = new Command(RevokePrivacyConsent);
            LoginUserCommand = new Command(LoginUser);
            LogoutUserCommand = new Command(LogoutUser);
            TrackEventCommand = new Command(TrackEvent);
            AddAliasCommand = new Command(AddAlias);
            PromptForPushCommand = new Command(PromptForPush);
            AddEmailCommand = new Command(AddEmail);
            AddSMSCommand = new Command(AddSMS);
            AddTagCommand = new Command(AddTag);
            AddOutcomeCommand = new Command(AddOutcome);
            AddTriggerCommand = new Command(AddTrigger);
            PromptForLocationCommand = new Command(PromptForLocation);
            EnterLiveActivityCommand = new Command(EnterLiveActivity);
            ExitLiveActivityCommand = new Command(ExitLiveActivity);
            ValidationCommand = new Command(Validation);

            // Initialize OneSignal SDK.
            OneSignal.Debug.LogLevel = LogLevel.VERBOSE;
            // OneSignal.Debug.AlertLevel = LogLevel.NONE;

            // OneSignal.ConsentRequired = true;
            // OneSignal.ConsentGiven = false;

            OneSignal.Initialize(_appId);

            OneSignal.User.PushSubscription.Changed += PushSubscription_Changed;
            // OneSignal.Notifications.PermissionChanged += Notifications_PermissionChanged;
            // OneSignal.Notifications.Clicked += Notifications_Clicked;
            // OneSignal.Notifications.WillDisplay += Notifications_WillDisplay;
            
            // OneSignal.InAppMessages.WillDisplay += InAppMessages_WillDisplay;
            // OneSignal.InAppMessages.DidDisplay += InAppMessages_DidDisplay;
            // OneSignal.InAppMessages.WillDismiss += InAppMessages_WillDismiss;
            // OneSignal.InAppMessages.DidDismiss += InAppMessages_DidDismiss;
            // OneSignal.InAppMessages.Clicked += InAppMessages_Clicked;

            IsPushEnabled = OneSignal.User.PushSubscription.OptedIn;
            HasPushPermission = OneSignal.Notifications.Permission;
            IsIAMPaused = OneSignal.InAppMessages.Paused;
            IsLocationShared = OneSignal.Location.IsShared;
            PushSubscriptionId = OneSignal.User.PushSubscription.Id;
        }

        private void InAppMessages_Clicked(object sender, OneSignalSDK.DotNet.Core.InAppMessages.InAppMessageClickedEventArgs e)
        {
            Debug.WriteLine($"IAM clicked: ${e.Result.ActionId}.");
        }

        private void InAppMessages_WillDisplay(object sender, OneSignalSDK.DotNet.Core.InAppMessages.InAppMessageWillDisplayEventArgs e)
        {
            Debug.WriteLine($"IAM ${e.Message.MessageId} will display.");
        }

        private void InAppMessages_DidDisplay(object sender, OneSignalSDK.DotNet.Core.InAppMessages.InAppMessageDidDisplayEventArgs e)
        {
            Debug.WriteLine($"IAM ${e.Message.MessageId} did display.");
        }

        private void InAppMessages_WillDismiss(object sender, OneSignalSDK.DotNet.Core.InAppMessages.InAppMessageWillDismissEventArgs e)
        {
            Debug.WriteLine($"IAM ${e.Message.MessageId} will dismiss.");
        }

        private void InAppMessages_DidDismiss(object sender, OneSignalSDK.DotNet.Core.InAppMessages.InAppMessageDidDismissEventArgs e)
        {
            Debug.WriteLine($"IAM ${e.Message.MessageId} did dismiss.");
        }

        private void Notifications_WillDisplay(object sender, OneSignalSDK.DotNet.Core.Notifications.NotificationWillDisplayEventArgs e)
        {
            Debug.WriteLine($"Notification ${e.Notification.NotificationId} will display.");
            e.PreventDefault();
            e.Notification.display();
        }

        private void Notifications_Clicked(object sender, OneSignalSDK.DotNet.Core.Notifications.NotificationClickedEventArgs e)
        {
            Debug.WriteLine($"Notification ${e.Notification.NotificationId} has been clicked");
        }

        private void Notifications_PermissionChanged(object sender, OneSignalSDK.DotNet.Core.Notifications.NotificationPermissionChangedEventArgs e)
        {
            Debug.WriteLine($"Notification Permissions has changed: ${e.Permission}");
            HasPushPermission = e.Permission;
        }

        private void PushSubscription_Changed(object sender, OneSignalSDK.DotNet.Core.User.Subscriptions.PushSubscriptionChangedEventArgs e)
        {
            var pushSubscription = e.State.Current as IPushSubscriptionState;
            Debug.WriteLine($"Push Subscription has changed: Id=${pushSubscription.Id}, Token={pushSubscription.Token}, OptedIn=${pushSubscription.OptedIn}");
            IsPushEnabled = OneSignal.User.PushSubscription.OptedIn;
            PushSubscriptionId = e.State.Current.Id;
        }

        private void GivePrivacyConsent()
        {
            OneSignalSDK.DotNet.OneSignal.ConsentGiven = true;
            HasGivenPrivacyConsent = true;
        }

        private void RevokePrivacyConsent()
        {
            OneSignalSDK.DotNet.OneSignal.ConsentGiven = false;
            HasGivenPrivacyConsent = false;
        }

        private async void LoginUser()
        {
            var externalId = await _page.DisplayPromptAsync("Login User", "External ID of User", "Login");

            if(String.IsNullOrWhiteSpace(externalId))
            {
                return;
            }

            OneSignal.Login(externalId);
        }

        private void LogoutUser()
        {
            OneSignal.Logout();
        }

        private void TrackEvent()
        {
            string platform = DeviceInfo.Platform == DevicePlatform.Android ? "android" : "ios";

            Debug.WriteLine($"Tracking event: DotNet-{platform}-noprops");
            OneSignal.User.TrackEvent($"DotNet-{platform}-noprops");

            Debug.WriteLine($"Tracking event: DotNet-{platform} with properties");
            OneSignal.User.TrackEvent($"DotNet-{platform}", new Dictionary<string, object>
            {
                { "someNum", 123 },
                { "someFloat", 3.14159 },
                { "someString", "abc" },
                { "someBool", true },
                { "someObject", new Dictionary<string, object>
                    {
                        { "abc", "123" },
                        { "nested", new Dictionary<string, object> { { "def", "456" } } },
                        { "ghi", null }
                    }
                },
                { "someArray", new List<object> { 1, 2 } },
                { "someMixedArray", new List<object> { 1, "2", new Dictionary<string, object> { { "abc", "123" } }, null } },
                { "someNull", null }
            });
        }

        private async void AddAlias()
        {
            var addPairModel = new AddPairPageModel("Add Alias", "Label", "ID");

            addPairModel.PageCompleted += (s, e) =>
            {
                OneSignal.User.AddAlias(addPairModel.Key, addPairModel.Value);
            };

            await _page.Navigation.PushModalAsync(new AddPairPage()
            {
                BindingContext = addPairModel
            });
        }

        private async void PromptForPush()
        {
            await OneSignal.Notifications.RequestPermissionAsync(true);
        }

        private async void AddEmail()
        {
            var email = await _page.DisplayPromptAsync("Add Email", "Email Address");
            OneSignal.User.AddEmail(email);
        }

        private async void AddSMS()
        {
            var sms = await _page.DisplayPromptAsync("Add SMS", "Phone Number");
            OneSignal.User.AddSms(sms);
        }

        private async void AddTag()
        {
            var addPairModel = new AddPairPageModel("Add Tag", "Key", "Value");
            addPairModel.PageCompleted += (s, e) =>
            {
                OneSignal.User.AddTag(addPairModel.Key, addPairModel.Value);
            };

            await _page.Navigation.PushModalAsync(new AddPairPage()
            {
                BindingContext = addPairModel
            });
        }

        private async void AddOutcome()
        {
            var addOutcomeModel = new AddOutcomePageModel();
            addOutcomeModel.PageCompleted += (s, e) =>
            {
                switch (addOutcomeModel.Type)
                {
                    case AddOutcomePageModel.OutcomeType.Normal:
                        OneSignal.Session.AddOutcome(addOutcomeModel.Name);
                        break;
                    case AddOutcomePageModel.OutcomeType.Unique:
                        OneSignal.Session.AddUniqueOutcome(addOutcomeModel.Name);
                        break;
                    case AddOutcomePageModel.OutcomeType.WithValue:
                        OneSignal.Session.AddOutcomeWithValue(addOutcomeModel.Name, (float)addOutcomeModel.ValueAsFloat);
                        break;
                }
            };

            await _page.Navigation.PushModalAsync(new AddOutcomePage()
            {
                BindingContext = addOutcomeModel
            });
        }

        private async void AddTrigger()
        {
            var addPairModel = new AddPairPageModel("Add Trigger", "Key", "Value");

            addPairModel.PageCompleted += (s, e) =>
            {
                OneSignal.InAppMessages.AddTrigger(addPairModel.Key, addPairModel.Value);
            };

            await _page.Navigation.PushModalAsync(new AddPairPage()
            {
                BindingContext = addPairModel
            });
        }

        private void PromptForLocation()
        {
            OneSignal.Location.RequestPermission();
        }

        private void EnterLiveActivity()
        {
            string activityId = LiveActivityId;

            if (String.IsNullOrWhiteSpace(activityId))
            {
                return;
            }

            OneSignal.LiveActivities.Enter(activityId, "FAKE_TOKEN");
        }

        private void ExitLiveActivity()
        {
            string activityId = LiveActivityId;

            if (String.IsNullOrWhiteSpace(activityId))
            {
                return;
            }

            OneSignal.LiveActivities.Exit(activityId);
        }

        private async void Validation()
        {
            var firstLoginEUID = RandomString(7);
            var firstLoginAlias = $"{firstLoginEUID}Alias";
            var firstLoginEmail = $"{firstLoginEUID}@email.com";
            var firstLoginNumber = $"+{RandomStringNumber(11)}";

            Debug.WriteLine($"Login");
            OneSignal.Login(firstLoginEUID);
            await Task.Delay(2000);

            Debug.WriteLine($"User.Language = \"en\"");
            OneSignal.User.Language = "en";
            await Task.Delay(2000);

            Debug.WriteLine($"User.AddAlias(\"aliasLabel1\", \"{firstLoginAlias}\")");
            OneSignal.User.AddAlias("aliasLabel1", firstLoginAlias);
            await Task.Delay(2000);

            Debug.WriteLine($"User.AddEmail(\"{firstLoginEmail}\")");
            OneSignal.User.AddEmail(firstLoginEmail);
            await Task.Delay(2000);

            Debug.WriteLine($"User.AddSms(\"{firstLoginNumber}\")");
            OneSignal.User.AddSms(firstLoginNumber);
            await Task.Delay(2000);

            Debug.WriteLine($"User.AddTag(\"tagKey1\", \"tagValue1\")");
            OneSignal.User.AddTag("tagKey1", "tagValue1");
            await Task.Delay(2000);

            Debug.WriteLine($"User.AddTag(new Dictionary<string, string> {{ {{ \"tagKey2\", \"tagValue2\" }}, {{ \"tagKey3\", \"tagValue3\" }} }})");
            OneSignal.User.AddTags(new Dictionary<string, string> { { "tagKey2", "tagValue2" }, { "tagKey3", "tagValue3" } });
            await Task.Delay(2000);

            Debug.WriteLine($"User.RemoveAlias(\"aliasLabel1\")");
            OneSignal.User.RemoveAlias("aliasLabel1");
            await Task.Delay(2000);

            Debug.WriteLine($"User.RemoveEmail(\"{firstLoginEmail}\")");
            OneSignal.User.RemoveEmail(firstLoginEmail);
            await Task.Delay(2000);

            Debug.WriteLine($"User.RemoveSms(\"{firstLoginNumber}\")");
            OneSignal.User.RemoveSms(firstLoginNumber);
            await Task.Delay(2000);

            Debug.WriteLine($"User.RemoveTag(\"tagKey1\")");
            OneSignal.User.RemoveTag("tagKey1");
            await Task.Delay(2000);

            Debug.WriteLine($"User.RemoveTags(\"tagKey2\", \"tagKey3\")");
            OneSignal.User.RemoveTags("tagKey2", "tagKey3");
            await Task.Delay(2000);

            Debug.WriteLine($"Logout");
            OneSignal.Logout();
            await Task.Delay(2000);

            Debug.WriteLine($"OptIn, OptedIn={OneSignal.User.PushSubscription.OptedIn}");
            OneSignal.User.PushSubscription.OptIn();
            await Task.Delay(2000);

            Debug.WriteLine($"OptOut, OptedIn={OneSignal.User.PushSubscription.OptedIn}");
            OneSignal.User.PushSubscription.OptOut();
            await Task.Delay(2000);

            Debug.WriteLine($"OptIn, OptedIn={OneSignal.User.PushSubscription.OptedIn}");
            OneSignal.User.PushSubscription.OptIn();
            await Task.Delay(2000);

            Debug.WriteLine($"Push Subscription: Id={OneSignal.User.PushSubscription.Id}, Token={OneSignal.User.PushSubscription.Token}, OptedIn={OneSignal.User.PushSubscription.OptedIn}");

            Debug.WriteLine($"Session.AddOutcome(\"outcomename\")");
            OneSignal.Session.AddOutcome("outcomename");
            await Task.Delay(2000);

            Debug.WriteLine($"Session.AddUniqueOutcome(\"uniqueoutcomename\")");
            OneSignal.Session.AddUniqueOutcome("uniqueoutcomename");
            await Task.Delay(2000);

            Debug.WriteLine($"Session.AddOutcomeWithValue(\"outcomenamewithvalue\", 1.1f)");
            OneSignal.Session.AddOutcomeWithValue("outcomenamewithvalue", 1.1f);
            await Task.Delay(2000);

            Debug.WriteLine($"Notifications.Permission={OneSignal.Notifications.Permission}");

            Debug.WriteLine($"Notifications.RequestPermission(true)");
            await OneSignal.Notifications.RequestPermissionAsync(true);
            await Task.Delay(2000);

            Debug.WriteLine($"Location.IsShared={OneSignal.Location.IsShared}");
            OneSignal.Location.IsShared = false;
            await Task.Delay(2000);

            OneSignal.Location.IsShared = true;
            await Task.Delay(2000);

            Debug.WriteLine($"Location.RequestPermission()");
            OneSignal.Location.RequestPermission();
            await Task.Delay(2000);

            Debug.WriteLine($"InAppMessages.Paused={OneSignal.InAppMessages.Paused}");
            OneSignal.InAppMessages.Paused = false;
            await Task.Delay(2000);

            OneSignal.InAppMessages.Paused = true;
            await Task.Delay(2000);

            Debug.WriteLine($"InAppMessages.AddTrigger(\"triggerKey1\", \"triggerValue1\")");
            OneSignal.InAppMessages.AddTrigger("triggerKey1", "triggerValue1");
            await Task.Delay(2000);

            Debug.WriteLine($"InAppMessages.AddTriggers(new Dictionary<string, string> {{ {{ \"triggerKey2\", \"triggerValue2\" }}, {{ \"triggerKey3\", \"triggerValue3\" }} }}");
            OneSignal.InAppMessages.AddTriggers(new Dictionary<string, string> { { "triggerKey2", "triggerValue2" }, { "triggerKey3", "triggerValue3" } });
            await Task.Delay(2000);

            Debug.WriteLine($"InAppMessages.RemoveTrigger(\"triggerKey1\")");
            OneSignal.InAppMessages.RemoveTrigger("triggerKey1");
            await Task.Delay(2000);

            Debug.WriteLine($"InAppMessages.RemoveTriggers(\"triggerKey2\", \"triggerKey3\")");
            OneSignal.InAppMessages.RemoveTriggers("triggerKey2", "triggerKey3");
            await Task.Delay(2000);
        }

        private void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static string RandomStringNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

