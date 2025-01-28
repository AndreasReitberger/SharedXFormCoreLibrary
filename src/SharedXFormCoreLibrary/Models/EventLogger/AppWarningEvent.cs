using AndreasReitberger.Shared.XForm.Core.Enums;

namespace AndreasReitberger.Shared.XForm.Core.EventLogger
{
    public class AppWarningEvent : AppEvent
    {
        #region Constructor
        public AppWarningEvent()
        {
            Level = ErrorLevel.Warning;
        }
        #endregion
    }
}
