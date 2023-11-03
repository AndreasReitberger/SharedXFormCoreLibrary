using UIKit;

namespace AndreasReitberger.Shared.XForm.Core.Services
{
    DeviceProviderService
    public class DeviceProviderService : IDeviceProviderService
    {
        public string GetDeviceId()
        {
            return UIDevice.CurrentDevice.IdentifierForVendor?.ToString();
        }
    }
}
