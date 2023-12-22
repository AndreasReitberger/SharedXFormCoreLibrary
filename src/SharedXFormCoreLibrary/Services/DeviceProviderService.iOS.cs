using AndreasReitberger.Shared.XForm.Core.Services;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceProviderService))]
namespace AppBasement.iOS.Interfaces
{
    public class DeviceProviderService : IDeviceProviderService
    {
        public string GetDeviceId()
        {
            return UIDevice.CurrentDevice.IdentifierForVendor?.ToString();
        }
    }
}