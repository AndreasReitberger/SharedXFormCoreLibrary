using AndreasReitberger.Shared.Core.Localization;

namespace AndreasReitberger.Shared.XForm.Core.Interfaces
{
    public interface ILocalizationManager
    {
        #region Properties
        public List<LocalizationInfo> Languages { get; set; }
        public LocalizationInfo? CurrentLanguage { get; set; }
        public CultureInfo? CurrentCulture { get; set; }
        #endregion

        #region Methods
        //Uri GetImageUri(string cultureCode);
        LocalizationInfo GetLocalizationInfoBasedOnCode(string cultureCode);
        void SetLanguages(List<LocalizationInfo> languages);
        void Change(LocalizationInfo info);
        void Change(LocalizationInfo info, Action<LocalizationInfo> action);
        bool Change(LocalizationInfo info, Func<LocalizationInfo, bool> function);
        //void ChangeOnTheFly(LocalizationInfo info);
        #endregion
    }
}
