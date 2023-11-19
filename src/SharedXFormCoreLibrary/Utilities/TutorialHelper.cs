using Xamarin.Essentials;

namespace AndreasReitberger.Shared.XForm.Core.Utilities
{
    public static class TutorialHelper
    {
        #region Methods
        public static string GetTutorialImageSourceString(OSAppTheme theme, string baseDirectory, int order, string fileType = "png", string prefix = "")
        {
            return theme switch
            {
                OSAppTheme.Dark => $"{baseDirectory}/{prefix}{DeviceInfo.Platform.ToString().ToLowerInvariant()}_dark_{order}.{fileType}",
                _ => $"{baseDirectory}/{prefix}{DeviceInfo.Platform.ToString().ToLowerInvariant()}_light_{order}.{fileType}",
            };
        }
        public static string GetTutorialImageSourceString(OSAppTheme theme, int order, string fileType = "png", string prefix = "")
        {

            return theme switch
            {
                OSAppTheme.Dark => $"{prefix}{DeviceInfo.Platform.ToString().ToLowerInvariant()}_dark_{order}.{fileType}",
                _ => $"{prefix}{DeviceInfo.Platform.ToString().ToLowerInvariant()}_light_{order}.{fileType}",
            };
        }
        #endregion
    }
}
