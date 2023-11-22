using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
namespace MAUISplashSample;

public partial class LoadSitePage : ContentPage
{
	public LoadSitePage()
	{
		InitializeComponent();
        LoaderView.IsVisible = true;

        // Apply safe area insets
        On<iOS>().SetUseSafeArea(false);
    }

    async void WebView_Loaded(System.Object sender, System.EventArgs e)
    {
        await Task.Delay(3000).ContinueWith(t =>
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                LoaderView.IsVisible = false;
            });
        });
        
    }
}
