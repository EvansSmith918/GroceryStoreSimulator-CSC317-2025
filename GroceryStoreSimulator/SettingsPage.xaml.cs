namespace GroceryStoreSimulator;
public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
        NameEntry.Text = Preferences.Get("Name", "Guest");
        CashEntry.Text = Preferences.Get("CashInHand", "0.00");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        Preferences.Set("Name", NameEntry.Text);
        Preferences.Set("CashInHand", CashEntry.Text);
    }
}