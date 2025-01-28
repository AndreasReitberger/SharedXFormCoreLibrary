using AndreasReitberger.Shared.XForm.Core.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AndreasReitberger.Shared.XForm.Core.Documentation
{
    public partial class ChangelogInfo : ObservableObject
    {
        #region Properties
        [ObservableProperty]
        public partial ChangelogType Type { get; set; }

        [ObservableProperty]
        public partial string Changelog { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string Version { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string GlyphIcon { get; set; } = string.Empty;
        #endregion

        #region Constructor
        public ChangelogInfo(string version, string changelog, ChangelogType type = ChangelogType.New)
        {
            Version = version;
            Changelog = changelog;
            Type = type;
        }
        #endregion
    }
}
