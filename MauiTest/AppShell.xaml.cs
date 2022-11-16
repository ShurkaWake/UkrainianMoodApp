namespace MauiTest;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(WinPage), typeof(WinPage));
        Routing.RegisterRoute(nameof(LoosePage), typeof(LoosePage));
    }
}
