using Foundation;
using UIKit;

namespace MAUISplashSample;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{

    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
        //// Hide the status bar and set full-screen mode
        //UIApplication.SharedApplication.StatusBarHidden = true;
        //UIApplication.SharedApplication.SetStatusBarHidden(true, UIStatusBarAnimation.None);
        //UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);

        return base.FinishedLaunching(app, options);
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

