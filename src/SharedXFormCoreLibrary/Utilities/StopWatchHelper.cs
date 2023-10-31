using AndreasReitberger.Shared.XForm.Core.Interfaces;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AndreasReitberger.Shared.XForm.Core.Utilities
{
    public static class StopWatchHelper
    {
        #region Methods
#nullable enable
        public static void Start(IDispatcher dispatcher, ref Stopwatch stopwatch, string methodName, IEventManager? eventManager = null, bool log = false)
        {
            stopwatch?.Start();
            string msg = $"Performance: Start => {methodName}: {DateTime.Now})";
            dispatcher?.BeginInvokeOnMainThread(() =>
            {
                if (log) eventManager?.LogInfo(new EventLogger.AppInfoEvent() { Message = msg, SourceName = $"{nameof(StopWatchHelper)}.{nameof(Start)}" });
                Debug.WriteLine(msg);
            });
        }

        public static void Stop(IDispatcher dispatcher, ref Stopwatch stopwatch, string methodName, IEventManager? eventManager = null, bool log = false)
        {
            stopwatch?.Start();
            string msg = $"Performance: Done => {methodName}: {DateTime.Now} (Duration: {stopwatch?.Elapsed})";
            dispatcher?.BeginInvokeOnMainThread(() =>
            {
                if (log) eventManager?.LogInfo(new EventLogger.AppInfoEvent() { Message = msg, SourceName = $"{nameof(StopWatchHelper)}.{nameof(Stop)}" });
                Debug.WriteLine(msg);
            });
        }

        public static async Task DoTaskAndStopTimeAsync(IDispatcher dispatcher, string methodName, Func<Task> func, IEventManager? eventManager = null, bool logStart = false)
        {
            Stopwatch? watch = new();
            Start(dispatcher, ref watch, methodName, eventManager, logStart);
            try { await func.Invoke(); } catch (Exception ex) { eventManager?.LogError(ex); }
            Stop(dispatcher, ref watch, methodName, eventManager);
        }

#nullable disable
        #endregion
    }
}
