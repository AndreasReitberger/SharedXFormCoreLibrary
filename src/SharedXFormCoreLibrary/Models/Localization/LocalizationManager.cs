using AndreasReitberger.Shared.XForm.Core.Events;
using AndreasReitberger.Shared.XForm.Core.Interfaces;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AndreasReitberger.Shared.XForm.Core.Localization
{
    public partial class LocalizationManager : ILocalizationManager
    {
        #region Instance
        static LocalizationManager _instance = null;
        static readonly object Lock = new();
        public static LocalizationManager Instance
        {
            get
            {
                lock (Lock)
                {
                    _instance ??= new();
                }
                return _instance;
            }

            set
            {
                if (_instance == value) return;
                lock (Lock)
                {
                    _instance = value;
                }
            }

        }
        #endregion

        #region Variables
        const string _defaultCultureCode = "en-US";
        #endregion

        #region Properties
        public string BaseFlagImageUri { get; set; } = "";
        public List<LocalizationInfo> Languages { get; set; } = new();
        public LocalizationInfo CurrentLanguage { get; set; } = new();
        public CultureInfo CurrentCulture { get; set; }
        #endregion

        #region Constructor
        public LocalizationManager()
        {

        }
        #endregion

        #region Events

        public event EventHandler LanguageChanged;
        protected virtual void OnLanguageChanged(LanguageChangedEventArgs e)
        {
            LanguageChanged?.Invoke(this, e);
        }
        #endregion

        #region Methods
        public void InitialLanguage(string cultureCode = "")
        {
            if (string.IsNullOrEmpty(cultureCode))
            {
                cultureCode = CultureInfo.CurrentCulture.Name;
            }
            LocalizationInfo info = GetLocalizationInfoBasedOnCode(cultureCode) ?? Languages.FirstOrDefault();
            if (info.Code != Languages.First().Code)
            {
                Change(info);
            }
            else
            {
                CurrentLanguage = info;
                CurrentCulture = new CultureInfo(info.Code);
            }
        }

        public void SetLanguages(List<LocalizationInfo> languages) => Languages = languages ?? new();
        
        public LocalizationInfo GetLocalizationInfoBasedOnCode(string cultureCode) => Languages?.FirstOrDefault(x => x.Code == cultureCode) ?? null;
        
        public Uri GetImageUri(string cultureCode)
        {
#if NETSTANDARD
            Uri image = Device.RuntimePlatform switch
            {
                Device.Android => new Uri($"{BaseFlagImageUri}/{cultureCode.Replace("-", "_")}.png", UriKind.RelativeOrAbsolute),
                Device.iOS => new Uri($"{cultureCode}", UriKind.RelativeOrAbsolute),
                _ => new Uri($"{BaseFlagImageUri}/{cultureCode}.png", UriKind.RelativeOrAbsolute),
            };
#else
            Uri image = string.IsNullOrEmpty(BaseFlagImageUri) ?
                 new($"{cultureCode.Replace("-", "_").ToLowerInvariant()}.png", UriKind.RelativeOrAbsolute) :
                 new($"{BaseFlagImageUri}/{cultureCode.Replace("-", "_").ToLowerInvariant()}.png", UriKind.RelativeOrAbsolute);
#endif
            return image;
        }

        public static Uri GetImageUri(string baseFlagUri, string cultureCode)
        {
#if NETSTANDARD
            Uri image = Device.RuntimePlatform switch
            {
                Device.Android => new Uri($"{baseFlagUri}/{cultureCode.Replace("-", "_")}.png", UriKind.RelativeOrAbsolute),
                Device.iOS => new Uri($"{baseFlagUri}/{cultureCode}", UriKind.RelativeOrAbsolute),
                _ => new Uri($"{baseFlagUri}/{cultureCode}.png", UriKind.RelativeOrAbsolute),
            };
#else
            Uri image = string.IsNullOrEmpty(baseFlagUri) ?
                 new($"{cultureCode.Replace("-", "_").ToLowerInvariant()}.png", UriKind.RelativeOrAbsolute) :
                 new($"{baseFlagUri}/{cultureCode.Replace("-", "_").ToLowerInvariant()}.png", UriKind.RelativeOrAbsolute);
#endif
            return image;
        }

        public void Change(LocalizationInfo info)
        {
            CurrentLanguage = info;
            CurrentCulture = new CultureInfo(info.Code);
            OnLanguageChanged(new()
            {
                LangaugeInfo = info,
                LangaugeCode = info.Code,
                Culture = CurrentCulture,
            });
        }

        public void Change(LocalizationInfo info, Action<LocalizationInfo> action)
        {
            action?.Invoke(info);
            OnLanguageChanged(new()
            {
                LangaugeInfo = info,
                LangaugeCode = info.Code,
                Culture = CurrentCulture,
            });
        }

        public bool Change(LocalizationInfo info, Func<LocalizationInfo, bool> function)
        {
            OnLanguageChanged(new()
            {
                LangaugeInfo = info,
                LangaugeCode = info.Code,
                Culture = CurrentCulture,
            });
            return function?.Invoke(info) ?? false;
        }
#endregion

    }
}
