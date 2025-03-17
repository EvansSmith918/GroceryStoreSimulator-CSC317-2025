namespace GroceryStoreSimulator;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

    		// Register routes for programmatic navigation (optional but useful)
      		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
       	 	Routing.RegisterRoute(nameof(AislePage), typeof(AislePage));
        	Routing.RegisterRoute(nameof(ItemPage), typeof(ItemPage));
        	Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
        	Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
	}
}
