using System.Globalization;

namespace exampledotnet;

public partial class MainPage : ContentPage
{
	int count = 0;
	string externalUserID = "";

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
        float uniqueOutcomeValueField = float.Parse(OutcomeWithValueValueField.Text, CultureInfo.InvariantCulture.NumberFormat);
        SharedPush.SendOutcomeWithValue(uniqueOutcomeKeyField, uniqueOutcomeValueField);
    }
    private void OnSendOutcome(object sender, EventArgs e)
    {
        string sendOutcome = SendOutcomeKey.Text;
        SharedPush.SendOutcome(externalUserID);
    }
    private void OnSendUniqueOutcome(object sender, EventArgs e)
    {
        string sendOutcome = SendUniqueOutcomeKey.Text;
        SharedPush.SendUniqueOutcome(externalUserID);
    }
}


