﻿using System.ComponentModel;

namespace AndreasReitberger.Shared.XForm.Core.Interfaces
{
    public interface IViewModelBase : INotifyPropertyChanged//, IDisposable
    {
        #region Properties
        int IsBusyCounter { get; set; }
        bool IsBusy { get; set; }
        bool IsLoading { get; set; }
        bool IsReady { get; set; }
        bool IsStartUp { get; set; }
        bool IsRefreshing { get; set; }
        bool IsStartingUp { get; set; }
        bool IsBeta { get; set; }
        bool IsResuming { get; set; }
        bool IsPortrait { get; set; }

        #endregion
    }
}
