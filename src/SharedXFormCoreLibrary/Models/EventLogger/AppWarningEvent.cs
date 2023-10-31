using AndreasReitberger.Shared.XForm.Core.Enums;

namespace AndreasReitberger.Shared.XForm.Core.EventLogger
{
    public class AppWarningEvent : AppEvent
    {
        #region Properties

        #endregion

        #region Constructor
        public AppWarningEvent()
        {
            Level = ErrorLevel.Warning;
        }
        #endregion
    }
}
