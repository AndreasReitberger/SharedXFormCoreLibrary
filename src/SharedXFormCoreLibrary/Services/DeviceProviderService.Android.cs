using static Android.Provider.Settings;

namespace AndreasReitberger.Shared.XForm.Core.Services
{
[assembly: Dependency(typeof(DeviceProviderService))]
    public class DeviceProviderService : IDeviceProviderService
	{
        public string GetDeviceId()
        {
            return Secure.GetString(Android.App.Application.Context.ContentResolver, Secure.AndroidId);
        }
    }
}
