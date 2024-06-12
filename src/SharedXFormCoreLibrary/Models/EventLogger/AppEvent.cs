using AndreasReitberger.Shared.XForm.Core.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AndreasReitberger.Shared.XForm.Core.EventLogger
{
    public partial class AppEvent : ObservableObject
    {
        #region Properties
        [ObservableProperty]
        string message = string.Empty;

        [ObservableProperty]
        string sourceName = string.Empty;

        [ObservableProperty]
        ErrorLevel level;

        [ObservableProperty]
        EventArgs? args;
        #endregion
    }
}
