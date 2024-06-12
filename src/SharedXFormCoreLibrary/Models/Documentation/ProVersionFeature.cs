using CommunityToolkit.Mvvm.ComponentModel;

namespace AndreasReitberger.Shared.XForm.Core.Documentation
{
    public  partial class ProVersionFeature : ObservableObject
    {
        #region Propertiers
        [ObservableProperty]
        string feature = string.Empty;
        #endregion
    }
}
