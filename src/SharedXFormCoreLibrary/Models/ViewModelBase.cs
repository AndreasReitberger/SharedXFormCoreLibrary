using AndreasReitberger.Shared.Core;
using AndreasReitberger.Shared.XForm.Core.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;

namespace AndreasReitberger.Shared.XForm.Core
{
    public partial class ViewModelBase : ViewModelCoreBase, IViewModelBase
    {
        #region Dependency Injection
        [ObservableProperty]
        public partial IDispatcher? Dispatcher { get; set; }

        #endregion

        #region Ctor
        public ViewModelBase()
        {
            Dispatcher ??= Application.Current.Dispatcher;
        }
        public ViewModelBase(IDispatcher? dispatcher) : base()
        {
            Dispatcher = dispatcher;
        }
        public ViewModelBase(IDispatcher? dispatcher, IServiceProvider? provider) : base(provider: provider)
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

        public async Task SetBusyAsync(bool isBusy, IDispatcher? dispatcher)
        {
            // Only dispatch if needed
            if (dispatcher is not null && dispatcher?.IsInvokeRequired is true)
            {
                await Task.Run(() => dispatcher.BeginInvokeOnMainThread(() =>
                {
                    if (isBusy)
                        IsBusyCounter++;
                    else
                        IsBusyCounter--;
                }));
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
