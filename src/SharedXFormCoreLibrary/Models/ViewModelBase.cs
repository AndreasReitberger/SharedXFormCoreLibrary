using AndreasReitberger.Shared.XForm.Core.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;

namespace AndreasReitberger.Shared.XForm.Core
{
    public partial class ViewModelBase : ObservableObject, IViewModelBase
    {
        #region Dependency Injection
        [ObservableProperty]
        public partial IDispatcher? Dispatcher { get; set; }

        [ObservableProperty]
        public partial IServiceProvider? Provider { get; set; }
        #endregion

        #region Properties
        [ObservableProperty]
        public partial bool IsLoading { get; set; } = false;

        [ObservableProperty]
        public partial bool IsLoadingData { get; set; } = false;

        [ObservableProperty]
        public partial int IsLoadingDataCounter { get; set; } = 0;
        partial void OnIsLoadingDataCounterChanged(int value)
        {
            // Avoid negative values
            if (value < 0) IsLoadingDataCounter = 0;
            IsLoadingData = value > 0;
        }

        [ObservableProperty]
        public partial bool IsBusy { get; set; } = false;

        [ObservableProperty]
        public partial int IsBusyCounter { get; set; } = 0;
        partial void OnIsBusyCounterChanged(int value)
        {
            // Avoid negative values
            if (value < 0) IsBusyCounter = 0;
            IsBusy = value > 0;
        }

        [ObservableProperty]
        public partial bool IsReady { get; set; } = false;

        [ObservableProperty]
        public partial bool IsStartUp { get; set; } = true;

        [ObservableProperty]
        public partial bool IsStartingUp { get; set; } = false;

        [ObservableProperty]
        public partial bool IsRefreshing { get; set; } = false;

        [ObservableProperty]
        public partial bool IsResuming { get; set; } = false;

        [ObservableProperty]
        public partial bool IsBeta { get; set; } = false;

        [ObservableProperty]
        public partial bool IsPortrait { get; set; } = true;

        #endregion

        #region Ctor
        public ViewModelBase()
        {
            Dispatcher = Application.Current.Dispatcher;
        }
        public ViewModelBase(IDispatcher dispatcher)
        {
            Dispatcher = dispatcher;
        }
        public ViewModelBase(IDispatcher dispatcher, IServiceProvider provider)
        {
            Dispatcher = dispatcher;
            Provider = provider;
        }
        #endregion

        #region Methods
        public void SetBusy(bool isBusy, IDispatcher? dispatcher)
        {
            // Only dispatch if needed
            if (dispatcher is not null && dispatcher?.IsInvokeRequired is true)
            {
                dispatcher.BeginInvokeOnMainThread(() =>
                {
                    if (isBusy)
                        IsBusyCounter++;
                    else
                        IsBusyCounter--;
                });
            }
            // Update on the MainThread
            else
            {
                if (isBusy)
                    IsBusyCounter++;
                else
                    IsBusyCounter--;
            }
        }

        #endregion

        #region Dispose
        /*
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            // Ordinarily, we release unmanaged resources here;
            // but all are wrapped by safe handles.

            // Release disposable objects.
            if (disposing)
            {

            }
        }
        */
        #endregion

    }
}
