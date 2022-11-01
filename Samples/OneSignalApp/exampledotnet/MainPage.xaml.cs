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
}


