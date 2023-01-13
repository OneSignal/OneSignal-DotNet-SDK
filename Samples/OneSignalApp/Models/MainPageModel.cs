using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core.Debug;
using OneSignalSDK.DotNet.Core.User.Subscriptions;

namespace OneSignalApp.Models
{
	public class MainPageModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _appId = "31cc0310-2322-493c-a323-194f7a8b11f4";
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
                    if(value && !OneSignal.Default.User.PushSubscription.OptedIn)
                    {
                        OneSignal.Default.User.PushSubscription.OptIn();
                    }
                    else if(!value && OneSignal.Default.User.PushSubscription.OptedIn)
                    {
                        OneSignal.Default.User.PushSubscription.OptOut();
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
                    if (value != OneSignal.Default.InAppMessages.Paused)
                    {
                        OneSignal.Default.InAppMessages.Paused = value;
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
                    if (value != OneSignal.Default.Location.IsShared)
                    {
                        OneSignal.Default.Location.IsShared = value;
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

        private Page _page;

        public MainPageModel(Page page)
        {
            _page = page;

            GivePrivacyConsentCommand = new Command(GivePrivacyConsent);
            RevokePrivacyConsentCommand = new Command(RevokePrivacyConsent);
            LoginUserCommand = new Command(LoginUser);
            LogoutUserCommand = new Command(LogoutUser);
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

            // Initialize OneSignal SDK.
            OneSignal.Default.Debug.LogLevel = LogLevel.VERBOSE;
            OneSignal.Default.Debug.AlertLevel = LogLevel.NONE;

            OneSignal.Default.RequiresPrivacyConsent = true;
            OneSignal.Default.PrivacyConsent = false;

            OneSignal.Default.Initialize(_appId);

            OneSignal.Default.User.PushSubscription.Changed += PushSubscription_Changed;
            OneSignal.Default.Notifications.PermissionChanged += Notifications_PermissionChanged;
            OneSignal.Default.Notifications.Clicked += Notifications_Clicked;
            OneSignal.Default.Notifications.WillDisplay += Notifications_WillDisplay;
            
            OneSignal.Default.InAppMessages.WillDisplay += InAppMessages_WillDisplay;
            OneSignal.Default.InAppMessages.DidDisplay += InAppMessages_DidDisplay;
            OneSignal.Default.InAppMessages.WillDismiss += InAppMessages_WillDismiss;
            OneSignal.Default.InAppMessages.DidDismiss += InAppMessages_DidDismiss;
            OneSignal.Default.InAppMessages.Clicked += InAppMessages_Clicked;

            IsPushEnabled = OneSignal.Default.User.PushSubscription.OptedIn;
            HasPushPermission = OneSignal.Default.Notifications.Permission;
            IsIAMPaused = OneSignal.Default.InAppMessages.Paused;
            IsLocationShared = OneSignal.Default.Location.IsShared;
            PushSubscriptionId = OneSignal.Default.User.PushSubscription.Id;
        }

        private void InAppMessages_Clicked(object sender, OneSignalSDK.DotNet.Core.InAppMessages.InAppMessageClickedEventArgs e)
        {
            Debug.WriteLine($"IAM ${e.Message.MessageId} clicked: ${e.Action.ClickName}.");
        }

        private void InAppMessages_WillDisplay(object sender, OneSignalSDK.DotNet.Core.InAppMessages.InAppMessageLifecycleEventArgs e)
        {
            Debug.WriteLine($"IAM ${e.Message.MessageId} will display.");
        }

        private void InAppMessages_DidDisplay(object sender, OneSignalSDK.DotNet.Core.InAppMessages.InAppMessageLifecycleEventArgs e)
        {
            Debug.WriteLine($"IAM ${e.Message.MessageId} did display.");
        }

        private void InAppMessages_WillDismiss(object sender, OneSignalSDK.DotNet.Core.InAppMessages.InAppMessageLifecycleEventArgs e)
        {
            Debug.WriteLine($"IAM ${e.Message.MessageId} will dismiss.");
        }

        private void InAppMessages_DidDismiss(object sender, OneSignalSDK.DotNet.Core.InAppMessages.InAppMessageLifecycleEventArgs e)
        {
            Debug.WriteLine($"IAM ${e.Message.MessageId} did dismiss.");
        }

        private void Notifications_WillDisplay(object sender, OneSignalSDK.DotNet.Core.Notifications.NotificationWillDisplayEventArgs e)
        {
            Debug.WriteLine($"Notification ${e.OriginalNotification.NotificationId} will display.");
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

        private void PushSubscription_Changed(object sender, OneSignalSDK.DotNet.Core.User.Subscriptions.SubscriptionChangedEventArgs e)
        {
            var pushSubscription = e.Subscription as IPushSubscription;
            Debug.WriteLine($"Push Subscription has changed: Id=${pushSubscription.Id}, Token={pushSubscription.Token}, OptedIn=${pushSubscription.OptedIn}");
            IsPushEnabled = OneSignal.Default.User.PushSubscription.OptedIn;
            PushSubscriptionId = e.Subscription.Id;
        }

        private void GivePrivacyConsent()
        {
            OneSignalSDK.DotNet.OneSignal.Default.PrivacyConsent = true;
            HasGivenPrivacyConsent = true;
        }

        private void RevokePrivacyConsent()
        {
            OneSignalSDK.DotNet.OneSignal.Default.PrivacyConsent = false;
            HasGivenPrivacyConsent = false;
        }

        private async void LoginUser()
        {
            var externalId = await _page.DisplayPromptAsync("Login User", "External ID of User", "Login");

            if(String.IsNullOrWhiteSpace(externalId))
            {
                return;
            }

            await OneSignal.Default.LoginAsync(externalId);
        }

        private async void LogoutUser()
        {
            await OneSignal.Default.LogoutAsync();
        }

        private async void AddAlias()
        {
            var addPairModel = new AddPairPageModel("Add Alias", "Label", "ID");

            addPairModel.PageCompleted += (s, e) =>
            {
                OneSignal.Default.User.AddAlias(addPairModel.Key, addPairModel.Value);
            };

            await _page.Navigation.PushModalAsync(new AddPairPage()
            {
                BindingContext = addPairModel
            });
        }

        private async void PromptForPush()
        {
            await OneSignal.Default.Notifications.RequestPermissionAsync(true);
        }

        private async void AddEmail()
        {
            var email = await _page.DisplayPromptAsync("Add Email", "Email Address");
            OneSignal.Default.User.AddEmailSubscription(email);
        }

        private async void AddSMS()
        {
            var sms = await _page.DisplayPromptAsync("Add SMS", "Phone Number");
            OneSignal.Default.User.AddSmsSubscription(sms);
        }

        private async void AddTag()
        {
            var addPairModel = new AddPairPageModel("Add Tag", "Key", "Value");
            addPairModel.PageCompleted += (s, e) =>
            {
                OneSignal.Default.User.AddTag(addPairModel.Key, addPairModel.Value);
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
                        OneSignal.Default.Session.AddOutcome(addOutcomeModel.Name);
                        break;
                    case AddOutcomePageModel.OutcomeType.Unique:
                        OneSignal.Default.Session.AddUniqueOutcome(addOutcomeModel.Name);
                        break;
                    case AddOutcomePageModel.OutcomeType.WithValue:
                        OneSignal.Default.Session.AddOutcomeWithValue(addOutcomeModel.Name, (float)addOutcomeModel.ValueAsFloat);
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
                OneSignal.Default.InAppMessages.AddTrigger(addPairModel.Key, addPairModel.Value);
            };

            await _page.Navigation.PushModalAsync(new AddPairPage()
            {
                BindingContext = addPairModel
            });
        }

        private async void PromptForLocation()
        {
            await OneSignal.Default.Location.RequestPermissionAsync(true);
        }

        private void EnterLiveActivity()
        {
            string activityId = LiveActivityId;

            if (String.IsNullOrWhiteSpace(activityId))
            {
                return;
            }

#if (LIVE_ACTIVITIES && IOS)
        var onesignalLiveActivity = new OneSignalLiveActivity.Binding.OneSignalLiveActivity();
        onesignalLiveActivity.StartLiveActivityWithRecievedToken((str) =>
        {
            OneSignal.Default.EnterLiveActivity(activityId, str);
        });
#elif !IOS
            _page.DisplayAlert("NOT SUPPORTED", "Live Activities is iOS only!", "OK");
#else
        _page.DisplayAlert("NOT SUPPORTED", "Live Activities is disabled in sample app by default, follow steps in Samples/LIVE_ACTIVITES.md to try it out!", "OK");
#endif
        }

        private void ExitLiveActivity()
        {
            string activityId = LiveActivityId;

            if (String.IsNullOrWhiteSpace(activityId))
            {
                return;
            }

#if (LIVE_ACTIVITIES && IOS)
        OneSignal.Default.ExitLiveActivity(activityId);
#elif !IOS
            _page.DisplayAlert("NOT SUPPORTED", "Live Activities is iOS only!", "OK");
#else
        _page.DisplayAlert("NOT SUPPORTED", "Live Activities is disabled in sample app by default, follow steps in Samples/LIVE_ACTIVITES.md to try it out!", "OK");
#endif
        }

        private void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

