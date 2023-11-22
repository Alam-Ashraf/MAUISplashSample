using Microsoft.Maui.Controls.PlatformConfiguration;

using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using NavigationPage = Microsoft.Maui.Controls.NavigationPage;

namespace MAUISplashSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        // Apply safe area insets
        On<iOS>().SetUseSafeArea(false);
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        // Apply fade-out animation
        await MainStack.FadeTo(0, 1);
        await MainStack.FadeTo(1, 500);

        await Task.Delay(2000).ContinueWith(t =>
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                // Apply fade-out animation
                await MainStack.FadeTo(0, 1000);
                App.Current.MainPage = new NavigationPage(new LoadSitePage());
            });
        });
    }
}


