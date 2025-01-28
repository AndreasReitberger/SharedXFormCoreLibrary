using CommunityToolkit.Mvvm.ComponentModel;

namespace AndreasReitberger.Shared.XForm.Core.Documentation
{
    public  partial class ProVersionFeature : ObservableObject
    {
        #region Propertiers
        [ObservableProperty]
        public partial string Feature { get; set; } = string.Empty;
        #endregion
    }
}
