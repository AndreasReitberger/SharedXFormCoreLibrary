using AndreasReitberger.Shared.XForm.Core.Localization;
using Newtonsoft.Json;

namespace AndreasReitberger.Shared.XForm.Core.Events
{
    public class LanguageChangedEventArgs : EventArgs
    {
        #region Properties
        public string Message { get; set; } = string.Empty;
        public LocalizationInfo? LangaugeInfo { get; set; }
        public CultureInfo? Culture { get; set; }
        public string LangaugeCode { get; set; } = string.Empty;
        #endregion

        #region Overrides
        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);

        #endregion
    }
}
