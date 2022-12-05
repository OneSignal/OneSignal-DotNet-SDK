using System.Globalization;

namespace exampledotnet;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    private void OnRegisterForPush(object sender, EventArgs e)
    {
	    // iOS only 
        SharedPush.RegisterIOS();
    }
    private void OnSetExternalUserID(object sender, EventArgs e)
    {
        string externalUserID = ExternalUserID.Text;
        SharedPush.SetExternalUserId(externalUserID);
    }
    private void OnRemoveExternalUserID(object sender, EventArgs e)
    {
        SharedPush.RemoveExternalUserId();
    }
    private void OnSendOutcomeWithValue(object sender, EventArgs e)
    {
        string uniqueOutcomeKeyField = OutcomeWithValueKeyField.Text;
        float uniqueOutcomeValueField;
        bool success = float.TryParse(OutcomeWithValueValueField.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture.NumberFormat, out uniqueOutcomeValueField);
        if (success)
        {
            SharedPush.SendOutcomeWithValue(uniqueOutcomeKeyField, uniqueOutcomeValueField);
        }
    }
    private void OnSendOutcome(object sender, EventArgs e)
    {
        string sendOutcome = SendOutcomeKey.Text;
        SharedPush.SendOutcome(sendOutcome);
    }
    private void OnSendUniqueOutcome(object sender, EventArgs e)
    {
        string sendUniqueOutcome = SendUniqueOutcomeKey.Text;
        SharedPush.SendUniqueOutcome(sendUniqueOutcome);
    }

    private void OnEnterLiveActivity(object sender, EventArgs e)
    {
        string activityId = ActivityID.Text;

        if(String.IsNullOrWhiteSpace(activityId))
        {
            return;
        }

#if (LIVE_ACTIVITIES && IOS)
        var onesignalLiveActivity = new OneSignalLiveActivity.Binding.OneSignalLiveActivity();
        onesignalLiveActivity.StartLiveActivityWithRecievedToken((str) =>
        {
            OneSignalSDK.DotNet.OneSignal.Default.EnterLiveActivity(activityId, str);
        });
#else
        DisplayAlert("NOT SUPPORTED", "Live Activities disabled in sample app by default, follow steps in Samples/LIVE_ACTIVITES.md to try it out!", "OK");
#endif
    }

    private void OnExitLiveActivity(object sender, EventArgs e)
    {
        string activityId = ActivityID.Text;

        if (String.IsNullOrWhiteSpace(activityId))
        {
            return;
        }

#if (LIVE_ACTIVITIES && IOS)
        OneSignalSDK.DotNet.OneSignal.Default.ExitLiveActivity(activityId);
#else
        DisplayAlert("NOT SUPPORTED", "Live Activities disabled in sample app by default, follow steps in Samples/LIVE_ACTIVITES.md to try it out!", "OK");
#endif
    }
}


