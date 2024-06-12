using AndreasReitberger.Shared.XForm.Core.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AndreasReitberger.Shared.XForm.Core.EventLogger
{
    public partial class AppErrorEvent : AppEvent
    {
        #region Properties
        [ObservableProperty]
        Exception? exception;

        [ObservableProperty]
        int type = 0;
        #endregion

        #region Constructor
        public AppErrorEvent()
        {
            Level = ErrorLevel.Critical;
        }
        #endregion
    }
}
