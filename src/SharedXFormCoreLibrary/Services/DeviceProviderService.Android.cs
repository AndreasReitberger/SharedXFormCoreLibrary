using AndreasReitberger.Shared.XForm.Core.Services;
using Xamarin.Forms;
using static Android.Provider.Settings;

[assembly: Dependency(typeof(DeviceProviderService))]
namespace AndreasReitberger.Shared.XForm.Core.Services
{
    public class DeviceProviderService : IDeviceProviderService
    {
        public string GetDeviceId()
        {
            return Secure.GetString(Android.App.Application.Context.ContentResolver, Secure.AndroidId);
        }
    }
}