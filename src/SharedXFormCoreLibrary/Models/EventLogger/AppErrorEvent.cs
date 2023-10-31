using AndreasReitberger.Shared.XForm.Core.Enums;

namespace AndreasReitberger.Shared.XForm.Core.EventLogger
{
    public class AppErrorEvent : AppEvent
    {
        #region Properties
        public Exception Exception { get; set; }
        public int Type { get; set; }
        #endregion

        #region Constructor
        public AppErrorEvent()
        {
            Level = ErrorLevel.Critical;
        }
        #endregion
    }
}
