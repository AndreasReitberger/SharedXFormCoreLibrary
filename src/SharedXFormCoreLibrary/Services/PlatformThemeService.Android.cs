using AndreasReitberger.Shared.XForm.Core.Services;
using Android.App;
using Android.OS;
using AppBasement.Droid.Services;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(PlatformThemeService))]
namespace AndreasReitberger.Shared.XForm.Core.Services
{
    public class PlatformThemeService : IPlatformThemeService
    {
        // Source: https://stackoverflow.com/a/39164921/10083577
        public void SetStatusBarColor(Color color)
        {
            // The SetStatusBarcolor is new since API 21
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                var androidColor = color.AddLuminosity(-0.1f).ToAndroid();
                if (Android.App.Application.Context is Activity activity)
                {
                    activity.Window.SetStatusBarColor(androidColor);
                }
            }
            else
            {
                // Here you will just have to set your 
                // color in styles.xml file as shown below.
            }
        }
    }
}
