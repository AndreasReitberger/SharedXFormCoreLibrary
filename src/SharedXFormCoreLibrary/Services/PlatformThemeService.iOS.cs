using AndreasReitberger.Shared.XForm.Core.Services;
using AppBasement.iOS.Interfaces;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Dependency(typeof(PlatformThemeService))]
namespace AndreasReitberger.Shared.XForm.Core.Services
{
    public class PlatformThemeService : IPlatformThemeService
    {
        // Source: https://stackoverflow.com/a/39164921/10083577
        public void SetStatusBarColor(Color color)
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                //var currentWindow = WindowStateManager.Default.GetCurrentUIWindow();
                // Nothing to do here, if needed use the `StatusBarBehavior`
                // Docs: https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/behaviors/statusbar-behavior?tabs=ios
                // Git : https://github.com/CommunityToolkit/Maui/blob/main/src/CommunityToolkit.Maui/Behaviors/PlatformBehaviors/StatusBar/StatusBarBehavior.shared.cs
            }
            else
            {
                if (UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) is UIView statusBar && statusBar.RespondsToSelector(
                new ObjCRuntime.Selector("setBackgroundColor:")))
                {
                    // change to your desired color 
                    statusBar.BackgroundColor = color.ToUIColor();
                }
            }
        }
    }
}
