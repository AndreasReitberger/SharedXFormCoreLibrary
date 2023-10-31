using AndreasReitberger.Shared.XForm.Core.Enums;

namespace AndreasReitberger.Shared.XForm.Core.EventLogger
{
    public class AppInfoEvent : AppEvent
    {
        #region Properties

        #endregion

        #region Constructor
        public AppInfoEvent()
        {
            Level = ErrorLevel.Info;
        }
        #endregion
    }
}
