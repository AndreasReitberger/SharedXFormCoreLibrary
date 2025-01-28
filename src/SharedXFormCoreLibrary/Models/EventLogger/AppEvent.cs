using AndreasReitberger.Shared.XForm.Core.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AndreasReitberger.Shared.XForm.Core.EventLogger
{
    public partial class AppEvent : ObservableObject
    {
        #region Properties
        [ObservableProperty]
        public partial string Message { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string SourceName { get; set; } = string.Empty;

        [ObservableProperty]
        public partial ErrorLevel Level { get; set; }

        [ObservableProperty]
        public partial EventArgs? Args { get; set; }
        #endregion
    }
}
